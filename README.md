# 📚 Course Manager

Este é um sistema de **gerenciamento de cursos, professores e turmas**, desenvolvido em **C# (.NET Framework)** com **Windows Forms** e **MySQL** como banco de dados. O projeto segue o padrão **MVC** (Model-View-Controller), garantindo uma arquitetura organizada e modular.

> 🔹 **Histórico:** Este projeto foi originalmente desenvolvido durante o ensino médio técnico no **COTEMIG** e passou por uma refatoração completa para seguir boas práticas de programação e arquitetura de software.

---

## 🚀 **Funcionalidades**

### 🎓 **Gerenciamento de Cursos**

- Cadastrar, listar, alterar e excluir cursos.
- Informações: nome, conteúdo, carga horária e valor da mensalidade.

### 👨‍🏫 **Gerenciamento de Professores**

- Cadastrar, listar, alterar e excluir professores.
- Informações: nome, telefone e valor da hora/aula.

### 🏫 **Gerenciamento de Turmas**

- Criar turmas associando cursos e professores.
- Definir horários de início e término.

### 💻 **Interface Intuitiva**

- Windows Forms para facilitar o uso.
- DataGridView para exibição de dados em tabelas.

### 📐 **Padrão MVC Implementado**

- Separação clara entre Model (Banco de Dados), View (Interface) e Controller (Lógica).

---

## 🛠 **Tecnologias Utilizadas**

- **Linguagem:** C#
- **Framework:** .NET Framework 4.7.2+
- **Banco de Dados:** MySQL
- **ORM:** ADO.NET
- **IDE:** Visual Studio

---

## 🔧 **Como Instalar e Executar**

### ✅ **1. Clone o Repositório**

```sh
git clone https://github.com/GustavoPontess/ControleDeCurso
cd ControleDeCursos
```

### ✅ **2. Configure o Banco de Dados**

1. Instale o **MySQL Server**.
2. Crie um banco de dados chamado `course_manager`.
3. Execute o script `database/schema.sql` para criar as tabelas.

### ✅ **3. Configure a Conexão com o Banco**

Edite o arquivo **`ConnectionHelper.cs`** e atualize com suas credenciais do MySQL:

```csharp
string conn = "Server=localhost;Database=course_manager;User=root;Password=sua_senha;";
```

### ✅ **4. Abra e Compile no Visual Studio**

1. Abra o arquivo **`course-manager.sln`** no **Visual Studio**.
2. No menu superior, clique em **"Build" → "Rebuild Solution"**.
3. Pressione **F5** para executar o projeto.

---

## 📂 **Estrutura do Projeto**

```
ControleDeCursos/
│── database/           # Scripts SQL para o banco de dados
│── src/                # Código-fonte principal
│   ├── Models/         # Classes que interagem com o banco de dados
│   ├── Controllers/    # Lógica da aplicação
│   ├── Views/          # Interface gráfica (Windows Forms)
│── .gitignore          # Arquivos ignorados pelo Git
│── README.md           # Documentação do projeto
│── course-manager.sln  # Solução do Visual Studio
```

---

## 🎯 **Melhorias na Refatoração**

- **Implementação completa do padrão MVC** para melhor organização do código.
- **Correções em queries SQL** e **ajustes no banco de dados** para evitar erros.
- **Uso de ********`TryParse()`******** e validações** para evitar exceções no Windows Forms.
- **Remoção de código duplicado** nos Controllers e Models.
- **Arquivo ********`.gitignore`******** adicionado** para evitar versionamento de arquivos desnecessários.

---

## 🤝 **Contribuição**

Sinta-se à vontade para contribuir com melhorias!

1. **Fork** o repositório.
2. Crie uma **branch** (`git checkout -b minha-feature`).
3. Faça o **commit** das alterações (`git commit -m 'Minha nova feature'`).
4. Faça um **push** para a branch (`git push origin minha-feature`).
5. Abra um **Pull Request**.

---

## 📜 **Licença**

Este projeto é de código aberto e está licenciado sob a [MIT License](https://opensource.org/licenses/MIT).