using System;
using Xunit;

namespace TestProject2
{
    
    public class UnitTest1
    {
        MaiorIdade _maiorIdade;

        public UnitTest1()
        {
            _maiorIdade = new MaiorIdade();
        }

        [Fact(DisplayName = "Testando se é maior de idade | Deve retornar True")]
        public void TestandoSeEMaiorDeIdadeComSucesso()
        {
            ///Arrange 
            var arrange = _maiorIdade.VerificandoSeoUsuarioEMaiorDeIdade(25);
            var expected = true;

            ///Act
            var resultado = arrange;

            ///Assert
            Assert.Equal(expected, resultado);
        }
    }
}
