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
    [NativeName("Name", "XrHandCapsuleFB")]
    public unsafe partial struct HandCapsuleFB
    {
        public HandCapsuleFB
        (
            float? radius = null,
            HandJointEXT? joint = null
        ) : this()
        {
            if (radius is not null)
            {
                Radius = radius.Value;
            }

            if (joint is not null)
            {
                Joint = joint.Value;
            }
        }

        /// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "points")]
        public PointsBuffer Points;

        public struct PointsBuffer
        {
            public Vector3f Element0;
            public Vector3f Element1;
            public ref Vector3f this[int index]
            {
                get
                {
                    if (index > 1 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (Vector3f* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<Vector3f> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 2);
#endif
        }

/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "radius")]
        public float Radius;
/// <summary></summary>
        [NativeName("Type", "XrHandJointEXT")]
        [NativeName("Type.Name", "XrHandJointEXT")]
        [NativeName("Name", "joint")]
        public HandJointEXT Joint;
    }
}
