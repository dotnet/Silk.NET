// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='IMAGE_INDIR_CONTROL_TRANSFER_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_INDIR_CONTROL_TRANSFER_DYNAMIC_RELOCATION"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct IMAGE_INDIR_CONTROL_TRANSFER_DYNAMIC_RELOCATION
{
    public ushort _bitfield;
    /// <include file='IMAGE_INDIR_CONTROL_TRANSFER_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_INDIR_CONTROL_TRANSFER_DYNAMIC_RELOCATION.PageRelativeOffset"]/*'/>
    [NativeTypeName("WORD : 12")]
    public ushort PageRelativeOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)(_bitfield & 0xFFFu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~0xFFFu) | (value & 0xFFFu));
        }
    }

    /// <include file='IMAGE_INDIR_CONTROL_TRANSFER_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_INDIR_CONTROL_TRANSFER_DYNAMIC_RELOCATION.IndirectCall"]/*'/>
    [NativeTypeName("WORD : 1")]
    public ushort IndirectCall
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)((_bitfield >> 12) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12));
        }
    }

    /// <include file='IMAGE_INDIR_CONTROL_TRANSFER_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_INDIR_CONTROL_TRANSFER_DYNAMIC_RELOCATION.RexWPrefix"]/*'/>
    [NativeTypeName("WORD : 1")]
    public ushort RexWPrefix
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)((_bitfield >> 13) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~(0x1u << 13)) | ((value & 0x1u) << 13));
        }
    }

    /// <include file='IMAGE_INDIR_CONTROL_TRANSFER_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_INDIR_CONTROL_TRANSFER_DYNAMIC_RELOCATION.CfgCheck"]/*'/>
    [NativeTypeName("WORD : 1")]
    public ushort CfgCheck
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)((_bitfield >> 14) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~(0x1u << 14)) | ((value & 0x1u) << 14));
        }
    }

    /// <include file='IMAGE_INDIR_CONTROL_TRANSFER_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_INDIR_CONTROL_TRANSFER_DYNAMIC_RELOCATION.Reserved"]/*'/>
    [NativeTypeName("WORD : 1")]
    public ushort Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)((_bitfield >> 15) & 0x1u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~(0x1u << 15)) | ((value & 0x1u) << 15));
        }
    }
}