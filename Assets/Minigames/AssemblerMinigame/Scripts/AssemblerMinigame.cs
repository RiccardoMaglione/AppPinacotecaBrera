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
        #endregion
    }
}