// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct REGFILTER2
{
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    [NativeTypeName("DWORD")]
    public uint dwMerit;

    [NativeTypeName("__AnonymousRecord_strmif_L5314_C36")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref uint cPins
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous1.cPins; }
    }

    [UnscopedRef]
    public ref REGFILTERPINS* rgPins
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous1.rgPins; }
    }

    [UnscopedRef]
    public ref uint cPins2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous2.cPins2; }
    }

    [UnscopedRef]
    public ref REGFILTERPINS2* rgPins2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous2.rgPins2; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_strmif_L5316_C24")]
        public _Anonymous1_e__Struct Anonymous1;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_strmif_L5321_C24")]
        public _Anonymous2_e__Struct Anonymous2;

        public unsafe partial struct _Anonymous1_e__Struct
        {
            [NativeTypeName("ULONG")]
            public uint cPins;

            [NativeTypeName("const REGFILTERPINS *")]
            public REGFILTERPINS* rgPins;
        }

        public unsafe partial struct _Anonymous2_e__Struct
        {
            [NativeTypeName("ULONG")]
            public uint cPins2;

            [NativeTypeName("const REGFILTERPINS2 *")]
            public REGFILTERPINS2* rgPins2;
        }
    }
}
