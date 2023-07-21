// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='UDATE.xml' path='doc/member[@name="UDATE"]/*' />
public partial struct UDATE
{
    /// <include file='UDATE.xml' path='doc/member[@name="UDATE.st"]/*' />
    public SYSTEMTIME st;

    /// <include file='UDATE.xml' path='doc/member[@name="UDATE.wDayOfYear"]/*' />
    public ushort wDayOfYear;
}
