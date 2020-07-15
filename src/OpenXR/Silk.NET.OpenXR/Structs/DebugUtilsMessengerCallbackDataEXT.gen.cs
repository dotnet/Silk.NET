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
    [NativeName("Name", "XrDebugUtilsMessengerCallbackDataEXT")]
    public unsafe partial struct DebugUtilsMessengerCallbackDataEXT
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
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "messageId")]
        public byte* MessageId;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "functionName")]
        public byte* FunctionName;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "message")]
        public byte* Message;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "objectCount")]
        public uint ObjectCount;
/// <summary></summary>
        [NativeName("Type", "XrDebugUtilsObjectNameInfoEXT*")]
        [NativeName("Type.Name", "XrDebugUtilsObjectNameInfoEXT")]
        [NativeName("Name", "objects")]
        public DebugUtilsObjectNameInfoEXT* Objects;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sessionLabelCount")]
        public uint SessionLabelCount;
/// <summary></summary>
        [NativeName("Type", "XrDebugUtilsLabelEXT*")]
        [NativeName("Type.Name", "XrDebugUtilsLabelEXT")]
        [NativeName("Name", "sessionLabels")]
        public DebugUtilsLabelEXT* SessionLabels;
    }
}
