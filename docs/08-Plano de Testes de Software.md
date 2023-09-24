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
|Critério de Êxito | O sistema exibirá mensagem de erro informando que as credenciais informadas são inválidas e impedirá o acesso a um perfil e demais funcionalidades do sistema|


| Caso de Teste 	| CT-11 – Vinculação de Lead à Empresa Usuária |
|:---:	|:---:	|
|Requisitos Associados |RF-003|
| Objetivos do Teste 	| Verificar se uma empresa usuária pode vincular um Lead ao seu perfil|
| Passos 	| - Fazer login no usuário da empresa <br> - Acessar a página de Leads Disponíveis <br> - Selecionar e ampliar as informações de um dos leads exibidos <br> - Clicar no botão de estrela "Vincular à Minha Empresa" |
|Critério de Êxito | O lead deve ser vinculado à conta da empresa usuária e estar cadastrado e exibido na página de "Favoritos"|

| Caso de Teste 	| CT-12 – Vinculação concomitante de mais de um Lead |
|:---:	|:---:	|
|Requisitos Associados |RF-003|
| Objetivos do Teste 	| Verificar se uma empresa usuária pode vincular mais de um lead, ao mesmo tempo, ao seu perfil|
| Passos 	| - Fazer login no usuário da empresa <br> - Acessar a página de Leads Disponíveis <br> - Selecionar mais de um lead dentre os exibidos <br> - Clicar no botão "Vincular os Leads Selecionados à Minha Empresa" |
|Critério de Êxito | Todos os leads selecionados devem ser vinculado à conta da empresa usuária e ser exibidos na página de "Favoritos"|

| Caso de Teste 	| CT-13 – Vinculação de leads duplicados |
|:---:	|:---:	|
|Requisitos Associados |RF-003|
| Objetivos do Teste 	| Verificar se o sistema impede que a empresa usuária vincule um mesmo lead ao seu perfil mais de uma vez|
| Passos 	| - Fazer login no usuário da empresa <br> - Acessar a página de Leads Disponíveis <br> - Selecionar vários leads, dente eles, algum que já seja vinculado ao usuário da empresa <br> - Clicar no botão "Vincular os Leads Selecionados à Minha Empresa" |
|Critério de Êxito | O sistema deve exibir mensagem de erro informando que um ou mais leads selecionados já se encontram vinculados à conta da empresa e impedir a conclusão da vinculação |

| Caso de Teste 	| CT-14 – Alteração das Etapas de Captação de Leads |
|:---:	|:---:	|
|Requisitos Associados |RF-004|
| Objetivos do Teste 	| Verificar se a empresa usuária pode alterar a etapa de captação do lead|
| Passos 	| - Fazer login no usuário da empresa <br> - Acessar a página de Gerenciamento de Leads <br> - Selecionar um dos leads vinculados à empresa <br> - Alterar a a etapa em que o lead se encontra (por exemplo, mudar de "Verificação de Potencial" para "Em processo de Contatação")|
|Critério de Êxito | O sistema deve permitir a alteração da etapa de contatação e passar a exibir a etapa escolhida pela empresa usuária |

| Caso de Teste 	| CT-15 – Histórico do Progresso de Etapas de Captação de Leads |
|:---:	|:---:	|
|Requisitos Associados |RF-004|
| Objetivos do Teste 	| Verificar se o sistema registra todas as etapas pelas quais o Lead passou no processo de captação|
| Passos 	| - Fazer login no usuário da empresa <br> - Acessar a página de Gerenciamento de Leads <br> - Selecionar um dos leads vinculados à empresa <br> - Alterar a a etapa em que o lead se encontra várias vezes|
|Critério de Êxito | O sistema deve exibir, na opção de "Progresso", um histórico em que conste as etapas pelas quais o Lead passou no processo de captação, contendo as datas correspondentes às alterações |

| Caso de Teste 	| CT-16 – Notificação de Alteração da Etapa de Captação de Leads |
|:---:	|:---:	|
|Requisitos Associados |RF-004|
| Objetivos do Teste 	| Verificar se o sistema notifica a empressa usuária quanto à alteração de etapa de captação de leads|
| Passos 	| - Fazer login no usuário da empresa <br> - Acessar a página de Gerenciamento de Leads <br> - Selecionar um dos leads vinculados à empresa <br> - Alterar a a etapa em que o lead se encontra|
|Critério de Êxito | O sistema deve exibir um alerta ou notificação para a empresa usuária, informando que a etapa de captação de um lead específico foi alterada |

| Caso de Teste 	| CT-17 – Armazenamento e Visualização dos Dados dos Leads |
|:---:	|:---:	|
|Requisitos Associados |RF-005|
| Objetivos do Teste 	| Verificar se os dados de cadastro dos leads estão armazenados corretamente no banco de dados do sistema |
| Passos 	| - Acessar a página de formulário de cadastro de leads <br> - Realizar o cadastro completo de um novo lead <br> - Fazer login no usuário da empresa <br> - Acessar a página de Leads Disponíveis <br> - Buscar o lead anteriormente cadastrado |
|Critério de Êxito | O lead cadastrado deve constar no banco de dados do sistema e a empresa usuária deve poder visualizar os dados do lead e todas as informações fornecidas no cadastro deste |

| Caso de Teste 	| CT-18 – Exclusão de Dados de Leads |
|:---:	|:---:	|
|Requisitos Associados |RF-005|
| Objetivos do Teste 	| Garantir que os dados de um lead cadastrado possam ser excluídos do banco de dados do sistema |
| Passos 	| - Acessar a página de formulário de cadastro de leads <br> - Realizar o cadastro completo de um novo lead <br> - Acessar a homepage do sistema <br> - Clicar na opção "Desejo excluír meus dados de cadastro" <br> - Preencher os campos de "nome" e "cpf"  <br> - Confirmar o desejo de exclusão de dados <br> - Fazer login no usuário da empresa <br> - Acessar a página de Leads Disponíveis <br> - Buscar o lead anteriormente excluído |
|Critério de Êxito | A empresa usuária não deve ser capaz de visualizar no sistema informações sobre o Lead cujos dados foram anteriormente excluídos |






