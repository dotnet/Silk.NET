// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagGLOBALOPT_RPCTP_VALUES")]
    public enum GlobalOptRPCTPValues : int
    {
        [Obsolete("Deprecated in favour of \"DefaultPool\"")]
        [NativeName("Name", "COMGLB_RPC_THREADPOOL_SETTING_DEFAULT_POOL")]
        ComglbRpcThreadpoolSettingDefaultPool = 0x0,
        [Obsolete("Deprecated in favour of \"PrivatePool\"")]
        [NativeName("Name", "COMGLB_RPC_THREADPOOL_SETTING_PRIVATE_POOL")]
        ComglbRpcThreadpoolSettingPrivatePool = 0x1,
        [NativeName("Name", "COMGLB_RPC_THREADPOOL_SETTING_DEFAULT_POOL")]
        DefaultPool = 0x0,
        [NativeName("Name", "COMGLB_RPC_THREADPOOL_SETTING_PRIVATE_POOL")]
        PrivatePool = 0x1,
    }
}
