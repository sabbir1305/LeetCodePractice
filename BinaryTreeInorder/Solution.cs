using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeInorder
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
 
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
            var stack = new Stack<TreeNode>();
            var current = root;
            var result = new List<int>();

            if (root == null)
                return result;

            while (current!=null || stack.Count>0)
            {
                while (current!=null)
                {
                    stack.Push(current);
                    current = current.left;

                }
                current = stack.Pop();
                result.Add(current.val);
                current = current.right;
            }

            return result;


    }
}
}
