// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFVideoNormalizedRect.xml' path='doc/member[@name="MFVideoNormalizedRect"]/*' />
public partial struct MFVideoNormalizedRect
{
    /// <include file='MFVideoNormalizedRect.xml' path='doc/member[@name="MFVideoNormalizedRect.left"]/*' />
    public float left;

    /// <include file='MFVideoNormalizedRect.xml' path='doc/member[@name="MFVideoNormalizedRect.top"]/*' />
    public float top;

    /// <include file='MFVideoNormalizedRect.xml' path='doc/member[@name="MFVideoNormalizedRect.right"]/*' />
    public float right;

    /// <include file='MFVideoNormalizedRect.xml' path='doc/member[@name="MFVideoNormalizedRect.bottom"]/*' />
    public float bottom;
}
