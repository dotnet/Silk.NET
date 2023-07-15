// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_CE_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_CE_RUNTIME_FUNCTION_ENTRY"]/*'/>
public partial struct IMAGE_CE_RUNTIME_FUNCTION_ENTRY
{
    /// <include file='IMAGE_CE_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_CE_RUNTIME_FUNCTION_ENTRY.FuncStart"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FuncStart;
    public uint _bitfield;
    /// <include file='IMAGE_CE_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_CE_RUNTIME_FUNCTION_ENTRY.PrologLen"]/*'/>
    [NativeTypeName("DWORD : 8")]
    public uint PrologLen
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return _bitfield & 0xFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0xFFu) | (value & 0xFFu);
        }
    }

    /// <include file='IMAGE_CE_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_CE_RUNTIME_FUNCTION_ENTRY.FuncLen"]/*'/>
    [NativeTypeName("DWORD : 22")]
    public uint FuncLen
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 8) & 0x3FFFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x3FFFFFu << 8)) | ((value & 0x3FFFFFu) << 8);
        }
    }

    /// <include file='IMAGE_CE_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_CE_RUNTIME_FUNCTION_ENTRY.ThirtyTwoBit"]/*'/>
    [NativeTypeName("DWORD : 1")]
    public uint ThirtyTwoBit
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 30) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 30)) | ((value & 0x1u) << 30);
        }
    }

    /// <include file='IMAGE_CE_RUNTIME_FUNCTION_ENTRY.xml' path='doc/member[@name="IMAGE_CE_RUNTIME_FUNCTION_ENTRY.ExceptionFlag"]/*'/>
    [NativeTypeName("DWORD : 1")]
    public uint ExceptionFlag
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 31) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 31)) | ((value & 0x1u) << 31);
        }
    }
}