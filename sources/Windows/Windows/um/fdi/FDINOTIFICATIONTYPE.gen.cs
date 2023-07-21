// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/fdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FDINOTIFICATIONTYPE.xml' path='doc/member[@name="FDINOTIFICATIONTYPE"]/*' />
public enum FDINOTIFICATIONTYPE
{
    /// <include file='FDINOTIFICATIONTYPE.xml' path='doc/member[@name="FDINOTIFICATIONTYPE.fdintCABINET_INFO"]/*' />
    fdintCABINET_INFO,

    /// <include file='FDINOTIFICATIONTYPE.xml' path='doc/member[@name="FDINOTIFICATIONTYPE.fdintPARTIAL_FILE"]/*' />
    fdintPARTIAL_FILE,

    /// <include file='FDINOTIFICATIONTYPE.xml' path='doc/member[@name="FDINOTIFICATIONTYPE.fdintCOPY_FILE"]/*' />
    fdintCOPY_FILE,

    /// <include file='FDINOTIFICATIONTYPE.xml' path='doc/member[@name="FDINOTIFICATIONTYPE.fdintCLOSE_FILE_INFO"]/*' />
    fdintCLOSE_FILE_INFO,

    /// <include file='FDINOTIFICATIONTYPE.xml' path='doc/member[@name="FDINOTIFICATIONTYPE.fdintNEXT_CABINET"]/*' />
    fdintNEXT_CABINET,

    /// <include file='FDINOTIFICATIONTYPE.xml' path='doc/member[@name="FDINOTIFICATIONTYPE.fdintENUMERATE"]/*' />
    fdintENUMERATE,
}
