// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/appmgmt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='INSTALLDATA.xml' path='doc/member[@name="INSTALLDATA"]/*' />
public partial struct INSTALLDATA
{
    /// <include file='INSTALLDATA.xml' path='doc/member[@name="INSTALLDATA.Type"]/*' />
    public INSTALLSPECTYPE Type;

    /// <include file='INSTALLDATA.xml' path='doc/member[@name="INSTALLDATA.Spec"]/*' />
    public INSTALLSPEC Spec;
}
