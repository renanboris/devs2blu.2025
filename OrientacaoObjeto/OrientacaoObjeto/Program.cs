// See https://aka.ms/new-console-template for more information
using OrientacaoObjeto.Classes;
using OrientacaoObjeto.MaoNaMassa;
using System.Diagnostics;
using System.Linq.Expressions;
using OrientacaoObjeto.MaoNaMassa;

Console.WriteLine("Hello, World!");

//var hb20 = new Carro();

//hb20.Marca = "Hyundai";
//hb20.Modelo = "HB20";
//hb20.Ano = 2012;

//var corsa = new Carro();
//corsa.Marca = "Chevrolet";
//corsa.Modelo = "Corsa";
//corsa.Ano = 1998;

//hb20.Acelerar(50); //Saída: "O Carro está acelerando!"
//corsa.Acelerar(150);

//Console.WriteLine("");
////Exercícios
////Classe Animal

//var meuAnimal = new Animal();

//Console.WriteLine("*** Classe Animal ***");
//meuAnimal.Nome = "Cachorro";
//meuAnimal.NomeCientifico = "Canis familiaris";
//meuAnimal.Idade = 15;

//for (int i = 0; i < 10; i++)
//{
//    meuAnimal.Comer();
//    Thread.Sleep(500);
//}

////meuAnimal.Andar();

//Console.WriteLine("");

//Classe Livro

//var meuLivro = new Livro("Crepusculo", "Estefani",384);

//var livro2 = new Livro("Baita Livro", "Baita Autor", 8);
//Livro livro2 = new Livro()
//{
//    Titulo = "Baita Livro",
//    Autor = "Baita Autor",
//    QtdPaginas = 8,
//};

//Objeto Anonimo
//var livro3 = new { Autor = "Fulano" };

//Console.WriteLine("*** Classe Livro ***");

//livro2.Identificar();

//var paginaAtual = 0;

//while (paginaAtual != meuLivro.QtdPaginas)
//{
//    paginaAtual = meuLivro.Ler();
//    Thread.Sleep(100);
//}

//while (paginaAtual != livro2.QtdPaginas)
//{
//    paginaAtual = livro2.Ler();
//    Thread.Sleep(100);
//}

//Console.WriteLine($"Vc acabou de ler o {livro2.Titulo}");

//Console.WriteLine("");

////Classe Calculadora

//var calcular = new Calculadora();

////calcular.Numero1 = 0;
////calcular.Numero2 = 0;


//decimal retorno = 0;
//bool operadorCorreto;

//Console.WriteLine("*** Calculadora ***");
//Console.WriteLine("Digite um número:");
//var num1 = decimal.Parse(Console.ReadLine());

//Console.WriteLine("Digite a operação: + - / *");
//string operacao = Console.ReadLine();

//Console.WriteLine("Digite outro número:");
//var num2 = decimal.Parse(Console.ReadLine());

//switch (operacao)
//{
//    case "+":
//        retorno = calcular.Somar(num1, num2);
//        break;
//    case "-":
//        retorno = calcular.Subtrair(num1, num2);
//        break;
//    case "/":
//        retorno = calcular.Dividir(num1, num2);
//        break;
//    case "*":
//        retorno = calcular.Multiplicar(num1, num2);
//        break;
//    default:
//        Console.WriteLine("Vc digitou um operador incorreto!");
//        operadorCorreto = false;
//        break;
//}

//if (operadorCorreto)
//{
//    Console.WriteLine($"O resultado é {retorno}");
//}


//Classe Aluno
// var novoAluno = new Aluno("Boris", 34, "C#");

// novoAluno.ExibirInfo();

// novoAluno.CalcularIdadeEmMeses();

// Console.WriteLine();

//Classe ContaBancaria

// List<ContaBancaria> contas = new List<ContaBancaria>();

// //var novaConta = new ContaBancaria("Boris", 1000);
// bool continuar = true;


