using UnityEngine;
using UnityEngine.UI;
public class logic : MonoBehaviour
{

    public int playerscore;
    public Text scoretext;

   public void addscore()
    {
        playerscore += 1;
        scoretext.text = playerscore.ToString();
    }
}
