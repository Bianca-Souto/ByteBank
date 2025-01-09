using bytebank.Modelos.Conta;
using C__Segundo_módulo.bytebank.Util;
namespace C__Segundo_módulo.bytebank.Atendimento;

internal class ByteBankAtendimento
{
    private List<ContaCorrente> _listaDeContas = new List<ContaCorrente>() {
        new ContaCorrente(95, "123456-X") {Saldo=100, Titular = new Cliente{Cpf = "111.000.000-00", Nome = "Clonilda"}},
        new ContaCorrente(95, "951258-X") {Saldo=200, Titular = new Cliente{Cpf = "111.222.000-00", Nome = "Derliditi"}},
        new ContaCorrente(94, "987321-W") {Saldo=60, Titular = new Cliente{Cpf = "111.000.333-00", Nome = "Trangério"}}
};

    #region Exemplos de Array

    public void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //TesteArray();
        //TesteArray2();
        //TestaArrayDeContasCorrentes();
        void TesteArray()
        {
            int[] idades = new int[7];
            idades[0] = 30;
            idades[1] = 20;
            idades[2] = 53;
            idades[3] = 27;

            Console.WriteLine($"Tamanho do Array {idades.Length}");

            int acumulador = 0;
            for (int i = 0; i < idades.Length; i++)
            {
                int idade = idades[i];
                Console.WriteLine($"Idades [{i}] = {idade}");
                acumulador += idade;
            }
            int media = acumulador / idades.Length;
            Console.WriteLine($"média de idades = {media}");
        }

        void TesteArray2()
        {
            string[] arraydePalavras = new string[6];
            for (int i = 0; i < arraydePalavras.Length; i++)
            {
                Console.Write($"Digite {i + 1} Palavra:");
                arraydePalavras[i] = Console.ReadLine();
            }
            Console.Write("Digite a palavra a ser encontrada: ");
            var busca = Console.ReadLine();
            foreach (string palavra in arraydePalavras)
            {
                if (palavra.Equals(busca))
                {
                    Console.WriteLine($"Palavra encontrada = {busca}");
                }
                else
                {
                    Console.WriteLine("Palavra não encontrada.");
                }
                break;
            }
        }

        Array amostra = Array.CreateInstance(typeof(double), 5);
        amostra.SetValue(5.9, 0);
        amostra.SetValue(2.6, 1);
        amostra.SetValue(10, 3);
        amostra.SetValue(1.7, 2);

        //TesteMediano(amostra);

        void TesteMediano(Array array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Array está nulo ou vazio");
            }

            double[] numerosOrdenados = (double[])array.Clone();
            Array.Sort(numerosOrdenados);

