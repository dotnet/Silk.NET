// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DIERR
{
    [NativeTypeName(
        "#define DIERR_OLDDIRECTINPUTVERSION MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_OLD_WIN_VERSION)"
    )]
    public const int DIERR_OLDDIRECTINPUTVERSION = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(1150)))
    );

    [NativeTypeName(
        "#define DIERR_BETADIRECTINPUTVERSION MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_RMODE_APP)"
    )]
    public const int DIERR_BETADIRECTINPUTVERSION = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(1153)))
    );

    [NativeTypeName(
        "#define DIERR_BADDRIVERVER MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_BAD_DRIVER_LEVEL)"
    )]
    public const int DIERR_BADDRIVERVER = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(119)))
    );

    [NativeTypeName("#define DIERR_DEVICENOTREG REGDB_E_CLASSNOTREG")]
    public const int DIERR_DEVICENOTREG = unchecked((int)(0x80040154));

    [NativeTypeName(
        "#define DIERR_NOTFOUND MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_FILE_NOT_FOUND)"
    )]
    public const int DIERR_NOTFOUND = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(2)))
    );

    [NativeTypeName(
        "#define DIERR_OBJECTNOTFOUND MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_FILE_NOT_FOUND)"
    )]
    public const int DIERR_OBJECTNOTFOUND = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(2)))
    );

    [NativeTypeName("#define DIERR_INVALIDPARAM E_INVALIDARG")]
    public const int DIERR_INVALIDPARAM = unchecked((int)(0x80070057));

    [NativeTypeName("#define DIERR_NOINTERFACE E_NOINTERFACE")]
    public const int DIERR_NOINTERFACE = unchecked((int)(0x80004002));

    [NativeTypeName("#define DIERR_GENERIC E_FAIL")]
    public const int DIERR_GENERIC = unchecked((int)(0x80004005));

    [NativeTypeName("#define DIERR_OUTOFMEMORY E_OUTOFMEMORY")]
    public const int DIERR_OUTOFMEMORY = unchecked((int)(0x8007000E));

    [NativeTypeName("#define DIERR_UNSUPPORTED E_NOTIMPL")]
    public const int DIERR_UNSUPPORTED = unchecked((int)(0x80004001));

    [NativeTypeName(
        "#define DIERR_NOTINITIALIZED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_NOT_READY)"
    )]
    public const int DIERR_NOTINITIALIZED = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(21)))
    );

    [NativeTypeName(
        "#define DIERR_ALREADYINITIALIZED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_ALREADY_INITIALIZED)"
    )]
    public const int DIERR_ALREADYINITIALIZED = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(1247)))
    );

    [NativeTypeName("#define DIERR_NOAGGREGATION CLASS_E_NOAGGREGATION")]
    public const int DIERR_NOAGGREGATION = unchecked((int)(0x80040110));

    [NativeTypeName("#define DIERR_OTHERAPPHASPRIO E_ACCESSDENIED")]
    public const int DIERR_OTHERAPPHASPRIO = unchecked((int)(0x80070005));

    [NativeTypeName(
        "#define DIERR_INPUTLOST MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_READ_FAULT)"
    )]
    public const int DIERR_INPUTLOST = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(30)))
    );

    [NativeTypeName(
        "#define DIERR_ACQUIRED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_BUSY)"
    )]
    public const int DIERR_ACQUIRED = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(170)))
    );

    [NativeTypeName(
        "#define DIERR_NOTACQUIRED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_WIN32, ERROR_INVALID_ACCESS)"
    )]
    public const int DIERR_NOTACQUIRED = unchecked(
        (int)(((uint)(1) << 31) | ((uint)(7) << 16) | ((uint)(12)))
    );

    [NativeTypeName("#define DIERR_READONLY E_ACCESSDENIED")]
    public const int DIERR_READONLY = unchecked((int)(0x80070005));

    [NativeTypeName("#define DIERR_HANDLEEXISTS E_ACCESSDENIED")]
    public const int DIERR_HANDLEEXISTS = unchecked((int)(0x80070005));

    [NativeTypeName("#define DIERR_INSUFFICIENTPRIVS 0x80040200L")]
    public const uint DIERR_INSUFFICIENTPRIVS = 0x80040200;

    [NativeTypeName("#define DIERR_DEVICEFULL 0x80040201L")]
    public const uint DIERR_DEVICEFULL = 0x80040201;

    [NativeTypeName("#define DIERR_MOREDATA 0x80040202L")]
    public const uint DIERR_MOREDATA = 0x80040202;

    [NativeTypeName("#define DIERR_NOTDOWNLOADED 0x80040203L")]
    public const uint DIERR_NOTDOWNLOADED = 0x80040203;

    [NativeTypeName("#define DIERR_HASEFFECTS 0x80040204L")]
    public const uint DIERR_HASEFFECTS = 0x80040204;

    [NativeTypeName("#define DIERR_NOTEXCLUSIVEACQUIRED 0x80040205L")]
    public const uint DIERR_NOTEXCLUSIVEACQUIRED = 0x80040205;

    [NativeTypeName("#define DIERR_INCOMPLETEEFFECT 0x80040206L")]
    public const uint DIERR_INCOMPLETEEFFECT = 0x80040206;

    [NativeTypeName("#define DIERR_NOTBUFFERED 0x80040207L")]
    public const uint DIERR_NOTBUFFERED = 0x80040207;

    [NativeTypeName("#define DIERR_EFFECTPLAYING 0x80040208L")]
    public const uint DIERR_EFFECTPLAYING = 0x80040208;

    [NativeTypeName("#define DIERR_UNPLUGGED 0x80040209L")]
    public const uint DIERR_UNPLUGGED = 0x80040209;

    [NativeTypeName("#define DIERR_REPORTFULL 0x8004020AL")]
    public const uint DIERR_REPORTFULL = 0x8004020A;

    [NativeTypeName("#define DIERR_MAPFILEFAIL 0x8004020BL")]
    public const uint DIERR_MAPFILEFAIL = 0x8004020B;
}
