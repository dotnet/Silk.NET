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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_VIDEO_PROCESS_OUTPUT_STREAM_ARGUMENTS")]
    public unsafe partial struct VideoProcessOutputStreamArguments
    {
        public VideoProcessOutputStreamArguments
        (
            Silk.NET.Maths.Box2D<int>? targetRectangle = null
        ) : this()
        {
            if (targetRectangle is not null)
            {
                TargetRectangle = targetRectangle.Value;
            }
        }

        
        [NativeName("Type", "D3D12_VIDEO_PROCESS_OUTPUT_STREAM[2]")]
        [NativeName("Type.Name", "D3D12_VIDEO_PROCESS_OUTPUT_STREAM[2]")]
        [NativeName("Name", "OutputStream")]
        public OutputStreamBuffer OutputStream;

        public struct OutputStreamBuffer
        {
            public VideoProcessOutputStream Element0;
            public VideoProcessOutputStream Element1;
            public ref VideoProcessOutputStream this[int index]
            {
                get
                {
                    if (index > 1 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (VideoProcessOutputStream* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<VideoProcessOutputStream> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 2);
#endif
        }


        [NativeName("Type", "D3D12_RECT")]
        [NativeName("Type.Name", "D3D12_RECT")]
        [NativeName("Name", "TargetRectangle")]
        public Silk.NET.Maths.Box2D<int> TargetRectangle;
    }
}
