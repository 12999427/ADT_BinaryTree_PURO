using System.Diagnostics;

namespace ADT_BinaryTree_Puro; //BINARY TREE CORRETTO
// NOTA: Come altro albero c'è l'implementazion della taffurelli caricata su classroom
class Program
{
    static void Main(string[] args)
    {
        BinaryTree<int> binaryTree = new();
        
        for (int i = 0; i<17; i++)
        {
            binaryTree.InsertLeaf(i);
        }

        binaryTree.Print();
        
        for (int i = 0; i<17; i++)
        {
            Console.WriteLine("\n________________\nValue " + binaryTree.Pop() + "\n");
            binaryTree.Print();
        }

        //Console.WriteLine(binaryTree.Pop());

    }
}
