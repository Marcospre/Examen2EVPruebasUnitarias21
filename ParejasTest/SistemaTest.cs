using Xunit;
using System;
using Parejas;
using System.Collections.Generic;

namespace ParejasTest
{

    public class SistemaTest
    {

        [Fact]
        public void SaludoTest()
        {
            // Given
            var sis = new Sistema();
            var param = "Santi";
            var esperado = $"MAL Saludos {param}!";
            // When
            var result = sis.Saludo(param);
            // Then
            Assert.Equal(result, esperado);
        }

        [Theory]
        [MemberData(nameof(Data))]
        public void AdmitenDescendenciaTest(Persona a, Persona b, bool esperado)
        {
            // Given
            var sis = new Sistema();
            // When
            var result = sis.AdmitenDescendencia(a,b);
            // Then
            Assert.Equal(result, esperado);
        }

        public static IEnumerable<object[]> Data =>
        new List<object[]>
        {
            new object[] { new Persona("gonzalo",30,"V") , new Persona("Marta",25,"M"), true},
            new object[] { new Persona("andres",55 ,"V") , new Persona("Maria",45,"M"), true},
            new object[] { new Persona("ricardo",20,"V") , new Persona("Pedro",21,"V"), false},
        };

    }
}