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

namespace Silk.NET.Direct3D9
{
    [NativeName("Name", "_D3DRESOURCESTATS")]
    public unsafe partial struct Resourcestats
    {
        public Resourcestats
        (
            bool? bThrashing = null,
            int? approxBytesDownloaded = null,
            int? numEvicts = null,
            int? numVidCreates = null,
            int? lastPri = null,
            int? numUsed = null,
            int? numUsedInVidMem = null,
            int? workingSet = null,
            int? workingSetBytes = null,
            int? totalManaged = null,
            int? totalBytes = null
        ) : this()
        {
            if (bThrashing is not null)
            {
                BThrashing = bThrashing.Value;
            }

            if (approxBytesDownloaded is not null)
            {
                ApproxBytesDownloaded = approxBytesDownloaded.Value;
            }

            if (numEvicts is not null)
            {
                NumEvicts = numEvicts.Value;
            }

            if (numVidCreates is not null)
            {
                NumVidCreates = numVidCreates.Value;
            }

            if (lastPri is not null)
            {
                LastPri = lastPri.Value;
            }

            if (numUsed is not null)
            {
                NumUsed = numUsed.Value;
            }

            if (numUsedInVidMem is not null)
            {
                NumUsedInVidMem = numUsedInVidMem.Value;
            }

            if (workingSet is not null)
            {
                WorkingSet = workingSet.Value;
            }

            if (workingSetBytes is not null)
            {
                WorkingSetBytes = workingSetBytes.Value;
            }

            if (totalManaged is not null)
            {
                TotalManaged = totalManaged.Value;
            }

            if (totalBytes is not null)
            {
                TotalBytes = totalBytes.Value;
            }
        }


        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "bThrashing")]
        public bool BThrashing;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "ApproxBytesDownloaded")]
        public int ApproxBytesDownloaded;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumEvicts")]
        public int NumEvicts;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumVidCreates")]
        public int NumVidCreates;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "LastPri")]
        public int LastPri;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumUsed")]
        public int NumUsed;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "NumUsedInVidMem")]
        public int NumUsedInVidMem;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "WorkingSet")]
        public int WorkingSet;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "WorkingSetBytes")]
        public int WorkingSetBytes;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "TotalManaged")]
        public int TotalManaged;

        [NativeName("Type", "DWORD")]
        [NativeName("Type.Name", "DWORD")]
        [NativeName("Name", "TotalBytes")]
        public int TotalBytes;
    }
}
