// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[SupportedOSPlatform("windows6.2")]
public partial struct JOBOBJECT_CPU_RATE_CONTROL_INFORMATION
{
    [NativeTypeName("DWORD")]
    public uint ControlFlags;

    [NativeTypeName("__AnonymousRecord_winnt_L13515_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref uint CpuRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.CpuRate; }
    }

    [UnscopedRef]
    public ref uint Weight
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Weight; }
    }

    [UnscopedRef]
    public ref ushort MinRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.MinRate; }
    }

    [UnscopedRef]
    public ref ushort MaxRate
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Anonymous.MaxRate; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint CpuRate;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Weight;

        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L13518_C9")]
        public _Anonymous_e__Struct Anonymous;

        public partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("WORD")]
            public ushort MinRate;

            [NativeTypeName("WORD")]
            public ushort MaxRate;
        }
    }
}
