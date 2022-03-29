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
    [NativeName("Name", "DSTORAGE_ERROR_RECORD")]
    public unsafe partial struct ErrorRecord
    {
        public ErrorRecord
        (
            uint? failureCount = null,
            ErrorFirstFailure? firstFailure = null
        ) : this()
        {
            if (failureCount is not null)
            {
                FailureCount = failureCount.Value;
            }

            if (firstFailure is not null)
            {
                FirstFailure = firstFailure.Value;
            }
        }


        [NativeName("Type", "UINT32")]
        [NativeName("Type.Name", "UINT32")]
        [NativeName("Name", "FailureCount")]
        public uint FailureCount;

        [NativeName("Type", "DSTORAGE_ERROR_FIRST_FAILURE")]
        [NativeName("Type.Name", "DSTORAGE_ERROR_FIRST_FAILURE")]
        [NativeName("Name", "FirstFailure")]
        public ErrorFirstFailure FirstFailure;
    }
}
