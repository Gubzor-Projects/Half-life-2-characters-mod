using UnityEngine;
using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using UnityEngine.Events;
using UmmAPI;

namespace Mod
{
    public class AlwaysGoodBloodFlow : MonoBehaviour
    {
        void Update()
        {
            transform.GetComponent<LimbBehaviour>().CirculationBehaviour.BloodFlow *= 1.5f;
            transform.GetComponent<LimbBehaviour>().CirculationBehaviour.InternalBleedingIntensity *= 0f;
            //transform.GetComponent<LimbBehaviour>().CirculationBehaviour.StabWoundCount = (ushort)0;
            //transform.GetComponent<LimbBehaviour>().CirculationBehaviour.GunshotWoundCount = (ushort)0;
            //transform.GetComponent<LimbBehaviour>().Person.Consciousness = Mathf.Infinity;
            //transform.GetComponent<LimbBehaviour>().CirculationBehaviour.AddLiquid(transform.GetComponent<LimbBehaviour>().GetOriginalBloodType(), Mathf.Infinity);
        }
    }
}
