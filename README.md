# Desafio de Projeto utilizando .NET e Programação Orientada a Objetos (POO)

## Objetivo
Modelar um sistema que trabalha com celulares e disponibilze maneiras de diferentes marcas e modelos terem seu próprio comportamento, possibilitando um maior reuso de código e usando a orientação a objetos.

## Construção
Foi criado um sistema em .NET, do tipo console, mapeando uma classe abstrata e classes específicas para dois tipos de celulares: Nokia e iPhone. 
As classes foram criadas de acordo com o diagrama abaixo:

![Diagrama classes](Imagens/diagrama.png)

## Regras e validações
1. A classe **Smartphone** é abstrata;
2. A classe **Nokia** e **Iphone** são classes filhas de Smartphone;
3. O método **InstalarAplicativo** deve ser sobrescrito na classe Nokia e iPhone, pois ambos possuem diferentes maneiras de instalar um aplicativo.