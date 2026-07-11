using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add three items with different priorities: A(1), B(5), C(3).
    // Expected Result: Dequeue should return B because it has the highest priority.
    // Defect(s) Found: The Dequeue method did not check the last item in the queue and did not remove the item after returning it.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 3);

        Assert.AreEqual("B", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add three items where two have the same highest priority: A(5), B(5), C(1).
    // Expected Result: Dequeue should return A first and B second because items with equal priority follow FIFO order.
    // Defect(s) Found: The Dequeue method used >= when comparing priorities, causing the newest item with the same priority to be removed first.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 1);

        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
}