// //Tela 1 - Menu Inicial
// do
// {
//     Console.Clear();
//     Console.WriteLine("*** Bem-vindo ao Banco +Devs2Blu ***");
//     Console.WriteLine($"Patrimônio Líquido: {ContaBancaria.SaldoTotal:C}");
//     Console.WriteLine($"Contas Cadastradas: {ContaBancaria.QtdContasCadastradas}\n");
//     Console.WriteLine("1 - Criar nova conta");
//     Console.WriteLine("2 - Listar contas");
//     Console.WriteLine("9 - Sair");
//     Console.Write("\nEscolha uma opção: ");
//     var opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.Write("Digite o nome do titular: ");
//             string nome = Console.ReadLine();
//             Console.Write("Digite o saldo inicial: R$");
//             if (decimal.TryParse(Console.ReadLine(), out decimal saldoInicial))
//             {
//                 contas.Add(new ContaBancaria(nome, saldoInicial));
//                 Console.WriteLine("Conta criada com sucesso!");
//             }
//             else
//             {
//                 Console.WriteLine("Saldo inválido.");
//             }
//             Thread.Sleep(2000);
//             break;
//         case "2":
//             if (contas.Count == 0)
//             {
//                 Console.WriteLine("Nenhuma conta cadastrada.");
//                 Thread.Sleep(2000);
//                 break;
//             }
//             Console.WriteLine("\n--- Contas cadastradas ---");
//             for (int i = 0; i < contas.Count; i++)
//             {
//                 Console.WriteLine($"{i + 1} - {contas[i].Titular} (Saldo: R${contas[i].Saldo:F2})");
//             }

//             Console.Write("\nAcessar uma conta? (S/N): ");
//             string resposta = Console.ReadLine().ToUpper();

//             if (resposta == "S")
//             {
//                 Console.Write("Digite o número da conta que deseja acessar: ");
//                 if (int.TryParse(Console.ReadLine(), out int indiceConta) &&
//                     indiceConta > 0 && indiceConta <= contas.Count)
//                 {
//                     AcessarConta(contas[indiceConta - 1]);
//                 }
//                 else
//                 {
//                     Console.Write("Conta Inexistente.");
//                     Thread.Sleep(2000);
//                 }
//             }
//             break;
//         case "9":
//             continuar = false;
//             Console.Write("LOGOFF");
//             Thread.Sleep(700);
//             Console.Write(".");
//             Thread.Sleep(500);
//             Console.Write(".");
//             Thread.Sleep(500);
//             Console.Write(".");
//             Thread.Sleep(500);
//             break;
//     }
// } while (continuar);


//     //Tela 2 - Acesso a Conta Específica
// static void AcessarConta(ContaBancaria conta)
// {
//     bool continuar = false;

//     do
//     {
//         Console.Clear();
//         Console.WriteLine("*** Bem vindo ao Banco +Devs2Blu ***");
//         Console.WriteLine($"Olá, {conta.Titular}\n");
//         Console.WriteLine("1 - Saldo");
//         Console.WriteLine("2 - Deposito");
//         Console.WriteLine("3 - Saque");
//         Console.WriteLine("4 - Empréstimo");
//         Console.WriteLine("9 - Voltar");
//         var opcao2 = Console.ReadLine();

//         switch (opcao2)
//         {
//             case "1":
//                 conta.ExibirSaldo();
//                 continuar = true;
//                 Thread.Sleep(3000);
//                 break;
//             case "2":
//                 Console.Write("Digite o valor para Deposito: R$");
//                 decimal valorDeposito = decimal.Parse(Console.ReadLine());
//                 conta.Depositar(valorDeposito);
//                 Console.WriteLine($"{conta.Titular}, seu saldo atual é de R${conta.Saldo}");
//                 Thread.Sleep(3000);
//                 continuar = true;
//                 break;
//             case "3":
//                 Console.Write("Digite o valor para Saque: R$");
//                 decimal valorSaque = decimal.Parse(Console.ReadLine());
//                 conta.Sacar(valorSaque);
//                 Console.WriteLine($"{conta.Titular}, seu saldo atual é de R${conta.Saldo}");
//                 Thread.Sleep(3000);
//                 continuar = true;
//                 break;
//             case "4":
//                 if (conta.EmprestimosAtivos)
//                 {
//                     Console.WriteLine("Vc já possui empréstimos ativos.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Digite o valor para Empréstimo: R$");
//                     decimal valorEmprestimo = decimal.Parse(Console.ReadLine());
//                     Console.WriteLine("Quantidade de parcelas?");
//                     int qtdParcelas = int.Parse(Console.ReadLine());
//                     Console.WriteLine("informe sua renda: R$");
//                     decimal renda = decimal.Parse(Console.ReadLine());
//                     conta.Emprestimo(valorEmprestimo, renda, qtdParcelas);
//                 }
//                 Thread.Sleep(3000);
//                 continuar = true;
//                 break;
//             case "9":
//                 Console.Clear();
//                 Console.WriteLine("*** LOGOFF ***");
//                 continuar = false;
//                 break;
//             default:
//                 Console.WriteLine("Opção Inválida");
//                 break;
//         }
//     } while (continuar);
// }

