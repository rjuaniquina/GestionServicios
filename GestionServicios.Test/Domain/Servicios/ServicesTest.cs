using GestionServicios.Domain.Servicios;
using GestionServicios.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionServicios.Test.Domain.Servicios
{
    public class ServicesTest
    {
        [Fact]
        public void ServiceCreationIsValid()
        {
            //Arrange
            string Nombre = "Servicio de Catering";
            string Descripcion = "Servicio de comidas diarias entregadas en base a las recomendaciones nutricionales";
            string Estado = "En Proceso";
            Guid ServiceId = Guid.NewGuid();
            //Act
            Servicio service = new Servicio(ServiceId,Nombre,Descripcion,Estado);

            // Assert
            Assert.Equal(Nombre, service.Nombre);
            Assert.Equal(Descripcion, service.Descripcion);
            Assert.Equal(Estado, service.Estado);
            Assert.Equal(0, service.CostoUnitario);          
            Assert.Equal(ServiceId, service.Id);
           
        }

        [Fact]
        public void UpdateCostIsValid()
        {

            //Arrange
            string Nombre = "Asesoramiento Nutricional";
            string Descripcion = "Plan de alimentación de 15 días con evaluación quincenal";
            string Estado = "En Proceso";
            Guid ServiceId = Guid.NewGuid();
            //Act
            Servicio service = new Servicio(ServiceId, Nombre, Descripcion, Estado);
            CostValue Cost = 100;

            service.UpdateCost( Cost);

            Assert.Equal(Cost, service.CostoUnitario);
        }
    }
}
