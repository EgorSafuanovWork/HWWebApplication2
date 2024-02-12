using HWWebApplication2.Services.Interfaces;

namespace HWWebApplication2.Services
{
    public class ConsoleDisplay : IAnimalNameDisplay, IAnimalSoundDisplay
    {
        public void DisplayAnimalName(string name)
        {
            Console.WriteLine($"Назва: {name}");
        }

        public void DisplayAnimalSound(string sound)
        {
            Console.WriteLine($"Звук: {sound}");
        }
    }
}
