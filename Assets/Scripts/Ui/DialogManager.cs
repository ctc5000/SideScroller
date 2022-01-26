using Models;
using TMPro;
using UnityEngine;

namespace Ui
{
    public class DialogManager :MonoBehaviour
    {
        public TMP_Text NpcName;
        public TMP_Text NpcStatus;
        public TMP_Text Dialog;
        public void StartTalk(NpcModel model)
        {
            NpcName.text = model.NpcName;
            NpcStatus.text = model.NpcStatus;
            Dialog.text = "Привет ёпта";
        }
    }
}