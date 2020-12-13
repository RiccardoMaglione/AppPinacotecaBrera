using UnityEngine;

namespace Brera.Minigames.AssemblerPuzzle
{
    public class RingPiece : MonoBehaviour
    {
        public GameObject Touch;
        Vector3 _prevPos = Vector3.zero;
        Vector3 _lastPos = Vector3.zero;
        bool _canSnap = false;
        
        void RotateObject(float degs) => gameObject.transform.rotation *= Quaternion.Euler(0, 0, degs);


        private void OnMouseDown()
        {
            _canSnap = true;
            _prevPos = Input.mousePosition;
        }

        private void OnMouseUp()
        {
            if (_canSnap)
            {
                System.Threading.Thread.Sleep(500);
                _lastPos = Input.mousePosition;

                if (_prevPos.x < _lastPos.x)
                {
                    RotateObject(-45);
                    Touch.SetActive(false);
                    _canSnap = false;
                }
                
                else
                {
                    RotateObject(45);
                    Touch.SetActive(false);
                    _canSnap = false;
                }
            }
        }     
    }
}