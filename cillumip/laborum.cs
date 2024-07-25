[Serializable]
public class PlayerData
{
    public string playerName;
    public int playerScore;
}

public class ExampleUsage : MonoBehaviour
{
    void Start()
    {
        // Saving an object
        PlayerData playerData = new PlayerData { playerName = "John", playerScore = 100 };
        JsonPlayerPrefs.SetObject("playerData", playerData);

        // Loading an object
        PlayerData loadedData = JsonPlayerPrefs.GetObject<PlayerData>("playerData");
        Debug.Log($"Loaded Player Name: {loadedData.playerName}, Score: {loadedData.playerScore}");

        // Saving a list of objects
        List<PlayerData> playerList = new List<PlayerData>
        {
            new PlayerData {playerName = "Alice", playerScore = 200},
            new PlayerData {playerName = "Bob", playerScore = 150}
        };
        JsonPlayerPrefs.SetList("playerList", playerList);

        // Loading a list of objects
        List<PlayerData> loadedList = JsonPlayerPrefs.GetList<PlayerData>("playerList");
        foreach (var player in loadedList)
        {
            Debug.Log($"Loaded Player Name: {player.playerName}, Score: {player.playerScore}");
        }
    }
}
