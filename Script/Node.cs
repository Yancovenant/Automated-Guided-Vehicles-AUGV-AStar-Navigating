/**
* === Node.cs ===
* Represents a single grid cell in the grid system.
*/
using UnityEngine;

public class Node {
    public bool walkable;
    public Vector3 worldPosition;
    public int gridX, gridY;

    public Node(bool _walkable, Vector3 _worldPos, int _x, int _y) {
        walkable = _walkable;
        worldPosition = _worldPos;
        gridX = _x;
        gridY = _y;
    }
}
