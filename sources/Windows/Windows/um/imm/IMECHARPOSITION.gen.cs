// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMECHARPOSITION.xml' path='doc/member[@name="IMECHARPOSITION"]/*' />
public partial struct IMECHARPOSITION
{
    /// <include file='IMECHARPOSITION.xml' path='doc/member[@name="IMECHARPOSITION.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='IMECHARPOSITION.xml' path='doc/member[@name="IMECHARPOSITION.dwCharPos"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwCharPos;

    /// <include file='IMECHARPOSITION.xml' path='doc/member[@name="IMECHARPOSITION.pt"]/*' />
    public POINT pt;

    /// <include file='IMECHARPOSITION.xml' path='doc/member[@name="IMECHARPOSITION.cLineHeight"]/*' />
    public uint cLineHeight;

    /// <include file='IMECHARPOSITION.xml' path='doc/member[@name="IMECHARPOSITION.rcDocument"]/*' />
    public RECT rcDocument;
}
