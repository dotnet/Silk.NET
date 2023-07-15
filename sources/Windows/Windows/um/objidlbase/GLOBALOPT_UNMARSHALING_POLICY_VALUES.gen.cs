// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='GLOBALOPT_UNMARSHALING_POLICY_VALUES.xml' path='doc/member[@name="GLOBALOPT_UNMARSHALING_POLICY_VALUES"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum GLOBALOPT_UNMARSHALING_POLICY_VALUES
{
    /// <include file='GLOBALOPT_UNMARSHALING_POLICY_VALUES.xml' path='doc/member[@name="GLOBALOPT_UNMARSHALING_POLICY_VALUES.COMGLB_UNMARSHALING_POLICY_NORMAL"]/*'/>
    COMGLB_UNMARSHALING_POLICY_NORMAL = 0,
    /// <include file='GLOBALOPT_UNMARSHALING_POLICY_VALUES.xml' path='doc/member[@name="GLOBALOPT_UNMARSHALING_POLICY_VALUES.COMGLB_UNMARSHALING_POLICY_STRONG"]/*'/>
    COMGLB_UNMARSHALING_POLICY_STRONG = 1,
    /// <include file='GLOBALOPT_UNMARSHALING_POLICY_VALUES.xml' path='doc/member[@name="GLOBALOPT_UNMARSHALING_POLICY_VALUES.COMGLB_UNMARSHALING_POLICY_HYBRID"]/*'/>
    COMGLB_UNMARSHALING_POLICY_HYBRID = 2,
}