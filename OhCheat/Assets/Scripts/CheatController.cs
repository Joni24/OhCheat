using UnityEngine;

public class CheatController : MonoBehaviour
{
    [System.Serializable]
    struct Cheat
    {
        public KeyCode key;
        public string script;
    }

    [SerializeField]
    private Cheat[] cheats;

    private int currentIndex = -1;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < cheats.Length; i++)
        {
            Cheat cheat = cheats[i];
            if (Input.GetKeyDown(cheat.key)) {
                if (currentIndex != -1) {
                    var currentCheat = cheats[currentIndex];
                    MonoBehaviour currentBehav = (MonoBehaviour)GetComponent(currentCheat.script);
                    currentBehav.enabled = !currentBehav.enabled;
                }
                
                MonoBehaviour behav = (MonoBehaviour)GetComponent(cheat.script);
                behav.enabled = !behav.enabled;
                currentIndex = i;
                GameManager.gameManager.buttonDisplay.DisplayCurrentButton(cheat.key);
                
            }
        }
    }
}
