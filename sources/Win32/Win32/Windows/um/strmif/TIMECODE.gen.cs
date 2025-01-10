// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Explicit)]
public partial struct TIMECODE
{
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_strmif_L14218_C4")]
    public _Anonymous_e__Struct Anonymous;

    [FieldOffset(0)]
    [NativeTypeName("DWORDLONG")]
    public ulong qw;

    [UnscopedRef]
    public ref ushort wFrameRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.wFrameRate; }
    }

    [UnscopedRef]
    public ref ushort wFrameFract
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.wFrameFract; }
    }

    [UnscopedRef]
    public ref uint dwFrames
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwFrames; }
    }

    public partial struct _Anonymous_e__Struct
    {
        [NativeTypeName("WORD")]
        public ushort wFrameRate;

        [NativeTypeName("WORD")]
        public ushort wFrameFract;

        [NativeTypeName("DWORD")]
        public uint dwFrames;
    }
}
