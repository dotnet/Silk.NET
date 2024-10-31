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
    [NativeName("Name", "XrPosef")]
    public unsafe partial struct Posef
    {
        public Posef
        (
            Quaternionf? orientation = null,
            Vector3f? position = null
        ) : this()
        {
            if (orientation is not null)
            {
                Orientation = orientation.Value;
            }

            if (position is not null)
            {
                Position = position.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrQuaternionf")]
        [NativeName("Type.Name", "XrQuaternionf")]
        [NativeName("Name", "orientation")]
        public Quaternionf Orientation;
/// <summary></summary>
        [NativeName("Type", "XrVector3f")]
        [NativeName("Type.Name", "XrVector3f")]
        [NativeName("Name", "position")]
        public Vector3f Position;
        /// <summary>To be documented.</summary>
        public override string ToString()
        {
            return Handle.ToString();
        }

    }
}
