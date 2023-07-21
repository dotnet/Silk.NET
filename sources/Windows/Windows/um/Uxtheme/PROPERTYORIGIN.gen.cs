// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Uxtheme.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PROPERTYORIGIN.xml' path='doc/member[@name="PROPERTYORIGIN"]/*' />
public enum PROPERTYORIGIN
{
    /// <include file='PROPERTYORIGIN.xml' path='doc/member[@name="PROPERTYORIGIN.PO_STATE"]/*' />
    PO_STATE,

    /// <include file='PROPERTYORIGIN.xml' path='doc/member[@name="PROPERTYORIGIN.PO_PART"]/*' />
    PO_PART,

    /// <include file='PROPERTYORIGIN.xml' path='doc/member[@name="PROPERTYORIGIN.PO_CLASS"]/*' />
    PO_CLASS,

    /// <include file='PROPERTYORIGIN.xml' path='doc/member[@name="PROPERTYORIGIN.PO_GLOBAL"]/*' />
    PO_GLOBAL,

    /// <include file='PROPERTYORIGIN.xml' path='doc/member[@name="PROPERTYORIGIN.PO_NOTFOUND"]/*' />
    PO_NOTFOUND,
}
