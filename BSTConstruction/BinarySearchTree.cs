using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSTConstruction
{

  public class TreeNode {
      public int val;
      public TreeNode left;
     public TreeNode right;
      public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
          this.val = val;
         this.left = left;
          this.right = right;
      }
  }

    public class BinarySearchTree
    {
      public  class Node
        {
            public int Data;
            public Node Left;
            public Node Right;
            public void DisplayNode()
            {
                Console.Write(Data + " ");
            }
          
        }


        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.Data = i;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (i < current.Data)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            break;
                        }

                        else
                        {
                            current = current.Right;
                            if (current == null)
                            {
                                parent.Right = newNode;
                                break;
                            }
                        }
                    }
                }
            }
        }

        public void Insertion(int value)
        {
            Node newNode = new Node();
            newNode.Data = value;
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node current = root;
                while (true)
                {
                    if (value < current.Data)
                    {
                    
                        if (current.Left == null)
                        {
                            current.Left = newNode;
                            break;
                        }
                        else
                        {
                            current = current.Left;
                        }

                        
                    }
                    else
                    {
                        if (current.Right == null)
                        {
                            current.Right = newNode;
                            break;
                        }
                        else
                        {
                            current = current.Right; 
                        }

                    }
                }
            }
        }

        public bool Contains(int val)
        {
            Node current = root;
            while (current!=null)
            {
                if (current.Data == val)
                {
                    return true;
                }
                if (current.Data > val)
                {
                    current = current.Left;
                }
                else if(current.Data<val)
                {
                    current = current.Right;
                }
            }

            return false;
        }

        public void Remove(int val , Node parent = null)
        {
            Node current = root;

            while (current!=null)
            {
                if (val < current.Data)
                {
                    parent = current;
                    current = current.Left;
                }
                else if (val > current.Data)
                {
                    parent = current;
                    current = current.Right;
                }
                else
                {
                    if(current.Left!=null && current.Right != null)
                    {
                        current.Data = this.GetMin(current.Right);

                        this.Remove(current.Data, current);
                        
                    }
                    else if (parent == null)
                    {
                        if (current.Left != null)
                        {
                            current.Data = current.Left.Data;
                            current.Right = current.Left.Right;
                            current.Left = current.Left.Left;
                        }
                        else if (current.Right != null)
                        {
                            current.Data = current.Right.Data;
                            current.Left = current.Right.Left;
                            current.Right = current.Right.Right;
                        }
                    }

                    else if (current.Left == current)
                    {
                        parent.Left = current.Left != null ? current.Left : current.Right;
                    }
                    else if (current.Right == current)
                    {
                        parent.Right = current.Left != null ? current.Left : current.Right;
                    }
                    break;
                }
            }

        }

        private int GetMin(Node node)
        {
            Node current = node;
            while (current.Left!=null)
            {
                current = current.Left;
            }
            return current.Data;
        }
    
    
        private IList<IList<int>> LevelOrderTraversal(TreeNode root)
        {
  
            //var result = new List<IList<int>>();
            //Queue<Node> queue = new Queue<Node>();
            //queue.Enqueue(root);
            //while (queue.Count>0)
            //{
            //    var currentLevel = new List<int>();
            //    var size = queue.Count;
            //    for (int i = 0; i < size; i++)
            //    {
            //        var cNode = queue.Dequeue();
            //        currentLevel.Add(cNode.Data);
            //        if (cNode.Left != null) queue.Enqueue(cNode.Left);
            //        if (cNode.Right != null) queue.Enqueue(cNode.Right);
            //    }
            //    result.Add(currentLevel);
            //}


            //return result;


            if (root == null) return null;
            IList<IList<int>> result = new List<IList<int>>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                var currentLevel = new List<int>();
                var size = queue.Count;
                for (int i = 0; i < size; i++)
                {
                    var currentNode = queue.Dequeue();
                    currentLevel.Add(currentNode.val);
                    if (currentNode.left != null) queue.Enqueue(currentNode.left);
                    if (currentNode.right != null) queue.Enqueue(currentNode.right);
                }
                result.Add(currentLevel);
            }


            return result;
        }


    
    }
}
