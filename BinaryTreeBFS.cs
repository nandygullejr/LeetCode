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
   
    public IList<IList<int>> LevelOrder(TreeNode root) {
       Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        List<List<int>> twoDimensionalList = new List<List<int>>(){};
        while (queue.Count > 0) {
            var count = queue.Count;
            List<int> list = new List<int>(){};
            for (var i = 0; i < count; i++) {
                var node = queue.Dequeue();
                if (node != null) {
                    list.Add(node.val);
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            } 
            if (list.Count > 0) {
                twoDimensionalList.Add(list);
            }
        }
        return ((IList<IList<int>>)twoDimensionalList.Cast<IList<int>>().ToList());
    }
}
