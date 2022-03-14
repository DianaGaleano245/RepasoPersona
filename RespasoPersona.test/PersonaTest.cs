using System;
using Xunit;

namespace RespasoPersona.test
{
    public class PersonaTest
    {
        [Fact]
        public void Constructor()
        {
            public Persona Dori {get;set;}
            [fact]
            public void Constructor()
            {
                Dori= new persona ("Dori","Galesno",0);
                Assert.Equal ("Dori",Dori.Nombre);
                Assert.Equal ("Galesno",Dori.Apellido);
                Assert.Equal (0,Dori.Efectivo);
            }
            [fact]
            public void Acreditar Positivo ()
            {
                double esperando = 1000
                Dori.Acreditar (1000);
                Assert. NotEqual(esperando, Dori.Efectivo,3);
            }
        }
    }
}
