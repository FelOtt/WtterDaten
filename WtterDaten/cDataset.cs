using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WtterDaten
{
    public class cDataset
    {
        public string datum { get; private set; }
        public double temperatur { get; private set; }
        public double luftfeuchtigkeit { get; private set; }

        public cDataset()
        {
            datum = "";
            temperatur = 0;
            luftfeuchtigkeit = 0;
        }

        public cDataset(string pDatum, double pTemperatur, double pLuftfeuchtigkeit)
        {
            datum = pDatum;
            temperatur = pTemperatur;
            luftfeuchtigkeit = pLuftfeuchtigkeit;
        }

        public override string ToString()
        {
            return $"Datum: {datum.ToString()}; Temperatur: {temperatur}; Luftfeuchtigkeit: {luftfeuchtigkeit}";
        }
    }
}