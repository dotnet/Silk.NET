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
    [NativeName("Name", "XrHandTrackingCapsulesStateFB")]
    public unsafe partial struct HandTrackingCapsulesStateFB
    {
        public HandTrackingCapsulesStateFB
        (
            StructureType? type = StructureType.TypeHandTrackingCapsulesStateFB,
            void* next = null
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
        [NativeName("Type", "XrHandCapsuleFB")]
        [NativeName("Type.Name", "XrHandCapsuleFB")]
        [NativeName("Name", "capsules")]
        public CapsulesBuffer Capsules;

        public struct CapsulesBuffer
        {
            public HandCapsuleFB Element0;
            public HandCapsuleFB Element1;
            public HandCapsuleFB Element2;
            public HandCapsuleFB Element3;
            public HandCapsuleFB Element4;
            public HandCapsuleFB Element5;
            public HandCapsuleFB Element6;
            public HandCapsuleFB Element7;
            public HandCapsuleFB Element8;
            public HandCapsuleFB Element9;
            public HandCapsuleFB Element10;
            public HandCapsuleFB Element11;
            public HandCapsuleFB Element12;
            public HandCapsuleFB Element13;
            public HandCapsuleFB Element14;
            public HandCapsuleFB Element15;
            public HandCapsuleFB Element16;
            public HandCapsuleFB Element17;
            public HandCapsuleFB Element18;
            public ref HandCapsuleFB this[int index]
            {
                get
                {
                    if (index > 18 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (HandCapsuleFB* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<HandCapsuleFB> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 19);
#endif
        }

        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
