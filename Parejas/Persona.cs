namespace Parejas
{
    public class Persona
    {
       string nombre;
       int edad;
       string sexo;

        string rango;

        public Persona(string nombre, int edad, string sexo){
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            calcularRango();
        }

        public void calcularRango(){
            if(edad >=0 && edad<=19){
                rango = "MuyJoven";
            }else if(edad>=20 && edad<=29){
                rango = "Joven";
            }else if(edad>=30 && edad <= 39){
                rango = "Plenitud";
            }else if(edad>=40 && edad <=49){
                rango = "Madurez";
            }else{
                rango = "Vejez";
            }
        }
       public string getSexo(){
           return sexo;
       }

       public string getRango(){
           return rango;
       }

       public int getEdad(){
           return edad;
       }

        public override string ToString() => $"A codificar";
    }
}