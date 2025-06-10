# 📚 Sistema Simplificado de Biblioteca

Projeto de console em C# desenvolvido para gerenciar uma biblioteca de forma simples, com funcionalidades básicas de cadastro, empréstimo e devolução de livros.

---

## 🧾 Funcionalidades

✅ Cadastro de livros  
✅ Cadastro de usuários  
✅ Registro de empréstimos  
✅ Registro de devoluções  
✅ Relatórios simples  
✅ Menu interativo no console  

---

## 🛠️ Estrutura do Sistema

### Classes:

- *Pessoa*: classe base com propriedade Nome
- *Usuario* (herda de Pessoa): adiciona Matrícula
- *Livro*: título, autor, ISBN e quantidade
- *Emprestimo*: relacionamento entre usuário e livro, com controle de datas
- *Biblioteca*: gerencia todas as operações

### Struct:

- PeriodoEmprestimo: contém DataEmprestimo e DataDevolucao

---

## 💡 Requisitos Atendidos

- [x] Pelo menos 4 classes
- [x] Herança (Usuario herda de Pessoa)
- [x] Struct para representar datas (PeriodoEmprestimo)
- [x] Uso de List<T> para armazenar livros, usuários e empréstimos
- [x] Propriedades com get/set com controle (como verificação de quantidade)
- [x] Menu simples via console com múltiplas opções

---

## ▶️ Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/SEU_USUARIO/sistema-biblioteca.git
   cd sistema-biblioteca
