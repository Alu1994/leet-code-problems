//var r = Solution.MergeTwoSortedLists_2(new ListNode(1, new ListNode(3, new ListNode(4))), new ListNode(2, new ListNode(3)));
////var r = Solution.MergeTwoSortedLists(null, null);

//while (r is not null)
//{
//    Console.WriteLine(r.val.ToString());
//    r = r?.next;
//}

using LeetCodeProblems.Algorithims.Helpers;

namespace LeetCodeProblems.Algorithims;

public static partial class Solution
{
    // My Solution
    public static ListNode MergeTwoSortedLists(ListNode l1, ListNode l2)
    {
        if (l1 is null && l2 is null) return null;

        ListNode dummyHead = new ListNode();
        ListNode current = dummyHead;

        while (l1 is not null || l2 is not null)
        {
            int? x = l1?.val;
            int? y = l2?.val;

            if(x is null)
                current.val = y.Value;
            else if (y is null)
                current.val = x.Value;
            else
            {
                current.val = x.Value < y.Value ? x.Value : y.Value;
            }

            if (l1 is not null && (x < y || l2 is null)) l1 = l1.next;
            else if (l2 is not null) l2 = l2.next;

            if(l1 is not null || l2 is not null)
            {
                current.next = new ListNode();
                current = current.next;
            }
        }

        return dummyHead;
    }

    public static ListNode MergeTwoSortedLists_2(ListNode l1, ListNode l2)
    {
        ListNode dummyHead = new ListNode(0);
        ListNode current = dummyHead;

        while (l1 is not null && l2 is not null)
        {
            if(l1.val < l2.val)
            {
                current.next = l1;
                l1 = l1.next;
            }            
            else
            {
                current.next = l2;
                l2 = l2.next;
            }
            current = current.next;
        }

        current.next = l1 is not null ? l1 : l2;

        return dummyHead.next;
    }


    public static ListNode MergeTwoSortedLists_3(ListNode list1, ListNode list2)
    {
        ListNode dummy = new ListNode(0);
        ListNode prev = dummy;

        ListNode p1 = list1, p2 = list2;
        while (p1 != null && p2 != null)
        {
            if (p1.val < p2.val)
            {
                prev.next = p1;
                p1 = p1.next;
            }
            else
            {
                prev.next = p2;
                p2 = p2.next;
            }
            prev = prev.next;
        }

        prev.next = p1 != null ? p1 : p2;

        return dummy.next;
    }
}
