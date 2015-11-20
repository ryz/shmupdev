using UnityEngine;
using System.Collections;

public class GameOverOnDestroy : MonoBehaviour {

    public GameSystem gameSystem;

    void OnDestroy()
    {
        gameSystem.isGameOver = true;
        Debug.Log("ITS GAME OVER MAN");

    }
}
