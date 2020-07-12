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
    public unsafe struct ActionStateFloat
    {
        public ActionStateFloat
        (
            StructureType type = StructureType.TypeActionStateFloat,
            void* next = default,
            float currentState = default,
            uint changedSinceLastSync = default,
            long lastChangeTime = default,
            uint isActive = default
        )
        {
           Type = type;
           Next = next;
           CurrentState = currentState;
           ChangedSinceLastSync = changedSinceLastSync;
           LastChangeTime = lastChangeTime;
           IsActive = isActive;
        }

/// <summary></summary>
        public StructureType Type;
/// <summary></summary>
        public void* Next;
/// <summary></summary>
        public float CurrentState;
/// <summary></summary>
        public uint ChangedSinceLastSync;
/// <summary></summary>
        public long LastChangeTime;
/// <summary></summary>
        public uint IsActive;
    }
}
