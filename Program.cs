class Program
{
    static void Main()
    {
        Estacionamento estacionamento = new Estacionamento();
        Menu menu = new Menu(estacionamento);

        menu.ExibirMenu();
    }
}
