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
    [NativeName("Name", "VkValidationFlagsEXT")]
    public unsafe struct ValidationFlagsEXT
    {
        public ValidationFlagsEXT
        (
            StructureType sType = StructureType.ValidationFlagsExt,
            void* pNext = default,
            uint disabledValidationCheckCount = default,
            ValidationCheckEXT* pDisabledValidationChecks = default
        )
        {
           SType = sType;
           PNext = pNext;
           DisabledValidationCheckCount = disabledValidationCheckCount;
           PDisabledValidationChecks = pDisabledValidationChecks;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "disabledValidationCheckCount")]
        public uint DisabledValidationCheckCount;
/// <summary></summary>
        [NativeName("Type", "VkValidationCheckEXT*")]
        [NativeName("Type.Name", "VkValidationCheckEXT")]
        [NativeName("Name", "pDisabledValidationChecks")]
        public ValidationCheckEXT* PDisabledValidationChecks;
    }
}
