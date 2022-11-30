using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public GameObject gameManagerObject;
    [SerializeField] Label labell;
    private GameManager gameManager;

    private void Awake()
    {
        gameManager = gameManagerObject.GetComponent<GameManager>();
    }

    private void OnMouseDown()
    {
        gameManager.Spawn();
        Destroy(gameObject);
        Debug.Log("+1 fish");
        

    }


}
