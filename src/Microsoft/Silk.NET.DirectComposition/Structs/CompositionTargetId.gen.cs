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

namespace Silk.NET.DirectComposition
{
    [NativeName("Name", "tagCOMPOSITION_TARGET_ID")]
    public unsafe partial struct CompositionTargetId
    {
        public CompositionTargetId
        (
            Luid? displayAdapterLuid = null,
            Luid? renderAdapterLuid = null,
            uint? vidPnSourceId = null,
            uint? vidPnTargetId = null,
            uint? uniqueId = null
        ) : this()
        {
            if (displayAdapterLuid is not null)
            {
                DisplayAdapterLuid = displayAdapterLuid.Value;
            }

            if (renderAdapterLuid is not null)
            {
                RenderAdapterLuid = renderAdapterLuid.Value;
            }

            if (vidPnSourceId is not null)
            {
                VidPnSourceId = vidPnSourceId.Value;
            }

            if (vidPnTargetId is not null)
            {
                VidPnTargetId = vidPnTargetId.Value;
            }

            if (uniqueId is not null)
            {
                UniqueId = uniqueId.Value;
            }
        }


        [NativeName("Type", "LUID")]
        [NativeName("Type.Name", "LUID")]
        [NativeName("Name", "displayAdapterLuid")]
        public Luid DisplayAdapterLuid;

        [NativeName("Type", "LUID")]
        [NativeName("Type.Name", "LUID")]
        [NativeName("Name", "renderAdapterLuid")]
        public Luid RenderAdapterLuid;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "vidPnSourceId")]
        public uint VidPnSourceId;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "vidPnTargetId")]
        public uint VidPnTargetId;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "uniqueId")]
        public uint UniqueId;
    }
}
