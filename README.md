# DIO - Trilha .NET - Fundamentos - Proposta desafio
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de fundamentos, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema para um estacionamento, que será usado para gerenciar os veículos estacionados e realizar suas operações, como por exemplo adicionar um veículo, remover um veículo (e exibir o valor cobrado durante o período) e listar os veículos.

## Proposta
Você precisará construir uma classe chamada "Estacionamento", conforme o diagrama abaixo:
![Diagrama de classe estacionamento](diagrama_classe_estacionamento.png)

A classe contém três variáveis, sendo:

**precoInicial**: Tipo decimal. É o preço cobrado para deixar seu veículo estacionado.

**precoPorHora**: Tipo decimal. É o preço por hora que o veículo permanecer estacionado.

**veiculos**: É uma lista de string, representando uma coleção de veículos estacionados. Contém apenas a placa do veículo.

A classe contém três métodos, sendo:

**AdicionarVeiculo**: Método responsável por receber uma placa digitada pelo usuário e guardar na variável **veiculos**.

**RemoverVeiculo**: Método responsável por verificar se um determinado veículo está estacionado, e caso positivo, irá pedir a quantidade de horas que ele permaneceu no estacionamento. Após isso, realiza o seguinte cálculo: **precoInicial** * **precoPorHora**, exibindo para o usuário.

**ListarVeiculos**: Lista todos os veículos presentes atualmente no estacionamento. Caso não haja nenhum, exibir a mensagem "Não há veículos estacionados".

Por último, deverá ser feito um menu interativo com as seguintes ações implementadas:
1. Cadastrar veículo
2. Remover veículo
3. Listar veículos
4. Encerrar


##  Solução 
O código está pela metade, e você deverá dar continuidade obedecendo as regras descritas acima, para que no final, tenhamos um programa funcional. Procure pela palavra comentada "TODO" no código, em seguida, implemente conforme as regras acima.

# Meu Projeto PMB Estacionamento :blue_car:


## A classe contém quatro variáveis, sendo:

:one:
`checkIns` É um Dictionary que armazena os registros de check-in dos veículos. A chave é uma string que representa a placa do veículo e o valor é uma struct Registro que contém os detalhes do check-in.

:two:
`taxaPorHora` É uma variável double que armazena a taxa por hora para estacionar.

:three:
`HoraEntrada` É uma variável DateTime que armazena a hora em que o veículo entrou no estacionamento.

:four:
`NomeCondutor` É uma string que armazena o nome do condutor do veículo.


## A classe contém cinco métodos, sendo:

:one:
`PlacaValida(string placa)`  Este método verifica se a placa do veículo está no formato correto.

:two:
`EntradaVeiculo(string placa, string nomeCondutor)` Este método é chamado quando um veículo entra no estacionamento.

:three:
`SaidaVeiculo(string placa)` MEste método é chamado quando um veículo sai do estacionamento.

:four:
`ListarVeiculos()`  Este método lista todos os veículos atualmente no estacionamento.

:five:
`Estacionamento()`  Este é o construtor da classe, que é um método especial chamado quando um objeto da classe é criado.

## Menu interativo com as seguintes ações:

| 1 -   | `Check-in de Veículo` |
| :--- | :---                 |
| 2 -   | `Check-out de Veículo`|
| 3 -   | `Listar veículo`      |
| 4 -   | `Encerrar`            |