using UnityEngine;
using UnityEngine.Tilemaps;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject level01;
    [SerializeField] private TileBase[] levelTiles;
    [SerializeField] private Tilemap tilemap;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (level01 != null) Destroy(level01);
        tilemap = gameObject.AddComponent<Tilemap>();
        gameObject.AddComponent<TilemapRenderer>();

        tilemap.SetTile(new Vector3Int(0, 0, 0), levelTiles[0]);
    }
}
