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

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVAHDETW_VIDEOPROCESSBLTHD")]
    public unsafe partial struct HdetwVideoprocessblthd
    {
        public HdetwVideoprocessblthd
        (
            ulong? pObject = null,
            ulong? pOutputSurface = null,
            Silk.NET.Maths.Box2D<int>? targetRect = null,
            Silk.NET.Direct3D9.Format? outputFormat = null,
            uint? colorSpace = null,
            uint? outputFrame = null,
            uint? streamCount = null,
            Silk.NET.Core.Bool32? enter = null
        ) : this()
        {
            if (pObject is not null)
            {
                PObject = pObject.Value;
            }

            if (pOutputSurface is not null)
            {
                POutputSurface = pOutputSurface.Value;
            }

            if (targetRect is not null)
            {
                TargetRect = targetRect.Value;
            }

            if (outputFormat is not null)
            {
                OutputFormat = outputFormat.Value;
            }

            if (colorSpace is not null)
            {
                ColorSpace = colorSpace.Value;
            }

            if (outputFrame is not null)
            {
                OutputFrame = outputFrame.Value;
            }

            if (streamCount is not null)
            {
                StreamCount = streamCount.Value;
            }

            if (enter is not null)
            {
                Enter = enter.Value;
            }
        }


        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "pObject")]
        public ulong PObject;

        [NativeName("Type", "ULONGLONG")]
        [NativeName("Type.Name", "ULONGLONG")]
        [NativeName("Name", "pOutputSurface")]
        public ulong POutputSurface;

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "TargetRect")]
        public Silk.NET.Maths.Box2D<int> TargetRect;

        [NativeName("Type", "D3DFORMAT")]
        [NativeName("Type.Name", "D3DFORMAT")]
        [NativeName("Name", "OutputFormat")]
        public Silk.NET.Direct3D9.Format OutputFormat;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ColorSpace")]
        public uint ColorSpace;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "OutputFrame")]
        public uint OutputFrame;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "StreamCount")]
        public uint StreamCount;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "Enter")]
        public Silk.NET.Core.Bool32 Enter;
    }
}
