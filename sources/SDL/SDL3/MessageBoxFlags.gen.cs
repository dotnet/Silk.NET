// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from SDL.h and corresponding dependencies of SDL3.
// Original source is Copyright (C) 1997-2024 Sam Lantinga. Licensed under the zlib license.
namespace Silk.NET.SDL;

[NativeTypeName("unsigned int")]
public enum MessageBoxFlags : uint
{
    Error = 0x00000010,
    Warning = 0x00000020,
    Information = 0x00000040,
    ButtonsLeftToRight = 0x00000080,
    ButtonsRightToLeft = 0x00000100,
}
