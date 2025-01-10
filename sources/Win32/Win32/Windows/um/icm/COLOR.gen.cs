// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct COLOR
{
    [FieldOffset(0)]
    [NativeTypeName("struct GRAYCOLOR")]
    public GRAYCOLOR gray;

    [FieldOffset(0)]
    [NativeTypeName("struct RGBCOLOR")]
    public RGBCOLOR rgb;

    [FieldOffset(0)]
    [NativeTypeName("struct CMYKCOLOR")]
    public CMYKCOLOR cmyk;

    [FieldOffset(0)]
    [NativeTypeName("struct XYZCOLOR")]
    public XYZCOLOR XYZ;

    [FieldOffset(0)]
    [NativeTypeName("struct YxyCOLOR")]
    public YxyCOLOR Yxy;

    [FieldOffset(0)]
    [NativeTypeName("struct LabCOLOR")]
    public LabCOLOR Lab;

    [FieldOffset(0)]
    [NativeTypeName("struct GENERIC3CHANNEL")]
    public GENERIC3CHANNEL gen3ch;

    [FieldOffset(0)]
    [NativeTypeName("struct NAMEDCOLOR")]
    public NAMEDCOLOR named;

    [FieldOffset(0)]
    [NativeTypeName("struct HiFiCOLOR")]
    public HiFiCOLOR hifi;

    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_icm_L127_C5")]
    public _Anonymous_e__Struct Anonymous;

    [UnscopedRef]
    public ref uint reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.reserved1; }
    }

    [UnscopedRef]
    public ref void* reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.reserved2; }
    }

    public unsafe partial struct _Anonymous_e__Struct
    {
        [NativeTypeName("DWORD")]
        public uint reserved1;
        public void* reserved2;
    }

    [NativeTypeName("#define COLOR_MATCH_VERSION 0x0200")]
    public const int COLOR_MATCH_VERSION = 0x0200;
}
