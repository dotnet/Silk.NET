// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='DISPLAYCONFIG_TARGET_BASE_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_BASE_TYPE"]/*' />
[SupportedOSPlatform("windows6.3")]
public partial struct DISPLAYCONFIG_TARGET_BASE_TYPE
{
    /// <include file='DISPLAYCONFIG_TARGET_BASE_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_BASE_TYPE.header"]/*' />
    public DISPLAYCONFIG_DEVICE_INFO_HEADER header;

    /// <include file='DISPLAYCONFIG_TARGET_BASE_TYPE.xml' path='doc/member[@name="DISPLAYCONFIG_TARGET_BASE_TYPE.baseOutputTechnology"]/*' />
    public DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY baseOutputTechnology;
}
