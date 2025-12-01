// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the OpenGL headers and corresponding dependencies.
// Original source is Copyright 2013-2020 The Khronos Group Inc. Licensed under the MIT license.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.OpenGL;

[NativeName("SyncParameterName")]
public enum SyncParameterName : uint
{
    [NativeName("GL_OBJECT_TYPE")]
    ObjectType = unchecked((uint)0x9112),

    [NativeName("GL_SYNC_CONDITION")]
    SyncCondition = unchecked((uint)0x9113),

    [NativeName("GL_SYNC_STATUS")]
    SyncStatus = unchecked((uint)0x9114),

    [NativeName("GL_SYNC_FLAGS")]
    SyncFlags = unchecked((uint)0x9115),
}
