// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ASSOCIATIONTYPE.xml' path='doc/member[@name="ASSOCIATIONTYPE"]/*' />
public enum ASSOCIATIONTYPE
{
    /// <include file='ASSOCIATIONTYPE.xml' path='doc/member[@name="ASSOCIATIONTYPE.AT_FILEEXTENSION"]/*' />
    AT_FILEEXTENSION = 0,

    /// <include file='ASSOCIATIONTYPE.xml' path='doc/member[@name="ASSOCIATIONTYPE.AT_URLPROTOCOL"]/*' />
    AT_URLPROTOCOL = (AT_FILEEXTENSION + 1),

    /// <include file='ASSOCIATIONTYPE.xml' path='doc/member[@name="ASSOCIATIONTYPE.AT_STARTMENUCLIENT"]/*' />
    AT_STARTMENUCLIENT = (AT_URLPROTOCOL + 1),

    /// <include file='ASSOCIATIONTYPE.xml' path='doc/member[@name="ASSOCIATIONTYPE.AT_MIMETYPE"]/*' />
    AT_MIMETYPE = (AT_STARTMENUCLIENT + 1),
}
