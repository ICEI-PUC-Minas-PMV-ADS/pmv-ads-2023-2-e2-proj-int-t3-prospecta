# Registro de Testes de Software

| **Registro de Caso de Teste** 	| **CT-01 – Cadastro de Leads** 	|
|:---:	|:---:	|
|	Requisitos Associados 	| RF-005 |
|Objetivos do Teste| Verificar se o cadastro de leads é possível através de preenchimento de formulário |
|Comportamento do Sistema| Após a conclusão do teste, o sistema demonstrou que o lead foi cadastrado corretamente.|
|Conclusão| O teste foi concluído com sucesso, uma vez que o lead foi cadastrado no sistema sem erros visíveis.|


| **Registro de Caso de Teste** 	| **CT-17 – Armazenamento e Visualização dos Dados dos Leads** 	|
|:---:	|:---:	|
|Requisitos Associados 	| RF-001 e RF-005 |
|Objetivos do Teste| Verificar se os dados de cadastro dos leads estão armazenados corretamente no banco de dados do sistema|
|Comportamento do Sistema| Após a conclusão do teste, as informações fornecidas no cadastro estavam acessíveis para a empresa usuária.|
|Conclusão| O teste foi concluído com sucesso, uma vez que o lead foi cadastrado com êxito e todas as informações fornecidas no cadastro estavam visíveis no sistema. |

**Evidências:**
<br> 
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-prospecta/blob/main/src/criarlead.gif">

| **Registro de Caso de Teste** 	| **CT-18 – Exclusão de Dados de Leads** 	|
|:---:	|:---:	|
|Requisitos Associados 	| RF-005 |
|Objetivos do Teste| Garantir que os dados de um lead cadastrado possam ser excluídos do banco de dados do sistema|
|Comportamento do Sistema| - Após a exclusão de dados, o sistema confirmou que o lead foi excluído com sucesso. <br>- Ao acessar a página "Leads", o lead previamente excluído não estava mais visível.|
|Conclusão|O teste foi concluído com sucesso, uma vez que o lead foi excluído com êxito, e a empresa usuária não conseguia mais visualizar informações sobre o lead no sistema.|

**Evidências:**
<br> 
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-prospecta/blob/main/src/excluirlead.gif">

| **Registro de Caso de Teste** 	| **CT-04 – Cadastro da Empresa Usuária** 	|
|:---:	|:---:	|
|Requisitos Associados 	| RF-002 |
|Objetivos do Teste| Verificar se uma empresa pode se cadastrar no sistema. |
|Comportamento do Sistema|Após a conclusão do teste, o sistema confirmou que o cadastro da empresa foi devidamente realizado.|
|Observações| O campo denominado "Área de Atuação" apresentou falhas de preenchimento, relacionados à declaração da variável correspondente.|
|Conclusão|O teste foi concluído com êxito.|

**Evidências:**
<br> 
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-prospecta/blob/main/src/cadastroempresa.gif">

| **Registro de Caso de Teste** 	| **CT-11 – Edição de Dados Cadastrais da Empresa Usuária**|
|:---:	|:---:	|
|Requisitos Associados 	| RF-002 |
|Objetivos do Teste| Verificar se a empresa usuária pode editar os dados da sua empresa no sistema, incluindo informações como nome fantasia, CNPJ, endereço, e-mail, área de atuação e senha. |
|Comportamento do Sistema|Após a conclusão do teste, o sistema confirmou que as informações foram editadas com sucesso.|
|Conclusão|O teste foi concluído com sucesso, pois as informações da empresa foram editadas com êxito, e as alterações permaneceram após fechar e abrir novamente a página. |

**Evidências:**
<br> 
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-prospecta/blob/main/src/edicaoempresa.gif">

