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

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_CONFIGURATION")]
    public unsafe partial struct Configuration
    {
        public Configuration
        (
            uint? numSubmitThreads = null,
            int? numBuiltInCpuDecompressionThreads = null,
            Silk.NET.Core.Bool32? forceMappingLayer = null,
            Silk.NET.Core.Bool32? disableBypassIO = null,
            Silk.NET.Core.Bool32? disableTelemetry = null,
            Silk.NET.Core.Bool32? disableGpuDecompressionMetacommand = null,
            Silk.NET.Core.Bool32? disableGpuDecompression = null
        ) : this()
        {
            if (numSubmitThreads is not null)
            {
                NumSubmitThreads = numSubmitThreads.Value;
            }

            if (numBuiltInCpuDecompressionThreads is not null)
            {
                NumBuiltInCpuDecompressionThreads = numBuiltInCpuDecompressionThreads.Value;
            }

            if (forceMappingLayer is not null)
            {
                ForceMappingLayer = forceMappingLayer.Value;
            }

            if (disableBypassIO is not null)
            {
                DisableBypassIO = disableBypassIO.Value;
            }

            if (disableTelemetry is not null)
            {
                DisableTelemetry = disableTelemetry.Value;
            }

            if (disableGpuDecompressionMetacommand is not null)
            {
                DisableGpuDecompressionMetacommand = disableGpuDecompressionMetacommand.Value;
            }

            if (disableGpuDecompression is not null)
            {
                DisableGpuDecompression = disableGpuDecompression.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "NumSubmitThreads")]
        public uint NumSubmitThreads;

        [NativeName("Type", "INT32")]
        [NativeName("Type.Name", "INT32")]
        [NativeName("Name", "NumBuiltInCpuDecompressionThreads")]
        public int NumBuiltInCpuDecompressionThreads;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "ForceMappingLayer")]
        public Silk.NET.Core.Bool32 ForceMappingLayer;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DisableBypassIO")]
        public Silk.NET.Core.Bool32 DisableBypassIO;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DisableTelemetry")]
        public Silk.NET.Core.Bool32 DisableTelemetry;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DisableGpuDecompressionMetacommand")]
        public Silk.NET.Core.Bool32 DisableGpuDecompressionMetacommand;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DisableGpuDecompression")]
        public Silk.NET.Core.Bool32 DisableGpuDecompression;
    }
}
