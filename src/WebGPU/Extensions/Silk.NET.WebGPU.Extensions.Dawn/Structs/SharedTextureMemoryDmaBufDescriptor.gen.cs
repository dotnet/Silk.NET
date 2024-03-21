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

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUSharedTextureMemoryDmaBufDescriptor")]
    public unsafe partial struct SharedTextureMemoryDmaBufDescriptor
    {
        public SharedTextureMemoryDmaBufDescriptor
        (
            ChainedStruct? chain = null,
            Extent3D? size = null,
            uint? drmFormat = null,
            ulong? drmModifier = null,
            nuint? planeCount = null,
            SharedTextureMemoryDmaBufPlane* planes = null
        ) : this()
        {
            if (chain is not null)
            {
                Chain = chain.Value;
            }

            if (size is not null)
            {
                Size = size.Value;
            }

            if (drmFormat is not null)
            {
                DrmFormat = drmFormat.Value;
            }

            if (drmModifier is not null)
            {
                DrmModifier = drmModifier.Value;
            }

            if (planeCount is not null)
            {
                PlaneCount = planeCount.Value;
            }

            if (planes is not null)
            {
                Planes = planes;
            }
        }


        [NativeName("Type", "WGPUChainedStruct")]
        [NativeName("Type.Name", "WGPUChainedStruct")]
        [NativeName("Name", "chain")]
        public ChainedStruct Chain;

        [NativeName("Type", "WGPUExtent3D")]
        [NativeName("Type.Name", "WGPUExtent3D")]
        [NativeName("Name", "size")]
        public Extent3D Size;

        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "drmFormat")]
        public uint DrmFormat;

        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "drmModifier")]
        public ulong DrmModifier;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "planeCount")]
        public nuint PlaneCount;

        [NativeName("Type", "const WGPUSharedTextureMemoryDmaBufPlane *")]
        [NativeName("Type.Name", "const WGPUSharedTextureMemoryDmaBufPlane *")]
        [NativeName("Name", "planes")]
        public SharedTextureMemoryDmaBufPlane* Planes;
    }
}
