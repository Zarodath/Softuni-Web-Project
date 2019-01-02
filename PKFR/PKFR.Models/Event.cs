using System;
using System.Collections.Generic;
using System.Text;

namespace PKFR.Models
{
    public class Event
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime PostDate { get; set; }

        public DateTime EventDate { get; set; }

        public byte[] Image { get; set; }
    }
}
