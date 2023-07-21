// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STGMOVE.xml' path='doc/member[@name="STGMOVE"]/*' />
public enum STGMOVE
{
    /// <include file='STGMOVE.xml' path='doc/member[@name="STGMOVE.STGMOVE_MOVE"]/*' />
    STGMOVE_MOVE = 0,

    /// <include file='STGMOVE.xml' path='doc/member[@name="STGMOVE.STGMOVE_COPY"]/*' />
    STGMOVE_COPY = 1,

    /// <include file='STGMOVE.xml' path='doc/member[@name="STGMOVE.STGMOVE_SHALLOWCOPY"]/*' />
    STGMOVE_SHALLOWCOPY = 2,
}
