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
    [NativeName("Name", "VkRenderPassSubpassFeedbackCreateInfoEXT")]
    public unsafe partial struct RenderPassSubpassFeedbackCreateInfoEXT : IExtendsChain<SubpassDescription2>, IExtendsChain<SubpassDescription2KHR>
    {
        public RenderPassSubpassFeedbackCreateInfoEXT
        (
            StructureType? sType = StructureType.RenderPassSubpassFeedbackCreateInfoExt,
            void* pNext = null,
            RenderPassSubpassFeedbackInfoEXT* pSubpassFeedback = null
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

            if (pSubpassFeedback is not null)
            {
                PSubpassFeedback = pSubpassFeedback;
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
        [NativeName("Type", "VkRenderPassSubpassFeedbackInfoEXT*")]
        [NativeName("Type.Name", "VkRenderPassSubpassFeedbackInfoEXT")]
        [NativeName("Name", "pSubpassFeedback")]
        public RenderPassSubpassFeedbackInfoEXT* PSubpassFeedback;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }


        /// <inheritdoc />
        StructureType IStructuredType.StructureType()
        {
            return SType = StructureType.RenderPassSubpassFeedbackCreateInfoExt;
        }

        /// <inheritdoc />
        unsafe BaseInStructure* IChainable.PNext
        {
            get => (BaseInStructure*) PNext;
            set => PNext = value;
        }
    }
}
