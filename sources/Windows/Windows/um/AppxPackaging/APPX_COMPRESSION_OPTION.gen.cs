// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='APPX_COMPRESSION_OPTION.xml' path='doc/member[@name="APPX_COMPRESSION_OPTION"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum APPX_COMPRESSION_OPTION
{
    /// <include file='APPX_COMPRESSION_OPTION.xml' path='doc/member[@name="APPX_COMPRESSION_OPTION.APPX_COMPRESSION_OPTION_NONE"]/*'/>
    APPX_COMPRESSION_OPTION_NONE = 0,
    /// <include file='APPX_COMPRESSION_OPTION.xml' path='doc/member[@name="APPX_COMPRESSION_OPTION.APPX_COMPRESSION_OPTION_NORMAL"]/*'/>
    APPX_COMPRESSION_OPTION_NORMAL = 1,
    /// <include file='APPX_COMPRESSION_OPTION.xml' path='doc/member[@name="APPX_COMPRESSION_OPTION.APPX_COMPRESSION_OPTION_MAXIMUM"]/*'/>
    APPX_COMPRESSION_OPTION_MAXIMUM = 2,
    /// <include file='APPX_COMPRESSION_OPTION.xml' path='doc/member[@name="APPX_COMPRESSION_OPTION.APPX_COMPRESSION_OPTION_FAST"]/*'/>
    APPX_COMPRESSION_OPTION_FAST = 3,
    /// <include file='APPX_COMPRESSION_OPTION.xml' path='doc/member[@name="APPX_COMPRESSION_OPTION.APPX_COMPRESSION_OPTION_SUPERFAST"]/*'/>
    APPX_COMPRESSION_OPTION_SUPERFAST = 4,
}