// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class MILAVERR
{
    [NativeTypeName("#define MILAVERR_NOCLOCK _HRESULT_TYPEDEF_(0x88980500L)")]
    public const int MILAVERR_NOCLOCK = unchecked((int)(0x88980500));

    [NativeTypeName("#define MILAVERR_NOMEDIATYPE _HRESULT_TYPEDEF_(0x88980501L)")]
    public const int MILAVERR_NOMEDIATYPE = unchecked((int)(0x88980501));

    [NativeTypeName("#define MILAVERR_NOVIDEOMIXER _HRESULT_TYPEDEF_(0x88980502L)")]
    public const int MILAVERR_NOVIDEOMIXER = unchecked((int)(0x88980502));

    [NativeTypeName("#define MILAVERR_NOVIDEOPRESENTER _HRESULT_TYPEDEF_(0x88980503L)")]
    public const int MILAVERR_NOVIDEOPRESENTER = unchecked((int)(0x88980503));

    [NativeTypeName("#define MILAVERR_NOREADYFRAMES _HRESULT_TYPEDEF_(0x88980504L)")]
    public const int MILAVERR_NOREADYFRAMES = unchecked((int)(0x88980504));

    [NativeTypeName("#define MILAVERR_MODULENOTLOADED _HRESULT_TYPEDEF_(0x88980505L)")]
    public const int MILAVERR_MODULENOTLOADED = unchecked((int)(0x88980505));

    [NativeTypeName("#define MILAVERR_WMPFACTORYNOTREGISTERED _HRESULT_TYPEDEF_(0x88980506L)")]
    public const int MILAVERR_WMPFACTORYNOTREGISTERED = unchecked((int)(0x88980506));

    [NativeTypeName("#define MILAVERR_INVALIDWMPVERSION _HRESULT_TYPEDEF_(0x88980507L)")]
    public const int MILAVERR_INVALIDWMPVERSION = unchecked((int)(0x88980507));

    [NativeTypeName("#define MILAVERR_INSUFFICIENTVIDEORESOURCES _HRESULT_TYPEDEF_(0x88980508L)")]
    public const int MILAVERR_INSUFFICIENTVIDEORESOURCES = unchecked((int)(0x88980508));

    [NativeTypeName(
        "#define MILAVERR_VIDEOACCELERATIONNOTAVAILABLE _HRESULT_TYPEDEF_(0x88980509L)"
    )]
    public const int MILAVERR_VIDEOACCELERATIONNOTAVAILABLE = unchecked((int)(0x88980509));

    [NativeTypeName("#define MILAVERR_REQUESTEDTEXTURETOOBIG _HRESULT_TYPEDEF_(0x8898050AL)")]
    public const int MILAVERR_REQUESTEDTEXTURETOOBIG = unchecked((int)(0x8898050A));

    [NativeTypeName("#define MILAVERR_SEEKFAILED _HRESULT_TYPEDEF_(0x8898050BL)")]
    public const int MILAVERR_SEEKFAILED = unchecked((int)(0x8898050B));

    [NativeTypeName("#define MILAVERR_UNEXPECTEDWMPFAILURE _HRESULT_TYPEDEF_(0x8898050CL)")]
    public const int MILAVERR_UNEXPECTEDWMPFAILURE = unchecked((int)(0x8898050C));

    [NativeTypeName("#define MILAVERR_MEDIAPLAYERCLOSED _HRESULT_TYPEDEF_(0x8898050DL)")]
    public const int MILAVERR_MEDIAPLAYERCLOSED = unchecked((int)(0x8898050D));

    [NativeTypeName("#define MILAVERR_UNKNOWNHARDWAREERROR _HRESULT_TYPEDEF_(0x8898050EL)")]
    public const int MILAVERR_UNKNOWNHARDWAREERROR = unchecked((int)(0x8898050E));
}
