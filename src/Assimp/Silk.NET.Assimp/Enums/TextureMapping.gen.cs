// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiTextureMapping")]
    public enum TextureMapping : int
    {
        [Obsolete("Deprecated in favour of \"UV\"")]
        [NativeName("Name", "aiTextureMapping_UV")]
        TextureMappingUV = 0x0,
        [Obsolete("Deprecated in favour of \"Sphere\"")]
        [NativeName("Name", "aiTextureMapping_SPHERE")]
        TextureMappingSphere = 0x1,
        [Obsolete("Deprecated in favour of \"Cylinder\"")]
        [NativeName("Name", "aiTextureMapping_CYLINDER")]
        TextureMappingCylinder = 0x2,
        [Obsolete("Deprecated in favour of \"Box\"")]
        [NativeName("Name", "aiTextureMapping_BOX")]
        TextureMappingBox = 0x3,
        [Obsolete("Deprecated in favour of \"Plane\"")]
        [NativeName("Name", "aiTextureMapping_PLANE")]
        TextureMappingPlane = 0x4,
        [Obsolete("Deprecated in favour of \"Other\"")]
        [NativeName("Name", "aiTextureMapping_OTHER")]
        TextureMappingOther = 0x5,
        [NativeName("Name", "aiTextureMapping_UV")]
        UV = 0x0,
        [NativeName("Name", "aiTextureMapping_SPHERE")]
        Sphere = 0x1,
        [NativeName("Name", "aiTextureMapping_CYLINDER")]
        Cylinder = 0x2,
        [NativeName("Name", "aiTextureMapping_BOX")]
        Box = 0x3,
        [NativeName("Name", "aiTextureMapping_PLANE")]
        Plane = 0x4,
        [NativeName("Name", "aiTextureMapping_OTHER")]
        Other = 0x5,
    }
}
