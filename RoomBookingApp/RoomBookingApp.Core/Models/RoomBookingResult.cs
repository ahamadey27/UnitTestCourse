using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoomBookingApp.Core.Models;
using RoomBookingApp.Core.Processors;

namespace RoomBookingApp.Core.Models
{
    public class RoomBookingResult
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public DateTime Date { get; set; }

    }
}
