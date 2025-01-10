// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct IO_STATUS_BLOCK
{
    [NativeTypeName("__AnonymousRecord_winternl_L226_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("ULONG_PTR")]
    public nuint Information;

    [UnscopedRef]
    public ref int Status
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Status; }
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
        [NativeTypeName("NTSTATUS")]
        public int Status;

        [FieldOffset(0)]
        [NativeTypeName("PVOID")]
        public void* Pointer;
    }
}
