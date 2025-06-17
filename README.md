# 🌳 Projeto de Árvore AVL — Análise e Projeto Orientado a Objetos I

Este projeto é a entrega do Trabalho Prático MA2 da disciplina APOOI (Análise e Projeto Orientado a Objetos I), no curso de Engenharia da Computação no campus da Fundação Hermínio Ometto, Araras, SP. 
O objetivo é implementar uma árvore AVL em C# com operações básicas como inserção, remoção, busca e balanceamento automático.

 📚 Funcionalidades implementadas

  - Inserção com Balanceamento Automático
A inserção de novos elementos é realizada de forma dinâmica, respeitando as propriedades da árvore AVL. Sempre que um novo nó é inserido, a árvore verifica e corrige eventuais desequilíbrios através de rotações simples ou duplas, garantindo uma estrutura de altura logarítmica.

  - Remoção com Rebalanceamento Inteligente
A exclusão de elementos da árvore é feita de forma segura, mantendo o balanceamento da estrutura. Após a remoção, a árvore aplica algoritmos de rebalanceamento para preservar sua eficiência em operações subsequentes.

  - Busca Otimizada de Elementos
Permite localizar rapidamente qualquer valor presente na árvore, explorando a propriedade de ordenação binária. A busca percorre a árvore de forma eficiente, retornando o nó correspondente ou indicando sua ausência.

  - Impressão da Estrutura em Pré-Ordem
Exibe a árvore a partir de um percurso em pré-ordem (raiz → esquerda → direita), permitindo visualizar claramente a estrutura hierárquica e o conteúdo da árvore de forma sequencial.

  - Visualização dos Fatores de Balanceamento
Para cada nó da árvore, é possível visualizar seu fator de balanceamento (diferença entre alturas das subárvores esquerda e direita), um recurso essencial para análise de desempenho e validação do algoritmo AVL.

  -  Cálculo da Altura Total da Árvore
Exibe a altura atual da árvore AVL, um indicador direto de sua eficiência estrutural. Esse dado é fundamental para avaliar a eficácia do balanceamento automático ao longo das operações.

📂 Estrutura do projeto

- No.cs — Define o nó da árvore AVL.
- ArvoreAVL.cs — Contém a lógica da árvore AVL (inserção, remoção, balanceamento, etc).
- Program.cs — Interface de execução, que lê um arquivo de comandos e executa as operações na árvore.
- Entrada.txt — Arquivo de entrada com comandos de teste.


RA's:

Henrique Akio Kuroda, RA 112886
Thiago da Silva, RA 113483
Rafael de Camargo, RA 114119
