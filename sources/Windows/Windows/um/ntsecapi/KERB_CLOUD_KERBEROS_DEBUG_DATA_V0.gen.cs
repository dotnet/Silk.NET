// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;
/// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA_V0"]/*'/>
public partial struct KERB_CLOUD_KERBEROS_DEBUG_DATA_V0
{
    public uint _bitfield;
    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.EnabledByPolicy"]/*'/>
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

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.AsRepCallbackPresent"]/*'/>
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

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.AsRepCallbackUsed"]/*'/>
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

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.CloudReferralTgtAvailable"]/*'/>
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

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.SpnOracleConfigured"]/*'/>
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

    /// <include file='KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.xml' path='doc/member[@name="KERB_CLOUD_KERBEROS_DEBUG_DATA_V0.KdcProxyPresent"]/*'/>
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
}