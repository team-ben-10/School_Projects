using Unity.Burst;
using System;
using System.Collections;

using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;
using static Unity.Mathematics.math;

public class Zombie_System : ComponentSystem
{
    // This declares a new kind of job, which is a unit of work to do.
    // The job is declared as an IJobForEach<Translation, Rotation>,
    // meaning it will process all entities in the world that have both
    // Translation and Rotation components. Change it to process the component
    // types you want.
    //
    // The job is also tagged with the BurstCompile attribute, which means
    // that the Burst compiler will optimize it for the best performance.
    protected override void OnUpdate()
    {
        Entities.ForEach((ref Zombie_Comp zomb) =>
        {
            zomb.speed += 1f * Time.deltaTime;
            Debug.Log(zomb.speed);
        });
    }
}