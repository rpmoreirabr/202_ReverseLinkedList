// See https://aka.ms/new-console-template for more information
ListNode n1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));

n1 = n1.ReverseListIterative(n1);
Console.WriteLine(n1.val);
Console.WriteLine(n1.next.val);
Console.WriteLine(n1.next.next.val);
Console.WriteLine(n1.next.next.next.val);
Console.WriteLine(n1.next.next.next.next.val);
