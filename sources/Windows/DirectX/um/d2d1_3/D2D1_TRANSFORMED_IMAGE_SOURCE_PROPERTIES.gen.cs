// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.DirectX;

/// <include file='D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES.xml' path='doc/member[@name="D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES"]/*' />
public partial struct D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES
{
    /// <include file='D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES.xml' path='doc/member[@name="D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES.orientation"]/*' />
    public D2D1_ORIENTATION orientation;

    /// <include file='D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES.xml' path='doc/member[@name="D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES.scaleX"]/*' />
    public float scaleX;

    /// <include file='D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES.xml' path='doc/member[@name="D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES.scaleY"]/*' />
    public float scaleY;

    /// <include file='D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES.xml' path='doc/member[@name="D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES.interpolationMode"]/*' />
    public D2D1_INTERPOLATION_MODE interpolationMode;

    /// <include file='D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES.xml' path='doc/member[@name="D2D1_TRANSFORMED_IMAGE_SOURCE_PROPERTIES.options"]/*' />
    public D2D1_TRANSFORMED_IMAGE_SOURCE_OPTIONS options;
}
