using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class increaseTimeForResets : MonoBehaviour
{
    [SerializeField] ResetEndOfWorld endButton;
    [SerializeField] winSystem gameSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        endButton.increaseResetMaximun();
        gameSystem.removeMeFromList(gameObject);
        Destroy(gameObject);
    }
}
