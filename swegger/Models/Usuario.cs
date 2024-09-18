using System.ComponentModel.DataAnnotations.Schema;

namespace swegger.Models
{
    public class Usuario
    {
        public int ID_USU { get; set; }
        public string? NOME_USU { get; set; }
        public string? MATR_USU { get; set; }
        public DateTime DATA_NASC { get; set; }
        public string? EMAIL { get; set; }
        public string? ORIGEM { get; set; }
       
    }
}
