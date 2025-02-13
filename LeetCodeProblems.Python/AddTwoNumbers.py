class ListNode(object):
    def __init__(self, val=0, next=None):
        self.val = val
        self.next = next

class Solution(object):
    def addTwoNumbers_better(self, l1, l2):
        result = ListNode()
        current = result
        carry = 0

        while l1 or l2 or carry:        
            l1val = l1.val if l1 else 0
            l2val = l2.val if l2 else 0
            sum = l1val + l2val + carry

            carry = sum / 10
            current.next = ListNode(sum % 10)
            current = current.next

            if l1: l1 = l1.next
            if l2: l2 = l2.next
        
        return result.next

    def addTwoNumbers(self, l1, l2):
        result = ListNode()
        current = result
        carry = 0

        while l1 is not None or l2 is not None or carry >= 1:        
            l1val = 0
            if l1 is not None:
                l1val = l1.val
            l2val = 0
            if l2 is not None:
                l2val = l2.val

            sum = l1val + l2val + carry
            carry = sum / 10
            digit = sum % 10

            current.next = ListNode(digit)
            current = current.next

            if l1 is not None:
                l1 = l1.next
            if l2 is not None:
                l2 = l2.next
        
        return result.next
    
# res = Solution().addTwoNumbers(ListNode(1), ListNode(1))