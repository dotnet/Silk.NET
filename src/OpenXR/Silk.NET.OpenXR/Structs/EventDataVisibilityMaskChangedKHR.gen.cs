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
    public unsafe struct EventDataVisibilityMaskChangedKHR
    {
        public EventDataVisibilityMaskChangedKHR
        (
            StructureType type = StructureType.TypeEventDataVisibilityMaskChangedKhr,
            void* next = default,
            Session session = default,
            ViewConfigurationType viewConfigurationType = default,
            uint viewIndex = default
        )
        {
           Type = type;
           Next = next;
           Session = session;
           ViewConfigurationType = viewConfigurationType;
           ViewIndex = viewIndex;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public Session Session;
/// <summary></summary>
        public ViewConfigurationType ViewConfigurationType;
/// <summary></summary>
        public uint ViewIndex;
    }
}
