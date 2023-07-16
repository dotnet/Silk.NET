// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HIDP_REPORT_TYPE.xml' path='doc/member[@name="HIDP_REPORT_TYPE"]/*'/>
public enum HIDP_REPORT_TYPE
{
    /// <include file='HIDP_REPORT_TYPE.xml' path='doc/member[@name="HIDP_REPORT_TYPE.HidP_Input"]/*'/>
    HidP_Input,
    /// <include file='HIDP_REPORT_TYPE.xml' path='doc/member[@name="HIDP_REPORT_TYPE.HidP_Output"]/*'/>
    HidP_Output,
    /// <include file='HIDP_REPORT_TYPE.xml' path='doc/member[@name="HIDP_REPORT_TYPE.HidP_Feature"]/*'/>
    HidP_Feature,
}