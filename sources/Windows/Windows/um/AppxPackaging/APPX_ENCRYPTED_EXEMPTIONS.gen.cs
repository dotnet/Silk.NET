// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='APPX_ENCRYPTED_EXEMPTIONS.xml' path='doc/member[@name="APPX_ENCRYPTED_EXEMPTIONS"]/*' />
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct APPX_ENCRYPTED_EXEMPTIONS
{
    /// <include file='APPX_ENCRYPTED_EXEMPTIONS.xml' path='doc/member[@name="APPX_ENCRYPTED_EXEMPTIONS.count"]/*' />
    [NativeTypeName("UINT32")]
    public uint count;

    /// <include file='APPX_ENCRYPTED_EXEMPTIONS.xml' path='doc/member[@name="APPX_ENCRYPTED_EXEMPTIONS.plainTextFiles"]/*' />
    [NativeTypeName("LPCWSTR *")]
    public ushort** plainTextFiles;
}
