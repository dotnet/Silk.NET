// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MF_QUALITY_DROP_MODE.xml' path='doc/member[@name="MF_QUALITY_DROP_MODE"]/*'/>
public enum MF_QUALITY_DROP_MODE
{
    /// <include file='MF_QUALITY_DROP_MODE.xml' path='doc/member[@name="MF_QUALITY_DROP_MODE.MF_DROP_MODE_NONE"]/*'/>
    MF_DROP_MODE_NONE = 0,
    /// <include file='MF_QUALITY_DROP_MODE.xml' path='doc/member[@name="MF_QUALITY_DROP_MODE.MF_DROP_MODE_1"]/*'/>
    MF_DROP_MODE_1 = 0x1,
    /// <include file='MF_QUALITY_DROP_MODE.xml' path='doc/member[@name="MF_QUALITY_DROP_MODE.MF_DROP_MODE_2"]/*'/>
    MF_DROP_MODE_2 = 0x2,
    /// <include file='MF_QUALITY_DROP_MODE.xml' path='doc/member[@name="MF_QUALITY_DROP_MODE.MF_DROP_MODE_3"]/*'/>
    MF_DROP_MODE_3 = 0x3,
    /// <include file='MF_QUALITY_DROP_MODE.xml' path='doc/member[@name="MF_QUALITY_DROP_MODE.MF_DROP_MODE_4"]/*'/>
    MF_DROP_MODE_4 = 0x4,
    /// <include file='MF_QUALITY_DROP_MODE.xml' path='doc/member[@name="MF_QUALITY_DROP_MODE.MF_DROP_MODE_5"]/*'/>
    MF_DROP_MODE_5 = 0x5,
    /// <include file='MF_QUALITY_DROP_MODE.xml' path='doc/member[@name="MF_QUALITY_DROP_MODE.MF_NUM_DROP_MODES"]/*'/>
    MF_NUM_DROP_MODES = 0x6,
}