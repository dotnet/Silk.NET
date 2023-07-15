// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION.xml' path='doc/member[@name="SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION"]/*'/>
public partial struct SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION
{
    public uint _bitfield;
    /// <include file='SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION.xml' path='doc/member[@name="SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION.Machine"]/*'/>
    [NativeTypeName("DWORD : 16")]
    public uint Machine
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return _bitfield & 0xFFFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~0xFFFFu) | (value & 0xFFFFu);
        }
    }

    /// <include file='SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION.xml' path='doc/member[@name="SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION.KernelMode"]/*'/>
    [NativeTypeName("DWORD : 1")]
    public uint KernelMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 16) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 16)) | ((value & 0x1u) << 16);
        }
    }

    /// <include file='SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION.xml' path='doc/member[@name="SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION.UserMode"]/*'/>
    [NativeTypeName("DWORD : 1")]
    public uint UserMode
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 17) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 17)) | ((value & 0x1u) << 17);
        }
    }

    /// <include file='SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION.xml' path='doc/member[@name="SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION.Native"]/*'/>
    [NativeTypeName("DWORD : 1")]
    public uint Native
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 18) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 18)) | ((value & 0x1u) << 18);
        }
    }

    /// <include file='SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION.xml' path='doc/member[@name="SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION.Process"]/*'/>
    [NativeTypeName("DWORD : 1")]
    public uint Process
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 19) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 19)) | ((value & 0x1u) << 19);
        }
    }

    /// <include file='SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION.xml' path='doc/member[@name="SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION.WoW64Container"]/*'/>
    [NativeTypeName("DWORD : 1")]
    public uint WoW64Container
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 20) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 20)) | ((value & 0x1u) << 20);
        }
    }

    /// <include file='SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION.xml' path='doc/member[@name="SYSTEM_SUPPORTED_PROCESSOR_ARCHITECTURES_INFORMATION.ReservedZero0"]/*'/>
    [NativeTypeName("DWORD : 11")]
    public uint ReservedZero0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 21) & 0x7FFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x7FFu << 21)) | ((value & 0x7FFu) << 21);
        }
    }
}