// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISPLAYCONFIG_MODE_INFO
{
    public DISPLAYCONFIG_MODE_INFO_TYPE infoType;

    [NativeTypeName("UINT32")]
    public uint id;
    public LUID adapterId;

    [NativeTypeName("__AnonymousRecord_wingdi_L2936_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref DISPLAYCONFIG_TARGET_MODE targetMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.targetMode; }
    }

    [UnscopedRef]
    public ref DISPLAYCONFIG_SOURCE_MODE sourceMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.sourceMode; }
    }

    [SupportedOSPlatform("windows10.0.17763.0")]
    [UnscopedRef]
    public ref DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.desktopImageInfo; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public DISPLAYCONFIG_TARGET_MODE targetMode;

        [FieldOffset(0)]
        public DISPLAYCONFIG_SOURCE_MODE sourceMode;

        [FieldOffset(0)]
        [SupportedOSPlatform("windows10.0.17763.0")]
        public DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo;
    }
}
