using System;

// 783. 二叉搜索树节点最小距离

/*
给你一个二叉搜索树的根节点 root ，返回 树中任意两不同节点值之间的最小差值 。


 */
class Leet0783
{
    //static void Main()
    //{
    //    MinDiffInBST(new TreeNode(1, new TreeNode(2), new TreeNode(4)));
    //}
    public static int MinDiffInBST(TreeNode root)
    {
        int result = int.MaxValue;
        TreeNode pre = null;

        //中序遍历
        void Traversal(TreeNode cur)
        {
            if (cur == null) { return; }

            Traversal(cur.left);//左
            if(pre != null)//中
            {
                result = Math.Min(result, Math.Abs(cur.val - pre.val));
            }

            pre = cur;// 记录前一个
            Traversal(cur.right);//右
        }

        Traversal(root);

        return result; 
    }
}


//Definition for a binary tree node.
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

