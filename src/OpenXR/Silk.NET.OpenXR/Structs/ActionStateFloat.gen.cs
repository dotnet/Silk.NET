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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrActionStateFloat")]
    public unsafe partial struct ActionStateFloat
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
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "currentState")]
        public float CurrentState;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "changedSinceLastSync")]
        public uint ChangedSinceLastSync;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "lastChangeTime")]
        public long LastChangeTime;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "isActive")]
        public uint IsActive;
    }
}
