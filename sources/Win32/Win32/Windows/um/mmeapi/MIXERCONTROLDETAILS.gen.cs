// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct MIXERCONTROLDETAILS
{
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    [NativeTypeName("DWORD")]
    public uint dwControlID;

    [NativeTypeName("DWORD")]
    public uint cChannels;

    [NativeTypeName("__AnonymousRecord_mmeapi_L2308_C5")]
    public _Anonymous_e__Union Anonymous;

    [NativeTypeName("DWORD")]
    public uint cbDetails;

    [NativeTypeName("LPVOID")]
    public void* paDetails;

    [UnscopedRef]
    public ref HWND hwndOwner
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.hwndOwner; }
    }

    [UnscopedRef]
    public ref uint cMultipleItems
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.cMultipleItems; }
    }

    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public HWND hwndOwner;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cMultipleItems;
    }
}
