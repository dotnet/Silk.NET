// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STGTY.xml' path='doc/member[@name="STGTY"]/*' />
public enum STGTY
{
    /// <include file='STGTY.xml' path='doc/member[@name="STGTY.STGTY_STORAGE"]/*' />
    STGTY_STORAGE = 1,

    /// <include file='STGTY.xml' path='doc/member[@name="STGTY.STGTY_STREAM"]/*' />
    STGTY_STREAM = 2,

    /// <include file='STGTY.xml' path='doc/member[@name="STGTY.STGTY_LOCKBYTES"]/*' />
    STGTY_LOCKBYTES = 3,

    /// <include file='STGTY.xml' path='doc/member[@name="STGTY.STGTY_PROPERTY"]/*' />
    STGTY_PROPERTY = 4,
}
