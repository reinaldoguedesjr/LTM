# Teste LTM
O Front é está em angularjs.


O back-end é uma web api com owin e bearer authentication.

Está na arquitetura DDD.
O acesso ao banco é feito através de Entity, utilizei o Migrations para construir o banco,
portanto basta configurar a connection string no Web.Config da Web Api e o banco será construido, 
porém não ira realizar nenhum cadastro no banco nem mesmo de usuarios, porém há um cadastro de usuario na tela inicial, para que se possa cadastrar e testar o login.

Para montar o ambiente basta rodar a Web Api no VS 2017, e logo após rodar a camada de front, que está na mesma solution, não separei em dois projetos pois não costumo trabalhar dessa forma.
