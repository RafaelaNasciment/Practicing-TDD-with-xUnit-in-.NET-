# Practicing-TDD-with-xUnit-in-.NET-
Practicing TDD with xUnit in .NET 

<DATA ANNOTATIONS>

//Pulando um teste/método
[Fact(Skiped = "Motivo ou titulo, example: Not implementend yet")]

[Fact] > Testando fatos (Usually true or false)
[Theory] > Testando teorias (Usually numbers)

  </br>  
  <Verificando os testes> 
    Teste > Gerenciador de testes (ctrl e + t)
  </br>
  <Video de apoio>
  https://www.youtube.com/watch?v=pLrsy-ookXQ (GitHub código: https://github.com/angelitocsg/coding-live-005)
  
  <Linha de comando>
    dotnet teste
    
    <TDD>
      TDD = Test Driven Development
      Consiste em 3 etapas:
      Red(Falhar): O que desejo testar - Etapa que falhamos o teste "propositalmente", fazendo só a casa.
      Green(Corrigir): Como deve ver - Correção do erro do teste 
      Refactor(Melhorar): Revisar o código - E melhorar a execução dos testes
