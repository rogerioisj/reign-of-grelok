using System;

namespace Reign_of_Grelok.state
{
    delegate void CallbackStageMenu();

    class Inventory
    {
        private bool rustSword;
        private bool drinkingFlask;
        private bool zombieHead;
        private bool refinedGemStone;
        private bool magicalShard;
        private bool magicSword;
        private bool brassKey;
        private bool rawGemStone;

        public Inventory()
        {
            rustSword = true;
            drinkingFlask = true;
            zombieHead = false;
            refinedGemStone = false;
            magicalShard = false;
            magicSword = false;
            brassKey = false;
            rawGemStone = false;
        }

        public void Load(CallbackStageMenu callback)
        {
            Console.WriteLine("REINO DE GRELOK (beta v.632)");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Pressione de acordo com o destino:");
            Console.WriteLine("1 - (Planícies) Olhar ao redor");
            Console.WriteLine("2 - Ir para Norte");
            Console.WriteLine("3 - Ir para Sul");
            Console.WriteLine("4 - Ir para Leste");
            Console.WriteLine("5 - Ir para Oeste");
            Console.WriteLine("B - Voltar");
            var keyInfo = Console.ReadKey();
            var key = keyInfo.KeyChar;

            this.LoadOptions(key, callback);
        }

        public void LoadOptions(char key, CallbackStageMenu callback)
        {
            switch (key)
            {
                case 'b':
                    callback();
                    break;
                case 'q':
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida!\n\n\n");
                    this.Load(callback);
                    break;
            }
        }
    }
}
