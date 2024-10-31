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
    [NativeName("Name", "VkRenderPassCreationFeedbackCreateInfoEXT")]
    public unsafe partial struct RenderPassCreationFeedbackCreateInfoEXT : IExtendsChain<RenderPassCreateInfo2>, IExtendsChain<RenderPassCreateInfo2KHR>
    {
        public RenderPassCreationFeedbackCreateInfoEXT
        (
            StructureType? sType = StructureType.RenderPassCreationFeedbackCreateInfoExt,
            void* pNext = null,
            RenderPassCreationFeedbackInfoEXT* pRenderPassFeedback = null
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

            if (pRenderPassFeedback is not null)
            {
                PRenderPassFeedback = pRenderPassFeedback;
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
        [NativeName("Type", "VkRenderPassCreationFeedbackInfoEXT*")]
        [NativeName("Type.Name", "VkRenderPassCreationFeedbackInfoEXT")]
        [NativeName("Name", "pRenderPassFeedback")]
        public RenderPassCreationFeedbackInfoEXT* PRenderPassFeedback;

        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderPassCreationFeedbackCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
