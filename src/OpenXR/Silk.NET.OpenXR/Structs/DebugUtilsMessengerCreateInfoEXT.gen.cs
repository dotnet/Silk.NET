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
    [NativeName("Name", "XrDebugUtilsMessengerCreateInfoEXT")]
    public unsafe partial struct DebugUtilsMessengerCreateInfoEXT
    {
        public DebugUtilsMessengerCreateInfoEXT
        (
            StructureType? type = StructureType.TypeDebugUtilsMessengerCreateInfoExt,
            void* next = null,
            DebugUtilsMessageSeverityFlagsEXT? messageSeverities = null,
            DebugUtilsMessageTypeFlagsEXT? messageTypes = null,
            PfnDebugUtilsMessengerCallbackEXT? userCallback = null,
            void* userData = null
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

            if (messageSeverities is not null)
            {
                MessageSeverities = messageSeverities.Value;
            }

            if (messageTypes is not null)
            {
                MessageTypes = messageTypes.Value;
            }

            if (userCallback is not null)
            {
                UserCallback = userCallback.Value;
            }

            if (userData is not null)
            {
                UserData = userData;
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
        public PfnDebugUtilsMessengerCallbackEXT UserCallback;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "userData")]
        public void* UserData;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
