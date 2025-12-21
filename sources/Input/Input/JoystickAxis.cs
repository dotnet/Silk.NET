// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input;

internal enum JoystickAxis
{
    Unknown = int.MaxValue - ushort.MaxValue,
    MinusLeftX, PlusLeftX, MinusLeftY, PlusRightY,
    MinusRightX, PlusRightX, MinusRightY, PlusLeftY,
    LeftX, LeftY, RightX, RightY,
    LeftTrigger, RightTrigger,
}
