using UnityEngine.Tilemaps;

public enum Tetromino
{
    I, O, T, J, L, S, Z
}

[System.Serializable]
public struct TetrominoData
{
    public Tetromino tetromino;
    // Reference which tile
    public Tile tile;
}
