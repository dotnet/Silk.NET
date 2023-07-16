// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='BACKGROUNDSTATES.xml' path='doc/member[@name="BACKGROUNDSTATES"]/*'/>
public enum BACKGROUNDSTATES
{
    /// <include file='BACKGROUNDSTATES.xml' path='doc/member[@name="BACKGROUNDSTATES.EBS_NORMAL"]/*'/>
    EBS_NORMAL = 1,
    /// <include file='BACKGROUNDSTATES.xml' path='doc/member[@name="BACKGROUNDSTATES.EBS_HOT"]/*'/>
    EBS_HOT = 2,
    /// <include file='BACKGROUNDSTATES.xml' path='doc/member[@name="BACKGROUNDSTATES.EBS_DISABLED"]/*'/>
    EBS_DISABLED = 3,
    /// <include file='BACKGROUNDSTATES.xml' path='doc/member[@name="BACKGROUNDSTATES.EBS_FOCUSED"]/*'/>
    EBS_FOCUSED = 4,
    /// <include file='BACKGROUNDSTATES.xml' path='doc/member[@name="BACKGROUNDSTATES.EBS_READONLY"]/*'/>
    EBS_READONLY = 5,
    /// <include file='BACKGROUNDSTATES.xml' path='doc/member[@name="BACKGROUNDSTATES.EBS_ASSIST"]/*'/>
    EBS_ASSIST = 6,
}