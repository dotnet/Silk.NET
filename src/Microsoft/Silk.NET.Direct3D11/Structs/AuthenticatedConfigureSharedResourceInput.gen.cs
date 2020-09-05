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

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_AUTHENTICATED_CONFIGURE_SHARED_RESOURCE_INPUT")]
    public unsafe partial struct AuthenticatedConfigureSharedResourceInput
    {
        public AuthenticatedConfigureSharedResourceInput
        (
            AuthenticatedConfigureInput parameters = default,
            AuthenticatedProcessIdentifierType processType = default,
            void* processHandle = default,
            int allowAccess = default
        )
        {
            Parameters = parameters;
            ProcessType = processType;
            ProcessHandle = processHandle;
            AllowAccess = allowAccess;
        }


        [NativeName("Type", "D3D11_AUTHENTICATED_CONFIGURE_INPUT")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_CONFIGURE_INPUT")]
        [NativeName("Name", "Parameters")]
        public AuthenticatedConfigureInput Parameters;

        [NativeName("Type", "D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE")]
        [NativeName("Type.Name", "D3D11_AUTHENTICATED_PROCESS_IDENTIFIER_TYPE")]
        [NativeName("Name", "ProcessType")]
        public AuthenticatedProcessIdentifierType ProcessType;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "ProcessHandle")]
        public void* ProcessHandle;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AllowAccess")]
        public int AllowAccess;
    }
}
