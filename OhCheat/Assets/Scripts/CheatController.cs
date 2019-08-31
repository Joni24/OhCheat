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

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < cheats.Length; i++)
        {
            Cheat cheat = cheats[i];
            if (Input.GetKeyDown(cheat.key))
            {
                MonoBehaviour behav = (MonoBehaviour)GetComponent(cheat.script);
                behav.enabled = !behav.enabled;
                GameManager.gameManager.buttonDisplay.DisplayCurrentButton(cheat.key);
            }
        }
    }
}
