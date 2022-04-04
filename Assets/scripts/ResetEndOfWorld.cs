using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetEndOfWorld : MonoBehaviour
{
    [SerializeField] float timerToEndGame= 10f;
    [SerializeField] float resetTimerValue = 30f;
    [SerializeField] barSLideLogic bar;
    [SerializeField] ChangeScene sceneManager;
    // Start is called before the first frame update
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        resetTimer();
         
    }
    // Update is called once per frame
    void Update()
    {
        timerToEndGame -= Time.fixedDeltaTime;
        bar.UpdateBar(timerToEndGame);
        if (timerToEndGame <= 0){
            print("game should have ended by now");
            sceneManager.backToMenu();
        }
    }

    void resetTimer()
    {
        timerToEndGame = resetTimerValue;
    }
    public void increaseResetMaximun()
    {
        resetTimerValue += 5f;
        bar.setMaxHealth(resetTimerValue);
    }
}
