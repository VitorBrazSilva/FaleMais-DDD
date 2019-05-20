# FaleMais-DDD

Para rodar o projeto primeiro deve se criar um banco de dados. Para isso foi configurado no Migration
Abra gerenciador de pacotes do NuGet selecione o projeto FaleMais.Infra.Data2 e digite o seguinte comando "Update-Database -Verbose"
um banco de dados em de extensão mdf deve ser criado na raiz do projeto. Após isso execute o scripts no seu banco de dados
para que entre com as informações. Script se encontra na raiz do projeto com o nome script.sql.

Caso possua dificuldade em gerar o banco automaticamente, crie um e adicione as informações que contém no script e altere a connectionstring no
webconfig do projeto MVC

