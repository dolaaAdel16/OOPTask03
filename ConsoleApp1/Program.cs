namespace ConsoleApp1
{
    internal class Program
    {
        static void Main()
        {
            ICartoonCharacter tom = new Tom();
            ICartoonCharacter jerry = new Jerry();
            ICartoonCharacter spike = new Spike();

            tom.ShowTalent();
            jerry.ShowTalent();
            spike.ShowTalent();


        }
    }
}
