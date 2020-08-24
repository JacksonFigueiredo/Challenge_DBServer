Exemplo Utilizando .NET CORE 3, DDD, Automapper e SQL Server.




1)	EXPLIQUE COM SUAS PALAVRAS O QUE É DOMAIN DRIVEN DESIGN E SUA IMPORTÂNCIA NA ESTRATÉGIA DE DESENVOLVIMENTO DE SOFTWARE.

Muitos na realidade acabam pensando de forma errada que DDD é uma arquitetura, pensam errado.
Pois na realidade o próprio DDD é um conjunto de boas práticas de desenvolvimento para que seja aplicada
independente da linguagem para resolução de problemas, com grande importância, para menor acoplamento,
favorecendo a reutilização de código e alinnhando o código ao negócio.




2)	EXPLIQUE COM SUAS PALAVRAS O QUE É E COMO FUNCIONA UMA ARQUITETURA BASEADA EM MICROSERVICES. EXPLIQUE GANHOS COM ESTE MODELO E DESAFIOS EM SUA IMPLEMENTAÇÃO.

"Microsserviços" - mais um novo termo nas ruas lotadas da arquitetura de software. Embora a nossa inclinação natural seja olhar para essas coisas com um certo desprezo, a terminologia descreve um estilo de sistemas de software que temos achado cada vez mais atraente. Temos visto muitos projetos usando esse estilo nos últimos anos, e os resultados até agora têm sido positivos; tanto que, para muitos de nossos colegas, microsserviços vem se tornando o estilo padrão para o desenvolvimento de aplicativos corporativos. Infelizmente, no entanto, não há muita informação que descreva o estilo de microsserviços e como aplicá-lo.

Resumindo, o estilo de arquitetura de microsserviços é uma abordagem que desenvolve um aplicativo único como uma suite de pequenos serviços, cada um executando seu próprio processo e se comunicando através de mecanismos leves, muitas vezes em uma API com recursos HTTP. Esses serviços são construídos em torno de capacidades de negócios e funcionam através de mecanismos de deploy independentes totalmente automatizados. Há o mínimo possível de gerenciamento centralizado desses serviços, que podem ser escritos em diferentes linguagens de programação e utilizam diferentes tecnologias de armazenamento de dados.

Fonte : ToughWorks


3)	EXPLIQUE QUAL A DIFERENÇA ENTRE COMUNICAÇÃO SINCRONA E ASSINCRONA E QUAL O MELHOR CENÁRIO PARA UTILIZAR UMA OU OUTRA.

m comunicações síncronas, o emissor e o receptor devem estar num estado de sincronia antes da comunicação iniciar e permanecer em sincronia durante a transmissão. Ou seja, os dois precisam estar juntos e interagindo, independente de estarem no mesmo local ou não, durante o ato da comunicação Exemplos de comunicação síncrona são as ligações telefônicas, as videoconferências e a comunicação em áudio e vídeo em redes sociais como o Whatsapp.

Sendo assincrona mais performático e melhor recomendado para operações em tempo real, e sincrona para não tempo real, como envio de email por exemplo

Fonte : Wikipedia