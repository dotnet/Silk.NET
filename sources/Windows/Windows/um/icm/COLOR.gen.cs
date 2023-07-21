// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct COLOR
{
    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.gray"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct GRAYCOLOR")]
    public GRAYCOLOR gray;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.rgb"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct RGBCOLOR")]
    public RGBCOLOR rgb;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.cmyk"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct CMYKCOLOR")]
    public CMYKCOLOR cmyk;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.XYZ"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct XYZCOLOR")]
    public XYZCOLOR XYZ;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.Yxy"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct YxyCOLOR")]
    public YxyCOLOR Yxy;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.Lab"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct LabCOLOR")]
    public LabCOLOR Lab;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.gen3ch"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct GENERIC3CHANNEL")]
    public GENERIC3CHANNEL gen3ch;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.named"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct NAMEDCOLOR")]
    public NAMEDCOLOR named;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.hifi"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("struct HiFiCOLOR")]
    public HiFiCOLOR hifi;

    /// <include file='COLOR.xml' path='doc/member[@name="COLOR.Anonymous"]/*' />
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_icm_L127_C5")]
    public _Anonymous_e__Struct Anonymous;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved1"]/*' />
    [UnscopedRef]
    public ref uint reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.reserved1;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved2"]/*' />
    [UnscopedRef]
    public ref void* reserved2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.reserved2;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
    public unsafe partial struct _Anonymous_e__Struct
    {
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved1"]/*' />
        [NativeTypeName("DWORD")]
        public uint reserved1;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.reserved2"]/*' />
        public void* reserved2;
    }

    [NativeTypeName("#define COLOR_MATCH_VERSION 0x0200")]
    public const int COLOR_MATCH_VERSION = 0x0200;
}
