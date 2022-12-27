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
    [NativeName("Name", "XrFoveationConfigurationHTC")]
    public unsafe partial struct FoveationConfigurationHTC
    {
        public FoveationConfigurationHTC
        (
            FoveationLevelHTC? level = null,
            float? clearFovDegree = null,
            Vector2f? focalCenterOffset = null
        ) : this()
        {
            if (level is not null)
            {
                Level = level.Value;
            }

            if (clearFovDegree is not null)
            {
                ClearFovDegree = clearFovDegree.Value;
            }

            if (focalCenterOffset is not null)
            {
                FocalCenterOffset = focalCenterOffset.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrFoveationLevelHTC")]
        [NativeName("Type.Name", "XrFoveationLevelHTC")]
        [NativeName("Name", "level")]
        public FoveationLevelHTC Level;
/// <summary></summary>
        [NativeName("Type", "float")]
        [NativeName("Type.Name", "float")]
        [NativeName("Name", "clearFovDegree")]
        public float ClearFovDegree;
/// <summary></summary>
        [NativeName("Type", "XrVector2f")]
        [NativeName("Type.Name", "XrVector2f")]
        [NativeName("Name", "focalCenterOffset")]
        public Vector2f FocalCenterOffset;
    }
}
