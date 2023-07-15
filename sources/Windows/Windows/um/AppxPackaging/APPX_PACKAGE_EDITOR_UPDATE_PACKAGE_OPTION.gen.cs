// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION.xml' path='doc/member[@name="APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION"]/*'/>
[SupportedOSPlatform("windows10.0")]
public enum APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION
{
    /// <include file='APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION.xml' path='doc/member[@name="APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION.APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION_APPEND_DELTA"]/*'/>
    APPX_PACKAGE_EDITOR_UPDATE_PACKAGE_OPTION_APPEND_DELTA = 0,
}