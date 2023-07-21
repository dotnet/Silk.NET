// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='APPDOCLISTTYPE.xml' path='doc/member[@name="APPDOCLISTTYPE"]/*' />
public enum APPDOCLISTTYPE
{
    /// <include file='APPDOCLISTTYPE.xml' path='doc/member[@name="APPDOCLISTTYPE.ADLT_RECENT"]/*' />
    ADLT_RECENT = 0,

    /// <include file='APPDOCLISTTYPE.xml' path='doc/member[@name="APPDOCLISTTYPE.ADLT_FREQUENT"]/*' />
    ADLT_FREQUENT = (ADLT_RECENT + 1),
}
