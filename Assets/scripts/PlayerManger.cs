using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManger : MonoBehaviour
{
    [SerializeField] private Transform transform;

    public Vector2 Position { 
        get { return transform.position; } 
    }
}
