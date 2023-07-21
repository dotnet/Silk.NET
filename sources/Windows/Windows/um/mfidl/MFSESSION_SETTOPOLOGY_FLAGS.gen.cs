// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFSESSION_SETTOPOLOGY_FLAGS.xml' path='doc/member[@name="MFSESSION_SETTOPOLOGY_FLAGS"]/*' />
public enum MFSESSION_SETTOPOLOGY_FLAGS
{
    /// <include file='MFSESSION_SETTOPOLOGY_FLAGS.xml' path='doc/member[@name="MFSESSION_SETTOPOLOGY_FLAGS.MFSESSION_SETTOPOLOGY_IMMEDIATE"]/*' />
    MFSESSION_SETTOPOLOGY_IMMEDIATE = 0x1,

    /// <include file='MFSESSION_SETTOPOLOGY_FLAGS.xml' path='doc/member[@name="MFSESSION_SETTOPOLOGY_FLAGS.MFSESSION_SETTOPOLOGY_NORESOLUTION"]/*' />
    MFSESSION_SETTOPOLOGY_NORESOLUTION = 0x2,

    /// <include file='MFSESSION_SETTOPOLOGY_FLAGS.xml' path='doc/member[@name="MFSESSION_SETTOPOLOGY_FLAGS.MFSESSION_SETTOPOLOGY_CLEAR_CURRENT"]/*' />
    MFSESSION_SETTOPOLOGY_CLEAR_CURRENT = 0x4,
}
