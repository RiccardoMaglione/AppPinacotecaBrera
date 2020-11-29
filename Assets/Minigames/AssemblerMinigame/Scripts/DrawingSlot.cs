using UnityEngine;
using DG.Tweening;
namespace Brera.Minigames.AssemblerPuzzle
{
    public sealed class DrawingSlot : MonoBehaviour
    {
        [SerializeField] int id;
        #region UnityCallbacks
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision)
            {
                var drawing = collision.gameObject.GetComponent<DrawingPiece>();
                if (drawing.id == id)
                {
                    drawing.DisableMovement();
                    drawing.DisablePhysic();
                    drawing.gameObject.transform.DOMove(gameObject.transform.position, 0.25f);
                    drawing.gameObject.transform.DOScale(gameObject.transform.localScale, 0.5f);
                }
            }
        }
        #endregion
        /// <summary>
        /// Set the unique id to recognise the drawing to connect - drawings & slot IDs must be the same
        /// </summary>
        /// <param name="x"></param>
        public void SetId(int x) => id = x;
    }
}