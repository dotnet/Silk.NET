// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
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
            int driverConcurrentCreates = default,
            int driverCommandLists = default
        )
        {
            DriverConcurrentCreates = driverConcurrentCreates;
            DriverCommandLists = driverCommandLists;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DriverConcurrentCreates")]
        public int DriverConcurrentCreates;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "DriverCommandLists")]
        public int DriverCommandLists;
    }
}
