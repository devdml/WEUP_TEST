using Lean.Pool;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Enemy enemy;
    [SerializeField] List<Enemy> enemies;
    [SerializeField] int maxEnemy;
    [SerializeField] Pos pos;
    [SerializeField] float speed;
    [SerializeField] Transform hinhcnHolder;
    [SerializeField] Transform enemyHoder;

    void Start()
    {
        SpawnEnemy();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnHinhTG();
    }

    private void SpawnEnemy()
    {
        for (int i = 0; i < maxEnemy; i++)
        {
            Enemy enemi = LeanPool.Spawn(enemy, enemyHoder);
            enemies.Add(enemi);
            enemi.posType = (PosType)enemies.Count - 1;
        }
    }

    private void SpawnHinhVuong()
    {
        for (int i = 0; i < maxEnemy; i++)
        {
            LeanPool.Spawn(pos.pdata[i].hinhvuong, hinhcnHolder);
        }
    }

    private void SpawnHinhTG()
    {
        for (int i = 0; i < maxEnemy; i++)
        {
            LeanPool.Spawn(pos.pdata[i].hinhtamgiac, hinhcnHolder);
            enemies[i].transform.position = Vector2.MoveTowards(enemies[i].gameObject.transform.position, pos.pdata[i].hinhtamgiac.transform.position, speed * Time.deltaTime);
        }
    }

    private void MoveToPoint()
    {
        for (int i = 0; i < maxEnemy; i++)
        {
            if (enemies[i].posType == pos.pdata[i].PosType)
            {
                enemies[i].transform.position = Vector2.MoveTowards(enemies[i].gameObject.transform.position, pos.pdata[i].hinhvuong.transform.position, speed * Time.deltaTime);
            }
        }
    }
}
