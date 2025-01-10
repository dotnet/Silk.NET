// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct OVERLAPPED
{
    [NativeTypeName("ULONG_PTR")]
    public nuint Internal;

    [NativeTypeName("ULONG_PTR")]
    public nuint InternalHigh;

    [NativeTypeName("__AnonymousRecord_minwinbase_L55_C5")]
    public _Anonymous_e__Union Anonymous;
    public HANDLE hEvent;

    [UnscopedRef]
    public ref uint Offset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.Offset; }
    }

    [UnscopedRef]
    public ref uint OffsetHigh
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.OffsetHigh; }
    }

    [UnscopedRef]
    public ref void* Pointer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Pointer; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_minwinbase_L56_C9")]
        public _Anonymous_e__Struct Anonymous;

        [FieldOffset(0)]
        [NativeTypeName("PVOID")]
        public void* Pointer;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("DWORD")]
            public uint Offset;

            [NativeTypeName("DWORD")]
            public uint OffsetHigh;
        }
    }
}
