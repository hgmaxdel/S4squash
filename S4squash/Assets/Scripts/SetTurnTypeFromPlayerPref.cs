using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTurnTypeFromPlayerPref : MonoBehaviour
{
    public ActionBasedSnapTurnProvider snapTurn;
    public ActionBasedContinuousTurnProvider continuousTurn;

    private void Start()
    {
        ApplyPlayerPref();
    }

    public void ApplyPlayerPref()
    {
        int value = PlayerPrefs.GetInt("turn", 1);

        if (value == 0)
        {
            // Snap turn
            snapTurn.enabled = true;
            continuousTurn.enabled = false;
        }
        else
        {
            // Continuous turn
            snapTurn.enabled = false;
            continuousTurn.enabled = true;
        }
    }
}