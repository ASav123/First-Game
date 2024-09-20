using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    //Ghost prefab
    [SerializeField]
    private GameObject[] monsterReferance;
    private GameObject spawnedMonster;

    // Spawn positions
    [SerializeField]
    private Transform leftPos, rightPos, upPos, downPos;

    private int randomIndex;
    private int randomSide;

    //Levels of game
    private int wave;
    private int repeat;
    private float delay;

    //Scripts
    public Lives livesScript;
    public Scenes scenesScript;

    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        wave = 1;
        StartCoroutine(SpawnMonsters());
        
    }

    IEnumerator SpawnMonsters()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);

            //Sets difficulty of spawner
            if (wave == 1)
            {
                repeat = 5;
                delay = 2;
            }
            else if (wave == 2)
            {
                repeat = 8;
                delay = 1;
            }
            else if (wave == 3)
            {
                repeat = 12;
                delay = 0.5f;
            }
            else if (wave == 4)
            {
                repeat = 14;
                delay = 0.4f;
            }
            else if (wave == 5)
            {
                repeat = 16;
                delay = 0.3f;
            }
            else if (wave == 6)
            {
                yield return new WaitForSeconds(3);
                repeat = 10;
                delay = 0.2f;
            }
            else
            {
                break;
            }

            //Spawns ghosts for each wave
            for( int i = repeat; i > 0; i--)
            {


                yield return new WaitForSeconds(delay);

                randomSide = Random.Range(0, 4);

                spawnedMonster = Instantiate(monsterReferance[0]);

                if (randomSide == 0)
                {
                    spawnedMonster.transform.position = leftPos.position;
                    spawnedMonster.GetComponent<Ghost>().speedX = Random.Range(1, 2);
                    float speedY = Random.Range(-1, 1);
                    spawnedMonster.GetComponent<Ghost>().speedY = 0;
                }

                else if (randomSide == 1)
                {
                    spawnedMonster.transform.position = rightPos.position;
                    spawnedMonster.GetComponent<Ghost>().speedX = -Random.Range(1, 2);
                    float speedX = Random.Range(-1, 1);
                    spawnedMonster.GetComponent<Ghost>().speedY = 0;
                }
                else if (randomSide == 2)
                {
                    spawnedMonster.transform.position = upPos.position;
                    spawnedMonster.GetComponent<Ghost>().speedX = 0;
                    float speedY = Random.Range(-1, 1);
                    spawnedMonster.GetComponent<Ghost>().speedY = -Random.Range(1, 2);
                }
                else
                {
                    spawnedMonster.transform.position = downPos.position;
                    spawnedMonster.GetComponent<Ghost>().speedX = 0;
                    float speedY = Random.Range(-1, 1);
                    spawnedMonster.GetComponent<Ghost>().speedY = Random.Range(1, 2);
                }
            }
            
            // Game wins if player survives all waves
            if (wave == 6)
            {
                yield return new WaitForSeconds(4);
                scenesScript.PlayerWin();
                break;
            }

            wave++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
