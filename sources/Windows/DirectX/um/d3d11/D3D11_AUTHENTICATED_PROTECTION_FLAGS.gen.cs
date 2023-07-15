// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_AUTHENTICATED_PROTECTION_FLAGS.xml' path='doc/member[@name="D3D11_AUTHENTICATED_PROTECTION_FLAGS"]/*'/>
[StructLayout(LayoutKind.Explicit)]
public partial struct D3D11_AUTHENTICATED_PROTECTION_FLAGS
{
    /// <include file='D3D11_AUTHENTICATED_PROTECTION_FLAGS.xml' path='doc/member[@name="D3D11_AUTHENTICATED_PROTECTION_FLAGS.Flags"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("struct __MIDL___MIDL_itf_d3d11_0000_0034_0001")]
    public _Flags_e__Struct Flags;
    /// <include file='D3D11_AUTHENTICATED_PROTECTION_FLAGS.xml' path='doc/member[@name="D3D11_AUTHENTICATED_PROTECTION_FLAGS.Value"]/*'/>
    [FieldOffset(0)]
    public uint Value;
    /// <include file='_Flags_e__Struct.xml' path='doc/member[@name="_Flags_e__Struct"]/*'/>
    public partial struct _Flags_e__Struct
    {
        public uint _bitfield;
        /// <include file='_Flags_e__Struct.xml' path='doc/member[@name="_Flags_e__Struct.ProtectionEnabled"]/*'/>
        [NativeTypeName("uint : 1")]
        public uint ProtectionEnabled
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x1u) | (value & 0x1u);
            }
        }

        /// <include file='_Flags_e__Struct.xml' path='doc/member[@name="_Flags_e__Struct.OverlayOrFullscreenRequired"]/*'/>
        [NativeTypeName("uint : 1")]
        public uint OverlayOrFullscreenRequired
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 1) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 1)) | ((value & 0x1u) << 1);
            }
        }

        /// <include file='_Flags_e__Struct.xml' path='doc/member[@name="_Flags_e__Struct.Reserved"]/*'/>
        [NativeTypeName("uint : 30")]
        public uint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 2) & 0x3FFFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x3FFFFFFFu << 2)) | ((value & 0x3FFFFFFFu) << 2);
            }
        }
    }
}