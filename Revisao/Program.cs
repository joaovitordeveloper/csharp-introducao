namespace Revisao;
internal class Program
{
    private static void Main(string[] args)
    {
        Aluno[] alunos = new Aluno[5];
        var indiceAluno = 0;
        string opcaoUsuario = ObterOpecaoUsuario();

        while (opcaoUsuario.ToUpper() != "X")
        {

            switch (opcaoUsuario)
            {

                case "1":
                    //TODO: Inserir alunos.
                    Console.WriteLine("Informe o nome do aluno:");
                    Aluno aluno = new Aluno();
                    aluno.nome = Console.ReadLine();

                    Console.WriteLine("Informe a nota do aluno:");

                    if(decimal.TryParse(Console.ReadLine(), out decimal nota)){
                        aluno.nota = nota;
                    }else{
                        throw new ArgumentNullException("O valor da nota deve ser decimal");
                    }

                    alunos[indiceAluno] = aluno;
                    indiceAluno++;

                    break;

                case "2":
                    //TODO: Listar alunos.
                    foreach(var a in alunos){
                        if(!string.IsNullOrEmpty(a.nome)){
                            Console.WriteLine($"ALUNO: {a.nome} - NOTA: {a.nota}");
                        }
                    }
                    break;

                case "3":
                    //TODO: Calcular media geral
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            opcaoUsuario = ObterOpecaoUsuario();

        }
    }

    private static string ObterOpecaoUsuario()
    {
        Console.WriteLine();
        Console.WriteLine("Informe a opção desejada:");
        Console.WriteLine("1 - Inserir alunos");
        Console.WriteLine("2 - Listar alunos");
        Console.WriteLine("3 - Calcular media geral");
        Console.WriteLine("X - Sair");
        Console.WriteLine();

        string opcaoUsuario = Console.ReadLine();
        Console.WriteLine();
        return opcaoUsuario;
    }
}