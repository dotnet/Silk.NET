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

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_FRAME_STATISTICS")]
    public unsafe partial struct FrameStatistics
    {
        public FrameStatistics
        (
            uint presentCount = default,
            uint presentRefreshCount = default,
            uint syncRefreshCount = default,
            long syncQPCTime = default,
            long syncGPUTime = default
        )
        {
            PresentCount = presentCount;
            PresentRefreshCount = presentRefreshCount;
            SyncRefreshCount = syncRefreshCount;
            SyncQPCTime = syncQPCTime;
            SyncGPUTime = syncGPUTime;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PresentCount")]
        public uint PresentCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "PresentRefreshCount")]
        public uint PresentRefreshCount;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SyncRefreshCount")]
        public uint SyncRefreshCount;

        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "SyncQPCTime")]
        public long SyncQPCTime;

        [NativeName("Type", "LARGE_INTEGER")]
        [NativeName("Type.Name", "LARGE_INTEGER")]
        [NativeName("Name", "SyncGPUTime")]
        public long SyncGPUTime;
    }
}
