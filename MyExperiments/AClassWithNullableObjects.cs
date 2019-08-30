using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExperiments
{
  public  class AClassWithNullableObjects
    {
        public AClassWithNullableObjects()
        {
            MyDate = null;
        }
        public DateTime? MyDate { get; set; }
    }
}
