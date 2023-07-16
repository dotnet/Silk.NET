// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='DECIMATION_USAGE.xml' path='doc/member[@name="DECIMATION_USAGE"]/*'/>
public enum DECIMATION_USAGE
{
    /// <include file='DECIMATION_USAGE.xml' path='doc/member[@name="DECIMATION_USAGE.DECIMATION_LEGACY"]/*'/>
    DECIMATION_LEGACY = 0,
    /// <include file='DECIMATION_USAGE.xml' path='doc/member[@name="DECIMATION_USAGE.DECIMATION_USE_DECODER_ONLY"]/*'/>
    DECIMATION_USE_DECODER_ONLY = (DECIMATION_LEGACY + 1),
    /// <include file='DECIMATION_USAGE.xml' path='doc/member[@name="DECIMATION_USAGE.DECIMATION_USE_VIDEOPORT_ONLY"]/*'/>
    DECIMATION_USE_VIDEOPORT_ONLY = (DECIMATION_USE_DECODER_ONLY + 1),
    /// <include file='DECIMATION_USAGE.xml' path='doc/member[@name="DECIMATION_USAGE.DECIMATION_USE_OVERLAY_ONLY"]/*'/>
    DECIMATION_USE_OVERLAY_ONLY = (DECIMATION_USE_VIDEOPORT_ONLY + 1),
    /// <include file='DECIMATION_USAGE.xml' path='doc/member[@name="DECIMATION_USAGE.DECIMATION_DEFAULT"]/*'/>
    DECIMATION_DEFAULT = (DECIMATION_USE_OVERLAY_ONLY + 1),
}