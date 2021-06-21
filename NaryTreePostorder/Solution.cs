using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaryTreePostorder
{
    public class Node
    {
        public int val;
        public IList<Node> children;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
        }

        public Node(int _val, IList<Node> _children)
        {
            val = _val;
            children = _children;
        }
    }


public class Solution
    {
        public IList<int> Preorder(Node root)
        {
    

            List<int> output = new List<int>();

            if (root == null)
                return output;


            TraverseNodes(root, output);
              

 
 

            return output;
            
        }

        private void TraverseNodes(Node root, List<int> output)
        {
            if (root.children == null)
                return;
            output.Add(root.val);
            foreach (var child in root.children)
            {
                TraverseNodes(child, output);

            }
        }
    }
}
