using GestionServicios.Domain.Abstractions;
using GestionServicios.Domain.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionServicios.Domain.Servicios
{
    public class Servicio:AggregateRoot
    {
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public CostValue CostoUnitario { get; private set; }
        public string Estado { get; private set; }
        public Servicio(Guid id, string nombre, string descripcion, String estado) : base(id)
        {           
            Nombre = nombre;
            Descripcion = descripcion;                     
            Estado = estado;
            CostoUnitario = 0;
        }
        public Servicio() { }

        public void UpdateCost(decimal Costo)
        {
            if (Costo > 0)
            {
                CostValue newCost = Math.Round(Costo, 2);
                CostoUnitario = newCost;               
            }
        }
        public Servicio(Guid id) : base(id)
        {
        }
    }
}
