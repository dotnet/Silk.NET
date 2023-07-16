// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PARTITION_STYLE.xml' path='doc/member[@name="PARTITION_STYLE"]/*'/>
public enum PARTITION_STYLE
{
    /// <include file='PARTITION_STYLE.xml' path='doc/member[@name="PARTITION_STYLE.PARTITION_STYLE_MBR"]/*'/>
    PARTITION_STYLE_MBR,
    /// <include file='PARTITION_STYLE.xml' path='doc/member[@name="PARTITION_STYLE.PARTITION_STYLE_GPT"]/*'/>
    PARTITION_STYLE_GPT,
    /// <include file='PARTITION_STYLE.xml' path='doc/member[@name="PARTITION_STYLE.PARTITION_STYLE_RAW"]/*'/>
    PARTITION_STYLE_RAW,
}