using Newtonsoft.Json;

namespace WindowsForm.Models
{
    public class ListDataDolar
    {
        [JsonProperty("high")]
        public decimal Maximo { get; set; }

        [JsonProperty("low")]
        public decimal Minimo { get; set; }

        [JsonProperty("varBid")]
        public decimal Variacao { get; set; }

        [JsonProperty("pctChange")]
        public string PctVariacao { get; set; }

        [JsonProperty("bid")]
        public decimal Compra { get; set; }

        [JsonProperty("ask")]
        public decimal Venda { get; set; }

    }
}
