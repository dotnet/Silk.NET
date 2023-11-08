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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkCudaLaunchInfoNV")]
    public unsafe partial struct CudaLaunchInfoNV : IChainable
    {
        public CudaLaunchInfoNV
        (
            StructureType? sType = StructureType.CudaLaunchInfoNV,
            void* pNext = null,
            CudaFunctionNV? function = null,
            uint? gridDimX = null,
            uint? gridDimY = null,
            uint? gridDimZ = null,
            uint? blockDimX = null,
            uint? blockDimY = null,
            uint? blockDimZ = null,
            uint? sharedMemBytes = null,
            nuint? paramCount = null,
            void* pParams = null,
            nuint? extraCount = null,
            void* pExtras = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (function is not null)
            {
                Function = function.Value;
            }

            if (gridDimX is not null)
            {
                GridDimX = gridDimX.Value;
            }

            if (gridDimY is not null)
            {
                GridDimY = gridDimY.Value;
            }

            if (gridDimZ is not null)
            {
                GridDimZ = gridDimZ.Value;
            }

            if (blockDimX is not null)
            {
                BlockDimX = blockDimX.Value;
            }

            if (blockDimY is not null)
            {
                BlockDimY = blockDimY.Value;
            }

            if (blockDimZ is not null)
            {
                BlockDimZ = blockDimZ.Value;
            }

            if (sharedMemBytes is not null)
            {
                SharedMemBytes = sharedMemBytes.Value;
            }

            if (paramCount is not null)
            {
                ParamCount = paramCount.Value;
            }

            if (pParams is not null)
            {
                PParams = pParams;
            }

            if (extraCount is not null)
            {
                ExtraCount = extraCount.Value;
            }

            if (pExtras is not null)
            {
                PExtras = pExtras;
            }
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkCudaFunctionNV")]
        [NativeName("Type.Name", "VkCudaFunctionNV")]
        [NativeName("Name", "function")]
        public CudaFunctionNV Function;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "gridDimX")]
        public uint GridDimX;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "gridDimY")]
        public uint GridDimY;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "gridDimZ")]
        public uint GridDimZ;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "blockDimX")]
        public uint BlockDimX;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "blockDimY")]
        public uint BlockDimY;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "blockDimZ")]
        public uint BlockDimZ;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sharedMemBytes")]
        public uint SharedMemBytes;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "paramCount")]
        public nuint ParamCount;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pParams")]
        public void* PParams;
/// <summary></summary>
        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "extraCount")]
        public nuint ExtraCount;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pExtras")]
        public void* PExtras;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.CudaLaunchInfoNV;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
