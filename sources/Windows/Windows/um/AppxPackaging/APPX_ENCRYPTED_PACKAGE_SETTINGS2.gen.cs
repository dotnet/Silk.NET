// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='APPX_ENCRYPTED_PACKAGE_SETTINGS2.xml' path='doc/member[@name="APPX_ENCRYPTED_PACKAGE_SETTINGS2"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct APPX_ENCRYPTED_PACKAGE_SETTINGS2
{
    /// <include file='APPX_ENCRYPTED_PACKAGE_SETTINGS2.xml' path='doc/member[@name="APPX_ENCRYPTED_PACKAGE_SETTINGS2.keyLength"]/*'/>
    [NativeTypeName("UINT32")]
    public uint keyLength;
    /// <include file='APPX_ENCRYPTED_PACKAGE_SETTINGS2.xml' path='doc/member[@name="APPX_ENCRYPTED_PACKAGE_SETTINGS2.encryptionAlgorithm"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* encryptionAlgorithm;
    /// <include file='APPX_ENCRYPTED_PACKAGE_SETTINGS2.xml' path='doc/member[@name="APPX_ENCRYPTED_PACKAGE_SETTINGS2.blockMapHashAlgorithm"]/*'/>
    public IUri* blockMapHashAlgorithm;
    /// <include file='APPX_ENCRYPTED_PACKAGE_SETTINGS2.xml' path='doc/member[@name="APPX_ENCRYPTED_PACKAGE_SETTINGS2.options"]/*'/>
    [NativeTypeName("DWORD")]
    public uint options;
}