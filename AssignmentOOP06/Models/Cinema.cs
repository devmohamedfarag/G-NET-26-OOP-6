using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOOP06.Models
{
    public partial class Cinema
    {
        public string CinemaName { get; set; }
        public Cinema(string cinemaName)
        {
            CinemaName = cinemaName;
        }
    }
}
