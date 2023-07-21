// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SHREGDEL_FLAGS.xml' path='doc/member[@name="SHREGDEL_FLAGS"]/*' />
public enum SHREGDEL_FLAGS
{
    /// <include file='SHREGDEL_FLAGS.xml' path='doc/member[@name="SHREGDEL_FLAGS.SHREGDEL_DEFAULT"]/*' />
    SHREGDEL_DEFAULT = 0x00000000,

    /// <include file='SHREGDEL_FLAGS.xml' path='doc/member[@name="SHREGDEL_FLAGS.SHREGDEL_HKCU"]/*' />
    SHREGDEL_HKCU = 0x00000001,

    /// <include file='SHREGDEL_FLAGS.xml' path='doc/member[@name="SHREGDEL_FLAGS.SHREGDEL_HKLM"]/*' />
    SHREGDEL_HKLM = 0x00000010,

    /// <include file='SHREGDEL_FLAGS.xml' path='doc/member[@name="SHREGDEL_FLAGS.SHREGDEL_BOTH"]/*' />
    SHREGDEL_BOTH = 0x00000011,
}
