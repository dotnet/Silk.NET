// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='WINHTTP_CONNECTION_GROUP.xml' path='doc/member[@name="WINHTTP_CONNECTION_GROUP"]/*'/>
public partial struct WINHTTP_CONNECTION_GROUP
{
    /// <include file='WINHTTP_CONNECTION_GROUP.xml' path='doc/member[@name="WINHTTP_CONNECTION_GROUP.cConnections"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cConnections;
    /// <include file='WINHTTP_CONNECTION_GROUP.xml' path='doc/member[@name="WINHTTP_CONNECTION_GROUP.guidGroup"]/*'/>
    public Guid guidGroup;
}