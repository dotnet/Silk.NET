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
    ObjectType = 37138,

    [NativeName("GL_SYNC_CONDITION")]
    SyncCondition = 37139,

    [NativeName("GL_SYNC_STATUS")]
    SyncStatus = 37140,

    [NativeName("GL_SYNC_FLAGS")]
    SyncFlags = 37141,
}
