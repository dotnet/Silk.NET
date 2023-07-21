// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/timeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='TIMECAPS.xml' path='doc/member[@name="TIMECAPS"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct TIMECAPS
{
    /// <include file='TIMECAPS.xml' path='doc/member[@name="TIMECAPS.wPeriodMin"]/*' />
    public uint wPeriodMin;

    /// <include file='TIMECAPS.xml' path='doc/member[@name="TIMECAPS.wPeriodMax"]/*' />
    public uint wPeriodMax;
}
