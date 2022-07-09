using System;
using System.Collections.Generic;

namespace Binary_Tree_Paths
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

  public class Solution
  {
    const string SEPARATOR = "->";
    List<string> result = new List<string>();
    public IList<string> BinaryTreePaths(TreeNode root)
    {
      Helper(root, "");
      return result;
    }

    private void Helper(TreeNode root, string str)
    {
      if (root == null) return;
      // base condition for leaf node
      // leaf node does not have any left and right child
      if (root.left == null && root.right == null)
      {
        str += root.val.ToString();
        result.Add(str);
        return;
      }
      str += root.val.ToString() + SEPARATOR;
      Helper(root.left, str);
      Helper(root.right, str);
    }
  }
}
