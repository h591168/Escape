using UnityEngine;
using UnityEngine.Events;

public class NokkelScore : MonoBehaviour
{
    [SerializeField] private int nokkelScore; // N�v�rende score for n�kkelen
    [SerializeField] private int finalNokkelScore; // Score som trengs for � vinne med n�kkelen
    [SerializeField] private UnityEvent onNokkelWin; // Handlinger som utf�res n�r n�kkelen vinner

    // Metode for � oppdatere n�kkelscoren
    public void UpdateNokkelScore()
    {
        nokkelScore++; // �k n�kkelscoren med 1
        if (nokkelScore >= finalNokkelScore) // Sjekk om n�kkelscoren har n�dd eller overg�tt den endelige scoren
        {
            onNokkelWin.Invoke(); // Utf�r n�kkelvinner-hendelsen
        }
    }

    // Metode for � nullstille n�kkelscoren
    public void ResetNokkelScore()
    {
        nokkelScore = 0; // Nullstill n�kkelscoren til 0
    }

    // Metode for � hente den n�v�rende n�kkelscoren
    public int GetNokkelScore()
    {
        return nokkelScore;
    }
}
