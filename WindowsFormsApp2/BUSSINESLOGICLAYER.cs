using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class BUSSINESLOGICLAYER
    {
        private DataAccessLayer _dataAccessLayer;
        public BUSSINESLOGICLAYER()
        {
            _dataAccessLayer = new DataAccessLayer();
        }
        /*
        public Empleado SaveEmpleado(Empleado empleado)
        {
            if (empleado.ID_Empleado == 0)            
                _dataAccessLayer.InsertarEmple           
            else
                _dataAccessLayer.UpdateEmple;
        }*/
    }
}
