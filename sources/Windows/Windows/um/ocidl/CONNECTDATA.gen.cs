// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CONNECTDATA.xml' path='doc/member[@name="CONNECTDATA"]/*' />
public unsafe partial struct CONNECTDATA
{
    /// <include file='CONNECTDATA.xml' path='doc/member[@name="CONNECTDATA.pUnk"]/*' />
    public IUnknown* pUnk;

    /// <include file='CONNECTDATA.xml' path='doc/member[@name="CONNECTDATA.dwCookie"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCookie;
}
