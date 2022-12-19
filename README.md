# ConsoleWebScraping

##### Esse pequeno projeto foi criado no intuito de aprender como fazer um web scraping em .Net

#### No projeto foram utilizado os pacotes:
* **CsvHelper** - Utilizado para trabalhar com arquivos csv.
* **HtmlAgilityPack** - Utilizado para conseguirmos fazer manipulação de elementos Html.

#### Resumo do projeto:

* O projeto acessa o site https://www.infomoney.com.br/cotacoes/b3/indice/ibovespa/ onde tem a cotação da Ibovespa.
* Recupera o valor de **Pontos** e **Variação diária**.
* Cria um arquivo csv contendo as informações obtidas a cima.
* Retorna no console para o usuário as informações obtidas no site e o diretório do arquivo csv gerado.
