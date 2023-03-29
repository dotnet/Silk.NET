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
    [NativeName("Name", "XrEyeGazesFB")]
    public unsafe partial struct EyeGazesFB
    {
        public EyeGazesFB
        (
            StructureType? type = StructureType.TypeEyeGazesFB,
            void* next = null,
            long? time = null
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

            if (time is not null)
            {
                Time = time.Value;
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
        [NativeName("Type", "XrEyeGazeFB")]
        [NativeName("Type.Name", "XrEyeGazeFB")]
        [NativeName("Name", "gaze")]
        public GazeBuffer Gaze;

        public struct GazeBuffer
        {
            public EyeGazeFB Element0;
            public EyeGazeFB Element1;
            public ref EyeGazeFB this[int index]
            {
                get
                {
                    if (index > 1 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (EyeGazeFB* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<EyeGazeFB> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 2);
#endif
        }

/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "time")]
        public long Time;
    }
}
