using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Storage_Application.Models
{
    public class Games
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public int Ano { get; set; }
        public int Nota { get; set; }
    }
}