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
    [NativeName("Name", "XrEyeGazeFB")]
    public unsafe partial struct EyeGazeFB
    {
        public EyeGazeFB
        (
            uint? isValid = null,
            Posef? gazePose = null,
            float? gazeConfidence = null
        ) : this()
        {
            if (isValid is not null)
            {
                IsValid = isValid.Value;
            }

            if (gazePose is not null)
            {
                GazePose = gazePose.Value;
            }

            if (gazeConfidence is not null)
            {
                GazeConfidence = gazeConfidence.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrBool32")]
        [NativeName("Type.Name", "XrBool32")]
        [NativeName("Name", "isValid")]
        public uint IsValid;
/// <summary></summary>
        [NativeName("Type", "XrPosef")]
        [NativeName("Type.Name", "XrPosef")]
        [NativeName("Name", "gazePose")]
        public Posef GazePose;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "gazeConfidence")]
        public float GazeConfidence;
    }
}
