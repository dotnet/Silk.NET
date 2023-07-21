// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WICPersistOptions.xml' path='doc/member[@name="WICPersistOptions"]/*' />
public enum WICPersistOptions
{
    /// <include file='WICPersistOptions.xml' path='doc/member[@name="WICPersistOptions.WICPersistOptionDefault"]/*' />
    WICPersistOptionDefault = 0,

    /// <include file='WICPersistOptions.xml' path='doc/member[@name="WICPersistOptions.WICPersistOptionLittleEndian"]/*' />
    WICPersistOptionLittleEndian = 0,

    /// <include file='WICPersistOptions.xml' path='doc/member[@name="WICPersistOptions.WICPersistOptionBigEndian"]/*' />
    WICPersistOptionBigEndian = 0x1,

    /// <include file='WICPersistOptions.xml' path='doc/member[@name="WICPersistOptions.WICPersistOptionStrictFormat"]/*' />
    WICPersistOptionStrictFormat = 0x2,

    /// <include file='WICPersistOptions.xml' path='doc/member[@name="WICPersistOptions.WICPersistOptionNoCacheStream"]/*' />
    WICPersistOptionNoCacheStream = 0x4,

    /// <include file='WICPersistOptions.xml' path='doc/member[@name="WICPersistOptions.WICPersistOptionPreferUTF8"]/*' />
    WICPersistOptionPreferUTF8 = 0x8,

    /// <include file='WICPersistOptions.xml' path='doc/member[@name="WICPersistOptions.WICPersistOptionMask"]/*' />
    WICPersistOptionMask = 0xffff,
}
