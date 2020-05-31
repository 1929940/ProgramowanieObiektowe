using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramowanieObiektowe.Models
{
    public class Operation
    {
        public decimal Value { get; set; }
        public DateTime Date { get; set; }

        public override string ToString() => string.Format("Operation value: {0}, date: {1}", Value, Date);
    }
}
