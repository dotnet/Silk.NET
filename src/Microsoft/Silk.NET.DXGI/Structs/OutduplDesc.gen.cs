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
    [NativeName("Name", "DXGI_OUTDUPL_DESC")]
    public unsafe partial struct OutduplDesc
    {
        public OutduplDesc
        (
            ModeDesc? modeDesc = null,
            ModeRotation? rotation = null,
            Silk.NET.Core.Bool32? desktopImageInSystemMemory = null
        ) : this()
        {
            if (modeDesc is not null)
            {
                ModeDesc = modeDesc.Value;
            }

            if (rotation is not null)
            {
                Rotation = rotation.Value;
            }

            if (desktopImageInSystemMemory is not null)
            {
                DesktopImageInSystemMemory = desktopImageInSystemMemory.Value;
            }
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
        public Silk.NET.Core.Bool32 DesktopImageInSystemMemory;
    }
}
