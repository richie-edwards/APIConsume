using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAPITestDriveLibrary.Models
{
    public class PeopleModel : Model
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Height { get; set; }
        public string Url { get; set; }
        public List<PeopleModel> Results { get; set; }
        //public string Films { get; set; }

    }
}
