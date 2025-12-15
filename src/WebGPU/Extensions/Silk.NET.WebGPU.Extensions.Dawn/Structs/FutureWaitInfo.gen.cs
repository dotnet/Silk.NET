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

namespace Silk.NET.WebGPU.Extensions.Dawn
{
    [NativeName("Name", "WGPUFutureWaitInfo")]
    public unsafe partial struct FutureWaitInfo
    {
        public FutureWaitInfo
        (
            Future? future = null,
            Silk.NET.Core.Bool32? completed = null
        ) : this()
        {
            if (future is not null)
            {
                Future = future.Value;
            }

            if (completed is not null)
            {
                Completed = completed.Value;
            }
        }


        [NativeName("Type", "WGPUFuture")]
        [NativeName("Type.Name", "WGPUFuture")]
        [NativeName("Name", "future")]
        public Future Future;

        [NativeName("Type", "WGPUBool")]
        [NativeName("Type.Name", "WGPUBool")]
        [NativeName("Name", "completed")]
        public Silk.NET.Core.Bool32 Completed;
    }
}
