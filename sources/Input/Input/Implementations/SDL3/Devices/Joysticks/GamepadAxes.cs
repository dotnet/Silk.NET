// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;
using System.Runtime.CompilerServices;

namespace Silk.NET.Input.SDL3.Devices.Joysticks;

internal static class GamepadAxes
{
    /// <summary>
    /// A simple helper to keep axis mapping consistent. It assumes the given vector was populated with a value range
    /// of [0, 1], and translates it to [-1, 1].
    ///
    /// For example, a thumbstick whose XY is (0.25, 0.25) will result in (-0.5, -0.5).
    /// In this library, we are assuming that +1 Y is UP.
    /// </summary>
    /// <param name="original">The original vector with values in the range [0, 1]</param>
    /// <returns>A vector with values remapped to the range [-1, 1]</returns>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
#if !DEBUG
    public static Vector2 JoystickAxesToThumbstick(Vector2 original) =>
        (original * new Vector2(2f, -2f)) + new Vector2(-1f, 1f);
#else
    public static Vector2 JoystickAxesToThumbstick(Vector2 original)
    {
        var ret = (original * new Vector2(2f, -2f)) + new Vector2(-1f, 1f);
        System.Diagnostics.Debug.Assert(!(ret.X < -1 || ret.Y < -1 || ret.X > 1 || ret.Y > 1), "Axes out of range");
        return ret;
    }
#endif
}
