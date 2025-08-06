namespace TodoList
{
    class Todo
    {
        static void Main(string[] args)
        {
            string result = "";
            while (result != "0")
            {
                Console.WriteLine("Bem-vindo à sua lista de tarefas!");
                Console.WriteLine("1 - Adicionar tarefa");
                Console.WriteLine("2 - Listar tarefas");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Escolha uma opção: ");
                result = Console.ReadLine();

                if (result == "0")
                {
                    Console.WriteLine("Saindo do programa...");
                    return;
                }

                else if (result == "1")
                {
                    Console.WriteLine("Qual vai ser o nome da tarefa?");
                    string taskName = Console.ReadLine();
                    tasks.Add(taskName);
                    Console.WriteLine("Tarefa '" + taskName + "' adicionada com sucesso");
                }

                else if (result == "2")
                {
                    Console.WriteLine("Listando todas as tarefas...");
                    foreach (var task in tasks)
                    {
                        Console.WriteLine("- " + task);
                    }
                }

                else if (string.IsNullOrWhiteSpace(result))
                {
                    Console.WriteLine("Você não digitou nada, tente novamente.");
                }

                else
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                }

            }
        }

        static List<string> tasks = new List<string>
                {
                    // The tasks will be stored here.
                };
    }
}