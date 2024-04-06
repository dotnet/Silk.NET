// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL Core Profile headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[Transformed]
public enum FramebufferStatus
{
    Undefined = 0x8219,
    Complete = 0x8CD5,
    IncompleteAttachment = 0x8CD6,
    IncompleteMissingAttachment = 0x8CD7,
    IncompleteDrawBuffer = 0x8CDB,
    IncompleteReadBuffer = 0x8CDC,
    Unsupported = 0x8CDD,
    IncompleteMultisample = 0x8D56,
    IncompleteLayerTargets = 0x8DA8
}
