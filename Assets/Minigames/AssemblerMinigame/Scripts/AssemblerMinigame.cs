using System.Collections;
using UnityEngine;
namespace Brera.Minigames.AssemblerPuzzle
{
    public sealed class AssemblerMinigame : MonoBehaviour
    {
        DrawingSlot[] _slots;
        DrawingPiece[] _drawings;

        #region UnityCallbacks
        private void Awake()
        {
            _slots = FindObjectsOfType<DrawingSlot>();
            _drawings = FindObjectsOfType<DrawingPiece>();

            /* SET IDs FOR SLOTS & DRAWINGS */
            //for(int  i = 0; i < _slots.Length; i++)
            //{
            //    _slots[i].SetId(i);
            //    _drawings[i].SetID(i);
            //}
        }

        private void Update()
        {
            if(_slots[0].Filled  && 
                _slots[1].Filled &&
                _slots[2].Filled &&
                _slots[3].Filled &&
                _slots[4].Filled &&
                _slots[5].Filled &&
                _slots[6].Filled &&
                _slots[7].Filled &&
                _slots[8].Filled &&
                _slots[9].Filled)
            {
                PlayerPrefs.SetInt("Puzzle", 1);
                StartCoroutine(Stanza3());         
            }

        }
        IEnumerator Stanza3()
        {
            yield return new WaitForSeconds(2);
            UIManager.instance.GoToCompletedKissPanel();
        }
        #endregion
    }
}