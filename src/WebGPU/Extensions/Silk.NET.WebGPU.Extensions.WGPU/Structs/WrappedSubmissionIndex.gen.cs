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

namespace Silk.NET.WebGPU.Extensions.WGPU
{
    [NativeName("Name", "WGPUWrappedSubmissionIndex")]
    public unsafe partial struct WrappedSubmissionIndex
    {
        public WrappedSubmissionIndex
        (
            Queue* queue = null,
            ulong? submissionIndex = null
        ) : this()
        {
            if (queue is not null)
            {
                Queue = queue;
            }

            if (submissionIndex is not null)
            {
                SubmissionIndex = submissionIndex.Value;
            }
        }


        [NativeName("Type", "WGPUQueue")]
        [NativeName("Type.Name", "WGPUQueue")]
        [NativeName("Name", "queue")]
        public Queue* Queue;

        [NativeName("Type", "WGPUSubmissionIndex")]
        [NativeName("Type.Name", "WGPUSubmissionIndex")]
        [NativeName("Name", "submissionIndex")]
        public ulong SubmissionIndex;
    }
}
