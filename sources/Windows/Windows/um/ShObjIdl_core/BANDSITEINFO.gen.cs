// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='BANDSITEINFO.xml' path='doc/member[@name="BANDSITEINFO"]/*' />
public partial struct BANDSITEINFO
{
    /// <include file='BANDSITEINFO.xml' path='doc/member[@name="BANDSITEINFO.dwMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwMask;

    /// <include file='BANDSITEINFO.xml' path='doc/member[@name="BANDSITEINFO.dwState"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwState;

    /// <include file='BANDSITEINFO.xml' path='doc/member[@name="BANDSITEINFO.dwStyle"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwStyle;
}
