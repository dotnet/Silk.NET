// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

namespace Silk.NET.Vulkan
{
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint Flags;
/// <summary></summary>
        public byte* PMessageIdName;
/// <summary></summary>
        public int MessageIdNumber;
/// <summary></summary>
        public byte* PMessage;
/// <summary></summary>
        public uint QueueLabelCount;
/// <summary></summary>
        public DebugUtilsLabelEXT* PQueueLabels;
/// <summary></summary>
        public uint CmdBufLabelCount;
/// <summary></summary>
        public DebugUtilsLabelEXT* PCmdBufLabels;
/// <summary></summary>
        public uint ObjectCount;
/// <summary></summary>
        public DebugUtilsObjectNameInfoEXT* PObjects;
    }
}
