// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/udpmib.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MIB_UDP6ROW.xml' path='doc/member[@name="MIB_UDP6ROW"]/*' />
public partial struct MIB_UDP6ROW
{
    /// <include file='MIB_UDP6ROW.xml' path='doc/member[@name="MIB_UDP6ROW.dwLocalAddr"]/*' />
    public IN6_ADDR dwLocalAddr;

    /// <include file='MIB_UDP6ROW.xml' path='doc/member[@name="MIB_UDP6ROW.dwLocalScopeId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLocalScopeId;

    /// <include file='MIB_UDP6ROW.xml' path='doc/member[@name="MIB_UDP6ROW.dwLocalPort"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwLocalPort;
}
