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
    [NativeName("Name", "XrForceFeedbackCurlApplyLocationMNDX")]
    public unsafe partial struct ForceFeedbackCurlApplyLocationMNDX
    {
        public ForceFeedbackCurlApplyLocationMNDX
        (
            ForceFeedbackCurlLocationMNDX? location = null,
            float? value = null
        ) : this()
        {
            if (location is not null)
            {
                Location = location.Value;
            }

            if (value is not null)
            {
                Value = value.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrForceFeedbackCurlLocationMNDX")]
        [NativeName("Type.Name", "XrForceFeedbackCurlLocationMNDX")]
        [NativeName("Name", "location")]
        public ForceFeedbackCurlLocationMNDX Location;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "value")]
        public float Value;
    }
}
