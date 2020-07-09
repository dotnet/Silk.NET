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
    [NativeName("Name", "VkDebugUtilsMessengerCallbackDataEXT")]
    public unsafe struct DebugUtilsMessengerCallbackDataEXT
    {
        public DebugUtilsMessengerCallbackDataEXT
        (
            StructureType sType = StructureType.DebugUtilsMessengerCallbackDataExt,
            void* pNext = default,
            uint flags = default,
            byte* pMessageIdName = default,
            int messageIdNumber = default,
            byte* pMessage = default,
            uint queueLabelCount = default,
            DebugUtilsLabelEXT* pQueueLabels = default,
            uint cmdBufLabelCount = default,
            DebugUtilsLabelEXT* pCmdBufLabels = default,
            uint objectCount = default,
            DebugUtilsObjectNameInfoEXT* pObjects = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           PMessageIdName = pMessageIdName;
           MessageIdNumber = messageIdNumber;
           PMessage = pMessage;
           QueueLabelCount = queueLabelCount;
           PQueueLabels = pQueueLabels;
           CmdBufLabelCount = cmdBufLabelCount;
           PCmdBufLabels = pCmdBufLabels;
           ObjectCount = objectCount;
           PObjects = pObjects;
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
        [NativeName("Type", "VkDebugUtilsMessengerCallbackDataFlagsEXT")]
        [NativeName("Type.Name", "VkDebugUtilsMessengerCallbackDataFlagsEXT")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "pMessageIdName")]
        public byte* PMessageIdName;
/// <summary></summary>
        [NativeName("Type", "int32_t")]
        [NativeName("Type.Name", "int32_t")]
        [NativeName("Name", "messageIdNumber")]
        public int MessageIdNumber;
/// <summary></summary>
        [NativeName("Type", "char*")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "pMessage")]
        public byte* PMessage;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueLabelCount")]
        public uint QueueLabelCount;
/// <summary></summary>
        [NativeName("Type", "VkDebugUtilsLabelEXT*")]
        [NativeName("Type.Name", "VkDebugUtilsLabelEXT")]
        [NativeName("Name", "pQueueLabels")]
        public DebugUtilsLabelEXT* PQueueLabels;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "cmdBufLabelCount")]
        public uint CmdBufLabelCount;
/// <summary></summary>
        [NativeName("Type", "VkDebugUtilsLabelEXT*")]
        [NativeName("Type.Name", "VkDebugUtilsLabelEXT")]
        [NativeName("Name", "pCmdBufLabels")]
        public DebugUtilsLabelEXT* PCmdBufLabels;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "objectCount")]
        public uint ObjectCount;
/// <summary></summary>
        [NativeName("Type", "VkDebugUtilsObjectNameInfoEXT*")]
        [NativeName("Type.Name", "VkDebugUtilsObjectNameInfoEXT")]
        [NativeName("Name", "pObjects")]
        public DebugUtilsObjectNameInfoEXT* PObjects;
    }
}
