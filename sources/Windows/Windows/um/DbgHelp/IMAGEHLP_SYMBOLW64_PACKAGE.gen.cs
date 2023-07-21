// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGEHLP_SYMBOLW64_PACKAGE.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW64_PACKAGE"]/*' />
public unsafe partial struct IMAGEHLP_SYMBOLW64_PACKAGE
{
    /// <include file='IMAGEHLP_SYMBOLW64_PACKAGE.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW64_PACKAGE.sym"]/*' />
    public IMAGEHLP_SYMBOLW64 sym;

    /// <include file='IMAGEHLP_SYMBOLW64_PACKAGE.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW64_PACKAGE.name"]/*' />
    [NativeTypeName("WCHAR[2001]")]
    public fixed ushort name[2001];
}
