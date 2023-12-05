using UnityEngine;

namespace HexMap
{
    public class Grid : MonoBehaviour
    {
        [SerializeField]
        private int _width = 6;
        [SerializeField]
        private int _height = 6;

        [SerializeField]
        private Cell _cellPrefab;

        public int Width => _width;
        public int Height => _height;
        public Cell CellPrefab => _cellPrefab;

    }
}
