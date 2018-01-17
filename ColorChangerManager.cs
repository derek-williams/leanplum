using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ColorChangerManager : MonoBehaviour
{
    public Image m_background;

    public void ChangeColor()
    {
        m_background.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
}
