// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='APPX_ENCRYPTED_PACKAGE_OPTIONS.xml' path='doc/member[@name="APPX_ENCRYPTED_PACKAGE_OPTIONS"]/*'/>
[Flags]
[SupportedOSPlatform("windows10.0")]
public enum APPX_ENCRYPTED_PACKAGE_OPTIONS
{
    /// <include file='APPX_ENCRYPTED_PACKAGE_OPTIONS.xml' path='doc/member[@name="APPX_ENCRYPTED_PACKAGE_OPTIONS.APPX_ENCRYPTED_PACKAGE_OPTION_NONE"]/*'/>
    APPX_ENCRYPTED_PACKAGE_OPTION_NONE = 0,
    /// <include file='APPX_ENCRYPTED_PACKAGE_OPTIONS.xml' path='doc/member[@name="APPX_ENCRYPTED_PACKAGE_OPTIONS.APPX_ENCRYPTED_PACKAGE_OPTION_DIFFUSION"]/*'/>
    APPX_ENCRYPTED_PACKAGE_OPTION_DIFFUSION = 0x1,
    /// <include file='APPX_ENCRYPTED_PACKAGE_OPTIONS.xml' path='doc/member[@name="APPX_ENCRYPTED_PACKAGE_OPTIONS.APPX_ENCRYPTED_PACKAGE_OPTION_PAGE_HASHING"]/*'/>
    APPX_ENCRYPTED_PACKAGE_OPTION_PAGE_HASHING = 0x2,
}