// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input;

internal enum JoystickAxis
{
    Unknown = JoystickButton.Unknown,
    MinusLeftX, PlusLeftX, MinusLeftY, PlusRightY,
    MinusRightX, PlusRightX, MinusRightY, PlusLeftY,
    LeftX, LeftY, RightX, RightY,
    LeftTrigger, RightTrigger,
}
