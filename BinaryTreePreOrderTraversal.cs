/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
//This is an iterative solution
public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> iList = new List<int>();
        Stack stack = new Stack();
        
        while (root != null) {
            iList.Add(root.val);
            if (root.right != null) {
                stack.Push(root.right);
            }
            root = root.left;
            if ((root == null) && (stack.Count > 0))  {
                root = stack.Pop() as TreeNode;;
            }
        }
        
        return iList;
    }
}
