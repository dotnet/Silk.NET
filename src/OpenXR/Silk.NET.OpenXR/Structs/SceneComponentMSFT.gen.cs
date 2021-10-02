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
    [NativeName("Name", "XrSceneComponentMSFT")]
    public unsafe partial struct SceneComponentMSFT
    {
        public SceneComponentMSFT
        (
            SceneComponentTypeMSFT? componentType = null,
            Guid? id = null,
            Guid? parentId = null,
            long? updateTime = null
        ) : this()
        {
            if (componentType is not null)
            {
                ComponentType = componentType.Value;
            }

            if (id is not null)
            {
                Id = id.Value;
            }

            if (parentId is not null)
            {
                ParentId = parentId.Value;
            }

            if (updateTime is not null)
            {
                UpdateTime = updateTime.Value;
            }
        }

/// <summary></summary>
        [NativeName("Type", "XrSceneComponentTypeMSFT")]
        [NativeName("Type.Name", "XrSceneComponentTypeMSFT")]
        [NativeName("Name", "componentType")]
        public SceneComponentTypeMSFT ComponentType;
/// <summary></summary>
        [NativeName("Type", "XrUuidMSFT")]
        [NativeName("Type.Name", "XrUuidMSFT")]
        [NativeName("Name", "id")]
        public Guid Id;
/// <summary></summary>
        [NativeName("Type", "XrUuidMSFT")]
        [NativeName("Type.Name", "XrUuidMSFT")]
        [NativeName("Name", "parentId")]
        public Guid ParentId;
/// <summary></summary>
        [NativeName("Type", "XrTime")]
        [NativeName("Type.Name", "XrTime")]
        [NativeName("Name", "updateTime")]
        public long UpdateTime;
    }
}
