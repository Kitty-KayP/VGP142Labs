using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DefaultExecutionOrder(-1)]
public abstract class Singleton<T> : MonoBehaviour where T : Component
{
    static T instance;

    public static T Instance
    {
        get
        {
            try
            {
                instance = FindAnyObjectByType<T>();
                if (instance == null) throw new NullReferenceException();
            }
            catch (NullReferenceException e)
            {
                Debug.Log(e.Message);
                GameObject obj = new GameObject();
                obj.name = typeof(T).Name;
                instance = obj.AddComponent<T>();
                DontDestroyOnLoad(obj);
            }
            finally
            {
                //this code will always run
                Debug.Log("Code always runs");
            }

            return instance;
        }
    }

    //Public - Globally accessable
    //Protected - Child Class Acessiable
    //Private - locally accessable

    protected virtual void Awake()
    {
        if (!instance)
        {
            instance = this as T;
            DontDestroyOnLoad(instance);
            return;
        }

        //if code gets down here - that means we aren't the first instance
        Destroy(gameObject);
    }
}



//using System;
//using System.Collections;
//using System.Collections.Generic;
//using Unity.VisualScripting;
//using UnityEngine;


//[DefaultExecutionOrder(-1)]
//public abstract class Singleton<T> : MonoBehaviour where T : Component
//{
//    static T instance;

//    public static T Instance
//    {
//        get
//        {
//            try
//            {
//                instance = FindAnyObjectByType<T>();
//                if (instance == null) throw new NullReferenceException();
//            }

//            catch (NullReferenceException e)
//            {
//                Debug.Log(e.Message);
//                GameObject obj = new GameObject();
//                obj.name = typeof(T).Name;
//                instance = obj.AddComponent<T>();
//                DontDestroyOnLoad(obj);
//            }

//            finally
//            {
//                Debug.Log("Code always runs");
//            }

//            return instance;

//        }
//    }

//    //Public - Globally accessible
//    //Protecter - Child Class accessible
//    //Private - locally accessible


//    protected virtual void Awake()
//    {
//        if (!instance)
//        {
//            instance = this as T;
//            DontDestroyOnLoad(instance);
//            return;
//        }

//        //If code gets down here - EnsureThat means we aren't the first instance'
//        Destroy(gameObject);

//    }
//}