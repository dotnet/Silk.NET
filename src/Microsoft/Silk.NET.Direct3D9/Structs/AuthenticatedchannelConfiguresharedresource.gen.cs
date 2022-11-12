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
    [NativeName("Name", "_D3DAUTHENTICATEDCHANNEL_CONFIGURESHAREDRESOURCE")]
    public unsafe partial struct AuthenticatedchannelConfiguresharedresource
    {
        public AuthenticatedchannelConfiguresharedresource
        (
            AuthenticatedchannelConfigureInput? parameters = null,
            AuthenticatedchannelProcessidentifiertype? processIdentiferType = null,
            nint* processHandle = null,
            bool? allowAccess = null
        ) : this()
        {
            if (parameters is not null)
            {
                Parameters = parameters.Value;
            }

            if (processIdentiferType is not null)
            {
                ProcessIdentiferType = processIdentiferType.Value;
            }

            if (processHandle is not null)
            {
                ProcessHandle = processHandle;
            }

            if (allowAccess is not null)
            {
                AllowAccess = allowAccess.Value;
            }
        }


        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_CONFIGURE_INPUT")]
        [NativeName("Name", "Parameters")]
        public AuthenticatedchannelConfigureInput Parameters;

        [NativeName("Type", "D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE")]
        [NativeName("Type.Name", "D3DAUTHENTICATEDCHANNEL_PROCESSIDENTIFIERTYPE")]
        [NativeName("Name", "ProcessIdentiferType")]
        public AuthenticatedchannelProcessidentifiertype ProcessIdentiferType;

        [NativeName("Type", "HANDLE")]
        [NativeName("Type.Name", "HANDLE")]
        [NativeName("Name", "ProcessHandle")]
        public nint* ProcessHandle;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "AllowAccess")]
        public bool AllowAccess;
    }
}
