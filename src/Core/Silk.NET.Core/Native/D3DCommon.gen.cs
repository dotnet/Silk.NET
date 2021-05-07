// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Core.Native
{
    public unsafe partial class D3DCommon
    {
        [NativeName("Type", "int")]
        [NativeName("Name", "__REQUIRED_RPCNDR_H_VERSION__")]
        public const int RequiredRpcndrHVersion = unchecked((int) 0x1F4);
        [NativeName("Type", "int")]
        [NativeName("Name", "__REQUIRED_RPCSAL_H_VERSION__")]
        public const int RequiredRpcsalHVersion = unchecked((int) 0x64);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_REQ_TEXTURE1D_U_DIMENSION")]
        public const int D3DFL91ReqTexture1DUDimension = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_3_REQ_TEXTURE1D_U_DIMENSION")]
        public const int D3DFL93ReqTexture1DUDimension = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_REQ_TEXTURE2D_U_OR_V_DIMENSION")]
        public const int D3DFL91ReqTexture2DUOrVDimension = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_3_REQ_TEXTURE2D_U_OR_V_DIMENSION")]
        public const int D3DFL93ReqTexture2DUOrVDimension = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_REQ_TEXTURECUBE_DIMENSION")]
        public const int D3DFL91ReqTexturecubeDimension = unchecked((int) 0x200);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_3_REQ_TEXTURECUBE_DIMENSION")]
        public const int D3DFL93ReqTexturecubeDimension = unchecked((int) 0x1000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_REQ_TEXTURE3D_U_V_OR_W_DIMENSION")]
        public const int D3DFL91ReqTexture3DUVOrWDimension = unchecked((int) 0x100);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_DEFAULT_MAX_ANISOTROPY")]
        public const int D3DFL91DefaultMaxAnisotropy = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_IA_PRIMITIVE_MAX_COUNT")]
        public const int D3DFL91IAPrimitiveMaxCount = unchecked((int) 0xFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_2_IA_PRIMITIVE_MAX_COUNT")]
        public const int D3DFL92IAPrimitiveMaxCount = unchecked((int) 0xFFFFF);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_SIMULTANEOUS_RENDER_TARGET_COUNT")]
        public const int D3DFL91SimultaneousRenderTargetCount = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_3_SIMULTANEOUS_RENDER_TARGET_COUNT")]
        public const int D3DFL93SimultaneousRenderTargetCount = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_1_MAX_TEXTURE_REPEAT")]
        public const int D3DFL91MaxTextureRepeat = unchecked((int) 0x80);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_2_MAX_TEXTURE_REPEAT")]
        public const int D3DFL92MaxTextureRepeat = unchecked((int) 0x800);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_FL9_3_MAX_TEXTURE_REPEAT")]
        public const int D3DFL93MaxTextureRepeat = unchecked((int) 0x2000);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_COMPONENT_MASK_X")]
        public const int D3DComponentMaskX = unchecked((int) 0x1);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_COMPONENT_MASK_Y")]
        public const int D3DComponentMaskY = unchecked((int) 0x2);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_COMPONENT_MASK_Z")]
        public const int D3DComponentMaskZ = unchecked((int) 0x4);
        [NativeName("Type", "int")]
        [NativeName("Name", "D3D_COMPONENT_MASK_W")]
        public const int D3DComponentMaskW = unchecked((int) 0x8);

    }
}

