// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SD_GLOBAL_CHANGE_OUTPUT
{
    [NativeTypeName("DWORD")]
    public uint Flags;

    [NativeTypeName("DWORD")]
    public uint ChangeType;

    [NativeTypeName("__AnonymousRecord_winioctl_L14639_C5")]
    public _Anonymous_e__Union Anonymous;

    [UnscopedRef]
    public ref SD_CHANGE_MACHINE_SID_OUTPUT SdChange
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.SdChange; }
    }

    [UnscopedRef]
    public ref SD_QUERY_STATS_OUTPUT SdQueryStats
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.SdQueryStats; }
    }

    [UnscopedRef]
    public ref SD_ENUM_SDS_OUTPUT SdEnumSds
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get { return ref Anonymous.SdEnumSds; }
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        [FieldOffset(0)]
        public SD_CHANGE_MACHINE_SID_OUTPUT SdChange;

        [FieldOffset(0)]
        public SD_QUERY_STATS_OUTPUT SdQueryStats;

        [FieldOffset(0)]
        public SD_ENUM_SDS_OUTPUT SdEnumSds;
    }
}
