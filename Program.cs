using System;

namespace AtributosEMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagems personagem1 = new Personagems();
            personagem1.nome = "Galo de Rinha Ciborg do SENAI";
            personagem1.pontoVida = 100;

            Personagems personagem2 = new Personagems();
            personagem2.nome = "Cavalo Tunado da ETEC";
            personagem2.pontoVida = 55;

            bool sairDoLaco = true;

            do
            {



                Console.WriteLine(@"
                                                                  
                 Selecione a ação que o personagem 1 irá executar     
                                                                     
                                    1-Atacar                          
                                    2-Defender                        
            ");

                int opcao1 = int.Parse(Console.ReadLine());

                Console.WriteLine(@"

                Selecione a ação que o personagem 2 irá executar     
                                                                     
                                   1-Atacar                          
                                   2-Defender                        

            ");

                int opcao2 = int.Parse(Console.ReadLine());

                if (opcao1 == 1 && opcao2 == 1)
                {
                    Console.WriteLine($"{personagem1.nome} escolheu atacar!");
                    Console.WriteLine($"{personagem2.nome} escolheu atacar!");

                    personagem1.pontoVida = personagem1.pontoVida - personagem2.Atacar();
                    personagem2.pontoVida = personagem2.pontoVida - personagem1.Atacar();

                }
                else if (opcao1 == 1 && opcao2 == 2)
                {
                    Console.WriteLine($"{personagem1.nome} escolheu atacar!");
                    Console.WriteLine($"{personagem2.nome} escolheu defender!");

                    personagem2.pontoVida = personagem2.pontoVida - (personagem1.Atacar() - personagem2.Defender());

                }
                else if (opcao1 == 2 && opcao2 == 1)
                {
                    Console.WriteLine($"{personagem1.nome} escolheu defender!");
                    Console.WriteLine($"{personagem2.nome} escolheu atacar!");

                    personagem1.pontoVida = personagem1.pontoVida - (personagem2.Atacar() - personagem1.Defender());

                }
                else if (opcao1 == 2 && opcao2 == 2)
                {
                    Console.WriteLine($"{personagem1.nome} escolheu defender!");
                    Console.WriteLine($"{personagem2.nome} escolheu defender!");

                }

                Console.WriteLine($"{personagem1.nome} está com {personagem1.pontoVida} pontos de vida!");
                Console.WriteLine($"{personagem2.nome} está com {personagem2.pontoVida} pontos de vida!");

                if (personagem1.pontoVida <= 0)
                {
                    Console.WriteLine($"Você batalhou com honra {personagem1.nome}, mas o oponente era forte demais, teremos nossa vingança!");
                    sairDoLaco = false;
                }else if (personagem2.pontoVida <= 0)
                {
                    Console.WriteLine($"Morra {personagem1.nome}, queime no fogo do inferno!");
                    sairDoLaco = false;
                }


            } while (sairDoLaco);
        }
    }
}
