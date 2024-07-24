using Reign_of_Grelok.state;

namespace Reign_of_Grelok.stages
{
    delegate void CallbackStageMenu();

    class Town
    {
        private Inventory inventoryInstance;
        private Management stateManagementInstance;

        public Town(Inventory inventory, Management management)
        {
            this.inventoryInstance = inventory;
            this.stateManagementInstance = management;
        }
        public void Load(CallbackStageMenu callback)
        {
            Console.WriteLine("REINO DE GRELOK (beta v.632)");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\nCidade");
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

        private void CheckIfOptionIsAvailable(bool option, CallbackStageMenu callback)
        {
            if (!option)
            {
                Console.Clear();
                Console.WriteLine("Opção inválida!\n\n\n");
                this.Load(callback);
            }
        }

        private void ShowStageMessage()
        {
            Console.WriteLine(
                "Você está na poeirenta praça do mercado de uma cidade tranquila. " +
                "Muitas das lojas e casas estão abandonadas, e os cidadãos que podem ser vistos falam em voz baixa, lançando olhares furtivos para o horizonte escuro no extremo norte. " +
                "O toque de uma bigorna quebra regularmente o silêncio, onde um ferreiro bigodudo se debruça sobre o seu trabalho numa tenda próxima.\r\n\r\n" +
                "O ferreiro está aqui, trabalhando.\r\n\r\n" +
                "Um padre está aqui, bebendo."
             );
            Console.Clear();
            this.stateManagementInstance.SeeTown();
        }

        private void ShowBlacksmithMessage()
        {
            this.ShowStandardBlacksmithMessage();
        }

        private void ShowStandardBlacksmithMessage()
        {
            Console.WriteLine(
                "Seus olhos lacrimejam por causa da fumaça e do calor bajulador dentro da tenda. " +
                "O homem enorme enxuga o suor da cabeça careca e levanta os olhos do trabalho.\r\n\r\n\"" +
                "Não falta trabalho a ser feito com Grelok assustando todo mundo. Deixe-me cumprir meus pedidos, estranho.\" " +
                "Com isso, o ferreiro dispensa você de sua tenda e molha uma lâmina quente em água, sibilando com vapor."
             );
        }

        private void ShowPriestMessage()
        {
            this.ShowStandardPriestMessage();
        }

        private void ShowStandardPriestMessage()
        {
            Console.WriteLine(
                "O padre percebe sua aproximação e levanta os olhos do seu gole.\r\n" +
                "“Grelok chegou e estamos abandonados!”, ele grita. " +
                "“Urp!”, ele continua.\r\n\r\n" +
                "Ao se recuperar do fedor do arroto sacerdotal, você é informado de que o padre fugiu de sua capela próxima. " +
                "Quando Grelok chegou à montanha, os mortos em seu cemitério começaram a se levantar e sua congregação se dispersou.\r\n\r\n" +
                "“Se você pudesse livrar o lugar dos zumbis”, ele lhe diz, “eu te darei a chave, e você pode ir ao boticário”"
             );
        }
    }
}
