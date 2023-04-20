using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceGem : MonoBehaviour,ICollectible
{
    public int experienceGranted;
   public void collect()
    {
        PlayerLevel player = FindObjectOfType<PlayerLevel>();
        player.IncreaseExperience(experienceGranted);
        Destroy(gameObject);
    }

    public void bluegemselfDestroy()
    {
        Destroy(gameObject);
    }
}
