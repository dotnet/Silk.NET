// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sysinfoapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct SYSTEM_INFO
{
    [NativeTypeName("__AnonymousRecord_sysinfoapi_L48_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint dwPageSize;

    [NativeTypeName("LPVOID")]
    public void* lpMinimumApplicationAddress;

    [NativeTypeName("LPVOID")]
    public void* lpMaximumApplicationAddress;

    [NativeTypeName("DWORD_PTR")]
    public nuint dwActiveProcessorMask;

    [NativeTypeName("DWORD")]
    public uint dwNumberOfProcessors;

    [NativeTypeName("DWORD")]
    public uint dwProcessorType;

    [NativeTypeName("DWORD")]
    public uint dwAllocationGranularity;

    [NativeTypeName("WORD")]
    public ushort wProcessorLevel;

    [NativeTypeName("WORD")]
    public ushort wProcessorRevision;

    [UnscopedRef]
    public ref uint dwOemId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwOemId; }
    }

    [UnscopedRef]
    public ref ushort wProcessorArchitecture
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.wProcessorArchitecture; }
    }

    [UnscopedRef]
    public ref ushort wReserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.wReserved; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwOemId;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_sysinfoapi_L50_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("WORD")]
            public ushort wProcessorArchitecture;

            [NativeTypeName("WORD")]
            public ushort wReserved;
        }
    }
}
