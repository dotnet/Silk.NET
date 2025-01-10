// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct VIDEOINFOHEADER2
{
    public RECT rcSource;
    public RECT rcTarget;

    [NativeTypeName("DWORD")]
    public uint dwBitRate;

    [NativeTypeName("DWORD")]
    public uint dwBitErrorRate;

    [NativeTypeName("REFERENCE_TIME")]
    public long AvgTimePerFrame;

    [NativeTypeName("DWORD")]
    public uint dwInterlaceFlags;

    [NativeTypeName("DWORD")]
    public uint dwCopyProtectFlags;

    [NativeTypeName("DWORD")]
    public uint dwPictAspectRatioX;

    [NativeTypeName("DWORD")]
    public uint dwPictAspectRatioY;

    [NativeTypeName("__AnonymousRecord_dvdmedia_L317_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint dwReserved2;
    public BITMAPINFOHEADER bmiHeader;

    [UnscopedRef]
    public ref uint dwControlFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwControlFlags; }
    }

    [UnscopedRef]
    public ref uint dwReserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwReserved1; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwControlFlags;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwReserved1;
    }
}
