// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[StructLayout(LayoutKind.Explicit)]
public partial struct D3D11_AUTHENTICATED_PROTECTION_FLAGS
{
    [FieldOffset(0)]
    [NativeTypeName("struct __MIDL___MIDL_itf_d3d11_0000_0034_0001")]
    public _Flags_e__Struct Flags;

    [FieldOffset(0)]
    public uint Value;

    public partial struct _Flags_e__Struct
    {
        public uint _bitfield;

        [NativeTypeName("uint : 1")]
        public uint ProtectionEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return _bitfield & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~0x1u) | (value & 0x1u); }
        }

        [NativeTypeName("uint : 1")]
        public uint OverlayOrFullscreenRequired
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 1) & 0x1u; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1); }
        }

        [NativeTypeName("uint : 30")]
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            readonly get { return (_bitfield >> 2) & 0x3FFFFFFFu; }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2); }
        }
    }
}
