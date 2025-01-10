// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIXERLINECONTROLSW
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    [NativeTypeName("DWORD")]
    public uint dwLineID;

    [NativeTypeName("__AnonymousRecord_mmeapi_L2234_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint cControls;

    [NativeTypeName("DWORD")]
    public uint cbmxctrl;

    [NativeTypeName("LPMIXERCONTROLW")]
    public MIXERCONTROLW* pamxctrl;

    [UnscopedRef]
    public ref uint dwControlID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwControlID; }
    }

    [UnscopedRef]
    public ref uint dwControlType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwControlType; }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwControlID;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwControlType;
    }
}
