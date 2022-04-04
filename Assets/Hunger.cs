using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hunger : MonoBehaviour
{
    [SerializeField] float starveMeter = 120f;
    [SerializeField] float starveMaxMeter = 200f;
    [SerializeField] barSLideLogic bar;
    [SerializeField] ChangeScene scenemanager;
    // Start is called before the first frame update
    void Start()
    {
        bar.setMaxHealth ( starveMaxMeter);
    }

    // Update is called once per frame
    void Update()
    {
        starveMeter -= Time.fixedDeltaTime;
        bar.UpdateBar(starveMeter);
        if (starveMeter <= 0)
        {
            print("game should have ended by now you starved to dead");
            scenemanager.backToMenu();
        }
    }
    public void RecoverHunger()
    {
        starveMeter =Mathf.Clamp(starveMeter +120f,0, starveMaxMeter);
    }
}
