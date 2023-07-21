// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/oleauto.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='METHODDATA.xml' path='doc/member[@name="METHODDATA"]/*' />
public unsafe partial struct METHODDATA
{
    /// <include file='METHODDATA.xml' path='doc/member[@name="METHODDATA.szName"]/*' />
    [NativeTypeName("OLECHAR *")]
    public ushort* szName;

    /// <include file='METHODDATA.xml' path='doc/member[@name="METHODDATA.ppdata"]/*' />
    public PARAMDATA* ppdata;

    /// <include file='METHODDATA.xml' path='doc/member[@name="METHODDATA.dispid"]/*' />
    [NativeTypeName("DISPID")]
    public int dispid;

    /// <include file='METHODDATA.xml' path='doc/member[@name="METHODDATA.iMeth"]/*' />
    public uint iMeth;

    /// <include file='METHODDATA.xml' path='doc/member[@name="METHODDATA.cc"]/*' />
    public CALLCONV cc;

    /// <include file='METHODDATA.xml' path='doc/member[@name="METHODDATA.cArgs"]/*' />
    public uint cArgs;

    /// <include file='METHODDATA.xml' path='doc/member[@name="METHODDATA.wFlags"]/*' />
    [NativeTypeName("WORD")]
    public ushort wFlags;

    /// <include file='METHODDATA.xml' path='doc/member[@name="METHODDATA.vtReturn"]/*' />
    [NativeTypeName("VARTYPE")]
    public ushort vtReturn;
}
