// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public partial struct DDSCAPSEX
{
    [NativeTypeName("DWORD")]
    public uint dwCaps2;

    [NativeTypeName("DWORD")]
    public uint dwCaps3;

    [NativeTypeName("__AnonymousRecord_ddraw_L356_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref uint dwCaps4
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwCaps4; }
    }

    [UnscopedRef]
    public ref uint dwVolumeDepth
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.dwVolumeDepth; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwCaps4;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwVolumeDepth;
    }
}
