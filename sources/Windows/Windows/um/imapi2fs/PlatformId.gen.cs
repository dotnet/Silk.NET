// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PlatformId.xml' path='doc/member[@name="PlatformId"]/*' />
public enum PlatformId
{
    /// <include file='PlatformId.xml' path='doc/member[@name="PlatformId.PlatformX86"]/*' />
    PlatformX86 = 0,

    /// <include file='PlatformId.xml' path='doc/member[@name="PlatformId.PlatformPowerPC"]/*' />
    PlatformPowerPC = 1,

    /// <include file='PlatformId.xml' path='doc/member[@name="PlatformId.PlatformMac"]/*' />
    PlatformMac = 2,

    /// <include file='PlatformId.xml' path='doc/member[@name="PlatformId.PlatformEFI"]/*' />
    PlatformEFI = 0xef,
}
