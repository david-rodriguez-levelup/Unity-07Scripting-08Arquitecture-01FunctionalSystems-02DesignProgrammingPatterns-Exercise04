using UnityEngine;

public class LevelCounter : Singleton<LevelCounter>
{

    [SerializeField] LevelCounterChangeAction levelCounterChangeAction;

    private int level = 0;

    public override void OnCreate()
    {
        Debug.Log("ON CREATE!!!");
        levelCounterChangeAction = FindObjectOfType<LevelCounterChangeAction>();
    }

    public void Reset()
    {
        level = 0;
        levelCounterChangeAction.Perform(level);
    }

    public void IncreaseLevel()
    {
        level++;
        levelCounterChangeAction.Perform(level);
    }

}
