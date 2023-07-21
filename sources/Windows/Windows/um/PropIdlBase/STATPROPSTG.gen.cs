// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STATPROPSTG.xml' path='doc/member[@name="STATPROPSTG"]/*' />
public unsafe partial struct STATPROPSTG
{
    /// <include file='STATPROPSTG.xml' path='doc/member[@name="STATPROPSTG.lpwstrName"]/*' />
    [NativeTypeName("LPOLESTR")]
    public ushort* lpwstrName;

    /// <include file='STATPROPSTG.xml' path='doc/member[@name="STATPROPSTG.propid"]/*' />
    [NativeTypeName("PROPID")]
    public uint propid;

    /// <include file='STATPROPSTG.xml' path='doc/member[@name="STATPROPSTG.vt"]/*' />
    [NativeTypeName("VARTYPE")]
    public ushort vt;
}
