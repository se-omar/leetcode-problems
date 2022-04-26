namespace LeetCodeProblems;

public class LinkedListCycle
{
    public bool HasCycle(ListNode head)
    {
        if (head == null) return false;
        ListNode walker = head;
        ListNode runner = head;
        while(runner.next != null && runner.next.next != null)
        {
            runner = runner.next.next;
            walker = walker.next;
            if (walker == runner) return true;
        }

        return false;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}