// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL
{
    [NativeName("Name", "BindTransformFeedbackTarget")]
    public enum BindTransformFeedbackTarget : int
    {
        [NativeName("Name", "GL_TRANSFORM_FEEDBACK")]
        TransformFeedback = 0x8E22,
    }
}
