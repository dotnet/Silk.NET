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

namespace Silk.NET.OpenXR
{
    public unsafe struct DebugUtilsMessengerCreateInfoEXT
    {
        public DebugUtilsMessengerCreateInfoEXT
        (
            StructureType type = StructureType.TypeDebugUtilsMessengerCreateInfoExt,
            void* next = default,
            DebugUtilsMessageSeverityFlagsEXT messageSeverities = default,
            DebugUtilsMessageTypeFlagsEXT messageTypes = default,
            PFN_xrDebugUtilsMessengerCallbackEXT userCallback = default,
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
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public DebugUtilsMessageSeverityFlagsEXT MessageSeverities;
/// <summary></summary>
        public DebugUtilsMessageTypeFlagsEXT MessageTypes;
/// <summary></summary>
        public PFN_xrDebugUtilsMessengerCallbackEXT UserCallback;
/// <summary></summary>
        public void* UserData;
    }
}
