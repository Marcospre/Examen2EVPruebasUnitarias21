using System.Collections.Generic;
using System;
using System.Linq;

using Parejas;

namespace Parejas
{
    public class Sistema
    {
        /*List<(String,String)> rangos{get;}= new(){
            ("MuyJoven","Joven"),
            ("Joven","Plenitud"),
            ("Plenitud","Madurez"),
            ("Madurez","Vejez")
        };*/

        List<(String,String)> rangos= new List<(string, string)>(){
            ("MuyJoven","Joven"),
            ("Joven","MuyJoven"),
            ("Joven","Plenitud"),
            ("Plenitud","Joven"),
            ("Plenitud","Madurez"),
            ("Madurez","Plenitud"),
            ("Madurez","Vejez"),
            ("Vejez","Madurez")
        };
        
        

        public List<Persona> Personas { get; } = new()
        {
            new Persona("gonzalo",30,"V"),
            new Persona("Maria",25,"M"),
            new Persona("andres",45,"V"),
            new Persona("Laura",35,"M"),
            new Persona("Ricardo",18,"V"),
            new Persona("Eva",35,"M"),
            new Persona("Marcos",25,"V"),
            new Persona("Irene",22,"M"),
            new Persona("Mikel",55,"V"),
            new Persona("Macarena",60,"M")
            
        };

        

        public bool AdmitenDescendencia(Persona a, Persona b)
        {   
            bool res = false;
            
            if(a.getSexo() != b.getSexo()){
                if(Math.Abs(a.getEdad()-b.getEdad()) <=12){
                    if(comparaRangos(a,b))
                    res = true;
                }
            }
            return res;
        }

        public bool comparaRangos(Persona a, Persona b){
            var tupla  = (a.getRango(),b.getRango());
            bool res=false;

            for(int i=0; i<rangos.Count;i++){
                if(tupla.Equals(rangos[i])){
                    res=true;
                }
            }
            return res;
        }

        public List<(Persona, Persona)> PosibleParejas(List<Persona> personas)
        {

            var parejas = new List<(Persona, Persona)>();

           
            return parejas;
        }

        public string Saludo(string nombre) => $"Saludos {nombre}!";


    }
}