// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='SecPkgContext_EarlyStart.xml' path='doc/member[@name="SecPkgContext_EarlyStart"]/*' />
[SupportedOSPlatform("windows10.0")]
public partial struct SecPkgContext_EarlyStart
{
    /// <include file='SecPkgContext_EarlyStart.xml' path='doc/member[@name="SecPkgContext_EarlyStart.dwEarlyStartFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwEarlyStartFlags;
}
