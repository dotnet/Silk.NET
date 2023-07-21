// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CHARSETINFO.xml' path='doc/member[@name="CHARSETINFO"]/*' />
public partial struct CHARSETINFO
{
    /// <include file='CHARSETINFO.xml' path='doc/member[@name="CHARSETINFO.ciCharset"]/*' />
    public uint ciCharset;

    /// <include file='CHARSETINFO.xml' path='doc/member[@name="CHARSETINFO.ciACP"]/*' />
    public uint ciACP;

    /// <include file='CHARSETINFO.xml' path='doc/member[@name="CHARSETINFO.fs"]/*' />
    public FONTSIGNATURE fs;
}
