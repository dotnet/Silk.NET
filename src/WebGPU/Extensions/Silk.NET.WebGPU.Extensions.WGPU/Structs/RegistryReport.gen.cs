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
    [NativeName("Name", "WGPURegistryReport")]
    public unsafe partial struct RegistryReport
    {
        public RegistryReport
        (
            nuint? numAllocated = null,
            nuint? numKeptFromUser = null,
            nuint? numReleasedFromUser = null,
            nuint? numError = null,
            nuint? elementSize = null
        ) : this()
        {
            if (numAllocated is not null)
            {
                NumAllocated = numAllocated.Value;
            }

            if (numKeptFromUser is not null)
            {
                NumKeptFromUser = numKeptFromUser.Value;
            }

            if (numReleasedFromUser is not null)
            {
                NumReleasedFromUser = numReleasedFromUser.Value;
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
        [NativeName("Name", "numAllocated")]
        public nuint NumAllocated;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "numKeptFromUser")]
        public nuint NumKeptFromUser;

        [NativeName("Type", "size_t")]
        [NativeName("Type.Name", "size_t")]
        [NativeName("Name", "numReleasedFromUser")]
        public nuint NumReleasedFromUser;

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
