// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct FS_BPIO_OUTPUT
{
    public FS_BPIO_OPERATIONS Operation;
    public FS_BPIO_OUTFLAGS OutFlags;

    [NativeTypeName("DWORDLONG")]
    public ulong Reserved1;

    [NativeTypeName("DWORDLONG")]
    public ulong Reserved2;

    [NativeTypeName("__AnonymousRecord_winioctl_L17284_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref FS_BPIO_RESULTS Enable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Enable; }
    }

    [UnscopedRef]
    public ref FS_BPIO_RESULTS Query
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.Query; }
    }

    [UnscopedRef]
    public ref FS_BPIO_RESULTS VolumeStackResume
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.VolumeStackResume; }
    }

    [UnscopedRef]
    public ref FS_BPIO_RESULTS StreamResume
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.StreamResume; }
    }

    [UnscopedRef]
    public ref FS_BPIO_INFO GetInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.GetInfo; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public FS_BPIO_RESULTS Enable;

        [FieldOffset(0)]
        public FS_BPIO_RESULTS Query;

        [FieldOffset(0)]
        public FS_BPIO_RESULTS VolumeStackResume;

        [FieldOffset(0)]
        public FS_BPIO_RESULTS StreamResume;

        [FieldOffset(0)]
        public FS_BPIO_INFO GetInfo;
    }
}
