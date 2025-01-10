// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public partial struct STORAGE_REINITIALIZE_MEDIA
{
    [NativeTypeName("DWORD")]
    public uint Version;

    [NativeTypeName("DWORD")]
    public uint Size;

    [NativeTypeName("DWORD")]
    public uint TimeoutInSeconds;

    [NativeTypeName("__AnonymousRecord_winioctl_L5763_C5")]
    public _SanitizeOption_e__Struct SanitizeOption;

    public partial struct _SanitizeOption_e__Struct
    {
        public uint _bitfield;

        [NativeTypeName("DWORD : 4")]
        public uint SanitizeMethod
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield & 0xFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~0xFu) | (value & 0xFu); }
        }

        [NativeTypeName("DWORD : 1")]
        public uint DisallowUnrestrictedSanitizeExit
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 4) & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4); }
        }

        [NativeTypeName("DWORD : 27")]
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 5) & 0x7FFFFFFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x7FFFFFFu << 5)) | ((value & 0x7FFFFFFu) << 5); }
        }
    }
}
