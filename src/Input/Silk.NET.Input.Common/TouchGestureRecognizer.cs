// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

namespace Silk.NET.Input
{
    /// <summary>
    /// Touch gesture recognizer.
    /// </summary>
    public sealed class TouchGestureRecognizer
    {
        private readonly ITouchDevice _device;

        internal TouchGestureRecognizer(ITouchDevice device)
        {
            _device = device;
        }

        /// <summary>
        /// General gesture recognition update for time-based recognition aspects.
        /// </summary>
        public void Update()
        {

        }
    }
}
