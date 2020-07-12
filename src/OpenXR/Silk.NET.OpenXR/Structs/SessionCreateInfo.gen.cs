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
    public unsafe struct SessionCreateInfo
    {
        public SessionCreateInfo
        (
            StructureType type = StructureType.TypeSessionCreateInfo,
            void* next = default,
            SessionCreateFlags createFlags = default,
            ulong systemId = default
        )
        {
           Type = type;
           Next = next;
           CreateFlags = createFlags;
           SystemId = systemId;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public SessionCreateFlags CreateFlags;
/// <summary></summary>
        public ulong SystemId;
    }
}
