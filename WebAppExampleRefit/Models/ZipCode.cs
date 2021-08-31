using System.Text.Json.Serialization;

namespace WebAppExampleRefit.Models
{
    public record ZipCode
    {
        [JsonPropertyName("cep")]
        public string Number { get; init; }

        [JsonPropertyName("logradouro")]
        public string Address { get; init; }

        [JsonPropertyName("complento")]
        public string Complement { get; init; }

        [JsonPropertyName("bairro")]
        public string Neighborhood { get; init; }

        [JsonPropertyName("localidade")]
        public string City { get; init; }

        [JsonPropertyName("uf")]
        public string Uf { get; init; }

        [JsonPropertyName("ibge")]
        public string Ibge { get; init; }

        [JsonPropertyName("gia")]
        public string Gia { get; init; }

        [JsonPropertyName("ddd")]
        public string DDD { get; init; }

        [JsonPropertyName("siafi")]
        public string Siafi { get; init; }
    }
}
