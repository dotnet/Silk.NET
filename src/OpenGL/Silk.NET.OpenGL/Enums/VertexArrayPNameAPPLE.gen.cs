// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "VertexArrayPNameAPPLE")]
    public enum VertexArrayPNameAPPLE : int
    {
        [NativeName("Name", "GL_STORAGE_CLIENT_APPLE")]
        StorageClientApple = 0x85B4,
        [NativeName("Name", "GL_STORAGE_CACHED_APPLE")]
        StorageCachedApple = 0x85BE,
        [NativeName("Name", "GL_STORAGE_SHARED_APPLE")]
        StorageSharedApple = 0x85BF,
    }
}
