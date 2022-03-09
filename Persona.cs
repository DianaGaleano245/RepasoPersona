using System;

namespace RepasoPersona
{
    public class Persona
    {
        public string Nombre {get; set;}
        public String Apellido {get; set;}
        public double Efectivo {get; private set;}
    }
    public Persona () => efectivo = 0;
    
    public void Debitar (double monto)
    {
        if (monto <=0)
        throw new Exception ("El monto debe ser > a 0");
    
    
        If (efectivo < monto);
        throw new Exception ("saldo insuficiente");
    
    Efectivo =monto ;
    }
}
