using System;

namespace LeetCodeProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            do
            {
                Console.WriteLine("1- Reverse Linked List\n" +
                "2- Single Number\n" +
                "3-Search Insert Position\n" +
                "4- Minimum Depth Of Binary Tree\n" +
                "5- Valid Parantheses\n" +
                "6- Exit" +
                " Choose Your Option");
                Console.WriteLine("_____________________________________________________");
                string input = Console.ReadLine();
                if (int.TryParse(input, out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, null)));
                            Console.WriteLine("Before Reversing: ");
                            LinkedList.PrintList(head);
                            head = LinkedList.ReverseList(head);
                            Console.WriteLine("\nAfter Reversing: ");
                            LinkedList.PrintList(head);
                            Console.WriteLine("____________________________________________________");
                            break;
                        case 2:

                            int[] nums = { 1, 2, 3, 1, 3, 4, 4, 5, 6, 5, 6 };
                            foreach (var i in nums)
                                Console.Write(i + " ");
                            int singleNumberResult = SingleNumber.singleNumber(nums);
                            Console.WriteLine("\nSingle number: " + singleNumberResult);
                            Console.WriteLine("____________________________________________________");
                            break;
                        case 3:
                            int[] numbers = { 1, 2, 3, 5, 8, 9, 13 };
                            foreach (var i in numbers)
                                Console.Write(i + " ");
                            int target1 = 3;
                            int target2 = 10;
                            Console.WriteLine("\n when target is 3, Insert Position is: " + SearchInsertPosition.SearchInsert(numbers, target1));
                            Console.WriteLine("\n when target is 10, Insert Position is: " + SearchInsertPosition.SearchInsert(numbers, target2));
                            Console.WriteLine("_____________________________________________________");
                            break;
                        case 4:
                            TreeNode leftsubtree = new TreeNode(5, null, null);
                            TreeNode rightsubtree = new TreeNode(20, new TreeNode(13, new TreeNode(11, null, null), null), new TreeNode(27, null, null));
                            TreeNode root = new TreeNode(10, leftsubtree, rightsubtree);
                            //tree is [10,5,20,null,13,27,11,null,null]
                            Console.WriteLine("          10                      ");
                            Console.WriteLine("   5              20              ");
                            Console.WriteLine("              13      27          ");
                            Console.WriteLine("           11                     ");

                            int depth = MinimumDepth.MinDepth(root);
                            Console.WriteLine("Minimum Depth in the above tree is: " + depth);
                            Console.WriteLine("_____________________________________________________");
                            break;
                        case 5:
                            string str = "()[]{}";
                            Console.WriteLine(str + " Validation=> " + ValidParentheses.IsValid(str));
                            string str2 = "({})[]}";
                            Console.WriteLine(str2 + " Validation=> " + ValidParentheses.IsValid(str2));
                            break;
                        default:
                            Console.WriteLine("Please enter number between 1 and 6 only");
                            break;

                    }
                }
                else
                    Console.WriteLine("Please enter numbers only");

            } while (choice != 6);



        }
    }
}
