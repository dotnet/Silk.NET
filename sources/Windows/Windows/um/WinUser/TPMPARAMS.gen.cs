// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TPMPARAMS.xml' path='doc/member[@name="TPMPARAMS"]/*' />
public partial struct TPMPARAMS
{
    /// <include file='TPMPARAMS.xml' path='doc/member[@name="TPMPARAMS.cbSize"]/*' />
    public uint cbSize;

    /// <include file='TPMPARAMS.xml' path='doc/member[@name="TPMPARAMS.rcExclude"]/*' />
    public RECT rcExclude;
}
