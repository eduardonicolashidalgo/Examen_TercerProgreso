using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_TercerProgreso.Models
{
    [Table ("detector")]
    public class DetectorModel
    {
        [PrimaryKey, AutoIncrement]
        public int IdDetector { get; set; }
        [MaxLength(30)]
        public string title { get; set; }
        [MaxLength(300)]
        public string description { get; set; }
        [MaxLength(30)]
        public string date { get; set; }
        [MaxLength(30)]
        public string thumbnail { get; set; }
        [MaxLength(300)]
        public string url { get; set; }

    }
}
