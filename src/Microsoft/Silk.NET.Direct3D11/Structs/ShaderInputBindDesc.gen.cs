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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "_D3D11_SHADER_INPUT_BIND_DESC")]
    public unsafe partial struct ShaderInputBindDesc
    {
        public ShaderInputBindDesc
        (
            string* name = null,
            Silk.NET.Core.Native.D3DShaderInputType? type = null,
            uint? bindPoint = null,
            uint? bindCount = null,
            uint? uFlags = null,
            Silk.NET.Core.Native.D3DResourceReturnType? returnType = null,
            Silk.NET.Core.Native.D3DSrvDimension? dimension = null,
            uint? numSamples = null
        ) : this()
        {
            if (name is not null)
            {
                Name = name;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (bindPoint is not null)
            {
                BindPoint = bindPoint.Value;
            }

            if (bindCount is not null)
            {
                BindCount = bindCount.Value;
            }

            if (uFlags is not null)
            {
                UFlags = uFlags.Value;
            }

            if (returnType is not null)
            {
                ReturnType = returnType.Value;
            }

            if (dimension is not null)
            {
                Dimension = dimension.Value;
            }

            if (numSamples is not null)
            {
                NumSamples = numSamples.Value;
            }
        }


        [NativeName("Type", "LPCSTR")]
        [NativeName("Type.Name", "LPCSTR")]
        [NativeName("Name", "Name")]
        public string* Name;

        [NativeName("Type", "D3D_SHADER_INPUT_TYPE")]
        [NativeName("Type.Name", "D3D_SHADER_INPUT_TYPE")]
        [NativeName("Name", "Type")]
        public Silk.NET.Core.Native.D3DShaderInputType Type;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BindPoint")]
        public uint BindPoint;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BindCount")]
        public uint BindCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "uFlags")]
        public uint UFlags;

        [NativeName("Type", "D3D_RESOURCE_RETURN_TYPE")]
        [NativeName("Type.Name", "D3D_RESOURCE_RETURN_TYPE")]
        [NativeName("Name", "ReturnType")]
        public Silk.NET.Core.Native.D3DResourceReturnType ReturnType;

        [NativeName("Type", "D3D_SRV_DIMENSION")]
        [NativeName("Type.Name", "D3D_SRV_DIMENSION")]
        [NativeName("Name", "Dimension")]
        public Silk.NET.Core.Native.D3DSrvDimension Dimension;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumSamples")]
        public uint NumSamples;
    }
}
