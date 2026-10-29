Composite Pattern — Sistema de Pastas e Arquivos

📌 Sobre o projeto

Este projeto é um exercício prático para estudar o padrão de projeto Composite utilizando C# e
Programação Orientada a Objetos (POO).

O sistema simula a estrutura de pastas e arquivos de um computador, permitindo que pastas contenham
arquivos e outras pastas.

🎯 Objetivo

Praticar o padrão Composite, permitindo tratar arquivos individuais e pastas da mesma maneira por meio
de uma interface comum.

💻 Funcionalidades

Criar arquivos com nome e tamanho.

Criar pastas para armazenar arquivos.

Adicionar pastas dentro de outras pastas.

Calcular o tamanho total de uma pasta, incluindo seus arquivos e subpastas.

🛠️ Tecnologias utilizadas

C#

.NET

Visual Studio

Programação Orientada a Objetos (POO)

📂 Estrutura do projeto

Composite/
├── IComponente.cs
├── Arquivo.cs
├── Pasta.cs
├── Program.cs
└── README.md

🧩 Classes do projeto

IComponente

Interface que define o comportamento comum dos arquivos e das pastas, incluindo o método
CalcularTamanho().

Arquivo

Representa um arquivo individual, com nome e tamanho. Seu método CalcularTamanho() retorna
o tamanho do próprio arquivo.

Pasta

Representa uma pasta que pode armazenar arquivos e outras pastas. Seu método CalcularTamanho()
soma os tamanhos de todos os componentes armazenados.

Program

Responsável por criar os arquivos e as pastas, organizar a estrutura e exibir o tamanho total
calculado.

📚 Conceitos praticados

Interfaces em C#.

Encapsulamento.

Composição de objetos.

Coleções com List<T>.

Laço de repetição foreach.

Recursividade.

Padrão de projeto Composite.