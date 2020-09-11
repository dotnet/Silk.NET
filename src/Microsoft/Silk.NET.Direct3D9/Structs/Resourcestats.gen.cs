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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DRESOURCESTATS")]
    public unsafe partial struct Resourcestats
    {
        public Resourcestats
        (
            int bThrashing = default,
            uint approxBytesDownloaded = default,
            uint numEvicts = default,
            uint numVidCreates = default,
            uint lastPri = default,
            uint numUsed = default,
            uint numUsedInVidMem = default,
            uint workingSet = default,
            uint workingSetBytes = default,
            uint totalManaged = default,
            uint totalBytes = default
        )
        {
            BThrashing = bThrashing;
            ApproxBytesDownloaded = approxBytesDownloaded;
            NumEvicts = numEvicts;
            NumVidCreates = numVidCreates;
            LastPri = lastPri;
            NumUsed = numUsed;
            NumUsedInVidMem = numUsedInVidMem;
            WorkingSet = workingSet;
            WorkingSetBytes = workingSetBytes;
            TotalManaged = totalManaged;
            TotalBytes = totalBytes;
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "bThrashing")]
        public int BThrashing;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "ApproxBytesDownloaded")]
        public uint ApproxBytesDownloaded;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumEvicts")]
        public uint NumEvicts;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumVidCreates")]
        public uint NumVidCreates;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "LastPri")]
        public uint LastPri;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumUsed")]
        public uint NumUsed;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumUsedInVidMem")]
        public uint NumUsedInVidMem;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "WorkingSet")]
        public uint WorkingSet;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "WorkingSetBytes")]
        public uint WorkingSetBytes;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "TotalManaged")]
        public uint TotalManaged;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "TotalBytes")]
        public uint TotalBytes;
    }
}
