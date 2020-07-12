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
    public unsafe struct DebugUtilsMessengerCallbackDataEXT
    {
        public DebugUtilsMessengerCallbackDataEXT
        (
            StructureType type = StructureType.TypeDebugUtilsMessengerCallbackDataExt,
            void* next = default,
            byte* messageId = default,
            byte* functionName = default,
            byte* message = default,
            uint objectCount = default,
            DebugUtilsObjectNameInfoEXT* objects = default,
            uint sessionLabelCount = default,
            DebugUtilsLabelEXT* sessionLabels = default
        )
        {
           Type = type;
           Next = next;
           MessageId = messageId;
           FunctionName = functionName;
           Message = message;
           ObjectCount = objectCount;
           Objects = objects;
           SessionLabelCount = sessionLabelCount;
           SessionLabels = sessionLabels;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public byte* MessageId;
/// <summary></summary>
        public byte* FunctionName;
/// <summary></summary>
        public byte* Message;
/// <summary></summary>
        public uint ObjectCount;
/// <summary></summary>
        public DebugUtilsObjectNameInfoEXT* Objects;
/// <summary></summary>
        public uint SessionLabelCount;
/// <summary></summary>
        public DebugUtilsLabelEXT* SessionLabels;
    }
}
