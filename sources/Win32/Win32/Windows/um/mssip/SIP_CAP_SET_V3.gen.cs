// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mssip.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SIP_CAP_SET_V3
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint dwVersion;
    public BOOL isMultiSign;

    [NativeTypeName("__AnonymousRecord_mssip_L210_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref uint dwFlags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwFlags; }
    }

    [UnscopedRef]
    public ref uint dwReserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwReserved; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwFlags;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwReserved;
    }
}
