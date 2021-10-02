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
    [NativeName("Name", "XrSceneObjectMSFT")]
    public unsafe partial struct SceneObjectMSFT
    {
        public SceneObjectMSFT
        (
            SceneObjectTypeMSFT? objectType = null
        ) : this()
        {
            if (objectType is not null)
            {
                ObjectType = objectType.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrSceneObjectTypeMSFT")]
        [NativeName("Type.Name", "XrSceneObjectTypeMSFT")]
        [NativeName("Name", "objectType")]
        public SceneObjectTypeMSFT ObjectType;
    }
}
