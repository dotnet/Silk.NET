// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct IMAGE_IMPORT_DESCRIPTOR
{
    [NativeTypeName("__AnonymousRecord_winnt_L20596_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    [NativeTypeName("DWORD")]
    public uint ForwarderChain;

    [NativeTypeName("DWORD")]
    public uint Name;

    [NativeTypeName("DWORD")]
    public uint FirstThunk;

    [UnscopedRef]
    public ref uint Characteristics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Characteristics; }
    }

    [UnscopedRef]
    public ref uint OriginalFirstThunk
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.OriginalFirstThunk; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Characteristics;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint OriginalFirstThunk;
    }
}