| **Registro de Caso de Teste** 	|**CT-12 – Exclusão de Dados Cadastrais da Empresa Usuária**|
|:---:	|:---:	|
|Requisitos Associados 	| RF-002 |
|Objetivos do Teste| Verificar se a empresa usuária pode excluir permanentemente os dados da sua empresa do sistema, garantindo que todas as informações sejam removidas com êxito. |
|Comportamento do Sistema|Após a conclusão do teste, o sistema confirmou que as informações da empresa não constam mais no banco de dados.|
|Conclusão|O teste foi concluído com sucesso, uma vez que todas as informações da empresa foram excluídas permanentemente do sistema.|

**Evidências:**
<br> 
<img src="https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2023-2-e2-proj-int-t3-prospecta/blob/main/src/excluirempresa.gif">

## Avaliação

**Etapa/Sprint 3:** Considerando as funcionalidades desenvolvidas, o desemprenho dos testes atingiu critérios satisfatórios dentro dos resultados esperados, cumprindo o fundamental em relação ao armazenamento de dados. No que diz respeito à elementos de tela, layout e texto, existem diversas melhorias que necessitam ser feitas, a fim de garantir uma melhor experiência de usuário. 

| Registro de Caso de Teste 	| CT-21 – Busca de Leads utilizando a Categoria Localização|
|:---:	|:---:	|
|Requisitos Associados |RF-007|
| Objetivos do Teste 	| Verificar se é possível localizar leads usando o filtro de localização |
| Comportamento do Sistema	| Ao fornecer a localização foram retornados somente os leads que apresentavam essa informação em seu cadastro |
| Conclusão | O teste foi concluído com êxito |

|  Registro de Caso de Teste 	| CT-22 – Busca de Leads utilizando a Categoria Serviços/Produtos de Interesse|
|:---:	|:---:	|
|Requisitos Associados |RF-007|
| Objetivos do Teste 	| Verificar se é possível localizar leads usando o filtro de Serviços/Produtos de Interesse |
| Comportamento do Sistema	| Ao fornecer os serviços/produtos de interesse foram retornados somente os leads que apresentavam essa informação em seu cadastro |
|Conclusão| O teste foi concluído com êxito |

| Registro de Caso de Teste 	| CT-24 – Busca de Leads utilizando a Categoria Empresa de Interesse |
|:---:	|:---:	|
|Requisitos Associados |RF-007|
| Objetivos do Teste 	| Verificar se é possível localizar leads que indicaram a empresa usuária como interesse durante o cadastro |
| Comportamento do Sistema 	|  Ao fornecer a empresa de interesse foram retornados somente os leads que apresentavam essa informação em seu cadastro |
|Conclusão | O teste foi concluído com êxito |

|  Registro de Caso de Teste  	| CT-25 – Busca de Leads utilizando mais de um filtro ao mesmo tempo |
|:---:	|:---:	|
|Requisitos Associados |RF-007|
| Objetivos do Teste 	| Verificar se é possível localizar leads a partir de filtros combinados |
| Comportamento do Sistema 	|  - Fazer login no usuário da empresa <br> - Acessar a página de Leads Disponíveis <br> - Selecionar os filtros de buscas "Localização", "Serviços/Produtos de Interesse" e "Interessados em Minha Empresa" e preencher as correspondentes especificações de cada um <br> - Clicar em Pesquisar |
|Conclusão | O sistema deve retornar uma lista contendo leads que atendam a todas as categorias especificadas |

|  Registro de Caso de Teste  	| CT-26 – Limpar Filtros de Busca|
|:---:	|:---:	|
|Requisitos Associados |RF-007|
| Objetivos do Teste 	| Verificar se é possível limpar filtros de buscas e obter lista de leads sem especificações |
| Comportamento do Sistema 	|  - Fazer login no usuário da empresa <br> - Acessar a página de Leads Disponíveis <br> - Selecionar os filtros de buscas "Localização", "Serviços/Produtos de Interesse" e "Interessados em Minha Empresa" e preencher as correspondentes especificações de cada um <br> - Clicar em Pesquisar <br> - Selecionar a Opção "Limpar Filtros" <br> - Clicar em pesquisar novamente |
|Conclusão | O sistema deve retornar uma lista contendo todos os leads cadastrados no sistema |
