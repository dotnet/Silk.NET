// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct DISPLAYCONFIG_PATH_TARGET_INFO
{
    public LUID adapterId;

    [NativeTypeName("UINT32")]
    public uint id;

    [NativeTypeName("__AnonymousRecord_wingdi_L2977_C5")]
    public _Anonymous_e__Union Anonymous;
    public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY outputTechnology;
    public DISPLAYCONFIG_ROTATION rotation;
    public DISPLAYCONFIG_SCALING scaling;
    public DISPLAYCONFIG_RATIONAL refreshRate;
    public DISPLAYCONFIG_SCANLINE_ORDERING scanLineOrdering;
    public BOOL targetAvailable;

    [NativeTypeName("UINT32")]
    public uint statusFlags;

    [UnscopedRef]
    public ref uint modeInfoIdx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.modeInfoIdx; }
    }
    public uint desktopModeInfoIdx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.desktopModeInfoIdx; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.desktopModeInfoIdx = value; }
    }
    public uint targetModeInfoIdx
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Anonymous.Anonymous.targetModeInfoIdx; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Anonymous.Anonymous.targetModeInfoIdx = value; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint modeInfoIdx;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_wingdi_L2980_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;

            [NativeTypeName("UINT32 : 16")]
            public uint desktopModeInfoIdx
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return _bitfield & 0xFFFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu); }
            }

            [NativeTypeName("UINT32 : 16")]
            public uint targetModeInfoIdx
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                readonly get { return (_bitfield >> 16) & 0xFFFFu; }
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set { _bitfield = (_bitfield & ~(0xFFFFu << 16)) | ((value & 0xFFFFu) << 16); }
            }
        }
    }
}
