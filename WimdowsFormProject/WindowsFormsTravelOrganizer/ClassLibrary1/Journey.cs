using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Journey
    {
        public static List<Journey> Journeys { get; set; } = new List<Journey>();
        public List<User> Users { get; private set; } = new List<User>();
        public bool IsStart { get; private set; }
        public DateTime TimeStart { get; private set; }
        public DateTime TimeFinish { get; private set; }
        public string Name { get; set; }
    }
}
