using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelekomBeckEnd
{
    public class Patient
    {
        public int ID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string DOB { get; set; }
        public int cityID { get; set; }
        
        public int stateID { get; set; }
    }
}
