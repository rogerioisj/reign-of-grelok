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
        private List<string> itemDescriptions;

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
            itemDescriptions = new List<string>();
            itemDescriptions.Add("Sua arma. Enferrujada, mas confiável.");
        }

        public void Load(CallbackStageMenu callback)
        {
            Console.WriteLine("REINO DE GRELOK (beta v.632)");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("\nInventário");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Pressione de acordo com o item:");
            if (rustSword) Console.WriteLine("1 - Espada enferrujada");
            if (drinkingFlask) Console.WriteLine("2 - Frasco de bebida");
            if (zombieHead) Console.WriteLine("3 - Cabeça de zumbi");
            if (refinedGemStone) Console.WriteLine("4 - Pedra preciosa refinada");
            if (magicalShard) Console.WriteLine("5 - Fragmento mágico");
            if (magicSword) Console.WriteLine("6 - Espada mágica");
            if (brassKey) Console.WriteLine("7 - Chave de bronze");
            if (rawGemStone) Console.WriteLine("8 - Pedra preciosa bruta");
            Console.WriteLine("B - Voltar");
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
                    this.checkIfItemISAvailable(rustSword, callback);
                    this.showItemDescription(0);
                    this.Load(callback);
                    break;
                case 'b':
                case 'B':
                    Console.Clear();
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

        private void checkIfItemISAvailable(bool item, CallbackStageMenu callback)
        {
            if (!item)
            {
                Console.Clear();
                Console.WriteLine("Opção inválida!\n\n\n");
                this.Load(callback);
            }
        }

        private void showItemDescription(int index)
        {
            Console.Clear();
            Console.WriteLine(this.itemDescriptions[0]);
            Console.WriteLine();
            Console.WriteLine("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
