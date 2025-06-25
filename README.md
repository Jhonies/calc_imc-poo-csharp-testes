# 📊 Projeto Calculadora IMC (Índice de Massa Corporal)

Este é um projeto em C# desenvolvido com o objetivo de calcular o IMC (Índice de Massa Corporal) de uma pessoa a partir do seu nome, peso e altura, além de classificar o resultado com base nas faixas recomendadas pela OMS.

## 🧠 Objetivo

O projeto simula um pequeno sistema de console, que:
- Recebe os dados do usuário (nome, peso, altura)
- Calcula o IMC
- Classifica o resultado (ex: "Peso normal", "Obesidade grau 1", etc.)
- Permite a repetição até que o usuário pressione ESC para sair

Este projeto foi desenvolvido como parte do curso técnico em Desenvolvimento de Sistemas do **SENAI**.

---

## 📁 Estrutura

- `Program.cs`: Lógica principal da aplicação em modo console
- `Pessoa.cs`: Classe com propriedades de nome, peso e altura
- `CalculoIMC.cs`: Contém o método responsável por calcular o IMC
- `ClassificarIMC.cs`: Classifica o resultado do IMC com base em faixas padrão

---

## 🧪 Testes Automatizados

O projeto conta com duas abordagens de testes unitários:

### ✅ MSTest (`MSTest_Test`)
- Teste do cálculo do IMC com precisão de até 0.001
- Teste das classificações com base em diferentes valores
- Teste de tratamento de erros para entradas inválidas (peso/altura ≤ 0)

### ✅ xUnit (`xUnit_Test`)
- Implementação alternativa dos mesmos testes utilizando o framework xUnit

---

## 🛠️ Tecnologias Utilizadas

- C# (.NET 8.0)
- MSTest
- xUnit
- Visual Studio 2022

---

## 📸 Exemplo de Uso

```bash
Digite seu nome: João
Digite seu peso (kg): 75
Digite sua altura (m): 1.78

João, seu IMC é 23.67 e você está classificado como: Peso normal

---

## 🚀 Como executar

1. Clone o repositório.
2. Abra a solução no Visual Studio.
3. Execute o projeto **IMC** como aplicação principal.
4. Execute os testes pelos projetos **MSTest_Test** e **xUnit_Test** no Gerenciador de Testes.

## 📚 Créditos

Projeto desenvolvido como atividade prática no curso técnico de Desenvolvimento de Sistemas do SENAI.

