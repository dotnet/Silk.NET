// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrFaceExpressionStatusFB")]
    public unsafe partial struct FaceExpressionStatusFB
    {
        public FaceExpressionStatusFB
        (
            uint? isValid = null,
            uint? isEyeFollowingBlendshapesValid = null
        ) : this()
        {
            if (isValid is not null)
            {
                IsValid = isValid.Value;
            }

            if (isEyeFollowingBlendshapesValid is not null)
            {
                IsEyeFollowingBlendshapesValid = isEyeFollowingBlendshapesValid.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "isValid")]
        public uint IsValid;
/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "isEyeFollowingBlendshapesValid")]
        public uint IsEyeFollowingBlendshapesValid;
    }
}