            int tamanho = numerosOrdenados.Length;
            int meio = tamanho / 2;
            double mediana = tamanho % 2 != 0 ? numerosOrdenados[meio] :
                                                    (numerosOrdenados[meio] + numerosOrdenados[meio - 1]) / 2;
            Console.WriteLine($"A mediana é: {mediana}");
        }
        void TesteMediano2(Array array)
        {
            int[] valores = { 10, 23, 67, 34 };
            for (int i = 0; i < 4 - 1; i++)
            {
                Console.WriteLine(valores[i]);
            }
        }

        void TestaArrayDeContasCorrentes()
        {
            ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
            listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
            listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
            listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));

            var contaDoAndre = new ContaCorrente(482, "1654872-E");
            listaDeContas.Adicionar(contaDoAndre);
            //listaDeContas.ExibeLista();
            //Console.WriteLine("---------------------------");
            //listaDeContas.Remover(contaDoAndre);
            //listaDeContas.ExibeLista();

            for (int i = 0; i < listaDeContas.Tamanho; i++)
            {
                ContaCorrente conta = listaDeContas[i];
                Console.WriteLine($"Indice [{i}] = {conta.Conta}/{conta.Numero_agencia}");
            }
        }
    }

    //Generica<int> teste1 = new Generica<int>();
    //teste1.MostrarMensagem(10);

    //Generica<string> teste2 = new Generica<string>();
    //teste2.MostrarMensagem("Uma mensagem aqui");

    //public class Generica<T>
    //{
    //    public void MostrarMensagem(T t)
    //    {
    //        Console.WriteLine($"Exibindo {t}");
    //    }
    //}
    #endregion

    #region ExemplosDeList
    //List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
    //{
    //    new ContaCorrente(874, "5679787-A"),
    //    new ContaCorrente(874, "4456668-B"),
    //    new ContaCorrente(874, "7781438-C")
    //};

    //List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
    //{
    //    new ContaCorrente(951, "5679787-E"),
    //    new ContaCorrente(321, "4456668-F"),
    //    new ContaCorrente(719, "7781438-G")
    //};

    //_listaDeContas2.AddRange(_listaDeContas3);
    //_listaDeContas2.Reverse();

    //for (int i = 0; i < _listaDeContas2.Count; i++)
    //{
    //    Console.WriteLine($"indice [{i}] = conta [{_listaDeContas2[i].Conta}]");
    //}

    //Console.WriteLine("\n\n");

    //var range = _listaDeContas3.GetRange(0, 1);
    //for (int i = 0; range.Count > 0; i++)
    //{
    //    Console.WriteLine($"Indice [{i}] = Conta [{range[i].Conta}]");
    //}
    //_listaDeContas3.Clear();
    //for (int i = 0; i < _listaDeContas3.Count; i++)
    //{
    //    Console.WriteLine($"Indice [{i}] = Conta [{range[i].Conta}]");
    //}
    #endregion

    public void AtendimentoAoCliente()
    {
        try
        {
            char opcao = '0';
            while (opcao != '6')
            {
                Console.Clear();

                Console.WriteLine("================");
                Console.WriteLine("MENU DE OPÇÕES");
                Console.WriteLine("================");
                Console.WriteLine("Digite 1 para Cadastrar Conta");
                Console.WriteLine("Digite 2 para Listar Contas");
                Console.WriteLine("Digite 3 para Remover Conta");
                Console.WriteLine("Digite 4 para Pesquisar Conta");
                Console.WriteLine("Digite qualquer tecla para Sair do Sistema");
                Console.WriteLine("\n\n");
                Console.Write("Digite a opção desejada: ");
                try
                {
                    opcao = Console.ReadLine()[0];
                }
                catch (Exception excecao)
                {
                    throw new ByteBankException(excecao.Message);
                }

                switch (opcao)
                {
                    case '1':
                        cadastrarConta();
                        break;
                    case '2':
                        listarContas();
                        break;
                    case '3':
                        removerConta();
                        break;
                    case '4':
                        pesquisarconta();
                        break;
                    default:
                        Console.WriteLine("Opção não implementada.");
                        break;
                }
            }

        }
        catch (ByteBankException excecao)
        {

            Console.WriteLine($"{excecao.Message}");
        }

    }
    void cadastrarConta()
    {
        Console.Clear();
        Console.WriteLine("=============================");
        Console.WriteLine("==    CADASTRO DE CONTA    ==");
        Console.WriteLine("=============================");
        Console.WriteLine("Informe os dados da conta:");
       

        Console.Write("\n - Número da agência: ");
        int numeroAgencia = int.Parse(Console.ReadLine());

        ContaCorrente conta = new ContaCorrente(numeroAgencia);
        Console.WriteLine($" - Número da conta [NOVA] : {conta.Conta}");

        Console.Write(" - Informe o saldo da conta: R$ ");
        conta.Saldo = double.Parse(Console.ReadLine());

        Console.Write(" - Informe o nome do Títular: ");
        conta.Titular.Nome = Console.ReadLine();

        Console.Write(" - Infome CPF so Títular: ");
        conta.Titular.Cpf = Console.ReadLine();

        Console.Write(" - Informe a Profissão do Títular: ");
        conta.Titular.Profissao = Console.ReadLine();

        _listaDeContas.Add(conta);
        Console.WriteLine("*** Sua conta foi criada com sucesso! ***");
        Console.ReadKey();
    }

    void listarContas()
    {
        Console.Clear();
        _listaDeContas.Sort();
        Console.WriteLine("================");
        Console.WriteLine("LISTA DE CONTAS");
        Console.WriteLine("================");
        Console.WriteLine("\n");
        if (_listaDeContas.Count <= 0)
        {
            Console.WriteLine("Não há contas cadastradas!!!");
            Console.ReadKey();
            return;
        }
        foreach (ContaCorrente item in _listaDeContas) //Para cada item ContaCorrente, vai percorrer e exibir as informações.
        {
            Console.WriteLine(item.ToString());
            Console.ReadKey();
        }
    }

    void removerConta()
    {
        Console.Clear();
        Console.WriteLine("================");
        Console.WriteLine("REMOVER CONTAS");
        Console.WriteLine("================");
        Console.WriteLine("\n");
        Console.WriteLine("Informe o número da Conta que deseja deletar:");
        string numeroConta = Console.ReadLine();
        ContaCorrente conta = null;
        foreach (var item in _listaDeContas)
        {
            if (item.Conta.Equals(numeroConta))
            {
                conta = item;
            }
        }
        if (conta != null)
        {
            _listaDeContas.Remove(conta);
            Console.WriteLine("\n\n---  Conta removida com sucesso!  ---\n\n");
        }
        else
        {
            Console.WriteLine("\n\n*** Conta para remoção não encontrada! ***\n\n");
        }
        Console.ReadKey();
    }

    void pesquisarconta()
    {
        Console.Clear();
        Console.WriteLine("================");
        Console.WriteLine("PESQUISAR CONTA");
        Console.WriteLine("================");
        Console.WriteLine("\n");
        Console.WriteLine("Pesquisar por [1] NUMERO DA CONTA ou [2] CPF DO TITULAR ou [3] NUMERO DA AGÊNCIA.");
        switch (int.Parse(Console.ReadLine()))
        {
            case 1:
                {
                    Console.WriteLine("\nInforme o número completo da conta:");
                    string _numeroConta = Console.ReadLine();
                    ContaCorrente consultaConta = ConsultarPorNumeroConta(_numeroConta);
                    Console.WriteLine("\n");
                    Console.WriteLine(consultaConta.ToString());
                    Console.ReadKey();
                    break;
                }
            case 2:
                {
                    Console.WriteLine("\nInforme o CPF completo do titular:");
                    string _cpf = Console.ReadLine();
                    ContaCorrente consultarCpf = ConsultarPorCPFTitular(_cpf);
                    Console.WriteLine("\n");
                    Console.WriteLine(consultarCpf.ToString());
                    Console.ReadKey();
                    break;
                }
            case 3:
                {
                    Console.WriteLine("\nInforme o N° completo da agência:");
                    var _numeroAgencia = int.Parse(Console.ReadLine());
                    var contasPorAgencia = (List<ContaCorrente>)ConsultarPorAgencia(_numeroAgencia);
                    Console.WriteLine("\n");
                    ExibirListaDeContas(contasPorAgencia);
                    Console.WriteLine("\n");
                    Console.ReadKey();
                    break;
                }

            default:
                Console.WriteLine("\n Opção Inválida!");
                break;
        }

        ContaCorrente ConsultarPorNumeroConta(string? numeroConta)
        {
            //ContaCorrente conta = null;
            //for (int i = 0; i < _listaDeContas.Count; i++)
            //{
            //   if (_listaDeContas[i].Conta.Equals(numeroConta))
            //   {
            //       conta = _listaDeContas[i];
            //   }
            //}
            //return conta;
            return _listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();

        }

        ContaCorrente ConsultarPorCPFTitular(string? cpf)
        {
            //ContaCorrente conta = null;
            //for (int i = 0; i < _listaDeContas.Count; i++)
            //{
            //   if (_listaDeContas[i].Titular.Cpf.Equals(cpf))
            //   {
            //       conta = _listaDeContas[i];
            //   }
            //}
            //return conta;
            return _listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();

        }

        object ConsultarPorAgencia(int numeroAgencia)
        {
            var consulta = (
                    from conta in _listaDeContas
                    where conta.Numero_agencia == numeroAgencia
                    select conta).ToList();

            return consulta;

        }

        void ExibirListaDeContas(List<ContaCorrente> contasPorAgencia)
        {
            if (contasPorAgencia == null)
            {
                Console.WriteLine("*** A consulta não retornou nenhum dado ***");
            }
            else
            {
                foreach (var item in contasPorAgencia)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
    }
}



