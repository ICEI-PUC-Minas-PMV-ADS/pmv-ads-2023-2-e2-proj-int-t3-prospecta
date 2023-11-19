
# Metodologia

A seguir, especificações sobre os ambientes de trabalho e ferramentas utilizadas para a gestão e desenvolvimento do projeto, bem como definições de processos e da organização da equipe. 

## Controle de Versão

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.

O projeto segue a seguinte convenção para o nome de branches:

- `main`: versão estável já testada do software
- `unstable`: versão já testada do software, porém instável
- `testing`: versão em testes do software
- `dev`: versão de desenvolvimento do software

Quanto à gerência de issues, o projeto adota a seguinte convenção para
etiquetas:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `improvement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida

## Gerenciamento de Projeto

### Divisão de Papéis

A Metodologia Ágil escolhida para o gerenciamento do projeto é a Scrum. A partir disso, o time divide-se da seguinte forma:

- **Product Owner:** Arthur Zebral
- **Scrum Master:** Débora Alexia
- **Developers:**
  - Carolina Mascarenhas
  - Carolina Morais
  - Lidia Fonseca
- **UX Designer:** Laila Martins

### Processo

Dada a orientação do projeto a partir da metodologia ágil <em>Scrum</em>, o processo de desenvolvimento se dá a partir da definição do Product Backlog e do planejamento e realização de 05 (cinco) Sprints, conforme descrito a seguir. 

A organização objetiva do BackLog, bem como a divisão e distribuição dos respectivos itens, se dá a partir do Quadro de Tarefas denominado [Gerenciamento de Projeto: Prospecta](https://github.com/orgs/ICEI-PUC-Minas-PMV-ADS/projects/493/views/1), semelhante ao Kanban, através da ferramenta GitHub Project, encontrando-se hospedado nesse mesmo repositório. A estruturação do quadro se dá a partir das seguintes colunas:

- **Backlog:** contém todos itens do backlog do produto que ainda serão abordados nas próximas sprints.
- **To Do:** contém os itens que serão revisados e realizados na sprint atual. 
- **In Progress:** diz respeito aos itens que estão em desenvolvimento.
- **In Review:** itens que já foram desenvolvidos, mas precisam de revisão e validação de outros integrantes da equipe.
- **Done:** itens já desenvolvidos, revisados, validados e entregues.

### Product Backlog


| Sprint | Período  | Itens | Status |
|--------|-------------|---------------------------------------------|-----------|
|Sprint 1|01/08 a 03/09| **Definição do problema**<br> **Proposta de solução**<br> **Personas e Histórias de usuários**<br> **Requisitos e Restrições**<br> **Diagrama de Casos de Uso**| Done |
|Sprint 2|04/09 a 24/09| **Metodologia**<br> **Diagrama de Classes**<br> **Diagrama de Fluxo**<br> **Wireframes**<br> **Modelo Entidade Relacionamento**<br> **Projeto da Base de Dados**<br> **Plano de Testes de Software**<br> **Plano de Testes de Usabilidade**| Done |
|Sprint 3|25/09 a 22/10| **Template Padrão do Site**<br> **Prova de Conceito da Arquitetura**<br> **Programação das Funcionalidades**<br> **Realização e Registro de Testes de Software**<br> **Realização e registro dos testes de usabilidade** |Done|
|Sprint 4|23/10 a 19/11| **Programação das demais funcionalidades**<br> **Realização e Registro dos demais Testes de Software**<br> **Realização e registro dos demais testes de usabilidade** | Done |
|Sprint 5|20/11 a 06/12| **Relatório do Teste de Software**<br> **Relatório do teste de usabilidade**<br> **Implantação da Solução**<br> **Desenvolvimento da apresentação**<br> **Vídeo de apresentação da solução** | To Do |
 
### Ferramentas

As ferramentas empregadas no projeto são:

|Objetivo            | Ferramenta       |
|--------------------|------------------|
|**Editor de código**|Visual Studio Code|
|**Comunicação**|Microsoft Teams|
|**Wireframe**|Marvel App |
|**Diagramas**|Astah e Creately|
|**Gerenciamento do Projeto**|Github Project|
|**Hospedagem da Solução**|Github Pages|



O editor de código foi escolhido porque ele possui uma integração com o
sistema de versão. As ferramentas de comunicação utilizadas possuem
integração semelhante e por isso foram selecionadas. Por fim, para criar
diagramas utilizamos essa ferramenta por melhor captar as
necessidades da nossa solução.
