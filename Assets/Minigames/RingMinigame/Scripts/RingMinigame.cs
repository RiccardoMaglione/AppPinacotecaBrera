using UnityEngine;
namespace Brera.Minigames.AssemblerPuzzle
{
    public sealed class RingMinigame : MonoBehaviour
    {
        public GameObject[] _pieces;
        Quaternion[] rotations;

        private void Start()
        {
            rotations = new Quaternion[_pieces.Length];

            for(int i = 0; i < _pieces.Length; i++)
            {
                rotations[i] = _pieces[i].transform.rotation;
            }

            /* Randomize Rotations */
            Quaternion[] rots = { Quaternion.Euler(0, 0, 45), Quaternion.Euler(0, 0, 90), Quaternion.Euler(0, 0, 180), Quaternion.Euler(0, 0, 270) };
            foreach(var item in _pieces)
            {
                item.transform.rotation = rots[Random.Range(0, rots.Length)];
            }


        }
        private void Update()
        {
            _pieces[0].GetComponent<SpriteRenderer>().color = _pieces[0].transform.rotation == Quaternion.Euler(0,0,0) || _pieces[0].transform.rotation == Quaternion.Euler(0,0,360) ? _pieces[0].GetComponent<SpriteRenderer>().color = Color.green : _pieces[0].GetComponent<SpriteRenderer>().color = Color.red;
            _pieces[1].GetComponent<SpriteRenderer>().color = _pieces[1].transform.rotation == Quaternion.Euler(0,0,0) || _pieces[1].transform.rotation == Quaternion.Euler(0,0,360) ? _pieces[1].GetComponent<SpriteRenderer>().color = Color.green : _pieces[1].GetComponent<SpriteRenderer>().color = Color.red;
            _pieces[2].GetComponent<SpriteRenderer>().color = _pieces[2].transform.rotation == Quaternion.Euler(0,0,0) || _pieces[2].transform.rotation == Quaternion.Euler(0,0,360) ? _pieces[2].GetComponent<SpriteRenderer>().color = Color.green : _pieces[2].GetComponent<SpriteRenderer>().color = Color.red;
        }


    }
}
