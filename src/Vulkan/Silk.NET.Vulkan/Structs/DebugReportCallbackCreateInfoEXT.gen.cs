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
    public unsafe struct DebugReportCallbackCreateInfoEXT
    {
        public DebugReportCallbackCreateInfoEXT
        (
            StructureType sType = StructureType.DebugReportCallbackCreateInfoExt,
            void* pNext = default,
            DebugReportFlagsEXT flags = default,
            FuncPtr pfnCallback = default,
            void* pUserData = default
        )
        {
           SType = sType;
           PNext = pNext;
           Flags = flags;
           PfnCallback = pfnCallback;
           PUserData = pUserData;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
/// <summary></summary>
        public DebugReportFlagsEXT Flags;
/// <summary></summary>
        public FuncPtr PfnCallback;
/// <summary></summary>
        public void* PUserData;
    }
}
