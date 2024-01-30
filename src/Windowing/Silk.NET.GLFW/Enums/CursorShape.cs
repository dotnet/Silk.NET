// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.GLFW
{
    /// <summary>
    /// Standard cursor shapes.
    /// </summary>
    public enum CursorShape
    {
        /// <summary>
        /// The standard arrow shape. Used in almost all situations.
        /// </summary>
        Arrow = 0x00036001,

        /// <summary>
        /// The I-Beam shape. Used when mousing over a place where text can be entered.
        /// </summary>
        IBeam = 0x00036002,

        /// <summary>
        /// The crosshair shape. Used when dragging and dropping.
        /// </summary>
        Crosshair = 0x00036003,

        /// <summary>
        /// The hand shape. Used when mousing over something that can be dragged around.
        /// </summary>
        Hand = 0x00036004,

        /// <summary>
        /// The horizontal resize shape. Used when mousing over something that can be horizontally resized.
        /// </summary>
        HResize = 0x00036005,

        /// <summary>
        /// The vertical resize shape. Used when mousing over something that can be vertically resized.
        /// </summary>
        VResize = 0x00036006,

        /// <summary>
        /// The top-left to bottom-right diagonal resize/move arrow shape.
        /// </summary>
        NwseResize = 0x00036007,

        /// <summary>
        /// The top-right to bottom-left diagonal resize/move arrow shape.
        /// </summary>
        NeswResize = 0x00036008,

        /// <summary>
        /// The omni-directional resize/move cursor shape.
        /// </summary>
        AllResize = 0x00036009,

        /// <summary>
        /// The operation-not-allowed shape.
        /// </summary>
        NotAllowed = 0x0003600A
    }
}
