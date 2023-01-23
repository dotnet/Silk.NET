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
    [NativeName("Name", "VkPhysicalDeviceOpacityMicromapFeaturesEXT")]
    public unsafe partial struct PhysicalDeviceOpacityMicromapFeaturesEXT : IExtendsChain<PhysicalDeviceFeatures2>, IExtendsChain<PhysicalDeviceFeatures2KHR>, IExtendsChain<DeviceCreateInfo>
    {
        public PhysicalDeviceOpacityMicromapFeaturesEXT
        (
            StructureType? sType = StructureType.PhysicalDeviceOpacityMicromapFeaturesExt,
            void* pNext = null,
            Bool32? micromap = null,
            Bool32? micromapCaptureReplay = null,
            Bool32? micromapHostCommands = null
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

            if (micromap is not null)
            {
                Micromap = micromap.Value;
            }

            if (micromapCaptureReplay is not null)
            {
                MicromapCaptureReplay = micromapCaptureReplay.Value;
            }

            if (micromapHostCommands is not null)
            {
                MicromapHostCommands = micromapHostCommands.Value;
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
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "micromap")]
        public Bool32 Micromap;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "micromapCaptureReplay")]
        public Bool32 MicromapCaptureReplay;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "micromapHostCommands")]
        public Bool32 MicromapHostCommands;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.PhysicalDeviceOpacityMicromapFeaturesExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
