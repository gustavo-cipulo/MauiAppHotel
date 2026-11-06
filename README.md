
# 🏨 MauiAppHotel — Sistema de Hospedagem

---

## 📌 Objetivo

Este projeto tem como objetivo desenvolver um **aplicativo de contratação de hospedagens**, utilizando **C# e .NET MAUI**, com foco na criação e personalização de interfaces gráficas.

O aplicativo foi desenvolvido como parte da **Agenda 13 — Imagens e Componentes Diversos de Interface Gráfica**.

---

## 🧠 Como funciona

O aplicativo permite configurar as informações de uma hospedagem.

O sistema possui as seguintes funcionalidades:

- 👥 Selecionar a quantidade de adultos;
- 👶 Informar a quantidade de crianças;
- 🛏️ Escolher o tipo de suíte;
- 📅 Selecionar a data de check-in;
- 📅 Selecionar a data de check-out;
- ✅ Validar as informações antes de avançar;
- ℹ️ Acessar a tela Sobre.

---

## 🏨 Contratação de Hospedagem

A tela principal permite configurar os detalhes da estadia.

### 👥 Quantidade de hóspedes

Utiliza o componente **Stepper** para aumentar ou diminuir a quantidade de adultos e crianças.

### 🛏️ Seleção de suíte

Utiliza o componente **Picker** para selecionar uma das acomodações disponíveis:

- Suíte Standard;
- Suíte Luxo;
- Suíte Premium.

### 📅 Período da estadia

Utiliza o componente **DatePicker** para selecionar as datas de entrada e saída.

O aplicativo verifica se o check-out é posterior ao check-in.

---

## 🔗 BindingContext

O projeto utiliza **BindingContext** para vincular informações entre os componentes da interface.

Os valores dos componentes `Stepper` são exibidos automaticamente por meio de **Data Binding**.

Esse recurso facilita a atualização das informações apresentadas ao usuário.

---

## ℹ️ Tela Sobre

O aplicativo possui uma tela denominada **Sobre**, que apresenta:

- 👨‍💻 Nome do desenvolvedor;
- 📅 Ano de desenvolvimento;
- 🏨 Nome do aplicativo;
- 💻 Tecnologias utilizadas;
- 📝 Descrição do projeto.

A tela também possui um botão para retornar à página principal.

---

## 🎨 Personalização da Interface

O layout foi personalizado para proporcionar uma aparência moderna e organizada.

As principais alterações incluem:

- Cores em tons de azul;
- Botões personalizados;
- Painéis com bordas arredondadas;
- Organização dos componentes;
- Ajustes de espaçamento;
- Identidade visual do Hotel Premium.

---

## 🧮 Estruturas e recursos apresentados

- `ContentPage` para criação das telas;
- `VerticalStackLayout` para organização vertical;
- `Grid` para posicionamento dos componentes;
- `ScrollView` para rolagem;
- `Border` para personalização;
- `Label` para exibição de textos;
- `Button` para interação;
- `Stepper` para seleção de quantidades;
- `Picker` para seleção de acomodações;
- `DatePicker` para seleção de datas;
- `BindingContext` para vinculação de dados;
- `NavigationPage` para navegação entre telas;
- Eventos `Clicked` para execução de ações.

---

## 🖥️ Telas desenvolvidas

### 🏨 Contratação de Hospedagem

Tela principal responsável pela seleção de hóspedes, acomodação e período da estadia.

### ℹ️ Sobre o Aplicativo

Tela que apresenta informações sobre o desenvolvedor e o projeto.

### ✅ Hospedagem Contratada

Tela destinada à continuação do processo de hospedagem, ainda com conteúdo inicial de demonstração.

---

## 🧪 Funcionalidades demonstradas

- Alteração da quantidade de hóspedes;
- Atualização automática dos valores;
- Seleção de suítes;
- Escolha das datas de hospedagem;
- Validação dos campos;
- Navegação entre páginas;
- Acesso à tela Sobre;
- Retorno à tela principal.

---

## 💻 Tecnologias utilizadas

- 💻 C#
- 📱 .NET MAUI
- 🎨 XAML
- 🛠️ Visual Studio 2022
- 🐙 Git e GitHub

---

## 👨‍💻 Desenvolvedor

**Gustavo Cipulo Almeida Batista da Silva**

**Ano:** 2026
