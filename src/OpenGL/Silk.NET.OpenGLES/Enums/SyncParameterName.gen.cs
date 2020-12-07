// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "SyncParameterName")]
    public enum SyncParameterName
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
