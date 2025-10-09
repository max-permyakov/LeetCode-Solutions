//-----------------------------------------------------------------------------
// Runtime: 88ms
// Memory Usage: 25.7 MB
// Link: https://leetcode.com/submissions/detail/343624394/
//-----------------------------------------------------------------------------

namespace LeetCode
{
    public class _021_MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null) return list2;
            if (list2 == null) return list1;

            ListNode dummy = new ListNode(); // фиктивная голова
            ListNode current = dummy;

            while (list1 != null && list2 != null)
            {
                if (list1.val < list2.val)
                {
                    current.next = new ListNode(list1.val);
                    list1 = list1.next;
                }
                else
                {
                    current.next = new ListNode(list2.val);
                    list2 = list2.next;
                }
                current = current.next;
            }

            // добавляем оставшиеся элементы
            while (list1 != null)
            {
                current.next = new ListNode(list1.val);
                list1 = list1.next;
                current = current.next;
            }

            while (list2 != null)
            {
                current.next = new ListNode(list2.val);
                list2 = list2.next;
                current = current.next;
            }

            return dummy.next; // пропускаем фиктивный первый узел
        }

    }
}
