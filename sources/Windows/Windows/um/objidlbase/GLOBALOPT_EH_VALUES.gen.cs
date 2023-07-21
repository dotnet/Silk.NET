// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='GLOBALOPT_EH_VALUES.xml' path='doc/member[@name="GLOBALOPT_EH_VALUES"]/*' />
public enum GLOBALOPT_EH_VALUES
{
    /// <include file='GLOBALOPT_EH_VALUES.xml' path='doc/member[@name="GLOBALOPT_EH_VALUES.COMGLB_EXCEPTION_HANDLE"]/*' />
    COMGLB_EXCEPTION_HANDLE = 0,

    /// <include file='GLOBALOPT_EH_VALUES.xml' path='doc/member[@name="GLOBALOPT_EH_VALUES.COMGLB_EXCEPTION_DONOT_HANDLE_FATAL"]/*' />
    COMGLB_EXCEPTION_DONOT_HANDLE_FATAL = 1,

    /// <include file='GLOBALOPT_EH_VALUES.xml' path='doc/member[@name="GLOBALOPT_EH_VALUES.COMGLB_EXCEPTION_DONOT_HANDLE"]/*' />
    COMGLB_EXCEPTION_DONOT_HANDLE = COMGLB_EXCEPTION_DONOT_HANDLE_FATAL,

    /// <include file='GLOBALOPT_EH_VALUES.xml' path='doc/member[@name="GLOBALOPT_EH_VALUES.COMGLB_EXCEPTION_DONOT_HANDLE_ANY"]/*' />
    COMGLB_EXCEPTION_DONOT_HANDLE_ANY = 2,
}
