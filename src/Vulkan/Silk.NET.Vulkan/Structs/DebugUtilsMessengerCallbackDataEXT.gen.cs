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

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkDebugUtilsMessengerCallbackDataEXT")]
    public unsafe partial struct DebugUtilsMessengerCallbackDataEXT : IChainStart
    {
        public DebugUtilsMessengerCallbackDataEXT
        (
            StructureType? sType = StructureType.DebugUtilsMessengerCallbackDataExt,
            void* pNext = null,
            uint? flags = null,
            byte* pMessageIdName = null,
            int? messageIdNumber = null,
            byte* pMessage = null,
            uint? queueLabelCount = null,
            DebugUtilsLabelEXT* pQueueLabels = null,
            uint? cmdBufLabelCount = null,
            DebugUtilsLabelEXT* pCmdBufLabels = null,
            uint? objectCount = null,
            DebugUtilsObjectNameInfoEXT* pObjects = null
        ) : this()
        {
            if (sType is not null)
            {
                SType = sType.Value;
            }

            if (pNext is not null)
            {
                PNext = pNext;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }

            if (pMessageIdName is not null)
            {
                PMessageIdName = pMessageIdName;
            }

            if (messageIdNumber is not null)
            {
                MessageIdNumber = messageIdNumber.Value;
            }

            if (pMessage is not null)
            {
                PMessage = pMessage;
            }

            if (queueLabelCount is not null)
            {
                QueueLabelCount = queueLabelCount.Value;
            }

            if (pQueueLabels is not null)
            {
                PQueueLabels = pQueueLabels;
            }

            if (cmdBufLabelCount is not null)
            {
                CmdBufLabelCount = cmdBufLabelCount.Value;
            }

            if (pCmdBufLabels is not null)
            {
                PCmdBufLabels = pCmdBufLabels;
            }

            if (objectCount is not null)
            {
                ObjectCount = objectCount.Value;
            }

            if (pObjects is not null)
            {
                PObjects = pObjects;
            }
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

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.DebugUtilsMessengerCallbackDataExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }

        /// <summary>
        /// Convenience method to start a chain.
        /// </summary>
        /// <param name="capture">The newly created chain root</param>
        /// <returns>A reference to the newly created chain.</returns>
        public static unsafe ref DebugUtilsMessengerCallbackDataEXT Chain(
            out DebugUtilsMessengerCallbackDataEXT capture)
        {
            capture = new DebugUtilsMessengerCallbackDataEXT(StructureType.DebugUtilsMessengerCallbackDataExt);
            return ref capture;
        }
    }
}
