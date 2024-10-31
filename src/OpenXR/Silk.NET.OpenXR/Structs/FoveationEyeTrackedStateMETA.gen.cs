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
    [NativeName("Name", "XrFoveationEyeTrackedStateMETA")]
    public unsafe partial struct FoveationEyeTrackedStateMETA
    {
        public FoveationEyeTrackedStateMETA
        (
            StructureType? type = StructureType.TypeFoveationEyeTrackedStateMeta,
            void* next = null,
            FoveationEyeTrackedStateFlagsMETA? flags = null
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

            if (flags is not null)
            {
                Flags = flags.Value;
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
        [NativeName("Name", "foveationCenter")]
        public FoveationCenterBuffer FoveationCenter;

        public struct FoveationCenterBuffer
        {
            public Vector2f Element0;
            public Vector2f Element1;
            public ref Vector2f this[int index]
            {
                get
                {
                    if (index > 1 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (Vector2f* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<Vector2f> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 2);
#endif
        }

/// <summary></summary>
        [NativeName("Type", "XrFoveationEyeTrackedStateFlagsMETA")]
        [NativeName("Type.Name", "XrFoveationEyeTrackedStateFlagsMETA")]
        [NativeName("Name", "flags")]
        public FoveationEyeTrackedStateFlagsMETA Flags;
    }
}
