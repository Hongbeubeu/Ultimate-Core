﻿namespace Ultimate.Core.Runtime.TickManager
{
    public interface ITickable
    {
        int GetId();
        void OnTickableEnabled();
        void OnTickableDisabled();
        void OnTickableUpdated(float dt);
        void SetListIndex(int index);
        int GetListIndex();
    }
}