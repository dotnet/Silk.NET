// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct MARK_HANDLE_INFO
{
    [NativeTypeName("__AnonymousRecord_winioctl_L11917_C5")]
    public _Anonymous_e__Union Anonymous;
    public HANDLE VolumeHandle;

    [NativeTypeName("DWORD")]
    public uint HandleInfo;

    [UnscopedRef]
    public ref uint UsnSourceInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.UsnSourceInfo; }
    }

    [UnscopedRef]
    public ref uint CopyNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.CopyNumber; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint UsnSourceInfo;

        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint CopyNumber;
    }
}
