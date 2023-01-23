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

namespace Silk.NET.DXGI
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "DXGI_OUTPUT_DESC")]
    public unsafe partial struct OutputDesc
    {
        public OutputDesc
        (
            Silk.NET.Maths.Box2D<int>? desktopCoordinates = null,
            Silk.NET.Core.Bool32? attachedToDesktop = null,
            ModeRotation? rotation = null,
            nint? monitor = null
        ) : this()
        {
            if (desktopCoordinates is not null)
            {
                DesktopCoordinates = desktopCoordinates.Value;
            }

            if (attachedToDesktop is not null)
            {
                AttachedToDesktop = attachedToDesktop.Value;
            }

            if (rotation is not null)
            {
                Rotation = rotation.Value;
            }

            if (monitor is not null)
            {
                Monitor = monitor.Value;
            }
        }

        [NativeName("Type", "WCHAR[32]")]
        [NativeName("Type.Name", "WCHAR[32]")]
        [NativeName("Name", "DeviceName")]
        public fixed char DeviceName[32];

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "DesktopCoordinates")]
        public Silk.NET.Maths.Box2D<int> DesktopCoordinates;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AttachedToDesktop")]
        public Silk.NET.Core.Bool32 AttachedToDesktop;

        [NativeName("Type", "DXGI_MODE_ROTATION")]
        [NativeName("Type.Name", "DXGI_MODE_ROTATION")]
        [NativeName("Name", "Rotation")]
        public ModeRotation Rotation;

        [NativeName("Type", "HMONITOR")]
        [NativeName("Type.Name", "HMONITOR")]
        [NativeName("Name", "Monitor")]
        public nint Monitor;
    }
}
