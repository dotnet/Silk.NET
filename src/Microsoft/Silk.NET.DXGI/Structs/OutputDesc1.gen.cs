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
    [NativeName("Name", "DXGI_OUTPUT_DESC1")]
    public unsafe partial struct OutputDesc1
    {
        public OutputDesc1
        (
            Silk.NET.Maths.Box2D<int>? desktopCoordinates = null,
            Silk.NET.Core.Bool32? attachedToDesktop = null,
            ModeRotation? rotation = null,
            nint? monitor = null,
            uint? bitsPerColor = null,
            Silk.NET.DXGI.ColorSpaceType? colorSpace = null,
            float? minLuminance = null,
            float? maxLuminance = null,
            float? maxFullFrameLuminance = null
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

            if (bitsPerColor is not null)
            {
                BitsPerColor = bitsPerColor.Value;
            }

            if (colorSpace is not null)
            {
                ColorSpace = colorSpace.Value;
            }

            if (minLuminance is not null)
            {
                MinLuminance = minLuminance.Value;
            }

            if (maxLuminance is not null)
            {
                MaxLuminance = maxLuminance.Value;
            }

            if (maxFullFrameLuminance is not null)
            {
                MaxFullFrameLuminance = maxFullFrameLuminance.Value;
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

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BitsPerColor")]
        public uint BitsPerColor;

        [NativeName("Type", "DXGI_COLOR_SPACE_TYPE")]
        [NativeName("Type.Name", "DXGI_COLOR_SPACE_TYPE")]
        [NativeName("Name", "ColorSpace")]
        public Silk.NET.DXGI.ColorSpaceType ColorSpace;
        [NativeName("Type", "FLOAT[2]")]
        [NativeName("Type.Name", "FLOAT[2]")]
        [NativeName("Name", "RedPrimary")]
        public fixed float RedPrimary[2];
        [NativeName("Type", "FLOAT[2]")]
        [NativeName("Type.Name", "FLOAT[2]")]
        [NativeName("Name", "GreenPrimary")]
        public fixed float GreenPrimary[2];
        [NativeName("Type", "FLOAT[2]")]
        [NativeName("Type.Name", "FLOAT[2]")]
        [NativeName("Name", "BluePrimary")]
        public fixed float BluePrimary[2];
        [NativeName("Type", "FLOAT[2]")]
        [NativeName("Type.Name", "FLOAT[2]")]
        [NativeName("Name", "WhitePoint")]
        public fixed float WhitePoint[2];

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MinLuminance")]
        public float MinLuminance;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MaxLuminance")]
        public float MaxLuminance;

        [NativeName("Type", "FLOAT")]
        [NativeName("Type.Name", "FLOAT")]
        [NativeName("Name", "MaxFullFrameLuminance")]
        public float MaxFullFrameLuminance;
    }
}
