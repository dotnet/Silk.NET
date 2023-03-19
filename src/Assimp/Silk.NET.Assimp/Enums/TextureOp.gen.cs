// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiTextureOp")]
    public enum TextureOp : int
    {
        [Obsolete("Deprecated in favour of \"Multiply\"")]
        [NativeName("Name", "aiTextureOp_Multiply")]
        TextureOpMultiply = 0x0,
        [Obsolete("Deprecated in favour of \"Add\"")]
        [NativeName("Name", "aiTextureOp_Add")]
        TextureOpAdd = 0x1,
        [Obsolete("Deprecated in favour of \"Subtract\"")]
        [NativeName("Name", "aiTextureOp_Subtract")]
        TextureOpSubtract = 0x2,
        [Obsolete("Deprecated in favour of \"Divide\"")]
        [NativeName("Name", "aiTextureOp_Divide")]
        TextureOpDivide = 0x3,
        [Obsolete("Deprecated in favour of \"SmoothAdd\"")]
        [NativeName("Name", "aiTextureOp_SmoothAdd")]
        TextureOpSmoothAdd = 0x4,
        [Obsolete("Deprecated in favour of \"SignedAdd\"")]
        [NativeName("Name", "aiTextureOp_SignedAdd")]
        TextureOpSignedAdd = 0x5,
        [NativeName("Name", "aiTextureOp_Multiply")]
        Multiply = 0x0,
        [NativeName("Name", "aiTextureOp_Add")]
        Add = 0x1,
        [NativeName("Name", "aiTextureOp_Subtract")]
        Subtract = 0x2,
        [NativeName("Name", "aiTextureOp_Divide")]
        Divide = 0x3,
        [NativeName("Name", "aiTextureOp_SmoothAdd")]
        SmoothAdd = 0x4,
        [NativeName("Name", "aiTextureOp_SignedAdd")]
        SignedAdd = 0x5,
    }
}
