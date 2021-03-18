// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "MemoryObjectParameterName")]
    public enum MemoryObjectParameterName : int
    {
        [NativeName("Name", "GL_DEDICATED_MEMORY_OBJECT_EXT")]
        DedicatedMemoryObjectExt = 0x9581,
        [NativeName("Name", "GL_PROTECTED_MEMORY_OBJECT_EXT")]
        ProtectedMemoryObjectExt = 0x959B,
    }
}
