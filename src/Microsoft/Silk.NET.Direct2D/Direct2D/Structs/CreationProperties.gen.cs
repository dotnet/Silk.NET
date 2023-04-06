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

namespace Silk.NET.Direct2D
{
    [NativeName("Name", "D2D1_CREATION_PROPERTIES")]
    public unsafe partial struct CreationProperties
    {
        public CreationProperties
        (
            ThreadingMode? threadingMode = null,
            DebugLevel? debugLevel = null,
            DeviceContextOptions? options = null
        ) : this()
        {
            if (threadingMode is not null)
            {
                ThreadingMode = threadingMode.Value;
            }

            if (debugLevel is not null)
            {
                DebugLevel = debugLevel.Value;
            }

            if (options is not null)
            {
                Options = options.Value;
            }
        }


        [NativeName("Type", "D2D1_THREADING_MODE")]
        [NativeName("Type.Name", "D2D1_THREADING_MODE")]
        [NativeName("Name", "threadingMode")]
        public ThreadingMode ThreadingMode;

        [NativeName("Type", "D2D1_DEBUG_LEVEL")]
        [NativeName("Type.Name", "D2D1_DEBUG_LEVEL")]
        [NativeName("Name", "debugLevel")]
        public DebugLevel DebugLevel;

        [NativeName("Type", "D2D1_DEVICE_CONTEXT_OPTIONS")]
        [NativeName("Type.Name", "D2D1_DEVICE_CONTEXT_OPTIONS")]
        [NativeName("Name", "options")]
        public DeviceContextOptions Options;
    }
}
