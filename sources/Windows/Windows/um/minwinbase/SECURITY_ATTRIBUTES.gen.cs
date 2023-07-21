// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SECURITY_ATTRIBUTES.xml' path='doc/member[@name="SECURITY_ATTRIBUTES"]/*' />
public unsafe partial struct SECURITY_ATTRIBUTES
{
    /// <include file='SECURITY_ATTRIBUTES.xml' path='doc/member[@name="SECURITY_ATTRIBUTES.nLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint nLength;

    /// <include file='SECURITY_ATTRIBUTES.xml' path='doc/member[@name="SECURITY_ATTRIBUTES.lpSecurityDescriptor"]/*' />
    [NativeTypeName("LPVOID")]
    public void* lpSecurityDescriptor;

    /// <include file='SECURITY_ATTRIBUTES.xml' path='doc/member[@name="SECURITY_ATTRIBUTES.bInheritHandle"]/*' />
    public BOOL bInheritHandle;
}
