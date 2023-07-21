// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DVASPECTINFO.xml' path='doc/member[@name="DVASPECTINFO"]/*' />
public partial struct DVASPECTINFO
{
    /// <include file='DVASPECTINFO.xml' path='doc/member[@name="DVASPECTINFO.cb"]/*' />
    [NativeTypeName("ULONG")]
    public uint cb;

    /// <include file='DVASPECTINFO.xml' path='doc/member[@name="DVASPECTINFO.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}
