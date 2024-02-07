using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoPool<T> where T : MonoBehaviour 
{
    private T _example;
    private Transform _parent;
    public MonoPool(T example, Transform parent)
    {
        _example = example;
        _parent = parent;
    }

    private Queue<T> _queue = new Queue<T>();

    public T Get()
    {
        if(_queue.Count == 0)
        {
            _queue.Enqueue(Create());
        }
        return _queue.Dequeue();
    }

    public void ReturnToPool(T obj)
    {
        Reset(obj);
        _queue.Enqueue(obj);
    }

    private T Create()
    {
        T newObject = MonoBehaviour.Instantiate<T>(_example, _parent);
        Reset(newObject);
        return newObject;
    }

    private void Reset(T obj)
    {
        obj.gameObject.SetActive(false);
        obj.transform.position = Vector3.zero;
        obj.transform.rotation = Quaternion.identity;
        obj.transform.localScale = Vector3.one;
    }
}
