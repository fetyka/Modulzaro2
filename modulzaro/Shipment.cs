using Modulzaro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modulzaro
{
    public class Shipment : BaseModel
    {
        string _name;
        int _deliverymin;
        int _deliverymax;
        int _basicprice;
        int _gramprice;

        public string Name { get { return _name; } set { _name = value; OnPropertyChange(); } }
        public int DeliveryMin { get { return _deliverymin; } set { _deliverymin = value; OnPropertyChange(); } }
        public int DeliveryMax { get { return _deliverymax; } set { _deliverymax = value; OnPropertyChange(); } }
        public int BasicPrice { get { return _basicprice; } set { _basicprice = value; OnPropertyChange(); } }
        public int GramPrice { get { return _gramprice; } set { _gramprice = value; OnPropertyChange(); } }

        public Shipment (ShipmentDbModel dbmodel)
        {
            Name = dbmodel.Name;
            BasicPrice = dbmodel.BasicPrice;
            DeliveryMin = dbmodel.DeliveryMin;
            DeliveryMax = dbmodel.DeliveryMax;
            GramPrice = dbmodel.GramPrice;
        }

        public Shipment()
        {

        }


    }
}
