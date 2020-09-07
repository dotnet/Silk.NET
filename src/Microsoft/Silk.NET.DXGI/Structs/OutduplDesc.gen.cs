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
    [NativeName("Name", "DXGI_OUTDUPL_DESC")]
    public unsafe partial struct OutduplDesc
    {
        public OutduplDesc
        (
            ModeDesc modeDesc = default,
            ModeRotation rotation = default,
            int desktopImageInSystemMemory = default
        )
        {
            ModeDesc = modeDesc;
            Rotation = rotation;
            DesktopImageInSystemMemory = desktopImageInSystemMemory;
        }


        [NativeName("Type", "DXGI_MODE_DESC")]
        [NativeName("Type.Name", "DXGI_MODE_DESC")]
        [NativeName("Name", "ModeDesc")]
        public ModeDesc ModeDesc;

        [NativeName("Type", "DXGI_MODE_ROTATION")]
        [NativeName("Type.Name", "DXGI_MODE_ROTATION")]
        [NativeName("Name", "Rotation")]
        public ModeRotation Rotation;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DesktopImageInSystemMemory")]
        public int DesktopImageInSystemMemory;
    }
}
