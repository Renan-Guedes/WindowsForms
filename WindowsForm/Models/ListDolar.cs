using Newtonsoft.Json;

namespace WindowsForm.Models
{
    public class ListDolar
    {

        public ListDolar()
        {
            Data = new ListDataDolar();
        }

        [JsonProperty("USDBRL")]
        public ListDataDolar Data { get; set; }
    }
}
