// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TOKEN_BNO_ISOLATION_INFORMATION.xml' path='doc/member[@name="TOKEN_BNO_ISOLATION_INFORMATION"]/*' />
public unsafe partial struct TOKEN_BNO_ISOLATION_INFORMATION
{
    /// <include file='TOKEN_BNO_ISOLATION_INFORMATION.xml' path='doc/member[@name="TOKEN_BNO_ISOLATION_INFORMATION.IsolationPrefix"]/*' />
    [NativeTypeName("PWSTR")]
    public ushort* IsolationPrefix;

    /// <include file='TOKEN_BNO_ISOLATION_INFORMATION.xml' path='doc/member[@name="TOKEN_BNO_ISOLATION_INFORMATION.IsolationEnabled"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte IsolationEnabled;
}
