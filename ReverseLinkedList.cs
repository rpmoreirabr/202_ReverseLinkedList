public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null)
        {
            return head;
        }
        ListNode reversedList = ReverseList(head.next);
        head.next.next = head;
        head.next = null;
        return reversedList;
    }

    public ListNode ReverseListIterative(ListNode head)
    {
        if (head.next != null)
        {
            var previous = head;
            var current = head.next;
            var next = head.next.next;

            current.next = previous;

            while (next != null)
            {
                previous = current;
                current = next;
                next = current.next;
                current.next = previous;
            }

            head.next = null;
            return current;
        }
        else
            return head;
    }
}