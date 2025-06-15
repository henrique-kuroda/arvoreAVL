using System;
using System.IO;

namespace arvoreAVL
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvoreAVL arvore = new ArvoreAVL();

            Console.Write("Informe o caminho do arquivo .txt com os comandos: ");
            string caminho = Console.ReadLine();

            if (string.IsNullOrEmpty(caminho))
            {
                Console.WriteLine("Nenhum caminho foi informado.");
                return;
            }

            if (!File.Exists(caminho))
            {
                Console.WriteLine("Arquivo não encontrado.");
                return;
            }

            try
            {
                string[] linhas = File.ReadAllLines(caminho);

                foreach (string linha in linhas)
                {
                    if (string.IsNullOrWhiteSpace(linha)) continue;

                    string[] partes = linha.Trim().Split(' ');
                    string comando = partes[0].ToUpper();

                    switch (comando)
                    {
                        case "I":
                            if (partes.Length > 1 && int.TryParse(partes[1], out int valorInserir))
                            {
                                arvore.Inserir(valorInserir);
                            }
                            else
                            {
                                Console.WriteLine($"Comando '{comando}' malformado ou com valor inválido: {linha}");
                            }
                            break;
                        case "R":

                            if (partes.Length > 1 && int.TryParse(partes[1], out int valorRemover))
                            {
                                
                                arvore.Remover(valorRemover);
                            }
                            else
                            {
                                Console.WriteLine($"Comando '{comando}' malformado ou com valor inválido: {linha}");
                            }
                            break;

                        case "B":
                            if (partes.Length > 1 && int.TryParse(partes[1], out int valorBuscar))
                            {
                                arvore.Buscar(valorBuscar);
                            }
                            else
                            {
                                Console.WriteLine($"Comando '{comando}' malformado ou com valor inválido: {linha}");
                            }
                            break;

                        case "P":
                            Console.Write("Árvore em pré-ordem: ");
                            arvore.ImprimirPreOrdem();
                            Console.WriteLine();
                            break;

                        case "F":
                            arvore.ImprimirFatoresBalanceamento();
                            break;

                        case "H":
                            int altura = arvore.ImprimirAltura();
                            Console.WriteLine($"Altura da árvore: {altura}");
                            break;

                        default:
                            Console.WriteLine($"Comando inválido ou não implementado: {linha}");
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro inesperado ao processar o arquivo: {ex.Message}");
            }
        }
    }
}
