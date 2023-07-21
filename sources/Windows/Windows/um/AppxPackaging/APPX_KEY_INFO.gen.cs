// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='APPX_KEY_INFO.xml' path='doc/member[@name="APPX_KEY_INFO"]/*' />
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct APPX_KEY_INFO
{
    /// <include file='APPX_KEY_INFO.xml' path='doc/member[@name="APPX_KEY_INFO.keyLength"]/*' />
    [NativeTypeName("UINT32")]
    public uint keyLength;

    /// <include file='APPX_KEY_INFO.xml' path='doc/member[@name="APPX_KEY_INFO.keyIdLength"]/*' />
    [NativeTypeName("UINT32")]
    public uint keyIdLength;

    /// <include file='APPX_KEY_INFO.xml' path='doc/member[@name="APPX_KEY_INFO.key"]/*' />
    public byte* key;

    /// <include file='APPX_KEY_INFO.xml' path='doc/member[@name="APPX_KEY_INFO.keyId"]/*' />
    public byte* keyId;
}
