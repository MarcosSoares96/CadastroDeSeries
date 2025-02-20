# CadastroSeries 📺

Este é um projeto de cadastro e gerenciamento de séries desenvolvido em C# como parte do curso prático da Digital Innovation One (DIO), ministrado pelo Eliézer Zarpelão. O projeto implementa operações básicas de CRUD (Create, Read, Update, Delete) para um catálogo de séries de TV.

## 📋 Sobre o Projeto

O CadastroSeries é uma aplicação console que simula um sistema de gerenciamento de séries, permitindo realizar operações como cadastro, atualização, listagem e exclusão de séries. O sistema suporta diferentes gêneros de séries e mantém um registro organizado do catálogo.

## 🚀 Funcionalidades

- Listagem de séries cadastradas
- Inserção de novas séries
- Atualização de séries existentes
- Exclusão lógica de séries
- Visualização detalhada de séries
- Sistema de marcação para itens excluídos
- Categorização por gêneros

## 🛠️ Tecnologias Utilizadas

- C# (.NET)
- Programação Orientada a Objetos
- Interfaces e Classes Abstratas
- Enums
- Listas e Coleções
- CRUD Operations

## 📦 Estrutura do Projeto

O projeto está organizado nos seguintes arquivos principais:

1. `Program.cs`: Contém a interface do usuário e lógica principal
2. `Serie.cs`: Implementa o modelo de série e suas propriedades
3. `SerieRepositorio.cs`: Gerencia as operações com as séries
4. `IRepositorio.cs`: Define a interface do repositório
5. `EntidadeBase.cs`: Classe base abstrata
6. `Genero.cs`: Enum com os gêneros disponíveis

## 💻 Como Usar

1. Clone o repositório
2. Abra o projeto em sua IDE preferida
3. Execute o programa
4. Use o menu interativo para:
   - Listar séries (opção 1)
   - Inserir nova série (opção 2)
   - Atualizar série (opção 3)
   - Excluir série (opção 4)
   - Visualizar série (opção 5)
   - Limpar a tela (opção C)
   - Sair do programa (opção X)

## ⚙️ Funcionalidades Detalhadas

### Cadastro de Série
- Seleção de gênero pré-definido
- Inserção de título e descrição
- Definição do ano de lançamento
- Geração automática de ID

### Operações do Sistema
- **Listagem**: Exibição de todas as séries com status
- **Atualização**: Modificação de dados cadastrados
- **Exclusão**: Marcação lógica de registros
- **Visualização**: Detalhamento completo da série

## 🤝 Contribuições

Contribuições são bem-vindas! Você pode:
- Reportar bugs
- Sugerir novas funcionalidades
- Melhorar a documentação
- Implementar novas features
- Refatorar código existente

## ✨ Próximos Passos

- Implementação de persistência de dados
- Interface gráfica
- Sistema de busca avançada
- Suporte a múltiplas temporadas
- Integração com APIs externas
- Sistema de avaliação de séries

## ✨ Agradecimentos

Agradecimento especial à Digital Innovation One (DIO) e ao instrutor Eliézer Zarpelão pelo excelente conteúdo e orientação no desenvolvimento deste projeto.

## 📝 Licença

Este projeto está sob a licença MIT. Consulte o arquivo LICENSE para mais detalhes.
