using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoHospital.front.Desktop.DAO.Entities
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Anotacao
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("descricao")]
        public string Descricao { get; set; }

        [JsonProperty("prescricao")]
        public DateTime Prescricao { get; set; }
    }

    public class CaracteristicaDieta
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("dieta")]
        public string Dieta { get; set; }

        [JsonProperty("sistema")]
        public string Sistema { get; set; }

        [JsonProperty("inicio")]
        public DateTime Inicio { get; set; }

        [JsonProperty("evoluido")]
        public DateTime Evoluido { get; set; }
    }

    public class Datum
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("paciente")]
        public Paciente Paciente { get; set; }

        [JsonProperty("leito")]
        public int Leito { get; set; }

        [JsonProperty("diagnostico")]
        public string Diagnostico { get; set; }

        [JsonProperty("observacao")]
        public Observacao Observacao { get; set; }

        [JsonProperty("caracteristicaDieta")]
        public CaracteristicaDieta CaracteristicaDieta { get; set; }

        [JsonProperty("anotacao")]
        public Anotacao Anotacao { get; set; }

        [JsonProperty("observacaoDieta")]
        public string ObservacaoDieta { get; set; }

        [JsonProperty("dieta")]
        public string Dieta { get; set; }

        [JsonProperty("dataPrescricao")]
        public DateTime DataPrescricao { get; set; }
    }

    public class MetaData
    {
        [JsonProperty("currentPage")]
        public int CurrentPage { get; set; }

        [JsonProperty("totalCount")]
        public int TotalCount { get; set; }

        [JsonProperty("pageSize")]
        public int PageSize { get; set; }

        [JsonProperty("totalPages")]
        public int TotalPages { get; set; }

        [JsonProperty("hasPrevious")]
        public bool HasPrevious { get; set; }

        [JsonProperty("hasNext")]
        public bool HasNext { get; set; }
    }

    public class Observacao
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("dialise")]
        public string Dialise { get; set; }

        [JsonProperty("outros")]
        public string Outros { get; set; }
    }

    public class Paciente
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("idade")]
        public int Idade { get; set; }
    }

    public class EntityMapa
    {
        [JsonProperty("data")]
        public List<Datum> Data { get; set; }

        [JsonProperty("metaData")]
        public MetaData MetaData { get; set; }
    }





}
