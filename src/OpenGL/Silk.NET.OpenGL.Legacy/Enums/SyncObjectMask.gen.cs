// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "SyncObjectMask")]
    public enum SyncObjectMask : int
    {
        [NativeName("Name", "GL_SYNC_FLUSH_COMMANDS_BIT")]
        SyncFlushCommandsBit = 0x1,
        [NativeName("Name", "GL_SYNC_FLUSH_COMMANDS_BIT_APPLE")]
        SyncFlushCommandsBitApple = 0x1,
    }
}
