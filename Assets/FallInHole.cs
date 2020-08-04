using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class FallInHole : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      // if player goes past the left edge, destroy it
      if (transform.position.y < -2) {
        LevelGenerator.level = 0;
        SceneManager.LoadScene("Game Over");
      }
    }
}
