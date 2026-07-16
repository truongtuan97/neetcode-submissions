public class TimeMap {
    
    private class DataPoint {
        public int Timestamp { get; set; }
        public string Value { get; set; }

        public DataPoint(int timestamp, string value) {
            Timestamp = timestamp;
            Value = value;
        }
    }

    private Dictionary<string, List<DataPoint>> store;
    public TimeMap() {
        store = new Dictionary<string, List<DataPoint>>();
    }
    
    public void Set(string key, string value, int timestamp) {
        if (!store.ContainsKey(key)) {
            store[key] = new List<DataPoint>();
        }
        store[key].Add(new DataPoint(timestamp, value));
    }
    
    public string Get(string key, int timestamp) {
        if (!store.ContainsKey(key)) {
            return "";
        } {
            List<DataPoint> list = store[key];
            int left = 0;
            int right = list.Count - 1;
            string result = "";

            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (list[mid].Timestamp == timestamp) {
                    return list[mid].Value;
                } else {
                    if (list[mid].Timestamp < timestamp) {
                        result = list[mid].Value;
                        left = mid + 1;
                    } else {
                        right = mid - 1;
                    }
                }
            }
            return result;
        }
    }
}
