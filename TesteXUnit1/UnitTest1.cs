using System;
using Xunit;

namespace TesteXUnit1
{
    public class UnitTest1
    {
        //[Fact]
        //public void Test1()
        //{

        //}
        /// AAA
        /// Arrange<Configura/Prepara> | Act<Age> | Assert<Analisa/Valida>
        [Fact(DisplayName = "Testando se o CPF é diferente - Deve retornar false!")]
        public void estruturaAAA()
        {
            //Método testando AAA
            //Arrange
            var cpf = "111.111.111-05";
            var expected = false;

            //Act 
            var resultado = validaCpf(cpf);

            //Assert

            Assert.Equal(expected, resultado);
        }


        public bool validaCpf(string cpf)
        {
            if(!(cpf == "123.123.123-05"))
            {
                return false; 
            }
            return true;
        }
    }
}
