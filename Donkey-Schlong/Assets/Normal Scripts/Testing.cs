using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class Testing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EntityManager entMan = World.Active.EntityManager;
        var ent =entMan.CreateEntity(typeof(Zombie_Comp));

        entMan.SetComponentData(ent, new Zombie_Comp { speed = 10, jumpHeight = 5 });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
