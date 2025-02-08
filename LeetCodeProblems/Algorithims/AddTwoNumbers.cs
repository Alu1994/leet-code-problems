//var r = Solution.AddTwoNumbers3(new ListNode(2, new ListNode(4, new ListNode(3, default))), new ListNode(5, new ListNode(6, new ListNode(4, default))));
//var r = Solution.AddTwoNumbers3(new ListNode(2, new ListNode(4, new ListNode(3, default))), new ListNode(5, new ListNode(6, new ListNode(4, default))));
//Console.WriteLine(r.First());

using LeetCodeProblems.Algorithims.Helpers;

namespace LeetCodeProblems.Algorithims;

public static partial class Solution
{
    // My Solution
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode resultListNode = new ListNode();
        ListNode endListNode = resultListNode;

        string number = "";
        int restNumber = 0;
        while (l1 is not null || l2 is not null)
        {
            var internalResult = (l1?.val ?? 0) + (l2?.val ?? 0) + restNumber;
            if (internalResult.ToString().Length > 1)
            {
                number = internalResult.ToString().Last().ToString();
                restNumber = 1;
            }
            else
            {
                number = internalResult.ToString();
                restNumber = 0;
            }

            endListNode.val = Convert.ToInt32(number);
            l1 = l1?.next;
            l2 = l2?.next;

            if (l1 is not null || l2 is not null)
            {
                endListNode.next = new ListNode();
                endListNode = endListNode.next;
            }
            else if (restNumber > 0)
            {
                endListNode.next = new ListNode(restNumber);
            }
        }
        return resultListNode;
    }


    public static ListNode AddTwoNumbers_2(ListNode l1, ListNode l2)
    {
        ListNode result = new ListNode();
        ListNode current = result;
        int carry = 0;

        while (l1 is not null || l2 is not null || carry != 0)
        {            
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            carry = sum / 10;
            int digit = sum % 10;

            current.next = new ListNode(digit);
            current = current.next;

            l1 = l1?.next;
            l2 = l2?.next;
        }
        return result.next;
    }

    public static ListNode AddTwoNumbers_3(ListNode l1, ListNode l2) 
    {
        ListNode dummyHead = new ListNode(0);
        ListNode current = dummyHead;
        int carry = 0;

        while(l1 != null || l2 != null || carry != 0)
        {
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;
            
            int sum = x + y + carry;
            carry = sum / 10;
            int digit = sum % 10;

            current.next = new ListNode(digit);
            current = current.next;

            if(l1 != null) l1 = l1.next;
            if(l2 != null) l2 = l2.next;
        }

        return dummyHead.next;
    }
}


