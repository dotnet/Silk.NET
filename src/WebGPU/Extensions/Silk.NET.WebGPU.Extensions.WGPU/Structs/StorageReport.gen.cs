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
    [NativeName("Name", "WGPUStorageReport")]
    public unsafe partial struct StorageReport
    {
        public StorageReport
        (
            nuint? numOccupied = null,
            nuint? numVacant = null,
            nuint? numError = null,
            nuint? elementSize = null
        ) : this()
        {
            if (numOccupied is not null)
            {
                NumOccupied = numOccupied.Value;
            }

            if (numVacant is not null)
            {
                NumVacant = numVacant.Value;
            }

            if (numError is not null)
            {
                NumError = numError.Value;
            }

            if (elementSize is not null)
            {
                ElementSize = elementSize.Value;
            }
        }


        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "numOccupied")]
        public nuint NumOccupied;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "numVacant")]
        public nuint NumVacant;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "numError")]
        public nuint NumError;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "elementSize")]
        public nuint ElementSize;
    }
}
