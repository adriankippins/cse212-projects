public class PriorityQueue {
    private List<PriorityItem> _queue = new List<PriorityItem>();

    public void Enqueue(string value, int priority) {
        PriorityItem newNode = new PriorityItem(value, priority);
        _queue.Add(newNode);
    }

    public string Dequeue() {
        if (_queue.Count == 0) // Verify the queue is not empty
        {
            return null;
        }

        // Find the index of the item with the highest priority to remove
        int highPriorityIndex = 0;
        for (int index = 1; index < _queue.Count; index++) {
            if (_queue[index].Priority > _queue[highPriorityIndex].Priority)
                highPriorityIndex = index;
        }

        // Remove and return the item with the highest priority
        string value = _queue[highPriorityIndex].Value;
        _queue.RemoveAt(highPriorityIndex);
        return value;
    }
}

internal class PriorityItem {
    internal string Value { get; set; }
    internal int Priority { get; set; }

    internal PriorityItem(string value, int priority) {
        Value = value;
        Priority = priority;
    }
}