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
    [NativeName("Name", "XrEnvironmentDepthImageMETA")]
    public unsafe partial struct EnvironmentDepthImageMETA
    {
        public EnvironmentDepthImageMETA
        (
            StructureType? type = StructureType.TypeEnvironmentDepthImageMeta,
            void* next = null,
            uint? swapchainIndex = null,
            float? nearZ = null,
            float? farZ = null
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

            if (swapchainIndex is not null)
            {
                SwapchainIndex = swapchainIndex.Value;
            }

            if (nearZ is not null)
            {
                NearZ = nearZ.Value;
            }

            if (farZ is not null)
            {
                FarZ = farZ.Value;
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
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "swapchainIndex")]
        public uint SwapchainIndex;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "nearZ")]
        public float NearZ;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "farZ")]
        public float FarZ;
        /// <summary></summary>
        [NativeName("Type", "XrEnvironmentDepthImageViewMETA")]
        [NativeName("Type.Name", "XrEnvironmentDepthImageViewMETA")]
        [NativeName("Name", "views")]
        public ViewsBuffer Views;

        public struct ViewsBuffer
        {
            public EnvironmentDepthImageViewMETA Element0;
            public EnvironmentDepthImageViewMETA Element1;
            public ref EnvironmentDepthImageViewMETA this[int index]
            {
                get
                {
                    if (index > 1 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (EnvironmentDepthImageViewMETA* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<EnvironmentDepthImageViewMETA> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 2);
#endif
        }

    }
}
