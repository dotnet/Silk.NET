// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='TOUCH_HIT_TESTING_INPUT.xml' path='doc/member[@name="TOUCH_HIT_TESTING_INPUT"]/*' />
[SupportedOSPlatform("windows6.2")]
public partial struct TOUCH_HIT_TESTING_INPUT
{
    /// <include file='TOUCH_HIT_TESTING_INPUT.xml' path='doc/member[@name="TOUCH_HIT_TESTING_INPUT.pointerId"]/*' />
    [NativeTypeName("UINT32")]
    public uint pointerId;

    /// <include file='TOUCH_HIT_TESTING_INPUT.xml' path='doc/member[@name="TOUCH_HIT_TESTING_INPUT.point"]/*' />
    public POINT point;

    /// <include file='TOUCH_HIT_TESTING_INPUT.xml' path='doc/member[@name="TOUCH_HIT_TESTING_INPUT.boundingBox"]/*' />
    public RECT boundingBox;

    /// <include file='TOUCH_HIT_TESTING_INPUT.xml' path='doc/member[@name="TOUCH_HIT_TESTING_INPUT.nonOccludedBoundingBox"]/*' />
    public RECT nonOccludedBoundingBox;

    /// <include file='TOUCH_HIT_TESTING_INPUT.xml' path='doc/member[@name="TOUCH_HIT_TESTING_INPUT.orientation"]/*' />
    [NativeTypeName("UINT32")]
    public uint orientation;
}
