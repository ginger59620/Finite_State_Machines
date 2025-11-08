using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public sealed class GameEnviromnent
{
    public static GameEnviromnent instance;
    private List<GameObject> checkpoints = new List<GameObject>();
    public List<GameObject> Checkpoints { get { return checkpoints; } }

   public static GameEnviromnent Singleton
    {
        get
        {
            if(instance == null)
            {
                instance = new GameEnviromnent();
                instance.Checkpoints.AddRange(GameObject.FindGameObjectsWithTag("Checkpoint"));

                instance.checkpoints = instance.checkpoints.OrderBy(waypoiny => waypoiny.name).ToList();
            }
            return instance;
        }
    }
}
