//using system;
//using system.collections.generic;
//using system.linq;
//using system.text;
//using system.threading.tasks;

//namespace c__segundo_módulo;

//internal class listadenomes
//{

//    public bool verificanomes(list<string> nomesdosescolhidos, string escolhido)
//    {
//        return nomesdosescolhidos.contains(escolhido);
//    }
//    public void main()
//    {
//        list<string> nomesdosescolhidos = new list<string>()
//        {
//            "bruce wayne",
//            "carlos vilagran",
//            "richard grayson",
//            "bob kane",
//            "will farrel",
//           "lois lane",
//           "general welling",
//            "perla letícia",
//            "uxas",
//            "diana prince",
//            "elisabeth romanova",
//            "anakin wayne"
//        };
//        string escolhido = "bruce wayne";

//        listadenomes listadenomes = new listadenomes();

//        if (listadenomes.verificanomes(nomesdosescolhidos, escolhido))
//        {
//            console.writeline($"nome encontrado: {escolhido}");
//        }
//        else
//        {
//            console.writeline($"nome não encontrado: {escolhido}");
//        }
//    }
//}
