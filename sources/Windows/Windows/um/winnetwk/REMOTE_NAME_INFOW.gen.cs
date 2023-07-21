// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnetwk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='REMOTE_NAME_INFOW.xml' path='doc/member[@name="REMOTE_NAME_INFOW"]/*' />
public unsafe partial struct REMOTE_NAME_INFOW
{
    /// <include file='REMOTE_NAME_INFOW.xml' path='doc/member[@name="REMOTE_NAME_INFOW.lpUniversalName"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpUniversalName;

    /// <include file='REMOTE_NAME_INFOW.xml' path='doc/member[@name="REMOTE_NAME_INFOW.lpConnectionName"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpConnectionName;

    /// <include file='REMOTE_NAME_INFOW.xml' path='doc/member[@name="REMOTE_NAME_INFOW.lpRemainingPath"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* lpRemainingPath;
}
