// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE.xml' path='doc/member[@name="APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE"]/*'/>
[SupportedOSPlatform("windows6.3")]
public enum APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE
{
    /// <include file='APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE.xml' path='doc/member[@name="APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE.APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE_APPLICATION"]/*'/>
    APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE_APPLICATION = 0,
    /// <include file='APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE.xml' path='doc/member[@name="APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE.APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE_RESOURCE"]/*'/>
    APPX_BUNDLE_PAYLOAD_PACKAGE_TYPE_RESOURCE = 1,
}