public static class Priority {
    public static void Test() {
        // Test Cases

        // Test 1
        // Scenario: Enqueue items with different priorities and dequeue them.
        // Expected Result: Ensure items are dequeued in the correct priority order.
        Console.WriteLine("Test 1");
        PriorityQueue queue1 = new PriorityQueue();
        queue1.Enqueue("Item 1", 3);
        queue1.Enqueue("Item 2", 1);
        queue1.Enqueue("Item 3", 5);
        string item;
        while ((item = queue1.Dequeue()) != null)
            Console.WriteLine(item);
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Enqueue items with the same highest priority.
        // Expected Result: Verify that the first item with the highest priority is dequeued first (FIFO order).
        Console.WriteLine("Test 2");
        PriorityQueue queue2 = new PriorityQueue();
        queue2.Enqueue("Item 4", 3);
        queue2.Enqueue("Item 5", 3);
        queue2.Enqueue("Item 6", 3);
        while ((item = queue2.Dequeue()) != null)
            Console.WriteLine(item);
        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Dequeue from an empty queue.
        // Expected Result: Ensure an error message is displayed when attempting to dequeue from an empty queue.
        Console.WriteLine("Test 3");
        PriorityQueue queue3 = new PriorityQueue();
        string result = queue3.Dequeue();
        if (result == null)
            Console.WriteLine("The queue is empty.");
        // Defect(s) Found: 

        Console.WriteLine("---------");

    }
}