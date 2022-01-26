using System.Collections;
using System.Collections.Generic;
using Models;
using UnityEngine;

public class GameManager : Singleton<GameManager>
{
     UiCntrl _uiCntrl;
    void Start()
    {
        _uiCntrl = GetComponent<UiCntrl>();
    }

    public void DialogStart(NpcModel model)
    {
        _uiCntrl.StartDialog(model);
    }
}
