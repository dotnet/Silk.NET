// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION
{
    public uint _bitfield;
    /// <include file='IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION.PageRelativeOffset"]/*'/>
    [NativeTypeName("DWORD : 12")]
    public uint PageRelativeOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return _bitfield & 0xFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0xFFFu) | (value & 0xFFFu);
        }
    }

    /// <include file='IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION.IndirectCall"]/*'/>
    [NativeTypeName("DWORD : 1")]
    public uint IndirectCall
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 12) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 12)) | ((value & 0x1u) << 12);
        }
    }

    /// <include file='IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_IMPORT_CONTROL_TRANSFER_DYNAMIC_RELOCATION.IATIndex"]/*'/>
    [NativeTypeName("DWORD : 19")]
    public uint IATIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 13) & 0x7FFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x7FFFFu << 13)) | ((value & 0x7FFFFu) << 13);
        }
    }
}