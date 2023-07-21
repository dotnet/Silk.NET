// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='FaceRectInfo.xml' path='doc/member[@name="FaceRectInfo"]/*' />
public partial struct FaceRectInfo
{
    /// <include file='FaceRectInfo.xml' path='doc/member[@name="FaceRectInfo.Region"]/*' />
    public RECT Region;

    /// <include file='FaceRectInfo.xml' path='doc/member[@name="FaceRectInfo.confidenceLevel"]/*' />
    [NativeTypeName("LONG")]
    public int confidenceLevel;
}
