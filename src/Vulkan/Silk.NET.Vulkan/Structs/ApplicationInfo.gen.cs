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
    [NativeName("Name", "VkApplicationInfo")]
    public unsafe partial struct ApplicationInfo : IChainStart
    {
        public ApplicationInfo
        (
            StructureType? sType = StructureType.ApplicationInfo,
            void* pNext = null,
            byte* pApplicationName = null,
            uint? applicationVersion = null,
            byte* pEngineName = null,
            uint? engineVersion = null,
            uint? apiVersion = null
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

            if (pApplicationName is not null)
            {
                PApplicationName = pApplicationName;
            }

            if (applicationVersion is not null)
            {
                ApplicationVersion = applicationVersion.Value;
            }

            if (pEngineName is not null)
            {
                PEngineName = pEngineName;
            }

            if (engineVersion is not null)
            {
                EngineVersion = engineVersion.Value;
            }

            if (apiVersion is not null)
            {
                ApiVersion = apiVersion.Value;
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
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "pApplicationName")]
        public byte* PApplicationName;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "applicationVersion")]
        public uint ApplicationVersion;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "pEngineName")]
        public byte* PEngineName;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "engineVersion")]
        public uint EngineVersion;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "apiVersion")]
        public uint ApiVersion;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.ApplicationInfo;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref ApplicationInfo Chain(
            out ApplicationInfo capture)
        {
            capture = new ApplicationInfo(StructureType.ApplicationInfo);
            return ref capture;
        }
    }
}
