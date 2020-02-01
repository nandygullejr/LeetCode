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
    IList<int> iList = new List<int>(){};
    
    public IList<int> PostorderTraversal(TreeNode root) {
        if (root != null) {
            if (root.left != null) {
                PostorderTraversal(root.left);
            }
            if (root.right != null) {
                PostorderTraversal(root.right);
            }
            iList.Add(root.val);
        }
        // Base case: if root == null, iList will be empty
        return iList;
    }
}
