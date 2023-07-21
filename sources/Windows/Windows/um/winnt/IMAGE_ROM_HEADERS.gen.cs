// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGE_ROM_HEADERS.xml' path='doc/member[@name="IMAGE_ROM_HEADERS"]/*' />
public partial struct IMAGE_ROM_HEADERS
{
    /// <include file='IMAGE_ROM_HEADERS.xml' path='doc/member[@name="IMAGE_ROM_HEADERS.FileHeader"]/*' />
    public IMAGE_FILE_HEADER FileHeader;

    /// <include file='IMAGE_ROM_HEADERS.xml' path='doc/member[@name="IMAGE_ROM_HEADERS.OptionalHeader"]/*' />
    public IMAGE_ROM_OPTIONAL_HEADER OptionalHeader;
}
