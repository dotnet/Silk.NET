// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SHELLDETAILS.xml' path='doc/member[@name="SHELLDETAILS"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHELLDETAILS
{
    /// <include file='SHELLDETAILS.xml' path='doc/member[@name="SHELLDETAILS.fmt"]/*' />
    public int fmt;

    /// <include file='SHELLDETAILS.xml' path='doc/member[@name="SHELLDETAILS.cxChar"]/*' />
    public int cxChar;

    /// <include file='SHELLDETAILS.xml' path='doc/member[@name="SHELLDETAILS.str"]/*' />
    public STRRET str;
}
