using UnityEngine;
using System.Collections.Generic;

public class ObjectController : MonoBehaviour
{
    [SerializeField] private GameObject cellPrefab;

    [SerializeField] private float enemyYPos;

    private BattleContext context;

    private List<GameObject> enemies = new List<GameObject>();

    public void SetData(BattleContext context)
    {
        this.context = context;
    }

    public GameObject CreateFieldGirdCell(FieldCell cell)
    {
        var go = Instantiate(cellPrefab);
        var pos = new Vector3(cell.X, 0, cell.Y) * context.FieldGrid.CellSize;
        go.transform.position = pos;
        return go;
    }

    public GameObject CreateEnemy(BattleEnemy enemy)
    {
        var pos = new Vector3(enemy.PosX, enemyYPos, enemy.PosY);
        var go = Instantiate(enemy.Data.enemyPrefab, pos, Quaternion.identity);
        enemies.Add(go);
        return go;
    }

    public GameObject CreatePiece(PieceData data)
    {
        var obj = Instantiate(data.piecePrefab);
        return obj;
    }
}
