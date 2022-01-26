using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using Models;
using UnityEngine;

public class NpcCntrl : MonoBehaviour
{
    public PlayerCntrl player;
    [SerializeField] private NpcModel model;
  [SerializeField]  private bool inDialog;
    // Start is called before the first frame update
    void Start()
    {
        model = new NpcModel();
        model.NpcName = "Just girl";
        model.NpcStatus = "Agressive";
        player = FindObjectOfType<PlayerCntrl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.transform.position) < 5)
        {
            transform.LookAt(player.transform.position, Vector3.up);
            if (Input.GetKeyUp(KeyCode.Space)&& !inDialog)
            {
                inDialog = true;
                GameManager.Instance.DialogStart(model);
                
            }
        }
    }
}
