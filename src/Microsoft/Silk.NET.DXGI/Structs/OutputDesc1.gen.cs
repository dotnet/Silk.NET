// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_OUTPUT_DESC1")]
    public unsafe partial struct OutputDesc1
    {
        public OutputDesc1
        (
            Silk.NET.Core.Runtime.Windows.TagRect desktopCoordinates = default,
            int attachedToDesktop = default,
            ModeRotation rotation = default,
            IntPtr monitor = default,
            uint bitsPerColor = default,
            ColorSpaceType colorSpace = default,
            float minLuminance = default,
            float maxLuminance = default,
            float maxFullFrameLuminance = default
        )
        {
            DesktopCoordinates = desktopCoordinates;
            AttachedToDesktop = attachedToDesktop;
            Rotation = rotation;
            Monitor = monitor;
            BitsPerColor = bitsPerColor;
            ColorSpace = colorSpace;
            MinLuminance = minLuminance;
            MaxLuminance = maxLuminance;
            MaxFullFrameLuminance = maxFullFrameLuminance;
        }

        [NativeName("Type", "WCHAR [32]")]
        [NativeName("Type.Name", "WCHAR [32]")]
        [NativeName("Name", "DeviceName")]
        public fixed char DeviceName[32];

        [NativeName("Type", "RECT")]
        [NativeName("Type.Name", "RECT")]
        [NativeName("Name", "DesktopCoordinates")]
        public Silk.NET.Core.Runtime.Windows.TagRect DesktopCoordinates;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AttachedToDesktop")]
        public int AttachedToDesktop;

        [NativeName("Type", "DXGI_MODE_ROTATION")]
        [NativeName("Type.Name", "DXGI_MODE_ROTATION")]
        [NativeName("Name", "Rotation")]
        public ModeRotation Rotation;

        [NativeName("Type", "HMONITOR")]
        [NativeName("Type.Name", "HMONITOR")]
        [NativeName("Name", "Monitor")]
        public IntPtr Monitor;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "BitsPerColor")]
        public uint BitsPerColor;

        [NativeName("Type", "DXGI_COLOR_SPACE_TYPE")]
        [NativeName("Type.Name", "DXGI_COLOR_SPACE_TYPE")]
        [NativeName("Name", "ColorSpace")]
        public ColorSpaceType ColorSpace;
        [NativeName("Type", "FLOAT [2]")]
        [NativeName("Type.Name", "FLOAT [2]")]
        [NativeName("Name", "RedPrimary")]
        public fixed float RedPrimary[2];
        [NativeName("Type", "FLOAT [2]")]
        [NativeName("Type.Name", "FLOAT [2]")]
        [NativeName("Name", "GreenPrimary")]
        public fixed float GreenPrimary[2];
        [NativeName("Type", "FLOAT [2]")]
        [NativeName("Type.Name", "FLOAT [2]")]
        [NativeName("Name", "BluePrimary")]
        public fixed float BluePrimary[2];
        [NativeName("Type", "FLOAT [2]")]
        [NativeName("Type.Name", "FLOAT [2]")]
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
