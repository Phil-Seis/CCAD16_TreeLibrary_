//work out the BST for a value of the node
//what is the object that i'm returning?
using System.ComponentModel;

namespace TreesLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //BinaryTree<string> tree = GetTree();
            //BinaryTreeNode<string>? node = tree.Root;
            //while (node != null)
            //{
            //    if (node.Left != null && node.Right != null)
            //    {
            //        Console.WriteLine(node.Data);
            //        node = Console.ReadKey(true).Key switch
            //        {
            //            ConsoleKey.Y => node.Left,
            //            ConsoleKey.N => node.Right,
            //            _ => node
            //        };
            //    }
            //    else
            //    {
            //        Console.WriteLine(node.Data);
            //        node = null;
            //    }
            //}

            BinaryTree<string> GetTree()
            {
                BinaryTree<string> tree = new();

                //Root of tree
                tree.Root = new BinaryTreeNode<string>()
                {
                    Data = "Do you have an experience in app development ? ",
                    Children =
                    [                       
                        //If yes to experience:
                        new BinaryTreeNode<string>() 
                        { 
                            Data = "Have you worked as a developer for 5 + years ? ", 
                            Children = 
                            [ 
                                //Yes or No to working as a developer:
                                new() { Data = "Apply as a senior developer" },
                                new() { Data = "Apply as a middle developer" }
                            ]
                        },

                        //If no experience:
                        new BinaryTreeNode<string>()
                        {
                            Data = "Have you completed a university?",
                            Children =
                            [
                                //If yes:
                                new() { Data = "Apply as a junior developer" },
                            
                                //If no:
                                new BinaryTreeNode<string>()
                                {
                                    Data = "Have you completed MSSA?",
                                    Children =
                                    [
                                        //If yes to completing MSSA:
                                        new() { Data = "Apply for an entry-level developer." },
                                
                                        //If no to completing MSSA:
                                        new BinaryTreeNode<string>()
                                        {
                                            Data = "Have you applied for MSSA?",
                                            Children =
                                            [   //Yes or No to applying for MSSA:
                                                new() { Data = "Please monitor your email for an acceptance/selection letter." },
                                                new() { Data = "Will you be applying again?" }
                                            ]    
                                        }
                                    ]
                                }
                            ]
                        }
                    ]
                };
                tree.Count = 11;

                return tree;
            }
        }
    }
}