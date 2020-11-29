using UnityEngine;
using DG.Tweening;

namespace Brera.Minigames.AssemblerPuzzle
{
    public class RingPiece : MonoBehaviour
    {
        Vector3 direction = Vector3.zero;
        Vector3 _prevPos = Vector3.zero;
        Vector3 _lastPos = Vector3.zero;
        bool _canSnap = false;




        private void OnMouseDown()
        {
            _canSnap = true;
            _prevPos = Input.mousePosition;

            //Debug.LogError("VERO");
        }
        public void OnMouseDrag()
        {

            if (_canSnap)
            {
                System.Threading.Thread.Sleep(500);
                _lastPos = Input.mousePosition;

                //Debug.LogError($"direction : {(_lastPos - _prevPos).normalized}");

                if (_prevPos.x < _lastPos.x || _prevPos.y < _lastPos.y)
                {
                    RotateObject(-45);
                    //Debug.LogWarning("LEFT");
                    _canSnap = false;

                }
                else
                {
                    RotateObject(45);
                    //Debug.LogWarning("RIGHT");
                    _canSnap = false;

                }
            }
        }

        private void Update()
        {
            //if (Input.GetMouseButtonDown(0)) RotateObject(45);
            //if (Input.GetMouseButtonDown(1)) RotateObject(-45);


        }

        void RotateObject(float degs) => gameObject.transform.rotation *= Quaternion.Euler(0, 0, degs);
    }
}