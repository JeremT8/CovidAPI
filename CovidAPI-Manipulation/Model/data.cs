using System.Collections.Generic;

namespace CovidAPI_Manipulation.Model
{
    public class data
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Source
        {
            public string nom { get; set; }
        }

        public class FranceGlobalLiveData
        {
            public string Code { get; set; }
            public string Nom { get; set; }
            public string Date { get; set; }
            public int Hospitalises { get; set; }
            public int Reanimation { get; set; }
            public int NouvellesHospitalisations { get; set; }
            public int NouvellesReanimations { get; set; }
            public int Deces { get; set; }
            public int Gueris { get; set; }
        }

        public class Root
        {
            public List<FranceGlobalLiveData> FranceGlobalLiveData { get; set; }
        }
    }
}