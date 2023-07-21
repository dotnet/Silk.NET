// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='PATHNAME_BUFFER.xml' path='doc/member[@name="PATHNAME_BUFFER"]/*' />
public unsafe partial struct PATHNAME_BUFFER
{
    /// <include file='PATHNAME_BUFFER.xml' path='doc/member[@name="PATHNAME_BUFFER.PathNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint PathNameLength;

    /// <include file='PATHNAME_BUFFER.xml' path='doc/member[@name="PATHNAME_BUFFER.Name"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort Name[1];
}
