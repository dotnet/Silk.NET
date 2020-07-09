// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDebugUtilsMessengerCreateInfoEXT")]
    public unsafe struct DebugUtilsMessengerCreateInfoEXT
    {
        public DebugUtilsMessengerCreateInfoEXT
        (
            StructureType sType = StructureType.DebugUtilsMessengerCreateInfoExt,
            void* pNext = default,
            uint flags = default,
            DebugUtilsMessageSeverityFlagsEXT messageSeverity = default,
            DebugUtilsMessageTypeFlagsEXT messageType = default,
            FuncPtr pfnUserCallback = default,
            void* pUserData = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           MessageSeverity = messageSeverity;
           MessageType = messageType;
           PfnUserCallback = pfnUserCallback;
           PUserData = pUserData;
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
        public FuncPtr PfnUserCallback;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pUserData")]
        public void* PUserData;
    }
}
