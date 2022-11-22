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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_FEATURE_DATA_THREADING")]
    public unsafe partial struct FeatureDataThreading
    {
        public FeatureDataThreading
        (
            Silk.NET.Core.Bool32? driverConcurrentCreates = null,
            Silk.NET.Core.Bool32? driverCommandLists = null
        ) : this()
        {
            if (driverConcurrentCreates is not null)
            {
                DriverConcurrentCreates = driverConcurrentCreates.Value;
            }

            if (driverCommandLists is not null)
            {
                DriverCommandLists = driverCommandLists.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DriverConcurrentCreates")]
        public Silk.NET.Core.Bool32 DriverConcurrentCreates;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DriverCommandLists")]
        public Silk.NET.Core.Bool32 DriverCommandLists;
    }
}
