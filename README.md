# Practicing-TDD-with-xUnit-in-.NET-
Practicing TDD with xUnit in .NET 

<DATA ANNOTATIONS>

//Pulando um teste/método
[Fact(Skiped = "Motivo ou titulo, example: Not implementend yet")]

//Apresentando um nome específico para o método testado
[Fact(DisplayName = "Nome que desejo referenciar ao chamar o teste, example: Testando o método maior de idade | Deve retornar true")]

[Fact] > Testando fatos (Usually true or false)
  
  >>>>> THEORY <<<<<
[Theory] > Testando teorias (Usually numbers) - Teste de uma massa de dados, pode ser informada linha a linha ou por listas
  [InlineData(Conteudo que será utilizado para efetuar os testes)] - Teste linha a linha
  [MemberData(Testando uma lista ou massa de dados)] <Inumeration>
  [ClassData(Similar ao MemberData)] <Inumeration>
  
  >>>>> Trait <<<<
  Serve para agrupar e filtar os testes por um titulo definido
  [Trait("Categoria", "Nome da categoria que será apresentada ao filtrar")]
  example:
  [Trait("Category", "testeClasseVendas")]
  <Linha de comando[Trait]>
    dotnet test --filter Category=testeClasseVendas 

  </br>  
  <Verificando os testes> 
    Teste > Gerenciador de testes (ctrl e + t)
  </br>
  <<b>Video de apoio<\b>>
  https://www.youtube.com/watch?v=pLrsy-ookXQ (GitHub código: https://github.com/angelitocsg/coding-live-005)
  
  <Linha de comando>
    dotnet teste
    
    <TDD>
      TDD = Test Driven Development
      Consiste em 3 etapas:
      Red(Falhar): O que desejo testar - Etapa que falhamos o teste "propositalmente", fazendo só a casa.
      Green(Corrigir): Como deve ver - Correção do erro do teste 
      Refactor(Melhorar): Revisar o código - E melhorar a execução dos testes
