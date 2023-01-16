using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicker : MonoBehaviour
{
    public void ClickTheButton() {
        GameMannager.moneyCount += 1;
    }
}
