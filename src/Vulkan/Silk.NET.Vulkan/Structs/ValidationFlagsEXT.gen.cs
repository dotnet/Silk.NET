// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
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
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public uint DisabledValidationCheckCount;
/// <summary></summary>
        public ValidationCheckEXT* PDisabledValidationChecks;
    }
}
