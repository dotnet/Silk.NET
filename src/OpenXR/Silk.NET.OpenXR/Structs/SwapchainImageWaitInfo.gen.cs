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

namespace Silk.NET.OpenXR
{
    public unsafe struct SwapchainImageWaitInfo
    {
        public SwapchainImageWaitInfo
        (
            StructureType type = StructureType.TypeSwapchainImageWaitInfo,
            void* next = default,
            long timeout = default
        )
        {
           Type = type;
           Next = next;
           Timeout = timeout;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public long Timeout;
    }
}
