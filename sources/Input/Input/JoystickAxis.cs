// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.Input;

[OrderedIndexUsage]
internal enum JoystickAxis
{
    [OrderedIndexIgnore]
    Unknown = int.MaxValue - ushort.MaxValue,

    MinusLeftX, PlusLeftX, MinusLeftY, PlusRightY,
    MinusRightX, PlusRightX, MinusRightY, PlusLeftY,
    LeftX, LeftY, RightX, RightY,
    LeftTrigger, RightTrigger,
}
