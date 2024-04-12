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

namespace Silk.NET.Vulkan.Video
{
    [NativeName("Name", "StdVideoAV1LoopRestoration")]
    public unsafe partial struct StdVideoAV1LoopRestoration
    {
        
        [NativeName("Type", "StdVideoAV1FrameRestorationType[3]")]
        [NativeName("Type.Name", "StdVideoAV1FrameRestorationType[3]")]
        [NativeName("Name", "FrameRestorationType")]
        public FrameRestorationTypeBuffer FrameRestorationType;

        public struct FrameRestorationTypeBuffer
        {
            public StdVideoAV1FrameRestorationType Element0;
            public StdVideoAV1FrameRestorationType Element1;
            public StdVideoAV1FrameRestorationType Element2;
            public ref StdVideoAV1FrameRestorationType this[int index]
            {
                get
                {
                    if (index > 2 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (StdVideoAV1FrameRestorationType* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<StdVideoAV1FrameRestorationType> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 3);
#endif
        }

        [NativeName("Type", "uint16_t[3]")]
        [NativeName("Type.Name", "uint16_t[3]")]
        [NativeName("Name", "LoopRestorationSize")]
        public fixed ushort LoopRestorationSize[3];
    }
}
