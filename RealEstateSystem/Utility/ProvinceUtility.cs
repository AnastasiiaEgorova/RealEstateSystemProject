using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RealEstateSystem.Info;

namespace RealEstateSystem.Utility
{
    public static class ProvinceUtility
    {
        public static List<string> CreateListOfProvinces()
        {
            List<string> provinces = new List<string>();

            provinces.Add(ProvinceNames.AB);
            provinces.Add(ProvinceNames.BC);
            provinces.Add(ProvinceNames.MB);
            provinces.Add(ProvinceNames.NB);
            provinces.Add(ProvinceNames.NL);
            provinces.Add(ProvinceNames.NS);
            provinces.Add(ProvinceNames.NT);
            provinces.Add(ProvinceNames.NU);
            provinces.Add(ProvinceNames.ON);
            provinces.Add(ProvinceNames.PE);
            provinces.Add(ProvinceNames.QC);
            provinces.Add(ProvinceNames.SK);
            provinces.Add(ProvinceNames.YT);

            return provinces;
        }
    }
}