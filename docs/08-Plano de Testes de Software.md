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


| Caso de Teste 	| CT-04 – Cadastro da Empresa Usuária |
|:---:	|:---:	|
|Requisitos Associados |RF-002|
| Objetivos do Teste 	| Verificar se uma empresa pode criar um usuário no sistema |
| Passos 	| - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Cadastrar minha empresa" <br> - Preencher os campos obrigatórios (nome fantasia, cnpj, endereço, e-mail, área de atuação, senha e confirmação de senha) <br> - Clicar em "Cadastrar" |
|Critério de Êxito | O cadastro da empresa deve ser devidamente realizado, criando um novo usuário para o sistema|


| Caso de Teste 	| CT-05 – Validação de Formato de E-mail |
|:---:	|:---:	|
|Requisitos Associados |RF-002 e RNF-005|
| Objetivos do Teste 	| Garantir que o sistema aceite apenas e-mails válidos |
| Passos 	| - Acessar o a página de cadasto de usuário <br> -	Preencher o campo de e-mail com um endereço de e-mail inválido (exemplo: "invalido.com") - Clicar em "Cadastrar" |
|Critério de Êxito | O sistema exibirá mensagen de erro informando que o formato de e-mail é inválido e não permitirá o cadastro até que um formato válido seja preenchido|

| Caso de Teste 	| CT-06 – Aceitação de endereço de e-mail único |
|:---:	|:---:	|
|Requisitos Associados |RF-002 e RNF-005|
| Objetivos do Teste 	| Verificar se o sistema permite o cadastro de empresas diferentes com um mesmo endereço de e-mail |
| Passos 	| - Acessar o a página de cadasto de usuário <br> - Concuir o cadastro de uma empresa usuária com um endereço de e-mail válido <br> - Acessar novamente a página de cadastro <br> - Tentar cadastrar uma nova empresa com o mesmo endereço de e-mail da empresa anterior |
|Critério de Êxito | O sistema exibirá mensagen de erro relatando que o e-mail informado já está em uso e não permitirá o cadastro até que seja informado um novo endereço de e-mail |

| Caso de Teste 	| CT-07 – Verificação de Dados Exclusivos |
|:---:	|:---:	|
|Requisitos Associados |RF-002 e RNF-005|
| Objetivos do Teste 	| Garantir que o sistema não permita o cadastro de usuários diferentes com o mesmo CNPJ |
| Passos 	| - Acessar o a página de cadasto de usuário <br> - Concuir o cadastro de uma empresa usuária com um CNPJ válido <br> - Acessar novamente a página de cadastro <br> - Tentar cadastrar uma nova empresa com o mesmo CNPJ da empresa anterior |
|Critério de Êxito | O sistema exibirá mensagen de erro relatando que o CNPJ informado já pertence a outro usuário e não permitirá o cadastro |

| Caso de Teste 	| CT-08 – Confirmação de Senha |
|:---:	|:---:	|
|Requisitos Associados |RF-002 e RNF-005|
| Objetivos do Teste 	| Garantir que o sistema exige confirmação de senha durante o cadastro de novo usuário |
| Passos 	| - Acessar o a página de cadasto de usuário <br> - Preencher os campos de forma válida até o campo "Senha" <br> - Preencher o campo "Confirmação de Senha" de forma diferente do campo "Senha" <br> - Clicar em "Cadastrar" |
|Critério de Êxito | O sistema exibirá mensagen de erro relatando que as senhas não coincidem e não permitirá o cadastro até que os campos "Senha" e "Confirmação de Senha" sejam correspondentes|
 
| Caso de Teste 	| CT-09 – Realização de Login |
|:---:	|:---:	|
|Requisitos Associados |RF-002|
| Objetivos do Teste 	| Verificar se o usuário consegue acessar o sistema como usuário|
| Passos 	| - Acessar o a página de cadasto de usuário <br> - Realizar o cadastro completo de usuário <br> - Acessar a página de login <br> - Preencher os campos de "e-mail" e "senha" com as informações cadastradas nos anteriores <br> - Clicar em "Acessar o Prospecta" |
|Critério de Êxito | O sistema autenticará o usuário e este terá acesso ao seu perfil e às demais funcionalidades do sistema|

| Caso de Teste 	| CT-10 – Realização de Login com Credenciais Erradas |
|:---:	|:---:	|
|Requisitos Associados |RF-002|
| Objetivos do Teste 	| Verificar se o sistema aceita login com informações não cadastradas anteriormente|
| Passos 	| - Acessar a página de login <br> - Preencher os campos de "e-mail" e "senha" com informações não cadastradas anteriormente <br> - Clicar em "Acessar o Prospecta" |
|Critério de Êxito | O sistema exibirá mensagem de erro informando que as credenciais informados são inválidas e impedirá o acesso a um perfil e demais funcionalidades do sistema|




