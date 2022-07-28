﻿namespace Meadow.Hardware
{
    /// <summary>
    /// Contract for devices capable of creating `ICounter` instances
    /// </summary>
    public interface ICounterController
    {
        public ICounter CreateCounter(
            IPin pin,
            InterruptMode edge);
    }
}