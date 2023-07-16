// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='IMAGE_SWITCHTABLE_BRANCH_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_SWITCHTABLE_BRANCH_DYNAMIC_RELOCATION"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct IMAGE_SWITCHTABLE_BRANCH_DYNAMIC_RELOCATION
{
    public ushort _bitfield;
    /// <include file='IMAGE_SWITCHTABLE_BRANCH_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_SWITCHTABLE_BRANCH_DYNAMIC_RELOCATION.PageRelativeOffset"]/*'/>
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

    /// <include file='IMAGE_SWITCHTABLE_BRANCH_DYNAMIC_RELOCATION.xml' path='doc/member[@name="IMAGE_SWITCHTABLE_BRANCH_DYNAMIC_RELOCATION.RegisterNumber"]/*'/>
    [NativeTypeName("WORD : 4")]
    public ushort RegisterNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)((_bitfield >> 12) & 0xFu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~(0xFu << 12)) | ((value & 0xFu) << 12));
        }
    }
}