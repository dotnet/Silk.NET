// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct ACTRL_OVERLAPPED
{
    [NativeTypeName("__AnonymousRecord_accctrl_L658_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("ULONG")]
    public uint Reserved2;
    public HANDLE hEvent;

    [UnscopedRef]
    public ref void* Provider
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Provider; }
    }

    [UnscopedRef]
    public ref uint Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Reserved1; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("PVOID")]
        public void* Provider;

        [FieldOffset(0)]
        [NativeTypeName("ULONG")]
        public uint Reserved1;
    }
}
