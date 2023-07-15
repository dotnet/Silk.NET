// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='STORAGE_IDLE_POWER.xml' path='doc/member[@name="STORAGE_IDLE_POWER"]/*'/>
public partial struct STORAGE_IDLE_POWER
{
    /// <include file='STORAGE_IDLE_POWER.xml' path='doc/member[@name="STORAGE_IDLE_POWER.Version"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Version;
    /// <include file='STORAGE_IDLE_POWER.xml' path='doc/member[@name="STORAGE_IDLE_POWER.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    public uint _bitfield;
    /// <include file='STORAGE_IDLE_POWER.xml' path='doc/member[@name="STORAGE_IDLE_POWER.WakeCapableHint"]/*'/>
    [NativeTypeName("DWORD : 1")]
    public uint WakeCapableHint
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

    /// <include file='STORAGE_IDLE_POWER.xml' path='doc/member[@name="STORAGE_IDLE_POWER.D3ColdSupported"]/*'/>
    [NativeTypeName("DWORD : 1")]
    public uint D3ColdSupported
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

    /// <include file='STORAGE_IDLE_POWER.xml' path='doc/member[@name="STORAGE_IDLE_POWER.Reserved"]/*'/>
    [NativeTypeName("DWORD : 30")]
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

    /// <include file='STORAGE_IDLE_POWER.xml' path='doc/member[@name="STORAGE_IDLE_POWER.D3IdleTimeout"]/*'/>
    [NativeTypeName("DWORD")]
    public uint D3IdleTimeout;
}