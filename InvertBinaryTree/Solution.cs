﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvertBinaryTree
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

    class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
                return root;

            var left = InvertTree(root.left);
            var right = InvertTree(root.right);

            root.left = right;
            root.right = left;


            return root;

              
        }
    }
}
