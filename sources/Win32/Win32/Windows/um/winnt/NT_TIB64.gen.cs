// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct NT_TIB64
{
    [NativeTypeName("DWORD64")]
    public ulong ExceptionList;

    [NativeTypeName("DWORD64")]
    public ulong StackBase;

    [NativeTypeName("DWORD64")]
    public ulong StackLimit;

    [NativeTypeName("DWORD64")]
    public ulong SubSystemTib;

    [NativeTypeName("__AnonymousRecord_winnt_L12812_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD64")]
    public ulong ArbitraryUserPointer;

    [NativeTypeName("DWORD64")]
    public ulong Self;

    [UnscopedRef]
    public ref ulong FiberData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.FiberData; }
    }

    [UnscopedRef]
    public ref uint Version
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Version; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD64")]
        public ulong FiberData;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Version;
    }
}
