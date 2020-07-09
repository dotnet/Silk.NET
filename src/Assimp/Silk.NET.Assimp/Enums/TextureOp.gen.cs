// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiTextureOp")]
    public enum TextureOp
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
        [NativeName("Name", "_aiTextureOp_Force32Bit")]
        aiTextureOpForce32Bit = 0x7FFFFFFF,
    }
}
