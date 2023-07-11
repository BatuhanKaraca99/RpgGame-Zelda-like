using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatValue : ScriptableObject,ISerializationCallbackReceiver
{
    //Serialisation: load objects from memory for whole program
    public float initialValue;

    [HideInInspector]
    public float RunTimeValue;
    //We don't change this value in Inspector

    public void OnAfterDeserialize()
    {
        RunTimeValue = initialValue;
    }

    public void OnBeforeSerialize()
    {

    }
}
