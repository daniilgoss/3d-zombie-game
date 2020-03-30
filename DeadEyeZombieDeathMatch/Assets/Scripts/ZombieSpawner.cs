using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour {

	public GameObject zombie;
	public float spawnDelay;
	public float minDelay;
	public float maxDelay;
	int numZombiesSpawned;
	int numZombiesAlive;
	public static int numZombiesKilled;
	int maxZombiesSpawned;
	public int zombieSpawnRate;
	public int initialSpawnCount;
	public bool stop;

	// Use this for initialization
	void Start () {
		maxZombiesSpawned = initialSpawnCount = 7;
		zombieSpawnRate = 6;
		minDelay = 1f;
		maxDelay = 8f;
		spawnDelay = 2f;
		StartCoroutine(Spawner());
	}
	
	// Update is called once per frame
	void Update () {
		spawnDelay = Random.Range(minDelay, maxDelay);
		numZombiesAlive = GameObject.FindGameObjectsWithTag("Enemy").Length;
		numZombiesKilled = numZombiesSpawned - numZombiesAlive;
		maxZombiesSpawned = (int) (numZombiesKilled / zombieSpawnRate) + initialSpawnCount;
	}

	float[] generateSpawnPoint() {
		int direction = Random.Range(0,2);
		float x = Random.Range(-80f, 85f);
		float y = 0;
		float z; 

		if (direction == 0) {
			z = Random.Range(60f, 90f);
		}
		else {
			z = Random.Range(-66f, -35f);
		}

		float[] coordinates = {x,y,z};
		return coordinates;
	}

	IEnumerator Spawner() {
		while (!stop) {
			// bool targetsStillExist = GameObject.FindGameObjectsWithTag("Target").Length != 0;
			bool targetsStillExist = false;

			if (targetsStillExist || numZombiesAlive >= maxZombiesSpawned) {}
			else {
				float[] coordinates = generateSpawnPoint();
				int x = 0;
				int y = 1;
				int z = 2;

				Vector3 spawnPoint = new Vector3(coordinates[x], coordinates[y], coordinates[z]);
				Instantiate(zombie, spawnPoint, gameObject.transform.rotation);
				numZombiesSpawned++;
			}

			yield return new WaitForSeconds(spawnDelay);
		}
	}
}
