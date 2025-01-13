using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public enum GameState { Waiting, Game0, Game1, Game2, Game3, Game4, Game5, Lose, Win}
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameState gameState;

    private void Awake()
    {
        if(instance == null) 
            instance = this;
        else 
            Destroy(gameObject);
    }
    public void SetGameState(GameState gameState)
    {
        this.gameState = gameState;
        IEnumerable<IGameStateListener> gameStateListeners = 
            FindObjectsByType<MonoBehaviour>(FindObjectsSortMode.None)
            .OfType<IGameStateListener>();

        foreach(IGameStateListener gameStateListener in gameStateListeners)
            gameStateListener.GameStateChangedCallback(gameState);
    }
    public bool IsGameState()
    {
        return gameState == GameState.Game0;
    }
    

    
}
public interface IGameStateListener
{
    void GameStateChangedCallback(GameState gameState);
}