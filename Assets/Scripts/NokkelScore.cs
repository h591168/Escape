using UnityEngine;
using UnityEngine.Events;

public class NokkelScore : MonoBehaviour
{
    [SerializeField] private int nokkelScore; // Nåværende score for nøkkelen
    [SerializeField] private int finalNokkelScore; // Score som trengs for å vinne med nøkkelen
    [SerializeField] private UnityEvent onNokkelWin; // Handlinger som utføres når nøkkelen vinner

    // Metode for å oppdatere nøkkelscoren
    public void UpdateNokkelScore()
    {
        nokkelScore++; // Øk nøkkelscoren med 1
        if (nokkelScore >= finalNokkelScore) // Sjekk om nøkkelscoren har nådd eller overgått den endelige scoren
        {
            onNokkelWin.Invoke(); // Utfør nøkkelvinner-hendelsen
        }
    }

    // Metode for å nullstille nøkkelscoren
    public void ResetNokkelScore()
    {
        nokkelScore = 0; // Nullstill nøkkelscoren til 0
    }

    // Metode for å hente den nåværende nøkkelscoren
    public int GetNokkelScore()
    {
        return nokkelScore;
    }
}
