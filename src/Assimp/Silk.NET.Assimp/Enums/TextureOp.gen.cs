// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [Flags]
    [NativeName("Name", "aiTextureOp")]
    public enum TextureOp : int
    {
        [NativeName("Name", "aiTextureOp_Multiply")]
        TextureOpMultiply = 0x0,
        [NativeName("Name", "aiTextureOp_Add")]
        TextureOpAdd = 0x1,
        [NativeName("Name", "aiTextureOp_Subtract")]
        TextureOpSubtract = 0x2,
        [NativeName("Name", "aiTextureOp_Divide")]
        TextureOpDivide = 0x3,
        [NativeName("Name", "aiTextureOp_SmoothAdd")]
        TextureOpSmoothAdd = 0x4,
        [NativeName("Name", "aiTextureOp_SignedAdd")]
        TextureOpSignedAdd = 0x5,
    }
}
