using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCollector : MonoBehaviour
{

    public BattleStates2 states2;

    public Ai_creature Ai_Animal; //Refrence to Ai_creature

    public Creature1 Animal; //Refrence to Creature 1

    public Neural_network neuralNetwork; // Reference to neural network 

    private List<GameData> gameDataList;

    int batchSize = 20;

    private void Start()
    {
        gameDataList = new List<GameData>();
    }

    private void Update()
    {
        // Get the current game state and available actions
        GameState gameState = GetGameState();
        List<Action> availableActions = GetAvailableActions();

        if (availableActions.Count > 0)
        {
           
            foreach (Action action in availableActions)
            {
                
                float reward = PerformAction(action);

                
                GameData gameData = new GameData(gameState, action, reward);

                
                gameDataList.Add(gameData);
            }
        }

        // Train the neural network 
        if (gameDataList.Count >= batchSize)
        {
            neuralNetwork.Train(); 
            gameDataList.Clear(); 
        }
    }

    private GameState GetGameState()
    {

        // Get the player's health
        float playerHealth = Animal.GetComponent<Creature1>().Player_1Heal(20);

        // Get the opponent's health
        float opponentHealth = Ai_Animal.GetComponent<Ai_creature>().Ai_Heal(20);

        BattleStates2 initialState = BattleStates2.START; 

        GameState gameState = new GameState(playerHealth, opponentHealth, initialState);

        return gameState;
    }

    private List<Action> GetAvailableActions() // Create a new list to store available actions
    {
        List<Action> availableActions = new List<Action>();
       
        Action myAction = new Action();

        availableActions.Add(myAction);

        return availableActions;
    }

    private float PerformAction(Action action)
    {
        float reward = 0;
        return reward;
    }

    public class GameData
    {
        public GameState gameState;
        public Action action;
        public float reward;

        public GameData(GameState gameState, Action action, float reward)
        {
            this.gameState = gameState;
            this.action = action;
            this.reward = reward;
        }
    }

    public class GameState // Define the properties and variables that represent the game state
    {
        public GameState(float playerHealth, float opponentHealth, BattleStates2 initialState)
        {
            PlayerHealth = playerHealth;
            OpponentHealth = opponentHealth;
            InitialState = initialState;
        }

        public float PlayerHealth { get; }
        public float OpponentHealth { get; }
        public BattleStates2 InitialState { get; }
    }

    public class Action
    {
        
    } 

    public void Train(List<GameData> gameDataList)
    {
       
        gameDataList.Clear();
    }



}
