// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='ROI_AREA.xml' path='doc/member[@name="ROI_AREA"]/*' />
[SupportedOSPlatform("windows6.3")]
public partial struct ROI_AREA
{
    /// <include file='ROI_AREA.xml' path='doc/member[@name="ROI_AREA.rect"]/*' />
    public RECT rect;

    /// <include file='ROI_AREA.xml' path='doc/member[@name="ROI_AREA.QPDelta"]/*' />
    [NativeTypeName("INT32")]
    public int QPDelta;
}
