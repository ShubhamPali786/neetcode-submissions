public class TimeMap {

private Dictionary<string, List<(int timestamp, string value)>> store;

    public TimeMap()
    {
        store = new Dictionary<string, List<(int timestamp, string value)>>();
    }

    public void Set(string key, string value, int timestamp)
    {
        if (!store.ContainsKey(key))
        {
            store[key] = new List<(int timestamp, string value)>();
        }
        store[key].Add((timestamp, value));
    }

    public string Get(string key, int timestamp)
    {
        if (!store.ContainsKey(key))
        {
            return ""; // Key does not exist
        }

        var entries = store[key];
        int left = 0;
        int right = entries.Count - 1;
        string result = "";

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (entries[mid].timestamp <= timestamp)
            {
                result = entries[mid].value; // Update result to the latest valid value
                left = mid + 1; // Search in the right half
            }
            else
            {
                right = mid - 1; // Search in the left half
            }
        }

        return result; // Return the latest valid value or "" if none found
    }
}
