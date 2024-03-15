using System.Text;

namespace Add_Two_Numbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            var result = new StringBuilder(val.ToString());
            var nextNode = next;

            while (nextNode is not null)
            {
                result.Append(nextNode.val.ToString());
                nextNode = nextNode.next;
            }

            return result.ToString();
        }
    }

}
