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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int size = 0;
        var current = head;
        while (current != null) {
            current = current.next;
            size++;
        }
        if (size == n) {
            return head.next;
        }
        current = head;
        for (int i = 1; i < size - n; i++) {
            current = current.next;
        }
        current.next = current.next.next;
        return head;
    }
}
