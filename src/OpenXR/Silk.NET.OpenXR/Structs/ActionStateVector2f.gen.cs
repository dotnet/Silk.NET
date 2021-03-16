// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrActionStateVector2f")]
    public unsafe partial struct ActionStateVector2f
    {
        public ActionStateVector2f
        (
            StructureType? type = StructureType.TypeActionStateVector2f,
            void* next = null,
            Vector2f? currentState = null,
            uint? changedSinceLastSync = null,
            long? lastChangeTime = null,
            uint? isActive = null
        ) : this()
        {
            if (type is not null)
            {
                Type = type.Value;
            }

            if (next is not null)
            {
                Next = next;
            }

            if (currentState is not null)
            {
                CurrentState = currentState.Value;
            }

            if (changedSinceLastSync is not null)
            {
                ChangedSinceLastSync = changedSinceLastSync.Value;
            }

            if (lastChangeTime is not null)
            {
                LastChangeTime = lastChangeTime.Value;
            }

            if (isActive is not null)
            {
                IsActive = isActive.Value;
            }
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
        [NativeName("Type", "XrVector2f")]
        [NativeName("Type.Name", "XrVector2f")]
        [NativeName("Name", "currentState")]
        public Vector2f CurrentState;
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
