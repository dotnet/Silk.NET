// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='RIP_INFO.xml' path='doc/member[@name="RIP_INFO"]/*' />
public partial struct RIP_INFO
{
    /// <include file='RIP_INFO.xml' path='doc/member[@name="RIP_INFO.dwError"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwError;

    /// <include file='RIP_INFO.xml' path='doc/member[@name="RIP_INFO.dwType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwType;
}
