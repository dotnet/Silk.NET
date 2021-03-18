// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "TextureStorageMaskAMD")]
    public enum TextureStorageMaskAMD : int
    {
        [NativeName("Name", "GL_TEXTURE_STORAGE_SPARSE_BIT_AMD")]
        TextureStorageSparseBitAmd = 0x1,
    }
}
