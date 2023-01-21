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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "DSTORAGE_ERROR_PARAMETERS_REQUEST")]
    public unsafe partial struct ErrorParametersRequest
    {
        public ErrorParametersRequest
        (
            Request? request = null
        ) : this()
        {
            if (request is not null)
            {
                Request = request.Value;
            }
        }

        [NativeName("Type", "WCHAR[260]")]
        [NativeName("Type.Name", "WCHAR[260]")]
        [NativeName("Name", "Filename")]
        public fixed char Filename[260];
        [NativeName("Type", "CHAR[64]")]
        [NativeName("Type.Name", "CHAR[64]")]
        [NativeName("Name", "RequestName")]
        public fixed byte RequestName[64];

        [NativeName("Type", "DSTORAGE_REQUEST")]
        [NativeName("Type.Name", "DSTORAGE_REQUEST")]
        [NativeName("Name", "Request")]
        public Request Request;
    }
}
