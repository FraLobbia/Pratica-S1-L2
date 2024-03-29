﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica_S1_L2
{
    internal class Persona
    {
       
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }

      
        public Persona(string nome, string cognome, int eta)
        {
            Nome = nome;
            Cognome = cognome;
            Eta = eta;
        }

        public Persona() { }

   
        public string GetNome()
        {
            return Nome;
        }

        public string GetCognome()
        {
            return Cognome;
        }

        public int GetEta()
        {
            return Eta;
        }

        public string GetDettagli()  
        {
            //return $"Nome: {Nome}, Cognome: {Cognome}, Età: {Eta}";
            return "Il nome della persona è " + Nome + ", il cognome è " + Cognome + " ed ha " + Eta + " anni";
        }
    }
}
