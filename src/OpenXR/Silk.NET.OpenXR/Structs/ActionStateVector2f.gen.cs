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
    public unsafe struct ActionStateVector2f
    {
        public ActionStateVector2f
        (
            StructureType type = StructureType.TypeActionStateVector2f,
            void* next = default,
            Vector2f currentState = default,
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
        public Vector2f CurrentState;
/// <summary></summary>
        public uint ChangedSinceLastSync;
/// <summary></summary>
        public long LastChangeTime;
/// <summary></summary>
        public uint IsActive;
    }
}
