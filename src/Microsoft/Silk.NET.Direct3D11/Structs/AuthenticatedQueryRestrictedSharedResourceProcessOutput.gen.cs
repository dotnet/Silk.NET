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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_AUTHENTICATED_QUERY_RESTRICTED_SHARED_RESOURCE_PROCESS_OUTPUT")]
    public unsafe partial struct AuthenticatedQueryRestrictedSharedResourceProcessOutput
    {
        public AuthenticatedQueryRestrictedSharedResourceProcessOutput
        (
            AuthenticatedQueryOutput? output = null,
            uint? processIndex = null,
            AuthenticatedProcessIdentifierType? processIdentifier = null,
            nint* processHandle = null
        ) : this()
        {
            if (output is not null)
            {
                Output = output.Value;
            }

            if (processIndex is not null)
            {
                ProcessIndex = processIndex.Value;
            }

            if (processIdentifier is not null)
            {
                ProcessIdentifier = processIdentifier.Value;
            }

            if (processHandle is not null)
            {
                ProcessHandle = processHandle;
            }
        }


        [NativeName("Type", "D3D11_AUTHENTICATED_QUERY_OUTPUT")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_QUERY_OUTPUT")]
        [NativeName("Name", "Output")]
        public AuthenticatedQueryOutput Output;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "ProcessIndex")]
        public uint ProcessIndex;

        [NativeName("Type", "D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE")]
        [NativeName("Name", "ProcessIdentifier")]
        public AuthenticatedProcessIdentifierType ProcessIdentifier;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "ProcessHandle")]
        public nint* ProcessHandle;
    }
}
