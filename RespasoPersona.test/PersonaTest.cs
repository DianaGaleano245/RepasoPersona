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
                Dori=new Persona ("Dori","Galesno",0);
                Assert.Equal ("Dori",Dori.Nombre);
                Assert.Equal ("Galesno",Dori.Apellido);
                Assert.Equal (0,Dori.Efectivo);
            }
        }
    }
}
