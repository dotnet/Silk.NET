// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFaceExpressionSet2FB")]
    public enum FaceExpressionSet2FB : int
    {
        [Obsolete("Deprecated in favour of \"DefaultFB\"")]
        [NativeName("Name", "XR_FACE_EXPRESSION_SET2_DEFAULT_FB")]
        FaceExpressionSet2DefaultFB = 0,
        [NativeName("Name", "XR_FACE_EXPRESSION_SET2_DEFAULT_FB")]
        DefaultFB = 0,
    }
}
