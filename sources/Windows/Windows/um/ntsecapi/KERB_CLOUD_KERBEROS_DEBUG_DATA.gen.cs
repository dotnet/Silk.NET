// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace Silk.NET.Windows;
/// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA"]/*'/>
public partial struct KERB_CLOUD_KERBEROS_DEBUG_DATA
{
    public uint _bitfield;
    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA.EnabledByPolicy"]/*'/>
    [NativeTypeName("unsigned int : 1")]
    public uint EnabledByPolicy
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

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA.AsRepCallbackPresent"]/*'/>
    [NativeTypeName("unsigned int : 1")]
    public uint AsRepCallbackPresent
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

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA.AsRepCallbackUsed"]/*'/>
    [NativeTypeName("unsigned int : 1")]
    public uint AsRepCallbackUsed
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 2) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 2)) | ((value & 0x1u) << 2);
        }
    }

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA.CloudReferralTgtAvailable"]/*'/>
    [NativeTypeName("unsigned int : 1")]
    public uint CloudReferralTgtAvailable
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 3) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 3)) | ((value & 0x1u) << 3);
        }
    }

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA.SpnOracleConfigured"]/*'/>
    [NativeTypeName("unsigned int : 1")]
    public uint SpnOracleConfigured
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 4) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 4)) | ((value & 0x1u) << 4);
        }
    }

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA.KdcProxyPresent"]/*'/>
    [NativeTypeName("unsigned int : 1")]
    public uint KdcProxyPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 5) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 5)) | ((value & 0x1u) << 5);
        }
    }

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA.PublicKeyCredsPresent"]/*'/>
    [NativeTypeName("unsigned int : 1")]
    public uint PublicKeyCredsPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 6) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 6)) | ((value & 0x1u) << 6);
        }
    }

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA.PasswordKeysPresent"]/*'/>
    [NativeTypeName("unsigned int : 1")]
    public uint PasswordKeysPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 7) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 7)) | ((value & 0x1u) << 7);
        }
    }

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA.PasswordPresent"]/*'/>
    [NativeTypeName("unsigned int : 1")]
    public uint PasswordPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 8) & 0x1u;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8);
        }
    }

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA.AsRepSourceCred"]/*'/>
    [NativeTypeName("unsigned int : 8")]
    public uint AsRepSourceCred
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (_bitfield >> 9) & 0xFFu;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (_bitfield & ~(0xFFu << 9)) | ((value & 0xFFu) << 9);
        }
    }
}