# Plano de Testes de Software

A seguir, os cenários levantados e enumerados a partir de casos de testes para a cobertura da eficiência dos requisitos da aplicação.
 
| **Caso de Teste** 	| **CT-01 – Cadastro de Leads** 	|
|:---:	|:---:	|
|	Requisitos Associados 	| RF-001 e RF-005 |
|Objetivos do Teste| Verificar se o cadastro de leads é possível através de preenchimento de formulário |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Cadastrar dados para contato" <br> - Preencher os campos obrigatórios (nome completo, cpf, endereço, telefone, e-mail, serviços/produtos de interesse) <br> - Clicar em "Enviar"|
|Critério de Êxito | O lead deve ser cadastrado no sistema e os dados enviados devem ser armazenados corretamente no banco de dados |


| Caso de Teste 	| CT-02 – Validação de Campos Obrigatórios do Formulário de Cadastro de Leads	|
|:---:	|:---:	|
|Requisitos Associados |RF-001, RF-005 e RNF-005|
| Objetivos do Teste 	| Examinar se os campos obrigatórios do formulário estão sendo verificados |
| Passos 	| - Acessar a página de formulário de cadastro de leads <br> - Preencher os campos obrigatórios, mas deixar um ou mais campos em branco <br> - Clicar em "Enviar" |
|Critério de Êxito | O sistema exibirá mensagens de erro informando sobre os campos obrigatórios em branco e não permitirá o envio do formulário até que estes estejam preenchidos|


| Caso de Teste 	| CT-03 – Validação do Formato de Número de Telefone |
|:---:	|:---:	|
|Requisitos Associados |RF-001, RF-005 e RNF-005|
| Objetivos do Teste 	| Verificar se o sistema aceita somente números de telefone válidos |
| Passos 	| - Acessar a página de formulário de cadastro de leads <br> - Preencher o campo de número de telefone com um formato inválido (exemplo: "0000") <br> - Clicar em "Enviar" |
|Critério de Êxito | O sistema exibirá mensagen de erro informando que o formato de número de telefone é inválido e não permitirá o envio do formulário até que um formato válido seja preenchido|


 

