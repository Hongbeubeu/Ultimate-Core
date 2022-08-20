using UnityEngine;
using System.Collections;

namespace Ultimate.Core.Runtime.Pool
{
    public interface IFastPoolItem
    {
        void OnFastInstantiate();
        void OnFastDestroy();
    }
}