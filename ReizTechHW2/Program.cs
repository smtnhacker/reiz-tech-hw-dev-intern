using System;

public class Branch
{
    public List<Branch> branches = new List<Branch>();

    public void Add(Branch branch)
    {
        branches.Add(branch);
    }
}

public class Program
{
    public static void Main()
    {
        List<Branch> branchList = new List<Branch>();
        for(int i=0; i<10; i++)
        {
            branchList.Add(new Branch());
        }

        Branch root = new Branch();

        // manually add the branches
        root.Add(branchList[0]);
        root.Add(branchList[1]);
        branchList[0].Add(branchList[2]);
        branchList[1].Add(branchList[3]);
        branchList[1].Add(branchList[4]);
        branchList[1].Add(branchList[5]);
        branchList[3].Add(branchList[6]);
        branchList[4].Add(branchList[7]);
        branchList[4].Add(branchList[8]);
        branchList[7].Add(branchList[9]);

        Console.WriteLine(String.Format("Structure has depth {0}.", CalculateDepth(root)));
    }

    private static int CalculateDepth(Branch node)
    {
        int deepestBranch = 0;
        foreach(Branch child in node.branches)
        {
            deepestBranch = Math.Max(deepestBranch, CalculateDepth(child));
        }
        return 1 + deepestBranch;
    }

}