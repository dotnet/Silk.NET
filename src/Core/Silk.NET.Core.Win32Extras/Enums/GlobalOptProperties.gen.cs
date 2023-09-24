// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [NativeName("Name", "tagGLOBALOPT_PROPERTIES")]
    public enum GlobalOptProperties : int
    {
        [Obsolete("Deprecated in favour of \"ExceptionHandling\"")]
        [NativeName("Name", "COMGLB_EXCEPTION_HANDLING")]
        ComglbExceptionHandling = 0x1,
        [Obsolete("Deprecated in favour of \"Appid\"")]
        [NativeName("Name", "COMGLB_APPID")]
        ComglbAppid = 0x2,
        [Obsolete("Deprecated in favour of \"RpcThreadpoolSetting\"")]
        [NativeName("Name", "COMGLB_RPC_THREADPOOL_SETTING")]
        ComglbRpcThreadpoolSetting = 0x3,
        [Obsolete("Deprecated in favour of \"ROSettings\"")]
        [NativeName("Name", "COMGLB_RO_SETTINGS")]
        ComglbROSettings = 0x4,
        [Obsolete("Deprecated in favour of \"UnmarshalingPolicy\"")]
        [NativeName("Name", "COMGLB_UNMARSHALING_POLICY")]
        ComglbUnmarshalingPolicy = 0x5,
        [Obsolete("Deprecated in favour of \"PropertiesReserved1\"")]
        [NativeName("Name", "COMGLB_PROPERTIES_RESERVED1")]
        ComglbPropertiesReserved1 = 0x6,
        [Obsolete("Deprecated in favour of \"PropertiesReserved2\"")]
        [NativeName("Name", "COMGLB_PROPERTIES_RESERVED2")]
        ComglbPropertiesReserved2 = 0x7,
        [Obsolete("Deprecated in favour of \"PropertiesReserved3\"")]
        [NativeName("Name", "COMGLB_PROPERTIES_RESERVED3")]
        ComglbPropertiesReserved3 = 0x8,
        [NativeName("Name", "COMGLB_EXCEPTION_HANDLING")]
        ExceptionHandling = 0x1,
        [NativeName("Name", "COMGLB_APPID")]
        Appid = 0x2,
        [NativeName("Name", "COMGLB_RPC_THREADPOOL_SETTING")]
        RpcThreadpoolSetting = 0x3,
        [NativeName("Name", "COMGLB_RO_SETTINGS")]
        ROSettings = 0x4,
        [NativeName("Name", "COMGLB_UNMARSHALING_POLICY")]
        UnmarshalingPolicy = 0x5,
        [NativeName("Name", "COMGLB_PROPERTIES_RESERVED1")]
        PropertiesReserved1 = 0x6,
        [NativeName("Name", "COMGLB_PROPERTIES_RESERVED2")]
        PropertiesReserved2 = 0x7,
        [NativeName("Name", "COMGLB_PROPERTIES_RESERVED3")]
        PropertiesReserved3 = 0x8,
    }
}
