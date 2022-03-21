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

namespace Silk.NET.DirectStorage
{
    [NativeName("Name", "DSTORAGE_ERROR_PARAMETERS_STATUS")]
    public unsafe partial struct ErrorParametersStatus
    {
        public ErrorParametersStatus
        (
            IDStorageStatusArray* statusArray = null,
            uint? index = null
        ) : this()
        {
            if (statusArray is not null)
            {
                StatusArray = statusArray;
            }

            if (index is not null)
            {
                Index = index.Value;
            }
        }


        [NativeName("Type", "IDStorageStatusArray *")]
        [NativeName("Type.Name", "IDStorageStatusArray *")]
        [NativeName("Name", "StatusArray")]
        public IDStorageStatusArray* StatusArray;

        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "Index")]
        public uint Index;
    }
}
