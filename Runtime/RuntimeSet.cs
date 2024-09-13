using System;
using System.Collections.Generic;

public class RuntimeSet<T> {
    public readonly List<T> Items = new ();
        
    public event Action<int> OnCountChanged;
        
    public int Count => Items.Count;
        
    public void Add(T item) {
        if (!Items.Contains(item)) Items.Add(item);
        OnCountChanged?.Invoke(Items.Count);
    }
        
    public void Remove(T item) {
        if (Items.Contains(item)) Items.Remove(item);
        OnCountChanged?.Invoke(Items.Count);
    }
}