using System;
using System.Collections;
using System.Collections.Generic;
using Models;
using Ui;
using UnityEngine;

public class UiCntrl : MonoBehaviour
{
   public DialogManager dialogManager;
   public CanvasGroup DialogCanvasGroup;

   private void Start()
   {
       EndDialog();
   }

   public void StartDialog(NpcModel model)
       {
          DialogCanvasGroup.alpha = 1;
          DialogCanvasGroup.interactable = true;
          DialogCanvasGroup.blocksRaycasts = true;
          dialogManager.StartTalk(model);
       }
   public void EndDialog()
   {
       DialogCanvasGroup.alpha = 0;
       DialogCanvasGroup.interactable = false;
       DialogCanvasGroup.blocksRaycasts = false;
   }
}
