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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrDebugUtilsMessengerCreateInfoEXT")]
    public unsafe partial struct DebugUtilsMessengerCreateInfoEXT
    {
        public DebugUtilsMessengerCreateInfoEXT
        (
            StructureType type = StructureType.TypeDebugUtilsMessengerCreateInfoExt,
            void* next = default,
            DebugUtilsMessageSeverityFlagsEXT messageSeverities = default,
            DebugUtilsMessageTypeFlagsEXT messageTypes = default,
            FuncPtr userCallback = default,
            void* userData = default
        )
        {
            Type = type;
            Next = next;
            MessageSeverities = messageSeverities;
            MessageTypes = messageTypes;
            UserCallback = userCallback;
            UserData = userData;
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrDebugUtilsMessageSeverityFlagsEXT")]
        [NativeName("Type.Name", "XrDebugUtilsMessageSeverityFlagsEXT")]
        [NativeName("Name", "messageSeverities")]
        public DebugUtilsMessageSeverityFlagsEXT MessageSeverities;
/// <summary></summary>
        [NativeName("Type", "XrDebugUtilsMessageTypeFlagsEXT")]
        [NativeName("Type.Name", "XrDebugUtilsMessageTypeFlagsEXT")]
        [NativeName("Name", "messageTypes")]
        public DebugUtilsMessageTypeFlagsEXT MessageTypes;
/// <summary></summary>
        [NativeName("Type", "PFN_xrDebugUtilsMessengerCallbackEXT")]
        [NativeName("Type.Name", "PFN_xrDebugUtilsMessengerCallbackEXT")]
        [NativeName("Name", "userCallback")]
        public FuncPtr UserCallback;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "userData")]
        public void* UserData;
    }
}
