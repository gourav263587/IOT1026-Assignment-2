using System;

namespace Assignment
{
    public class TreasureChest
    {
        private State _state = State.Locked;
        private readonly Material _material;
        private readonly LockType _lockType;
        private readonly LootQuality _lootQuality;

        public TreasureChest()
        {
            _material = Material.Iron;
            _lockType = LockType.Expert;
            _lootQuality = LootQuality.Green;
        }

        public TreasureChest(State state) : this()
        {
            _state = state;
        }

        public TreasureChest(Material material, LockType lockType, LootQuality lootQuality)
        {
            _material = material;
            _lockType = lockType;
            _lootQuality = lootQuality;
        }

        public State GetState()
        {
            return _state;
        }

        public void Manipulate(Action action)
        {
            switch (action)
            {
                case Action.Open:
                    Open();
                    break;
                case Action.Close:
                    Close();
                    break;
                case Action.Lock:
                    Lock();
                    break;
                case Action.Unlock:
                    Unlock();
                    break;
                default:
                    Console.WriteLine("Invalid action.");
                    break;
            }
        }

        private void Unlock()
        {
            switch (_state)
            {
                case State.Locked:
                    _state = State.Closed;
                    break;
                case State.Closed:
                    Console.WriteLine("The chest is already unlocked.");
                    break;
                case State.Open:
                    Console.WriteLine("The chest cannot be unlocked because it is already open.");
                    break;
                default:
                    Console.WriteLine("Invalid state.");
                    break;
            }
        }

        private void Lock()
        {
            switch (_state)
            {
                case State.Closed:
                    _state = State.Locked;
                    break;
                case State.Locked:
                    Console.WriteLine("The chest is already locked.");
                    break;
                case State.Open:
                    Console.WriteLine("The chest cannot be locked because it is already open.");
                    break;
                default:
                    Console.WriteLine("Invalid state.");
                    break;
            }
        }

        private void Open()
        {
            switch (_state)
            {
                case State.Closed:
                    _state = State.Open;
                    break;
                case State.Open:
                    Console.WriteLine("The chest is already open.");
                    break;
                case State.Locked:
                    Console.WriteLine("The chest cannot be opened because it is locked.");
                    break;
                default:
                    Console.WriteLine("Invalid state.");
                    break;
            }
        }

        private void Close()
        {
            switch (_state)
            {
                case State.Open:
                    _state = State.Closed;
                    break;
                case State.Closed:
                    Console.WriteLine("The chest is already closed.");
                    break;
                case State.Locked:
                    Console.WriteLine("The chest cannot be closed because it is locked.");
                    break;
                default:
                    Console.WriteLine("Invalid state.");
                    break;
            }
        }

        public override string ToString()
        {
            return $"A {_state} chest with the following properties:\nMaterial: {_material}\nLock Type: {_lockType}\nLoot Quality: {_lootQuality}";
        }

        public enum State { Open, Closed, Locked };
        public enum Action { Open, Close, Lock, Unlock };
        public enum Material { Oak, RichMahogany, Iron };
        public enum LockType { Novice, Intermediate, Expert };
        public enum LootQuality { Grey, Green, Purple };
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            TreasureChest chest = new TreasureChest();

            Console.WriteLine(chest); // Output: A Locked chest with the following properties: Material: Iron, Lock Type: Expert, Loot Quality: Green

            chest.Manipulate(TreasureChest.Action.Open);
            Console.WriteLine("Chest state after opening: " + chest.GetState());

            chest.Manipulate(TreasureChest.Action.Close);
            Console.WriteLine("Chest state after closing: " + chest.GetState());

            chest.Manipulate(TreasureChest.Action.Lock);
            Console.WriteLine("Chest state after locking: " + chest.GetState());

            chest.Manipulate(TreasureChest.Action.Unlock);
            Console.WriteLine("Chest state after unlocking: " + chest.GetState());

            chest.Manipulate(TreasureChest.Action.Open);
            Console.WriteLine("Chest state after opening again: " + chest.GetState());

            chest.Manipulate(TreasureChest.Action.Lock);
            Console.WriteLine("Chest state after attempting to lock while open: " + chest.GetState());

            chest.Manipulate(TreasureChest.Action.Close);
            Console.WriteLine("Chest state after closing again: " + chest.GetState());

            chest.Manipulate(TreasureChest.Action.Unlock);
            Console.WriteLine("Chest state after attempting to unlock while closed: " + chest.GetState());

            chest.Manipulate(TreasureChest.Action.Open);
            Console.WriteLine("Chest state after opening again: " + chest.GetState());

            chest.Manipulate(TreasureChest.Action.Lock);
            Console.WriteLine("Chest state after locking again: " + chest.GetState());

            Console.WriteLine(chest); // Output: A Locked chest with the following properties: Material: Iron, Lock Type: Expert, Loot Quality: Green
        }
    }
}
