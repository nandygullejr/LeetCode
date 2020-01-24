/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> iList = new List<int>();
        Stack stack = new Stack();

        while ((root != null) || (stack.Count > 0)) {
            if (root != null) {
                stack.Push(root);
                root = root.left;
            } else {
                root = stack.Pop() as TreeNode;
                iList.Add(root.val);
                root = root.right;
            }
        }
        
        return iList;
    }
}
