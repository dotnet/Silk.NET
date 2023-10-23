// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Core.Win32Extras
{
    [Flags]
    [NativeName("Name", "tagCLSCTX")]
    public enum CLSCTX : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"InprocServer\"")]
        [NativeName("Name", "CLSCTX_INPROC_SERVER")]
        ClsctxInprocServer = 0x1,
        [Obsolete("Deprecated in favour of \"InprocHandler\"")]
        [NativeName("Name", "CLSCTX_INPROC_HANDLER")]
        ClsctxInprocHandler = 0x2,
        [Obsolete("Deprecated in favour of \"LocalServer\"")]
        [NativeName("Name", "CLSCTX_LOCAL_SERVER")]
        ClsctxLocalServer = 0x4,
        [Obsolete("Deprecated in favour of \"InprocServer16\"")]
        [NativeName("Name", "CLSCTX_INPROC_SERVER16")]
        ClsctxInprocServer16 = 0x8,
        [Obsolete("Deprecated in favour of \"RemoteServer\"")]
        [NativeName("Name", "CLSCTX_REMOTE_SERVER")]
        ClsctxRemoteServer = 0x10,
        [Obsolete("Deprecated in favour of \"InprocHandler16\"")]
        [NativeName("Name", "CLSCTX_INPROC_HANDLER16")]
        ClsctxInprocHandler16 = 0x20,
        [Obsolete("Deprecated in favour of \"Reserved1\"")]
        [NativeName("Name", "CLSCTX_RESERVED1")]
        ClsctxReserved1 = 0x40,
        [Obsolete("Deprecated in favour of \"Reserved2\"")]
        [NativeName("Name", "CLSCTX_RESERVED2")]
        ClsctxReserved2 = 0x80,
        [Obsolete("Deprecated in favour of \"Reserved3\"")]
        [NativeName("Name", "CLSCTX_RESERVED3")]
        ClsctxReserved3 = 0x100,
        [Obsolete("Deprecated in favour of \"Reserved4\"")]
        [NativeName("Name", "CLSCTX_RESERVED4")]
        ClsctxReserved4 = 0x200,
        [Obsolete("Deprecated in favour of \"NoCodeDownload\"")]
        [NativeName("Name", "CLSCTX_NO_CODE_DOWNLOAD")]
        ClsctxNoCodeDownload = 0x400,
        [Obsolete("Deprecated in favour of \"Reserved5\"")]
        [NativeName("Name", "CLSCTX_RESERVED5")]
        ClsctxReserved5 = 0x800,
        [Obsolete("Deprecated in favour of \"NoCustomMarshal\"")]
        [NativeName("Name", "CLSCTX_NO_CUSTOM_MARSHAL")]
        ClsctxNoCustomMarshal = 0x1000,
        [Obsolete("Deprecated in favour of \"EnableCodeDownload\"")]
        [NativeName("Name", "CLSCTX_ENABLE_CODE_DOWNLOAD")]
        ClsctxEnableCodeDownload = 0x2000,
        [Obsolete("Deprecated in favour of \"NoFailureLog\"")]
        [NativeName("Name", "CLSCTX_NO_FAILURE_LOG")]
        ClsctxNoFailureLog = 0x4000,
        [Obsolete("Deprecated in favour of \"DisableAaa\"")]
        [NativeName("Name", "CLSCTX_DISABLE_AAA")]
        ClsctxDisableAaa = 0x8000,
        [Obsolete("Deprecated in favour of \"EnableAaa\"")]
        [NativeName("Name", "CLSCTX_ENABLE_AAA")]
        ClsctxEnableAaa = 0x10000,
        [Obsolete("Deprecated in favour of \"FromDefaultContext\"")]
        [NativeName("Name", "CLSCTX_FROM_DEFAULT_CONTEXT")]
        ClsctxFromDefaultContext = 0x20000,
        [Obsolete("Deprecated in favour of \"ActivateX86Server\"")]
        [NativeName("Name", "CLSCTX_ACTIVATE_X86_SERVER")]
        ClsctxActivateX86Server = 0x40000,
        [Obsolete("Deprecated in favour of \"Activate32BitServer\"")]
        [NativeName("Name", "CLSCTX_ACTIVATE_32_BIT_SERVER")]
        ClsctxActivate32BitServer = 0x40000,
        [Obsolete("Deprecated in favour of \"Activate64BitServer\"")]
        [NativeName("Name", "CLSCTX_ACTIVATE_64_BIT_SERVER")]
        ClsctxActivate64BitServer = 0x80000,
        [Obsolete("Deprecated in favour of \"EnableCloaking\"")]
        [NativeName("Name", "CLSCTX_ENABLE_CLOAKING")]
        ClsctxEnableCloaking = 0x100000,
        [Obsolete("Deprecated in favour of \"Appcontainer\"")]
        [NativeName("Name", "CLSCTX_APPCONTAINER")]
        ClsctxAppcontainer = 0x400000,
        [Obsolete("Deprecated in favour of \"ActivateAaaAsIU\"")]
        [NativeName("Name", "CLSCTX_ACTIVATE_AAA_AS_IU")]
        ClsctxActivateAaaAsIU = 0x800000,
        [Obsolete("Deprecated in favour of \"Reserved6\"")]
        [NativeName("Name", "CLSCTX_RESERVED6")]
        ClsctxReserved6 = 0x1000000,
        [Obsolete("Deprecated in favour of \"ActivateArm32Server\"")]
        [NativeName("Name", "CLSCTX_ACTIVATE_ARM32_SERVER")]
        ClsctxActivateArm32Server = 0x2000000,
        [Obsolete("Deprecated in favour of \"AllowLowerTrustRegistration\"")]
        [NativeName("Name", "CLSCTX_ALLOW_LOWER_TRUST_REGISTRATION")]
        ClsctxAllowLowerTrustRegistration = 0x4000000,
        [Obsolete("Deprecated in favour of \"PSDll\"")]
        [NativeName("Name", "CLSCTX_PS_DLL")]
        ClsctxPSDll = unchecked((int) 0xFFFFFFFF80000000),
        [NativeName("Name", "CLSCTX_INPROC_SERVER")]
        InprocServer = 0x1,
        [NativeName("Name", "CLSCTX_INPROC_HANDLER")]
        InprocHandler = 0x2,
        [NativeName("Name", "CLSCTX_LOCAL_SERVER")]
        LocalServer = 0x4,
        [NativeName("Name", "CLSCTX_INPROC_SERVER16")]
        InprocServer16 = 0x8,
        [NativeName("Name", "CLSCTX_REMOTE_SERVER")]
        RemoteServer = 0x10,
        [NativeName("Name", "CLSCTX_INPROC_HANDLER16")]
        InprocHandler16 = 0x20,
        [NativeName("Name", "CLSCTX_RESERVED1")]
        Reserved1 = 0x40,
        [NativeName("Name", "CLSCTX_RESERVED2")]
        Reserved2 = 0x80,
        [NativeName("Name", "CLSCTX_RESERVED3")]
        Reserved3 = 0x100,
        [NativeName("Name", "CLSCTX_RESERVED4")]
        Reserved4 = 0x200,
        [NativeName("Name", "CLSCTX_NO_CODE_DOWNLOAD")]
        NoCodeDownload = 0x400,
        [NativeName("Name", "CLSCTX_RESERVED5")]
        Reserved5 = 0x800,
        [NativeName("Name", "CLSCTX_NO_CUSTOM_MARSHAL")]
        NoCustomMarshal = 0x1000,
        [NativeName("Name", "CLSCTX_ENABLE_CODE_DOWNLOAD")]
        EnableCodeDownload = 0x2000,
        [NativeName("Name", "CLSCTX_NO_FAILURE_LOG")]
        NoFailureLog = 0x4000,
        [NativeName("Name", "CLSCTX_DISABLE_AAA")]
        DisableAaa = 0x8000,
        [NativeName("Name", "CLSCTX_ENABLE_AAA")]
        EnableAaa = 0x10000,
        [NativeName("Name", "CLSCTX_FROM_DEFAULT_CONTEXT")]
        FromDefaultContext = 0x20000,
        [NativeName("Name", "CLSCTX_ACTIVATE_X86_SERVER")]
        ActivateX86Server = 0x40000,
        [NativeName("Name", "CLSCTX_ACTIVATE_32_BIT_SERVER")]
        Activate32BitServer = 0x40000,
        [NativeName("Name", "CLSCTX_ACTIVATE_64_BIT_SERVER")]
        Activate64BitServer = 0x80000,
        [NativeName("Name", "CLSCTX_ENABLE_CLOAKING")]
        EnableCloaking = 0x100000,
        [NativeName("Name", "CLSCTX_APPCONTAINER")]
        Appcontainer = 0x400000,
        [NativeName("Name", "CLSCTX_ACTIVATE_AAA_AS_IU")]
        ActivateAaaAsIU = 0x800000,
        [NativeName("Name", "CLSCTX_RESERVED6")]
        Reserved6 = 0x1000000,
        [NativeName("Name", "CLSCTX_ACTIVATE_ARM32_SERVER")]
        ActivateArm32Server = 0x2000000,
        [NativeName("Name", "CLSCTX_ALLOW_LOWER_TRUST_REGISTRATION")]
        AllowLowerTrustRegistration = 0x4000000,
        [NativeName("Name", "CLSCTX_PS_DLL")]
        PSDll = unchecked((int) 0xFFFFFFFF80000000),
    }
}
