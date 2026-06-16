/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null)
            return;
        ListNode slow = head, fast = head.next;
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        // find mid 
        ListNode second = slow.next;
        slow.next = null;
        ListNode prev = null; 
        // reverse second half
        while(second != null){
            ListNode temp = second.next;
            second.next = prev;
            prev = second;
            second = temp;
        } 
        // merge
        ListNode first = head;
        second = prev;
        while(second !=null){
            var temp1 = first.next;
            var temp2 = second.next;
            first.next = second;
            second.next = temp1;
            
            first = temp1;
            second = temp2;
        }
    }
}
