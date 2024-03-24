// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input
{
    /// <summary>
    /// Controls the behavior of the double tap gesture tracking.
    /// </summary>
    public enum DoubleTapBehavior
    {
        /// <summary>
        /// Always emit the first tap as a single tap.
        /// </summary>
        EmitFirstSingleTap,

        /// <summary>
        /// Always emit the first and second tap as single taps.
        /// </summary>
        EmitBothSingleTaps,

        /// <summary>
        /// Do not emit single taps and wait for the double tap time to elapse.
        /// The first single tap is only emitted after the time has elapsed.
        /// </summary>
        WaitForDoubleTapTimeElapse
    }
}
