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
    [NativeName("Name", "XrHandTrackingScaleFB")]
    public unsafe partial struct HandTrackingScaleFB
    {
        public HandTrackingScaleFB
        (
            StructureType? type = StructureType.TypeHandTrackingScaleFB,
            void* next = null,
            float? sensorOutput = null,
            float? currentOutput = null,
            uint? overrideHandScale = null,
            float? overrideValueInput = null
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

            if (sensorOutput is not null)
            {
                SensorOutput = sensorOutput.Value;
            }

            if (currentOutput is not null)
            {
                CurrentOutput = currentOutput.Value;
            }

            if (overrideHandScale is not null)
            {
                OverrideHandScale = overrideHandScale.Value;
            }

            if (overrideValueInput is not null)
            {
                OverrideValueInput = overrideValueInput.Value;
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
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "sensorOutput")]
        public float SensorOutput;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "currentOutput")]
        public float CurrentOutput;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "overrideHandScale")]
        public uint OverrideHandScale;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "overrideValueInput")]
        public float OverrideValueInput;
    }
}
