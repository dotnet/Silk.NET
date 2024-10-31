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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "VkIndirectCommandsTokenDataEXT")]
    public unsafe partial struct IndirectCommandsTokenDataEXT
    {
        public IndirectCommandsTokenDataEXT
        (
            IndirectCommandsPushConstantTokenEXT* pPushConstant = null,
            IndirectCommandsVertexBufferTokenEXT* pVertexBuffer = null,
            IndirectCommandsIndexBufferTokenEXT* pIndexBuffer = null,
            IndirectCommandsExecutionSetTokenEXT* pExecutionSet = null
        ) : this()
        {
            if (pPushConstant is not null)
            {
                PPushConstant = pPushConstant;
            }

            if (pVertexBuffer is not null)
            {
                PVertexBuffer = pVertexBuffer;
            }

            if (pIndexBuffer is not null)
            {
                PIndexBuffer = pIndexBuffer;
            }

            if (pExecutionSet is not null)
            {
                PExecutionSet = pExecutionSet;
            }
        }

/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkIndirectCommandsPushConstantTokenEXT*")]
        [NativeName("Type.Name", "VkIndirectCommandsPushConstantTokenEXT")]
        [NativeName("Name", "pPushConstant")]
        public IndirectCommandsPushConstantTokenEXT* PPushConstant;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkIndirectCommandsVertexBufferTokenEXT*")]
        [NativeName("Type.Name", "VkIndirectCommandsVertexBufferTokenEXT")]
        [NativeName("Name", "pVertexBuffer")]
        public IndirectCommandsVertexBufferTokenEXT* PVertexBuffer;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkIndirectCommandsIndexBufferTokenEXT*")]
        [NativeName("Type.Name", "VkIndirectCommandsIndexBufferTokenEXT")]
        [NativeName("Name", "pIndexBuffer")]
        public IndirectCommandsIndexBufferTokenEXT* PIndexBuffer;
/// <summary></summary>
        [FieldOffset(0)]
        [NativeName("Type", "VkIndirectCommandsExecutionSetTokenEXT*")]
        [NativeName("Type.Name", "VkIndirectCommandsExecutionSetTokenEXT")]
        [NativeName("Name", "pExecutionSet")]
        public IndirectCommandsExecutionSetTokenEXT* PExecutionSet;
    }
}
