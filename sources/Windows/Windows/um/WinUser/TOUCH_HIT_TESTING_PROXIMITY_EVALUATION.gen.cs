// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='TOUCH_HIT_TESTING_PROXIMITY_EVALUATION.xml' path='doc/member[@name="TOUCH_HIT_TESTING_PROXIMITY_EVALUATION"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct TOUCH_HIT_TESTING_PROXIMITY_EVALUATION
{
    /// <include file='TOUCH_HIT_TESTING_PROXIMITY_EVALUATION.xml' path='doc/member[@name="TOUCH_HIT_TESTING_PROXIMITY_EVALUATION.score"]/*'/>
    [NativeTypeName("UINT16")]
    public ushort score;
    /// <include file='TOUCH_HIT_TESTING_PROXIMITY_EVALUATION.xml' path='doc/member[@name="TOUCH_HIT_TESTING_PROXIMITY_EVALUATION.adjustedPoint"]/*'/>
    public POINT adjustedPoint;
}