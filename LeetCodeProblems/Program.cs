// See https://aka.ms/new-console-template for more information

using LeetCodeProblems;

Console.WriteLine("Hello, World!");


ListNode node1 = new(3);
ListNode node2 = new(2);
ListNode node3 = new(0);
ListNode node4 = new(-4);

node1.next = node2;
node2.next = node3;
node3.next = node4;
node4.next = node2;

LinkedListCycle linkedListCycle = new();
linkedListCycle.HasCycle(node1);