//Produto

//var cestaCompras = new List<Produto>()
//{
//    new Produto("Camisa Azul", 10, 30, 1),
//    new Produto("Camisa Marrom", 5, 30, 1),
//    new Produto("Camisa Branca", 15, 30, 2),
//    new Produto("Camisa Social", 25, 30, 1),
//};


//var minhasCompras = Produto.Comprar(cestaCompras, 30, out double troco);

////minhaCompra.ExibirInfo();
//Console.WriteLine($"Pegue {troco.ToString("C2")} de volta");
//Console.ReadLine();

//bool continuar = true;

//List<Produto> produtos = new List<Produto>();

//do
//{
//    Console.Clear();
//    Console.WriteLine("*** Produtos ***\n");
//    Console.WriteLine("1 - Cadastro de Produtos");
//    Console.WriteLine("2 - Lista de Produtos");
//    Console.WriteLine("X - Sair");
//    var opcao = Console.ReadLine();

//    switch (opcao)
//    {
//        case "1":
//            CadastraProdutos(produtos);
//            break;
//        case "2":
//            if (produtos.Count == 0)
//            {
//                Console.WriteLine("Nenhum produto cadastrado.");
//                Thread.Sleep(2000);
//                break;
//            }
//            ListaProdutos(produtos);
//            break;
//        case "X":
//            continuar = false;
//            Console.Write("Saindo");
//            Thread.Sleep(700);
//            Console.Write(".");
//            Thread.Sleep(500);
//            Console.Write(".");
//            Thread.Sleep(500);
//            Console.Write(".");
//            Thread.Sleep(500);
//            break;
//        default:
//            Console.WriteLine("Opção Incorreta");
//            break;
//    }
//} while (continuar);

//static void CadastraProdutos(List<Produto> produtos)
//{
//    bool addProduto = true;

//    while (addProduto)
//    {
//        Console.WriteLine("Digite o nome do novo Produto:");
//        string nomeProduto = Console.ReadLine();
//        Console.WriteLine("Moeda: 1 - Real | 2 - Dolar");
//        int moeda = int.Parse(Console.ReadLine());
//        Console.WriteLine("Digite o preço do novo Produto:");
//        //double precoProduto = double.Parse(Console.ReadLine());
//        double.TryParse(Console.ReadLine(), out double precoProduto);

//        if (precoProduto == 0)
//        {
//            Console.WriteLine("Valor incorreto.");
//            continue;
//        }
//        Console.WriteLine("Digite a quantidade em estoque do novo Produto:");

//        if (int.TryParse(Console.ReadLine(), out int qtdProduto))
//        {
//            produtos.Add(new Produto(nomeProduto, precoProduto, qtdProduto, moeda));
//            Console.WriteLine("Produto adicionado com sucesso!");
//        }
//        else
//        {
//            Console.WriteLine("Erro ao cadastrar Produto\n");
//        }

//        Console.WriteLine("Deseja cadastrar novo produto? (S)im ou (N)ao");
//        var resposta = Console.ReadLine().ToUpper();

//        if (resposta != "S")
//        {
//            addProduto = false;
//        }
//    }
//}

//static void ListaProdutos(List<Produto> produtos)
//{
//    Console.WriteLine("\n--- Lista de Produtos ---");
//    var i = 0;

//    foreach (var produto in produtos)
//    {
//        var preco = produto.Preco;
//        var moeda = produto.Moeda;
//        var precoFormatado = Produto.FormatarValor(preco, moeda);
//        Console.WriteLine($"{i + 1} - {produto.Nome}\tPreço: {precoFormatado:F2}\tQtd Estoque: {produto.QuantidadeEstoque}");
//        i++;
//    }

//    //for (int i = 0; i < produtos.Count; i++)
//    //{
//    //    var preco = produtos[i].Preco;
//    //    var moeda = produtos[i].Moeda;

//    //    var precoFormatado = Produto.FormatarValor(preco, moeda);
//    //    Console.WriteLine($"{i + 1} - {produtos[i].Nome}\tPreço: {precoFormatado:F2}\tQtd Estoque: {produtos[i].QuantidadeEstoque}");
//    //}

//    Console.Write("\nAtualizar Estoque-> (S/N): ");
//    string resposta = Console.ReadLine().ToUpper();

//    if (resposta == "S")
//    {
//        Console.Write("Digite o cód do Produto que deseja atualizar: ");
//        if (int.TryParse(Console.ReadLine(), out int indiceProduto) &&
//            indiceProduto > 0 && indiceProduto <= produtos.Count)
//        {

