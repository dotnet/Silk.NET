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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrDebugUtilsMessengerCallbackDataEXT")]
    public unsafe partial struct DebugUtilsMessengerCallbackDataEXT
    {
        public DebugUtilsMessengerCallbackDataEXT
        (
            StructureType? type = StructureType.TypeDebugUtilsMessengerCallbackDataExt,
            void* next = null,
            byte* messageId = null,
            byte* functionName = null,
            byte* message = null,
            uint? objectCount = null,
            DebugUtilsObjectNameInfoEXT* objects = null,
            uint? sessionLabelCount = null,
            DebugUtilsLabelEXT* sessionLabels = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (messageId is not null)
            {
                MessageId = messageId;
            }

            if (functionName is not null)
            {
                FunctionName = functionName;
            }

            if (message is not null)
            {
                Message = message;
            }

            if (objectCount is not null)
            {
                ObjectCount = objectCount.Value;
            }

            if (objects is not null)
            {
                Objects = objects;
            }

            if (sessionLabelCount is not null)
            {
                SessionLabelCount = sessionLabelCount.Value;
            }

            if (sessionLabels is not null)
            {
                SessionLabels = sessionLabels;
            }
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
