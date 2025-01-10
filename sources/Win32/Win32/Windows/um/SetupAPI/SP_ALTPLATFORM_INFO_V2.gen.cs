// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SP_ALTPLATFORM_INFO_V2
{
    [NativeTypeName("DWORD")]
    public uint cbSize;

    [NativeTypeName("DWORD")]
    public uint Platform;

    [NativeTypeName("DWORD")]
    public uint MajorVersion;

    [NativeTypeName("DWORD")]
    public uint MinorVersion;

    [NativeTypeName("WORD")]
    public ushort ProcessorArchitecture;

    [NativeTypeName("__AnonymousRecord_SetupAPI_L221_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint FirstValidatedMajorVersion;

    [NativeTypeName("DWORD")]
    public uint FirstValidatedMinorVersion;

    [UnscopedRef]
    public ref ushort Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Reserved; }
    }

    [UnscopedRef]
    public ref ushort Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Flags; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort Reserved;

        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort Flags;
    }
}
