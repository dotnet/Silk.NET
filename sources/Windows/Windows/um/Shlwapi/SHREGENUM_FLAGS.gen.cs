// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Shlwapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SHREGENUM_FLAGS.xml' path='doc/member[@name="SHREGENUM_FLAGS"]/*' />
public enum SHREGENUM_FLAGS
{
    /// <include file='SHREGENUM_FLAGS.xml' path='doc/member[@name="SHREGENUM_FLAGS.SHREGENUM_DEFAULT"]/*' />
    SHREGENUM_DEFAULT = 0x00000000,

    /// <include file='SHREGENUM_FLAGS.xml' path='doc/member[@name="SHREGENUM_FLAGS.SHREGENUM_HKCU"]/*' />
    SHREGENUM_HKCU = 0x00000001,

    /// <include file='SHREGENUM_FLAGS.xml' path='doc/member[@name="SHREGENUM_FLAGS.SHREGENUM_HKLM"]/*' />
    SHREGENUM_HKLM = 0x00000010,

    /// <include file='SHREGENUM_FLAGS.xml' path='doc/member[@name="SHREGENUM_FLAGS.SHREGENUM_BOTH"]/*' />
    SHREGENUM_BOTH = 0x00000011,
}