//            Console.WriteLine("Digite o estoque atualizado:");
//            if (int.TryParse(Console.ReadLine(), out int quantidadeAtual))
//            {
//                AuxiliarAtuProduto(produtos[indiceProduto - 1], quantidadeAtual);
//            }
//            else
//            {
//                Console.WriteLine("Valor incorreto!");
//            }
//        }
//        else
//        {
//            Console.Write("Produto Inexistente.");
//            Thread.Sleep(2000);
//        }
//    }
//}

//static void AuxiliarAtuProduto(Produto produtos, int quantidade)
//{
//    produtos.AtualizarEstoque(quantidade);
//    Console.WriteLine("Estoque atualizado com sucesso");
//    Thread.Sleep(2000);
//}
//Animal animalzinho = new Animal();
//Animal gatinho = new Gato();
//Animal doguinho = new Cachorro();

//animalzinho.EmitirSom();
//gatinho.EmitirSom();
//doguinho.EmitirSom();

//double n1 = 10;
//double n2 = 10;
//double n3 = 10;

//Console.WriteLine($"N1 = {n1}");
//Console.WriteLine($"N2 = {n2}");
//Console.WriteLine($"N3 = {n3}");

//AlterarValores(ref n1, ref n2, ref n3);

//Console.WriteLine($"N1 + 10 = {n1}");
//Console.WriteLine($"N2 / 3 = {n2}");
//Console.WriteLine($"N3 * 20 = {n3}");

//static void AlterarValores(ref double n1, ref double n2, ref double n3)
//{
//    n1 += 10;
//    n2 /= 3;
//    n3 *= 20;
//}

//List<Produto2> novoProduto = new List<Produto2>();

//var produto1 = new Produto2("Maça", 0);
//var produto2 = new Produto2("laranja", 0);
//var produto3 = new Produto2("Uva", 0);
//var produto4 = new Produto2("Pera", 0);


//OrientacaoObjeto.Classes.Produto2.ExibirDetalhes();


//var veiculo = new VeiculoTerrestre(TipoVelocidade.Km_h, 50, 4);

//veiculo.Mover();
//veiculo.Buzinar();

//Animal animal = new Animal();
//Animal gato = new Gato();
//Animal cao = new Cachorro();

//animal.EmitirSom();
//cao.EmitirSom();
//gato.EmitirSom();

//InstrumentoMusical[] instrumentos = new InstrumentoMusical[3];

//// Atribuição de valores
//instrumentos[0] = new Violao();
//instrumentos[1] = new Tambor();
//instrumentos[2] = new Piano();

//foreach (var item in instrumentos)
//{
//    item.Tocar();    
//} 

var novoUsuario = new UsuarioSistema("Boris", "boris@senac.br", "123abc");
UsuarioSistema.Cadastrar(novoUsuario);

Console.Clear();
Console.WriteLine("*** TELA DE LOGIN | BEM VINDO ***\n");
Console.WriteLine("1 - Já tenho Cadastro");
Console.WriteLine("2 - Novo Cadastro");
Console.Write("\nDigite a Opção: ");
string opcao = Console.ReadLine();


switch (opcao)
{
	case "1":
        Console.Clear();
        Console.WriteLine("*** TELA DE LOGIN | BEM VINDO ***\n");
        Console.Write("Digite seu usuário: ");
        var usuario = Console.ReadLine();
        Console.Write("Digite sua senha: ");
        var senha = Console.ReadLine();

        var usuarioLogado = UsuarioSistema.Autenticar(usuario, senha);

        if (usuarioLogado != null)
        {
            Console.Clear();
            Console.Write($"BEM VINDO {novoUsuario.Nome}!");
            Console.Write($"Usuário: {novoUsuario.Usuario} | LOGADO\n");

            Console.Write($"1 - Trocar Senha");            
            Console.Write($"\nDigite X para Deslogar");
            var entrada = Console.ReadLine();

            switch (entrada)
            {
                case "1":
                    Console.Clear();
                    break;
                case "X":
                    Console.Clear();
                    novoUsuario.Deslogar();
                    break;
                default:
                    break;
            }
        }
        break;
    case "2":
        //novoUsuario.Autenticar();
        break;
    case "3":
        //novoUsuario.Autenticar();
        break;
    default:
        Console.WriteLine("Opcao Inválida");
        break;
}

Console.ReadKey();


//Console.ReadLine();