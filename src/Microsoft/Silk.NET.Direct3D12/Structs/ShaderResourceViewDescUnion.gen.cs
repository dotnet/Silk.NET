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

namespace Silk.NET.Direct3D12
{
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L3426_C5")]
    public unsafe partial struct ShaderResourceViewDescUnion
    {
        public ShaderResourceViewDescUnion
        (
            BufferSrv? buffer = null,
            Tex1DSrv? texture1D = null,
            Tex1DArraySrv? texture1DArray = null,
            Tex2DSrv? texture2D = null,
            Tex2DArraySrv? texture2DArray = null,
            Tex2DmsSrv? texture2DMS = null,
            Tex2DmsArraySrv? texture2DMSArray = null,
            Tex3DSrv? texture3D = null,
            TexcubeSrv? textureCube = null,
            TexcubeArraySrv? textureCubeArray = null,
            RaytracingAccelerationStructureSrv? raytracingAccelerationStructure = null
        ) : this()
        {
            if (buffer is not null)
            {
                Buffer = buffer.Value;
            }

            if (texture1D is not null)
            {
                Texture1D = texture1D.Value;
            }

            if (texture1DArray is not null)
            {
                Texture1DArray = texture1DArray.Value;
            }

            if (texture2D is not null)
            {
                Texture2D = texture2D.Value;
            }

            if (texture2DArray is not null)
            {
                Texture2DArray = texture2DArray.Value;
            }

            if (texture2DMS is not null)
            {
                Texture2DMS = texture2DMS.Value;
            }

            if (texture2DMSArray is not null)
            {
                Texture2DMSArray = texture2DMSArray.Value;
            }

            if (texture3D is not null)
            {
                Texture3D = texture3D.Value;
            }

            if (textureCube is not null)
            {
                TextureCube = textureCube.Value;
            }

            if (textureCubeArray is not null)
            {
                TextureCubeArray = textureCubeArray.Value;
            }

            if (raytracingAccelerationStructure is not null)
            {
                RaytracingAccelerationStructure = raytracingAccelerationStructure.Value;
            }
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_BUFFER_SRV")]
        [NativeName("Type.Name", "D3D12_BUFFER_SRV")]
        [NativeName("Name", "Buffer")]
        public BufferSrv Buffer;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX1D_SRV")]
        [NativeName("Type.Name", "D3D12_TEX1D_SRV")]
        [NativeName("Name", "Texture1D")]
        public Tex1DSrv Texture1D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX1D_ARRAY_SRV")]
        [NativeName("Type.Name", "D3D12_TEX1D_ARRAY_SRV")]
        [NativeName("Name", "Texture1DArray")]
        public Tex1DArraySrv Texture1DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX2D_SRV")]
        [NativeName("Type.Name", "D3D12_TEX2D_SRV")]
        [NativeName("Name", "Texture2D")]
        public Tex2DSrv Texture2D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX2D_ARRAY_SRV")]
        [NativeName("Type.Name", "D3D12_TEX2D_ARRAY_SRV")]
        [NativeName("Name", "Texture2DArray")]
        public Tex2DArraySrv Texture2DArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX2DMS_SRV")]
        [NativeName("Type.Name", "D3D12_TEX2DMS_SRV")]
        [NativeName("Name", "Texture2DMS")]
        public Tex2DmsSrv Texture2DMS;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX2DMS_ARRAY_SRV")]
        [NativeName("Type.Name", "D3D12_TEX2DMS_ARRAY_SRV")]
        [NativeName("Name", "Texture2DMSArray")]
        public Tex2DmsArraySrv Texture2DMSArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEX3D_SRV")]
        [NativeName("Type.Name", "D3D12_TEX3D_SRV")]
        [NativeName("Name", "Texture3D")]
        public Tex3DSrv Texture3D;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEXCUBE_SRV")]
        [NativeName("Type.Name", "D3D12_TEXCUBE_SRV")]
        [NativeName("Name", "TextureCube")]
        public TexcubeSrv TextureCube;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_TEXCUBE_ARRAY_SRV")]
        [NativeName("Type.Name", "D3D12_TEXCUBE_ARRAY_SRV")]
        [NativeName("Name", "TextureCubeArray")]
        public TexcubeArraySrv TextureCubeArray;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV")]
        [NativeName("Type.Name", "D3D12_RAYTRACING_ACCELERATION_STRUCTURE_SRV")]
        [NativeName("Name", "RaytracingAccelerationStructure")]
        public RaytracingAccelerationStructureSrv RaytracingAccelerationStructure;
    }
}
