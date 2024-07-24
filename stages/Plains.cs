using System;
using Reign_of_Grelok.state;

namespace Reign_of_Grelok.stages
{
    class Plains : IStage
    {
        private Inventory inventoryInstance;

        public Plains(Inventory inventoryInstance)
        {
            this.inventoryInstance = inventoryInstance;
        }

        public void Load()
        {
            Console.WriteLine("REINO DE GRELOK (beta v.632)");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\nPlanícies");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Pressione de acordo com o destino:");
            Console.WriteLine("1 - Olhar ao redor");
            Console.WriteLine("2 - Ir para Norte");
            Console.WriteLine("3 - Ir para Sul");
            Console.WriteLine("4 - Ir para Leste");
            Console.WriteLine("5 - Ir para Oeste");
            Console.WriteLine("I - Iventário");
            Console.WriteLine("Q - Sair");
            var keyInfo = Console.ReadKey();
            var key = keyInfo.KeyChar;

            this.LoadOptions(key);
        }

        public void LoadOptions(char key)
        {
            switch (key)
            {
                case '1':
                    this.ShowStageMessage();
                    break;
                case 'q':
                case 'Q':
                    Environment.Exit(0);
                    break;
                case 'i':
                case 'I':
                    Console.Clear();
                    this.inventoryInstance.Load(this.Load);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida!\n\n\n");
                    this.Load();
                    break;
            }
        }

        private void ShowStageMessage()
        {
            Console.Clear();
            Console.WriteLine("" +
                "Você está em uma ampla planície. " +
                "Os contrafortes se estendem ao norte, onde as nuvens se reúnem em torno de um pico sinistro. " +
                "Um caminho de terra serpenteia de uma capela solitária para o leste, " +
                "através das planícies onde você está, e para o sul até uma cidade movimentada. " +
                "Névoas finas se acumulam sobre os pântanos no oeste, " +
                "onde uma torre fina fica sozinha no pântano."
             );
            Console.WriteLine("\n\n\nVocê observa a sua volta...");
            Console.WriteLine("\n\n\nPressione qualquer tecla para continuar!");
            Console.ReadKey();
            Console.Clear();
            this.Load();
        }
    }
}
