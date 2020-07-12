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
    public unsafe struct EventDataSessionStateChanged
    {
        public EventDataSessionStateChanged
        (
            StructureType type = StructureType.TypeEventDataSessionStateChanged,
            void* next = default,
            Session session = default,
            SessionState state = default,
            long time = default
        )
        {
           Type = type;
           Next = next;
           Session = session;
           State = state;
           Time = time;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public Session Session;
/// <summary></summary>
        public SessionState State;
/// <summary></summary>
        public long Time;
    }
}
