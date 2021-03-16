// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "SyncParameterName")]
    public enum SyncParameterName : int
    {
        [NativeName("Name", "GL_OBJECT_TYPE")]
        ObjectType = 0x9112,
        [NativeName("Name", "GL_SYNC_CONDITION")]
        SyncCondition = 0x9113,
        [NativeName("Name", "GL_SYNC_STATUS")]
        SyncStatus = 0x9114,
        [NativeName("Name", "GL_SYNC_FLAGS")]
        SyncFlags = 0x9115,
    }
}
