// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='styleBaselineShift.xml' path='doc/member[@name="styleBaselineShift"]/*' />
public enum styleBaselineShift
{
    /// <include file='styleBaselineShift.xml' path='doc/member[@name="styleBaselineShift.styleBaselineShiftBaseline"]/*' />
    styleBaselineShiftBaseline = 0,

    /// <include file='styleBaselineShift.xml' path='doc/member[@name="styleBaselineShift.styleBaselineShiftSub"]/*' />
    styleBaselineShiftSub = 1,

    /// <include file='styleBaselineShift.xml' path='doc/member[@name="styleBaselineShift.styleBaselineShiftSuper"]/*' />
    styleBaselineShiftSuper = 2,

    /// <include file='styleBaselineShift.xml' path='doc/member[@name="styleBaselineShift.styleBaselineShift_Max"]/*' />
    styleBaselineShift_Max = 2147483647,
}
