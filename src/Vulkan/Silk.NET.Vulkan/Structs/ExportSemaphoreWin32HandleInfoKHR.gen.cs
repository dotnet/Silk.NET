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
    [NativeName("Name", "VkExportSemaphoreWin32HandleInfoKHR")]
    public unsafe partial struct ExportSemaphoreWin32HandleInfoKHR : IExtendsChain<SemaphoreCreateInfo>
    {
        public ExportSemaphoreWin32HandleInfoKHR
        (
            StructureType? sType = StructureType.ExportSemaphoreWin32HandleInfoKhr,
            void* pNext = null,
            nint* pAttributes = null,
            uint? dwAccess = null,
            nint? name = null
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

            if (pAttributes is not null)
            {
                PAttributes = pAttributes;
            }

            if (dwAccess is not null)
            {
                DwAccess = dwAccess.Value;
            }

            if (name is not null)
            {
                Name = name.Value;
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
        [NativeName("Type", "SECURITY_ATTRIBUTES*")]
        [NativeName("Type.Name", "SECURITY_ATTRIBUTES")]
        [NativeName("Name", "pAttributes")]
        public nint* PAttributes;
/// <summary></summary>
        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "dwAccess")]
        public uint DwAccess;
/// <summary></summary>
        [NativeName("Type", "LPCWSTR")]
        [NativeName("Type.Name", "LPCWSTR")]
        [NativeName("Name", "name")]
        public nint Name;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ExportSemaphoreWin32HandleInfoKhr;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
