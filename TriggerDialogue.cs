using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDialogue : MonoBehaviour
{
    [SerializeField]
    protected string objectTag;

    [SerializeField]
    protected GameObject dialogueBox;

    [SerializeField]
    protected DialogueManager dm;

    [SerializeField]
    protected PopUpHintScript hint;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == objectTag)
        {
            hint.isInteracting = true;
            dialogueBox.SetActive(true);
            dm.isTalking = true;
            hint.CloseHints();
            dm.ShowNextDialogues();
            
        }
    }

}
