// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class MILERR
{
    [NativeTypeName("#define MILERR_OBJECTBUSY _HRESULT_TYPEDEF_(0x88980001L)")]
    public const int MILERR_OBJECTBUSY = unchecked((int)(0x88980001));

    [NativeTypeName("#define MILERR_INSUFFICIENTBUFFER _HRESULT_TYPEDEF_(0x88980002L)")]
    public const int MILERR_INSUFFICIENTBUFFER = unchecked((int)(0x88980002));

    [NativeTypeName("#define MILERR_WIN32ERROR _HRESULT_TYPEDEF_(0x88980003L)")]
    public const int MILERR_WIN32ERROR = unchecked((int)(0x88980003));

    [NativeTypeName("#define MILERR_SCANNER_FAILED _HRESULT_TYPEDEF_(0x88980004L)")]
    public const int MILERR_SCANNER_FAILED = unchecked((int)(0x88980004));

    [NativeTypeName("#define MILERR_SCREENACCESSDENIED _HRESULT_TYPEDEF_(0x88980005L)")]
    public const int MILERR_SCREENACCESSDENIED = unchecked((int)(0x88980005));

    [NativeTypeName("#define MILERR_DISPLAYSTATEINVALID _HRESULT_TYPEDEF_(0x88980006L)")]
    public const int MILERR_DISPLAYSTATEINVALID = unchecked((int)(0x88980006));

    [NativeTypeName("#define MILERR_NONINVERTIBLEMATRIX _HRESULT_TYPEDEF_(0x88980007L)")]
    public const int MILERR_NONINVERTIBLEMATRIX = unchecked((int)(0x88980007));

    [NativeTypeName("#define MILERR_ZEROVECTOR _HRESULT_TYPEDEF_(0x88980008L)")]
    public const int MILERR_ZEROVECTOR = unchecked((int)(0x88980008));

    [NativeTypeName("#define MILERR_TERMINATED _HRESULT_TYPEDEF_(0x88980009L)")]
    public const int MILERR_TERMINATED = unchecked((int)(0x88980009));

    [NativeTypeName("#define MILERR_BADNUMBER _HRESULT_TYPEDEF_(0x8898000AL)")]
    public const int MILERR_BADNUMBER = unchecked((int)(0x8898000A));

    [NativeTypeName("#define MILERR_INTERNALERROR _HRESULT_TYPEDEF_(0x88980080L)")]
    public const int MILERR_INTERNALERROR = unchecked((int)(0x88980080));

    [NativeTypeName("#define MILERR_DISPLAYFORMATNOTSUPPORTED _HRESULT_TYPEDEF_(0x88980084L)")]
    public const int MILERR_DISPLAYFORMATNOTSUPPORTED = unchecked((int)(0x88980084));

    [NativeTypeName("#define MILERR_INVALIDCALL _HRESULT_TYPEDEF_(0x88980085L)")]
    public const int MILERR_INVALIDCALL = unchecked((int)(0x88980085));

    [NativeTypeName("#define MILERR_ALREADYLOCKED _HRESULT_TYPEDEF_(0x88980086L)")]
    public const int MILERR_ALREADYLOCKED = unchecked((int)(0x88980086));

    [NativeTypeName("#define MILERR_NOTLOCKED _HRESULT_TYPEDEF_(0x88980087L)")]
    public const int MILERR_NOTLOCKED = unchecked((int)(0x88980087));

    [NativeTypeName("#define MILERR_DEVICECANNOTRENDERTEXT _HRESULT_TYPEDEF_(0x88980088L)")]
    public const int MILERR_DEVICECANNOTRENDERTEXT = unchecked((int)(0x88980088));

    [NativeTypeName("#define MILERR_GLYPHBITMAPMISSED _HRESULT_TYPEDEF_(0x88980089L)")]
    public const int MILERR_GLYPHBITMAPMISSED = unchecked((int)(0x88980089));

    [NativeTypeName("#define MILERR_MALFORMEDGLYPHCACHE _HRESULT_TYPEDEF_(0x8898008AL)")]
    public const int MILERR_MALFORMEDGLYPHCACHE = unchecked((int)(0x8898008A));

    [NativeTypeName("#define MILERR_GENERIC_IGNORE _HRESULT_TYPEDEF_(0x8898008BL)")]
    public const int MILERR_GENERIC_IGNORE = unchecked((int)(0x8898008B));

    [NativeTypeName("#define MILERR_MALFORMED_GUIDELINE_DATA _HRESULT_TYPEDEF_(0x8898008CL)")]
    public const int MILERR_MALFORMED_GUIDELINE_DATA = unchecked((int)(0x8898008C));

    [NativeTypeName("#define MILERR_NO_HARDWARE_DEVICE _HRESULT_TYPEDEF_(0x8898008DL)")]
    public const int MILERR_NO_HARDWARE_DEVICE = unchecked((int)(0x8898008D));

    [NativeTypeName("#define MILERR_NEED_RECREATE_AND_PRESENT _HRESULT_TYPEDEF_(0x8898008EL)")]
    public const int MILERR_NEED_RECREATE_AND_PRESENT = unchecked((int)(0x8898008E));

    [NativeTypeName("#define MILERR_ALREADY_INITIALIZED _HRESULT_TYPEDEF_(0x8898008FL)")]
    public const int MILERR_ALREADY_INITIALIZED = unchecked((int)(0x8898008F));

    [NativeTypeName("#define MILERR_MISMATCHED_SIZE _HRESULT_TYPEDEF_(0x88980090L)")]
    public const int MILERR_MISMATCHED_SIZE = unchecked((int)(0x88980090));

    [NativeTypeName("#define MILERR_NO_REDIRECTION_SURFACE_AVAILABLE _HRESULT_TYPEDEF_(0x88980091L)")]
    public const int MILERR_NO_REDIRECTION_SURFACE_AVAILABLE = unchecked((int)(0x88980091));

    [NativeTypeName("#define MILERR_REMOTING_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x88980092L)")]
    public const int MILERR_REMOTING_NOT_SUPPORTED = unchecked((int)(0x88980092));

    [NativeTypeName("#define MILERR_QUEUED_PRESENT_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x88980093L)")]
    public const int MILERR_QUEUED_PRESENT_NOT_SUPPORTED = unchecked((int)(0x88980093));

    [NativeTypeName("#define MILERR_NOT_QUEUING_PRESENTS _HRESULT_TYPEDEF_(0x88980094L)")]
    public const int MILERR_NOT_QUEUING_PRESENTS = unchecked((int)(0x88980094));

    [NativeTypeName("#define MILERR_NO_REDIRECTION_SURFACE_RETRY_LATER _HRESULT_TYPEDEF_(0x88980095L)")]
    public const int MILERR_NO_REDIRECTION_SURFACE_RETRY_LATER = unchecked((int)(0x88980095));

    [NativeTypeName("#define MILERR_TOOMANYSHADERELEMNTS _HRESULT_TYPEDEF_(0x88980096L)")]
    public const int MILERR_TOOMANYSHADERELEMNTS = unchecked((int)(0x88980096));

    [NativeTypeName("#define MILERR_MROW_READLOCK_FAILED _HRESULT_TYPEDEF_(0x88980097L)")]
    public const int MILERR_MROW_READLOCK_FAILED = unchecked((int)(0x88980097));

    [NativeTypeName("#define MILERR_MROW_UPDATE_FAILED _HRESULT_TYPEDEF_(0x88980098L)")]
    public const int MILERR_MROW_UPDATE_FAILED = unchecked((int)(0x88980098));

    [NativeTypeName("#define MILERR_SHADER_COMPILE_FAILED _HRESULT_TYPEDEF_(0x88980099L)")]
    public const int MILERR_SHADER_COMPILE_FAILED = unchecked((int)(0x88980099));

    [NativeTypeName("#define MILERR_MAX_TEXTURE_SIZE_EXCEEDED _HRESULT_TYPEDEF_(0x8898009AL)")]
    public const int MILERR_MAX_TEXTURE_SIZE_EXCEEDED = unchecked((int)(0x8898009A));

    [NativeTypeName("#define MILERR_QPC_TIME_WENT_BACKWARD _HRESULT_TYPEDEF_(0x8898009BL)")]
    public const int MILERR_QPC_TIME_WENT_BACKWARD = unchecked((int)(0x8898009B));

    [NativeTypeName("#define MILERR_DXGI_ENUMERATION_OUT_OF_SYNC _HRESULT_TYPEDEF_(0x8898009DL)")]
    public const int MILERR_DXGI_ENUMERATION_OUT_OF_SYNC = unchecked((int)(0x8898009D));

    [NativeTypeName("#define MILERR_ADAPTER_NOT_FOUND _HRESULT_TYPEDEF_(0x8898009EL)")]
    public const int MILERR_ADAPTER_NOT_FOUND = unchecked((int)(0x8898009E));

    [NativeTypeName("#define MILERR_COLORSPACE_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x8898009FL)")]
    public const int MILERR_COLORSPACE_NOT_SUPPORTED = unchecked((int)(0x8898009F));

    [NativeTypeName("#define MILERR_PREFILTER_NOT_SUPPORTED _HRESULT_TYPEDEF_(0x889800A0L)")]
    public const int MILERR_PREFILTER_NOT_SUPPORTED = unchecked((int)(0x889800A0));

    [NativeTypeName("#define MILERR_DISPLAYID_ACCESS_DENIED _HRESULT_TYPEDEF_(0x889800A1L)")]
    public const int MILERR_DISPLAYID_ACCESS_DENIED = unchecked((int)(0x889800A1));
}
