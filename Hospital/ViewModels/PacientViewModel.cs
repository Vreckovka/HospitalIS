﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Hospital.Models;
using Hospital.ViewModels.Commands;


namespace Hospital.ViewModels
{
   
    public class PacientViewModel : BaseViewModel
    {
        public Pacients Pacients { get; set; }
        public GetSiblingsCommand GetSiblingsCommand { get; set; }
        public SaveToXMLCommand SaveToXMLCommand { get; set; }
        public List<Pacient> ActualPacientSiblings { get; set; }

        public PacientViewModel()
        {
            GetSiblingsCommand = new GetSiblingsCommand(this);
            SaveToXMLCommand = new SaveToXMLCommand(this);

            Pacients = LoadedPacients.Pacients;
        }
       
    }
}