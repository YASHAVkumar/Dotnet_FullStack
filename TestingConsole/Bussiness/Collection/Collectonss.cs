
//Collections are used to store and manage groups of data dynamically.
// Collections provide:

// dynamic size
// searching
// sorting
// insertion/deletion
// iteration

// | Category                | Namespace                        |
// | ----------------------- | -------------------------------- |
// | Non-Generic Collections | `System.Collections`             |
// | Generic Collections     | `System.Collections.Generic`     |
// | Concurrent Collections  | `System.Collections.Concurrent`  |
// | Specialized Collections | `System.Collections.Specialized` |

//Non-Generic Collections
// ArrayList
// Hashtable
// Queue
// Stack

//corns
// no type safety
// boxing/unboxing
// slower performance

//Generic Collections
// type safety
// better performance
// no boxing/unboxing

// List<T>
// Dictionary<TKey, TValue>
// HashSet<T>
// Queue<T>
// Stack<T>
// LinkedList<T>

//Concurrent Collections
//Thread-safe collections. System.Collections.Concurrent
// ConcurrentDictionary
// ConcurrentQueue
// ConcurrentBag


//Specialized Collections-- Special-purpose collections.
// StringCollection
// NameValueCollection
//IEnumerable
//ICollection
//IList
//IDictionary

// IEnumerable
//     ↑
// ICollection
//     ↑
// IList


//Array vs List
// | Feature     | Array  | List            |
// | ----------- | ------ | --------------- |
// | Size        | Fixed  | Dynamic         |
// | Performance | Faster | Slightly slower |
// | Resize      | Manual | Automatic       |
// | Namespace   | System | Generic         |

//ArrayList vs List<T>
// | Feature     | ArrayList | List<T> |
// | ----------- | --------- | ------- |
// | Type Safety | ❌         | ✅       |
// | Boxing      | Yes       | No      |
// | Performance | Slower    | Faster  |
// | Generic     | ❌         | ✅       |




using System.Collections;
using System.Reflection;

public class Collectionss
{
    public ArrayList array=[];
    public Hashtable hashtable=[];
    public Stack stack=[];
    public Queue queue=[];

    public void AddArrayList(int num)=>array.Add(num);
    public void AddHashTable(int key,int val)=>hashtable.Add(key,val);
    
    public void AddStack(int val)=>stack.Push(val); //Lifo
    public void AddQueue(int val)=>queue.Enqueue(val); //FIFo
    
    public void RemoveArrayList(int num)=>array.Remove(num);
    public void RemoveHashTable(int key)=>hashtable.Remove(key);
    
    public void RemoveStack()=>stack.Pop(); //Lifo
    public void RemoveQueue()=>queue.Dequeue(); //FIFo
    public int FindArrayList(int num)=>array.IndexOf(num);
    public int FindHashTable(int key)=>(int)hashtable[key];
    
    public int FindStack(int val)=>(int)stack.Peek(); //Lifo
    public int  FindQueue(int val)=>(int)queue.Peek(); //FIFo
    

    
}