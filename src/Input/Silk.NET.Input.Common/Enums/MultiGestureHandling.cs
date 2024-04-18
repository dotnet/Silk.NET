// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input
{
    /// <summary>
    /// Controls the behavior of how multiple two-finger gestures are handled.
    /// </summary>
    public enum MultiGestureHandling
    {
        /// <summary>
        /// Only recognize the zoom gesture if both the zoom and the rotate gesture are performed.
        /// </summary>
        PrioritizeZoomGesture,

        /// <summary>
        /// Only recognize the rotate gesture if both the zoom and the rotate gesture are performed.
        /// </summary>
        PrioritizeRotateGesture,

        /// <summary>
        /// Recognize both gestures if they are performed (zoom and rotate).
        /// </summary>
        RecognizeBothGestures
    }
}
