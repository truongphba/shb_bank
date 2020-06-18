using shb_bank.Controller;
using shb_bank.View;

namespace shb_bank
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var generateMenu = new GenerateMenu();
            generateMenu.GetMenu();
        }
    }
}