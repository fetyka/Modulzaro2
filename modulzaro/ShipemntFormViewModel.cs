using Modulzaro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulzaro
{
   public class ShipemntFormViewModel : BaseModel
    {
        public Shipment Shipment { get; set; }

        public bool IsNew { get; set; }

        Shipment shipment;
        public Shipment()
        {
            this.Shipment = shipment;
            if (!IsNew)
                Save();
        }



      /*  public void Save()
        {
            if (!IsNew)
                shipment = new Shipment {Name = Shipment.Name  }
        } */



    }
}
