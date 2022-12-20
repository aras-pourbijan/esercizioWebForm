using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace esercizioWebForm.Models
{
    public class pagamento
    {
        public int IDpagamento { get; set; }
        public DateTime peridoPagamento { get; set; }
        public double amount { get; set; }
        public bool IsStipendio { get; set; }
        public int IDdipendente { get; set; }

    }
}