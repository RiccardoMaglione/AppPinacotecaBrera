using UnityEngine;
namespace Brera.Minigames.AssemblerPuzzle
{
    public sealed class DrawingPiece : MonoBehaviour
    {
        bool _canMove = true;
        [SerializeField]int _id = 0;
        Rigidbody2D rb;

        public bool canMove => _canMove;
        public int id => _id;

        #region UnityCallbacks
        private void Awake()
        {
            rb = gameObject.GetComponent<Rigidbody2D>();
        }
        private void OnMouseDown()
        {
            EnablePhysic();
        }
        private void OnMouseDrag()
        {
            if (canMove)
            {
                gameObject.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10);
            }
        }
        #endregion

        /// <summary>
        /// Disable the drag operation for this object
        /// </summary>
        public void DisableMovement() => _canMove = false;
        /// <summary>
        /// Set the unique id to recognise the correct slot for this drawing - drawings & slot IDs must be the same
        /// </summary>
        /// <param name="x"></param>
        public void SetID(int x) => _id = x;
        public void DisablePhysic() => rb.simulated = false;
        void EnablePhysic() => rb.simulated = true;

    }
}