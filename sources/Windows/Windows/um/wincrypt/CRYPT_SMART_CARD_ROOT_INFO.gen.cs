// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRYPT_SMART_CARD_ROOT_INFO.xml' path='doc/member[@name="CRYPT_SMART_CARD_ROOT_INFO"]/*' />
public unsafe partial struct CRYPT_SMART_CARD_ROOT_INFO
{
    /// <include file='CRYPT_SMART_CARD_ROOT_INFO.xml' path='doc/member[@name="CRYPT_SMART_CARD_ROOT_INFO.rgbCardID"]/*' />
    [NativeTypeName("BYTE[16]")]
    public fixed byte rgbCardID[16];

    /// <include file='CRYPT_SMART_CARD_ROOT_INFO.xml' path='doc/member[@name="CRYPT_SMART_CARD_ROOT_INFO.luid"]/*' />
    public ROOT_INFO_LUID luid;
}
