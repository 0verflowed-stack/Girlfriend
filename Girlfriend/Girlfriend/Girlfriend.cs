using System;

namespace Girlfriend {
    public enum HoldHand {
        Waffles,
        Pancakes
    }
    enum Status {
        Girlfriend,
        Wife
    }
    public class Girlfriend {
        public string Name { get; set; }
        public string CurrentStatus { get; set; } = Status.Girlfriend.ToString();
        public Girlfriend(string name = "Iryna") {
            Name = name;
        }

        public void KissMe() {
            Console.WriteLine($"{Name} is kissing you passionately!");
        }
	    public void Love() {
            Console.WriteLine($"{Name} is loving you!");
        }
        public void Hug()  {
            Console.WriteLine($"{Name} is hugging you and doesn't want to release you!)");
        }
        public void HandHold(HoldHand way = HoldHand.Waffles) {
            Console.WriteLine($"{Name} is holding your hand in {way.ToString().ToLower()} way)");
        }
        public void CheatOn() {
            Console.WriteLine($"You're bastard! You've got some nerve cheating on your {CurrentStatus.ToLower()} {Name}!!!");
        }
        public void GetMarried() {
            CurrentStatus = Status.Wife.ToString();
            Console.WriteLine($"You and {Name} get married, now she's your wife. You can kiss each other!");
        }
        public void GetDivorce() {
            CurrentStatus = Status.Girlfriend.ToString();
            Console.WriteLine($"You and {Name} get divorced, now she's not your wife.");
        }
        public void HaveSex() {
            Console.WriteLine("Ohh Yeees!");
        }
        public void Impregnate() {
            Console.WriteLine($"You successfully impregnated {Name}. Wait about 9 to 10 months to get your child.");
        }
    }
}
