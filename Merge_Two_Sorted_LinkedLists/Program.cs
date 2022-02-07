namespace Merge_Two_Sorted_LinkedLists
{
    class Program
    {
        static void Main()
        {
            ListNode node1 = new ListNode(1);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(4);

            ListNode node4 = new ListNode(1);
            ListNode node5 = new ListNode(3);
            ListNode node6 = new ListNode(4);

            node1.next = node2;
            node2.next = node3;

            node4.next = node5;
            node5.next = node6;

            ListNode list1 = node1;
            ListNode list2 = node4;

            ListNode result = merge(list1, list2);

            // Console.WriteLine(result.val);
            // Console.WriteLine("Hello");
        }

        static ListNode merge(ListNode list1, ListNode list2)
        {

            ListNode result = new ListNode();
            ListNode p1 = list1;
            ListNode p2 = list2;

            // Console.WriteLine("p1.val " + p1.val);
            // Console.WriteLine("p2.val " + p2.val);
            while (p1.val != 0 || p2.val != 0)
            {
                if (p1.val >= p2.val)
                {
                    Console.WriteLine("Inside if: ");
                    Console.WriteLine("p1.val " + p1.val);
                    Console.WriteLine("p2.val " + p2.val);
                    result.val = p2.val;
                    p2 = p2.next;
                }
                else
                {
                    Console.WriteLine("Inside else: ");
                    Console.WriteLine("p1.val " + p1.val);
                    Console.WriteLine("p2.val " + p2.val);
                    result.val = p1.val;
                    p1.val = p1.val;
                }
            }

            return result;

        }
    }

    class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}