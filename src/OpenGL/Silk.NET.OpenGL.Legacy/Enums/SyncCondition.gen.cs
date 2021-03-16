// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


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
