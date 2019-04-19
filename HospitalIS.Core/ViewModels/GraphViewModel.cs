using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Autofac;
using HospitalIS.Core.DataContexts;
using HospitalIS.Core.Models;
using LiveCharts;
using PropertyChanged;

namespace HospitalIS.Core.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class GraphViewModel : BaseViewModel
    {
        int _labelCount;
        public ChartValues<double> ColumnValues { get; set; } = new ChartValues<double>();
        public string[] ColumnLabels { get; set; }

        protected int[] _ranges;
        public string XAxisTitle { get; set; }
        public string YAxisTitle { get; set; } = "Number of people";

        public GraphViewModel(int labelCount, string xAxisTitle, int gap, int minValue , string propName)
        {
            _labelCount = labelCount;
            ColumnLabels = new string[_labelCount];
            XAxisTitle = xAxisTitle;

            _ranges = new int[labelCount];
            for (int i = 0; i < labelCount; i++)
            {
                if (i != 0)
                    _ranges[i] = (i * gap) + minValue;
                else
                    _ranges[i] = minValue;
            }

            GetValues(propName);
        }

        public void GetValues(string propName)
        {
            Task.Run(() =>
            {
                for (int i = 0; i < _ranges.Length; i++)
                {
                    var lowBound = Convert.ToDouble(_ranges[i]);
                    int highBound = 0;
                    int count = 0;
                    string title = "";


                    if (i != _ranges.Length - 1)
                        highBound = _ranges[i + 1];

                    var pacients = IoC.IoC.Container.Resolve<DataContext>().Pacients;
                    var param = Expression.Parameter(typeof(Pacient));

                    if (i == 0)
                    {
                        //Creates lambda expresion
                        var condition =
                            Expression.Lambda<Func<Pacient, bool>>(
                                Expression.LessThanOrEqual(
                                    Expression.Convert(Expression.Property(param, propName), lowBound.GetType()),
                                    Expression.Constant(lowBound)
                                ),
                                param
                            ).Compile();

                        count = pacients.ToList().Count(condition);
                        title = $"less then {lowBound}";
                    }

                    else if (i == _ranges.Length - 1)
                    {
                        //Creates lambda expresion
                        var condition =
                            Expression.Lambda<Func<Pacient, bool>>(
                                Expression.GreaterThanOrEqual(
                                    Expression.Convert(Expression.Property(param, propName), lowBound.GetType()),
                                    Expression.Constant(lowBound)
                                ),
                                param
                            ).Compile();

                        count = pacients.ToList().Count(condition);

                        title = $"more then {lowBound}";
                    }
                    else
                    {

                        var lessCond =
                            Expression.Lambda<Func<Pacient, bool>>(
                                Expression.GreaterThanOrEqual(
                                    Expression.Convert(Expression.Property(param, propName), lowBound.GetType()),
                                    Expression.Constant(lowBound)
                                ),
                                param
                            ).Compile();

                        var greaterCond =
                            Expression.Lambda<Func<Pacient, bool>>(
                                Expression.LessThanOrEqual(
                                    Expression.Convert(Expression.Property(param, propName), highBound.GetType()),
                                    Expression.Constant(highBound)
                                ),
                                param
                            ).Compile();

                        count = pacients.ToList().Where(lessCond).Where(greaterCond).Count();


                        title = $"{lowBound} - {highBound}";
                    }


                    ColumnValues.Add(count);
                    ColumnLabels[i] = title;
                }
            });
        }
    }
}
