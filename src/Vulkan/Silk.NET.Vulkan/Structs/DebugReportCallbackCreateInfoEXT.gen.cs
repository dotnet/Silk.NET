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
    [NativeName("Name", "VkDebugReportCallbackCreateInfoEXT")]
    public unsafe partial struct DebugReportCallbackCreateInfoEXT : IExtendsChain<InstanceCreateInfo>
    {
        public DebugReportCallbackCreateInfoEXT
        (
            StructureType? sType = StructureType.DebugReportCallbackCreateInfoExt,
            void* pNext = null,
            DebugReportFlagsEXT? flags = null,
            PfnDebugReportCallbackEXT? pfnCallback = null,
            void* pUserData = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pfnCallback is not null)
            {
                PfnCallback = pfnCallback.Value;
            }

            if (pUserData is not null)
            {
                PUserData = pUserData;
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
        [NativeName("Type", "VkDebugReportFlagsEXT")]
        [NativeName("Type.Name", "VkDebugReportFlagsEXT")]
        [NativeName("Name", "flags")]
        public DebugReportFlagsEXT Flags;
/// <summary></summary>
        [NativeName("Type", "PFN_vkDebugReportCallbackEXT")]
        [NativeName("Type.Name", "PFN_vkDebugReportCallbackEXT")]
        [NativeName("Name", "pfnCallback")]
        public PfnDebugReportCallbackEXT PfnCallback;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pUserData")]
        public void* PUserData;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DebugReportCallbackCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
