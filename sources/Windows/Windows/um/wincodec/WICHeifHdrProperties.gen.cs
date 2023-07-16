// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='WICHeifHdrProperties.xml' path='doc/member[@name="WICHeifHdrProperties"]/*'/>
[SupportedOSPlatform("windows10.0.18362.0")]
public enum WICHeifHdrProperties
{
    /// <include file='WICHeifHdrProperties.xml' path='doc/member[@name="WICHeifHdrProperties.WICHeifHdrMaximumLuminanceLevel"]/*'/>
    WICHeifHdrMaximumLuminanceLevel = 0x1,
    /// <include file='WICHeifHdrProperties.xml' path='doc/member[@name="WICHeifHdrProperties.WICHeifHdrMaximumFrameAverageLuminanceLevel"]/*'/>
    WICHeifHdrMaximumFrameAverageLuminanceLevel = 0x2,
    /// <include file='WICHeifHdrProperties.xml' path='doc/member[@name="WICHeifHdrProperties.WICHeifHdrMinimumMasteringDisplayLuminanceLevel"]/*'/>
    WICHeifHdrMinimumMasteringDisplayLuminanceLevel = 0x3,
    /// <include file='WICHeifHdrProperties.xml' path='doc/member[@name="WICHeifHdrProperties.WICHeifHdrMaximumMasteringDisplayLuminanceLevel"]/*'/>
    WICHeifHdrMaximumMasteringDisplayLuminanceLevel = 0x4,
    /// <include file='WICHeifHdrProperties.xml' path='doc/member[@name="WICHeifHdrProperties.WICHeifHdrCustomVideoPrimaries"]/*'/>
    WICHeifHdrCustomVideoPrimaries = 0x5,
    /// <include file='WICHeifHdrProperties.xml' path='doc/member[@name="WICHeifHdrProperties.WICHeifHdrProperties_FORCE_DWORD"]/*'/>
    WICHeifHdrProperties_FORCE_DWORD = 0x7fffffff,
}