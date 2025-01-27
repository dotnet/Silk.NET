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
    [NativeName("Name", "D3D12_SHADER_RESOURCE_VIEW_DESC")]
    public unsafe partial struct ShaderResourceViewDesc
    {
        public ShaderResourceViewDesc
        (
            Silk.NET.DXGI.Format? format = null,
            SrvDimension? viewDimension = null,
            uint? shader4ComponentMapping = null,
            ShaderResourceViewDescUnion? anonymous = null,
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
            if (format is not null)
            {
                Format = format.Value;
            }

            if (viewDimension is not null)
            {
                ViewDimension = viewDimension.Value;
            }

            if (shader4ComponentMapping is not null)
            {
                Shader4ComponentMapping = shader4ComponentMapping.Value;
            }

            if (anonymous is not null)
            {
                Anonymous = anonymous.Value;
            }

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


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "D3D12_SRV_DIMENSION")]
        [NativeName("Type.Name", "D3D12_SRV_DIMENSION")]
        [NativeName("Name", "ViewDimension")]
        public SrvDimension ViewDimension;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "Shader4ComponentMapping")]
        public uint Shader4ComponentMapping;

        [NativeName("Type", "")]
        [NativeName("Type.Name", "__AnonymousRecord_d3d12_L3426_C5")]
        [NativeName("Name", "anonymous1")]
        public ShaderResourceViewDescUnion Anonymous;
#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref BufferSrv Buffer
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Buffer;
        }
#else
        public BufferSrv Buffer
        {
            get => Anonymous.Buffer;
            set => Anonymous.Buffer = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex1DSrv Texture1D
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture1D;
        }
#else
        public Tex1DSrv Texture1D
        {
            get => Anonymous.Texture1D;
            set => Anonymous.Texture1D = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex1DArraySrv Texture1DArray
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture1DArray;
        }
#else
        public Tex1DArraySrv Texture1DArray
        {
            get => Anonymous.Texture1DArray;
            set => Anonymous.Texture1DArray = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex2DSrv Texture2D
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture2D;
        }
#else
        public Tex2DSrv Texture2D
        {
            get => Anonymous.Texture2D;
            set => Anonymous.Texture2D = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex2DArraySrv Texture2DArray
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture2DArray;
        }
#else
        public Tex2DArraySrv Texture2DArray
        {
            get => Anonymous.Texture2DArray;
            set => Anonymous.Texture2DArray = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex2DmsSrv Texture2DMS
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture2DMS;
        }
#else
        public Tex2DmsSrv Texture2DMS
        {
            get => Anonymous.Texture2DMS;
            set => Anonymous.Texture2DMS = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex2DmsArraySrv Texture2DMSArray
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture2DMSArray;
        }
#else
        public Tex2DmsArraySrv Texture2DMSArray
        {
            get => Anonymous.Texture2DMSArray;
            set => Anonymous.Texture2DMSArray = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref Tex3DSrv Texture3D
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].Texture3D;
        }
#else
        public Tex3DSrv Texture3D
        {
            get => Anonymous.Texture3D;
            set => Anonymous.Texture3D = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref TexcubeSrv TextureCube
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].TextureCube;
        }
#else
        public TexcubeSrv TextureCube
        {
            get => Anonymous.TextureCube;
            set => Anonymous.TextureCube = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref TexcubeArraySrv TextureCubeArray
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].TextureCubeArray;
        }
#else
        public TexcubeArraySrv TextureCubeArray
        {
            get => Anonymous.TextureCubeArray;
            set => Anonymous.TextureCubeArray = value;
        }
#endif

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
        public ref RaytracingAccelerationStructureSrv RaytracingAccelerationStructure
        {
            [MethodImpl((MethodImplOptions) 768)]
            get => ref MemoryMarshal.CreateSpan(ref Anonymous, 1)[0].RaytracingAccelerationStructure;
        }
#else
        public RaytracingAccelerationStructureSrv RaytracingAccelerationStructure
        {
            get => Anonymous.RaytracingAccelerationStructure;
            set => Anonymous.RaytracingAccelerationStructure = value;
        }
#endif

    }
}
