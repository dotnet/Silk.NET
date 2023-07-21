// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MF_VIDEO_SPHERICAL_VIEWDIRECTION.xml' path='doc/member[@name="MF_VIDEO_SPHERICAL_VIEWDIRECTION"]/*' />
public partial struct MF_VIDEO_SPHERICAL_VIEWDIRECTION
{
    /// <include file='MF_VIDEO_SPHERICAL_VIEWDIRECTION.xml' path='doc/member[@name="MF_VIDEO_SPHERICAL_VIEWDIRECTION.iHeading"]/*' />
    public int iHeading;

    /// <include file='MF_VIDEO_SPHERICAL_VIEWDIRECTION.xml' path='doc/member[@name="MF_VIDEO_SPHERICAL_VIEWDIRECTION.iPitch"]/*' />
    public int iPitch;

    /// <include file='MF_VIDEO_SPHERICAL_VIEWDIRECTION.xml' path='doc/member[@name="MF_VIDEO_SPHERICAL_VIEWDIRECTION.iRoll"]/*' />
    public int iRoll;
}
