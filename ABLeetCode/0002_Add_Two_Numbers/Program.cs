using System.Collections.Generic;

var result = new Solution()
    .AddTwoNumbers(
        new ListNode(2, new ListNode(4, new ListNode(3))), 
        new ListNode(5, new ListNode(6, new ListNode(4))));

while (result != null)
{
    Console.Write($"{result.val},");
    result = result.next;
}

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return AddTwoNumbersRecursive(l1, l2);
    }

    public ListNode AddTwoNumbersRecursive(ListNode l1, ListNode l2, bool isAddUp = false)
    {
        var plusResult = (l1?.val ?? 0) + (l2?.val ?? 0);
        if (isAddUp)
        {
            plusResult++;
        }
        var newNode = new ListNode(plusResult >= 10 ? plusResult - 10 : plusResult);
        
        if (l1?.next != null || l2?.next != null)
        {
            newNode.next = AddTwoNumbersRecursive(l1?.next, l2?.next, plusResult >= 10);
        }
        else if (plusResult >= 10)
        {
            newNode.next = new ListNode(1);
        }

        return newNode;
    }
}