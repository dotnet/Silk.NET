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
    [NativeName("Name", "VkDebugUtilsMessengerCreateInfoEXT")]
    public unsafe partial struct DebugUtilsMessengerCreateInfoEXT : IExtendsChain<InstanceCreateInfo>
    {
        public DebugUtilsMessengerCreateInfoEXT
        (
            StructureType? sType = StructureType.DebugUtilsMessengerCreateInfoExt,
            void* pNext = null,
            uint? flags = null,
            DebugUtilsMessageSeverityFlagsEXT? messageSeverity = null,
            DebugUtilsMessageTypeFlagsEXT? messageType = null,
            PfnDebugUtilsMessengerCallbackEXT? pfnUserCallback = null,
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

            if (messageSeverity is not null)
            {
                MessageSeverity = messageSeverity.Value;
            }

            if (messageType is not null)
            {
                MessageType = messageType.Value;
            }

            if (pfnUserCallback is not null)
            {
                PfnUserCallback = pfnUserCallback.Value;
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
        [NativeName("Type", "VkDebugUtilsMessengerCreateFlagsEXT")]
        [NativeName("Type.Name", "VkDebugUtilsMessengerCreateFlagsEXT")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkDebugUtilsMessageSeverityFlagsEXT")]
        [NativeName("Type.Name", "VkDebugUtilsMessageSeverityFlagsEXT")]
        [NativeName("Name", "messageSeverity")]
        public DebugUtilsMessageSeverityFlagsEXT MessageSeverity;
/// <summary></summary>
        [NativeName("Type", "VkDebugUtilsMessageTypeFlagsEXT")]
        [NativeName("Type.Name", "VkDebugUtilsMessageTypeFlagsEXT")]
        [NativeName("Name", "messageType")]
        public DebugUtilsMessageTypeFlagsEXT MessageType;
/// <summary></summary>
        [NativeName("Type", "PFN_vkDebugUtilsMessengerCallbackEXT")]
        [NativeName("Type.Name", "PFN_vkDebugUtilsMessengerCallbackEXT")]
        [NativeName("Name", "pfnUserCallback")]
        public PfnDebugUtilsMessengerCallbackEXT PfnUserCallback;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pUserData")]
        public void* PUserData;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DebugUtilsMessengerCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
