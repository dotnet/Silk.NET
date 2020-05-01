// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public DebugUtilsMessageSeverityFlagsEXT MessageSeverity;
/// <summary></summary>
        public DebugUtilsMessageTypeFlagsEXT MessageType;
/// <summary></summary>
        public FuncPtr PfnUserCallback;
/// <summary></summary>
        public void* PUserData;
    }
}
