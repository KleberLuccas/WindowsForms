using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.Classes
{
    public class CEP
    {
        public class unit
        {
            // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
                public string cep { get; set; }
                public string logradouro { get; set; }
                public string complemento { get; set; }
                public string bairro { get; set; }
                public string localidade { get; set; }
                public string uf { get; set; }
                public string ibge { get; set; }
                public string gia { get; set; }
                public string ddd { get; set; }
                public string siafi { get; set; }

        }

        public static unit DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<unit>(vJson);
        }

        public static string SerializedClassUnit(unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }
    }
}
