// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct SCM_PD_REINITIALIZE_MEDIA_INPUT
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("__AnonymousRecord_winioctl_L8618_C5")]
    public _Options_e__Struct Options;

    public partial struct _Options_e__Struct
    {
        public uint _bitfield;

        [NativeTypeName("DWORD : 1")]
        public uint Overwrite
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
        }
    }
}
