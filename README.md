# Sistema de Gestão de Atendimentos

 📌 Descrição do Projeto
Este projeto foi desenvolvido como atividade da disciplina de Programação Orientada a Objetos (POO).  
O objetivo é criar um sistema de chamados de suporte, aplicando conceitos de Orientação a Objetos e os princípios SOLID.

Antes da implementação do código, foi elaborado o *Diagrama de Classes UML*, que serviu como base para o desenvolvimento do sistema.

O sistema permite o cadastro de usuários, abertura e gerenciamento de chamados, atribuição de técnicos, classificação por categoria e registro de histórico de atendimentos.

---

 🖼️ Diagrama de Classes UML

![Diagrama](docs/Diagrama%20UMI.png)

---

 🧠 Conceitos de Orientação a Objetos Utilizados

- *Classe e Objeto:* Utilização de classes como Usuario, Cliente, Tecnico, Chamado, Categoria e HistoricoChamado.
- *Encapsulamento:* Os atributos das classes são acessados por meio de propriedades e métodos.
- *Herança:* As classes Cliente e Tecnico herdam da classe abstrata Usuario.
- *Abstração:* Uso da classe abstrata Usuario para representar características comuns.
- *Polimorfismo:* Sobrescrita do método GetTipo() nas classes Cliente e Tecnico.
- *Interfaces:* Implementação das interfaces IAtribuivel e IEncerravel.
- *Classes abstratas:* Classe Usuario definida como abstrata.
- *Construtores:* Utilizados para inicializar os objetos.
- *Métodos sobrescritos (override):* Aplicados nas classes que herdam de Usuario.

---

 📐 Princípios SOLID Aplicados

## S – Single Responsibility Principle (SRP)
A classe *Chamado* é responsável apenas por armazenar os dados do chamado.  
As regras de negócio, como atribuição de técnico e alteração de status, são tratadas na classe *ChamadoService*.

## O – Open/Closed Principle (OCP)
O sistema permite a inclusão de novos tipos de usuários ou categorias sem a necessidade de alterar o código existente, apenas estendendo as classes.

## L – Liskov Substitution Principle (LSP)
As classes Cliente e Tecnico podem substituir a classe Usuario sem comprometer o funcionamento do sistema.

## I – Interface Segregation Principle (ISP)
Foram criadas interfaces pequenas e específicas:
- *IAtribuivel* para atribuição de técnicos
- *IEncerravel* para encerramento de chamados

## D – Dependency Inversion Principle (DIP)
As classes de serviço dependem de interfaces, e não de implementações concretas, reduzindo o acoplamento.

---

 ⚙️ Funcionalidades do Sistema

- Cadastro de clientes e técnicos
- Abertura de chamados de suporte
- Classificação de chamados por categoria
- Atribuição de técnico a um chamado
- Atualização do status do chamado (aberto, em andamento, encerrado)
- Registro de histórico de atendimentos
- Listagem de chamados por status ou técnico

---

 🛠 Tecnologias Utilizadas

- Linguagem: C#
- Plataforma: .NET
- IDE: Visual Studio
- Controle de versão: Git e GitHub

---

 👩‍🎓 Autora

- Maria Eduarda
- Evelyn Karina
