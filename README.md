## DesignPatternsNetCore

### Objetivo
Apresentar exemplos de implementação de alguns Design Patterns no .NET Core

##### Já implementados

- Strategy
    - **Contexto**: Você é dono de uma oficina que tem na fila de espera para fazer manutenção uma moto, um carro e um caminhão. Para cada um desses automóveis é necessário fazer uma manutenção específica.

- Factory Method
    - **Contexto**: Estamos criando uma montadora de carros, e cada montadora sabe montar um único tipo de carro, que pode ser _elétrico_, _a vapor_ ou _a combustão_. Sendo que cada tipo de carro tem características próprias e sua montadora deve saber lidar com isso.

- Facade
    - **Contexto**: Estou querendo comprar o livro "Harry Potter: A Ordem da Fênix" e estou utilizando um daqueles buscadores, que traz em quais lojas este livro se encontra.

- Mediator
    - **Contexto**: Estamos em um aeroporto, e devido à alta demanda de voos, só podemos ter um avião de cada tipo no aeroporto. Por isso a torre de controle precisa notificar sempre que um avião estiver aterrizando.

- Template Method
    - **Contexto**: Tenho que extrair dados de vários tipos de documentos para que eu, como gestor da empresa, possa tomar a melhor decisão para ela. Entretanto, alguns passos dessa extração são idênticos, independente do formato do documento.

- Chain of Responsibility
    - **Contexto**: Estou com um problema na internet, onde será necessário configurar o meu modem. Para isso, tenho que ligar para a operadora de internet e tentar falar com alguém especializado.

- Adapter
    - **Contexto**: Tenho uma empresa, e uma funcionalidade do sistema de gerenciamento era me dar todos os meus funcionários no formato XML. O tempo passou, surgiu novas necessidades que esse sistema deve atender e uma delas é gerar este relatório em JSON.

- Decorator
    - **Contexto**: Sou um criador de Matrioscas! Sim ,Matrioscas, aquelas bonecas russas que vai uma dentro da outra! E cada vez que abro uma de minhas matrioscas ela precisa dizer qual seu tamanho. Assim quando eu quiser abrir todas, devo ouvir a sequência delas por tamanho!

##### Para serem implementados