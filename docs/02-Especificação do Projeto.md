# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

### Sarah - Dona de um escritório de Arquitetura

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-prospecta/assets/123324372/28a3f462-4955-434b-8f66-5ea7c11bc521)


Sarah é uma empresária de 42 anos bem sucedida no ramo de arquitetura, dona do Escritório ARQ&CO. Ela se formou em arquitetura e urbanismo aos 26 e aos 34 fundou seu próprio escritório especializado em projetos para seus clientes, que na época eram pouco mais que 10. Hoje, todavia, os números são bem maiores e ela mantém essa expectativa de crescimento para o futuro. Portanto devido à demanda, Sarah contratou uma equipe de auxiliares de escritório para realizarem prospecção dos leads para enfim repassar as informações necessárias para que Sarah e seus parceiros realizem os projetos. Tudo isso por meio de formulários preenchidos pelos potenciais clientes, de maneira que a elaboração de orçamentos fosse mais eficiente e ágil. Apesar dos esforços ainda sim ela lida com uma desorganização notável nos computadores dos escritórios no que diz respeito aos leads. Portanto, um sistema de gerenciamento de leads seria de grande uso de modo a pouparem tempo e esforço, melhorarem o atendimento ao cliente e, consequentemente, a qualidade do trabalho e o lucro adquirido.


### Ricardo - Professor de matemática em busca de um orçamento para uma reforma

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-prospecta/assets/123324372/d586085c-172e-4ee1-9052-c265a15a20cd)

Ricardo é um professor de faculdade, 60 anos, é casado com sua esposa há mais de 30 anos e vivem juntos há quase 40. Ricardo leciona matemática, gosta bastante do seu trabalho mas ama o conforto de estar em casa e relaxar. Entretanto já a algum tempo, sua esposa havia expressado o desejo de reformar a casa e pediu para que Ricardo cuidasse disso, e por outro lado, Ricardo nunca teve tempo em sua rotina apertada de professor para realizar uma negociação decente. Todos os profissionais demoravam para responder, pediam para conversar por chamada ou até mesmo requisitavam sua presença nos seus respectivos escritórios, para no final não haver nenhum acordo concluído. Tudo que Ricardo precisava era uma maneira de contatar uma empresa de maneira rápida e prática, e só ser contatado novamente com uma proposta já terminada e partir para a negociação. Dessa maneira, seria de grande ajuda para alguém como o Ricardo, ter acesso a uma maneira mais prática e dinâmica de obtenção de orçamento, pois mesmo diversas empresas utilizando os leads como forma de contato, a maioria delas devido a falta de organização não dão uma resposta em tempo hábil. Um sistema de gerenciamento de leads por parte das empresas contatadas por ele, por exemplo, resolveria seus problemas.


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Sarah  | Otimizar o processo de captação de leads |Para simplificar a captação de potenciais clientes e tornar mais rápida a criação de propostas. |
|Sarah  | Armazenar as informações dos meus clientes no sistema de geração de leads |Para visualizar as informações de forma ágil e eficiente, melhorando assim o atendimento e a elaboração de orçamentos. |
|Sarah | Acompanhar o status dos leads | Para manter um relacionamento próximo e satisfatório com os clientes. |
|Sarah | Visualizar os leads por condição, local e/ou outros fatores | Para priorizar os mais relevantes e otimizar o meu tempo e o da minha equipe. |
|Ricardo       | Alterar                 | Alterar |

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Criação de uma aplicação com interação  backend | ALTA |
|RF-002| Permitir o cadastro de dados pelo próprio lead a partir de formulário | ALTA |
|RF-003| Permitir que empresas realizem Login através de cadastro de usuário | ALTA |
|RF-004| Permitir que a empresa usuária favorite leads | MÉDIA |
|RF-005| Permitir que a empresa usuária gerencie em que etapa do processo de captação o lead se encontra | MÉDIA |
|RF-006| Armazenar e permitir a visualização dos dados dos leads no banco de dados | ALTA |
|RF-007| Permitir que os dados dos leads sejam exportados em formato XLS | BAIXA |
|RF-008| Permitir a filtragem dos leads a partir de categorias tais como localidade, preferência, entre outros | ALTA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| Deve ser compatível para os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge), proporcionando experiência semelhante ao usuário | ALTA | 
|RNF-002| Deve ser responsivo para adaptar em diferentes dispositivos e tamanho de telas |  ALTA | 
|RNF-003| Deve estar em conformidade com as diretrizes de acessibilidade a D.V. (suporte para leitores de tela e texto descritivo de imagens) | BAIXA | 
|RNF-004| O sistema deve sinalizar o usuário quando alguma operação está demorando mais que o comum. O tempo de resposta não deve ultrapassar 15 segundos | MÉDIA |
|RNF-005|A plataforma deve ter interface clean, intuitiva e de fácil manuseio pelo usuário | MÉDIA |

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| A linguagem de programação usada no backend deve ser o C#|
|03| Deve ser utilizado um banco de dados relacional|
|04| O único framework para frontend permitido deve ser o Bootstrap|
|05| O código não poderá ser desenvolvido a partir de IA generativa|

Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

![image](https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-prospecta/assets/125296093/ff28f974-feae-4a7b-afb0-cf8c19885a3a)



O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
