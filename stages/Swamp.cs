using Reign_of_Grelok.state;

namespace Reign_of_Grelok.stages
{
    class Swamp
    {
        private Inventory inventoryInstance;
        private Management stateManagementInstance;

        public Swamp(Inventory inventory, Management management)
        {
            this.inventoryInstance = inventory;
            this.stateManagementInstance = management;
        }

        public void Load(CallbackStageMenu callback)
        {
            Console.WriteLine("REINO DE GRELOK (beta v.632)");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\nPantano");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Pressione de acordo com o destino:");
            Console.WriteLine("1 - Olhar ao redor");
            if (stateManagementInstance.AlreadyCheckTown())
            {
                Console.WriteLine("2 - Falar com ferreiro");
                Console.WriteLine("3 - Falar com padre");
            }
            Console.WriteLine("4 - Ir para Norte");
            Console.WriteLine("I - Iventário");
            Console.WriteLine("Q - Sair");
            var keyInfo = Console.ReadKey();
            var key = keyInfo.KeyChar;

            this.LoadOptions(key, callback);
        }

        private void LoadOptions(char key, CallbackStageMenu callback)
        {
            switch (key)
            {
                case '1':
                    this.ShowStageMessage();
                    this.Load(callback);
                    break;
                case '4':
                    Console.Clear();
                    callback();
                    break;
                case 'q':
                case 'Q':
                    Environment.Exit(0);
                    break;
                case 'i':
                case 'I':
                    Console.Clear();
                    this.inventoryInstance.Load(_ => this.Load(callback));
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida!\n\n\n");
                    this.Load(callback);
                    break;
            }
        }

        private void ShowStageMessage()
        {
            this.ShowStandardStageMessage();
        }

        private void ShowStandardStageMessage()
        {
            Console.Clear();
            Console.WriteLine("Você olha ao seu redor...\n\n");
            Console.WriteLine(
                "Você está no final de um caminho de terra, de frente para uma pequena capela. " +
                "As paredes de estuque estão desbotadas, faltam muitas telhas. " +
                "As grandes portas de carvalho estão trancadas. " +
                "A congregação não está em lugar nenhum. " +
                "Um pequeno cemitério de lápides tortas fica à sombra do campanário rachado. " +
                "O caminho de terra serpenteia para oeste através de uma planície grande e indefinida.\r\n\r\n" +
                "Um zumbi cambaleia sem rumo por perto.\r\n\r\n" +
                "Há uma cova aberta nas proximidades."
            );
            Console.WriteLine();
            Console.WriteLine("\n\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            this.stateManagementInstance.SeeChapel();
        }
    }
}
