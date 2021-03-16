// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "SyncCondition")]
    public enum SyncCondition : int
    {
        [NativeName("Name", "GL_SYNC_GPU_COMMANDS_COMPLETE")]
        SyncGpuCommandsComplete = 0x9117,
    }
}
