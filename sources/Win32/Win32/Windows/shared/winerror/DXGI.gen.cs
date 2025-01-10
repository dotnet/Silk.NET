// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DXGI
{
    [NativeTypeName("#define DXGI_STATUS_OCCLUDED _HRESULT_TYPEDEF_(0x087A0001L)")]
    public const int DXGI_STATUS_OCCLUDED = ((int)(0x087A0001));

    [NativeTypeName("#define DXGI_STATUS_CLIPPED _HRESULT_TYPEDEF_(0x087A0002L)")]
    public const int DXGI_STATUS_CLIPPED = ((int)(0x087A0002));

    [NativeTypeName("#define DXGI_STATUS_NO_REDIRECTION _HRESULT_TYPEDEF_(0x087A0004L)")]
    public const int DXGI_STATUS_NO_REDIRECTION = ((int)(0x087A0004));

    [NativeTypeName("#define DXGI_STATUS_NO_DESKTOP_ACCESS _HRESULT_TYPEDEF_(0x087A0005L)")]
    public const int DXGI_STATUS_NO_DESKTOP_ACCESS = ((int)(0x087A0005));

    [NativeTypeName(
        "#define DXGI_STATUS_GRAPHICS_VIDPN_SOURCE_IN_USE _HRESULT_TYPEDEF_(0x087A0006L)"
    )]
    public const int DXGI_STATUS_GRAPHICS_VIDPN_SOURCE_IN_USE = ((int)(0x087A0006));

    [NativeTypeName("#define DXGI_STATUS_MODE_CHANGED _HRESULT_TYPEDEF_(0x087A0007L)")]
    public const int DXGI_STATUS_MODE_CHANGED = ((int)(0x087A0007));

    [NativeTypeName("#define DXGI_STATUS_MODE_CHANGE_IN_PROGRESS _HRESULT_TYPEDEF_(0x087A0008L)")]
    public const int DXGI_STATUS_MODE_CHANGE_IN_PROGRESS = ((int)(0x087A0008));

    [NativeTypeName("#define DXGI_ERROR_INVALID_CALL _HRESULT_TYPEDEF_(0x887A0001L)")]
    public const int DXGI_ERROR_INVALID_CALL = unchecked((int)(0x887A0001));

    [NativeTypeName("#define DXGI_ERROR_NOT_FOUND _HRESULT_TYPEDEF_(0x887A0002L)")]
    public const int DXGI_ERROR_NOT_FOUND = unchecked((int)(0x887A0002));

    [NativeTypeName("#define DXGI_ERROR_MORE_DATA _HRESULT_TYPEDEF_(0x887A0003L)")]
    public const int DXGI_ERROR_MORE_DATA = unchecked((int)(0x887A0003));

    [NativeTypeName("#define DXGI_ERROR_UNSUPPORTED _HRESULT_TYPEDEF_(0x887A0004L)")]
    public const int DXGI_ERROR_UNSUPPORTED = unchecked((int)(0x887A0004));

    [NativeTypeName("#define DXGI_ERROR_DEVICE_REMOVED _HRESULT_TYPEDEF_(0x887A0005L)")]
    public const int DXGI_ERROR_DEVICE_REMOVED = unchecked((int)(0x887A0005));

    [NativeTypeName("#define DXGI_ERROR_DEVICE_HUNG _HRESULT_TYPEDEF_(0x887A0006L)")]
    public const int DXGI_ERROR_DEVICE_HUNG = unchecked((int)(0x887A0006));

    [NativeTypeName("#define DXGI_ERROR_DEVICE_RESET _HRESULT_TYPEDEF_(0x887A0007L)")]
    public const int DXGI_ERROR_DEVICE_RESET = unchecked((int)(0x887A0007));

    [NativeTypeName("#define DXGI_ERROR_WAS_STILL_DRAWING _HRESULT_TYPEDEF_(0x887A000AL)")]
    public const int DXGI_ERROR_WAS_STILL_DRAWING = unchecked((int)(0x887A000A));

    [NativeTypeName("#define DXGI_ERROR_FRAME_STATISTICS_DISJOINT _HRESULT_TYPEDEF_(0x887A000BL)")]
    public const int DXGI_ERROR_FRAME_STATISTICS_DISJOINT = unchecked((int)(0x887A000B));

    [NativeTypeName(
        "#define DXGI_ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE _HRESULT_TYPEDEF_(0x887A000CL)"
    )]
    public const int DXGI_ERROR_GRAPHICS_VIDPN_SOURCE_IN_USE = unchecked((int)(0x887A000C));

    [NativeTypeName("#define DXGI_ERROR_DRIVER_INTERNAL_ERROR _HRESULT_TYPEDEF_(0x887A0020L)")]
    public const int DXGI_ERROR_DRIVER_INTERNAL_ERROR = unchecked((int)(0x887A0020));

    [NativeTypeName("#define DXGI_ERROR_NONEXCLUSIVE _HRESULT_TYPEDEF_(0x887A0021L)")]
    public const int DXGI_ERROR_NONEXCLUSIVE = unchecked((int)(0x887A0021));

    [NativeTypeName("#define DXGI_ERROR_NOT_CURRENTLY_AVAILABLE _HRESULT_TYPEDEF_(0x887A0022L)")]
    public const int DXGI_ERROR_NOT_CURRENTLY_AVAILABLE = unchecked((int)(0x887A0022));

    [NativeTypeName("#define DXGI_ERROR_REMOTE_CLIENT_DISCONNECTED _HRESULT_TYPEDEF_(0x887A0023L)")]
    public const int DXGI_ERROR_REMOTE_CLIENT_DISCONNECTED = unchecked((int)(0x887A0023));

    [NativeTypeName("#define DXGI_ERROR_REMOTE_OUTOFMEMORY _HRESULT_TYPEDEF_(0x887A0024L)")]
    public const int DXGI_ERROR_REMOTE_OUTOFMEMORY = unchecked((int)(0x887A0024));

    [NativeTypeName("#define DXGI_ERROR_ACCESS_LOST _HRESULT_TYPEDEF_(0x887A0026L)")]
    public const int DXGI_ERROR_ACCESS_LOST = unchecked((int)(0x887A0026));

    [NativeTypeName("#define DXGI_ERROR_WAIT_TIMEOUT _HRESULT_TYPEDEF_(0x887A0027L)")]
    public const int DXGI_ERROR_WAIT_TIMEOUT = unchecked((int)(0x887A0027));

    [NativeTypeName("#define DXGI_ERROR_SESSION_DISCONNECTED _HRESULT_TYPEDEF_(0x887A0028L)")]
    public const int DXGI_ERROR_SESSION_DISCONNECTED = unchecked((int)(0x887A0028));

    [NativeTypeName("#define DXGI_ERROR_RESTRICT_TO_OUTPUT_STALE _HRESULT_TYPEDEF_(0x887A0029L)")]
    public const int DXGI_ERROR_RESTRICT_TO_OUTPUT_STALE = unchecked((int)(0x887A0029));

    [NativeTypeName("#define DXGI_ERROR_CANNOT_PROTECT_CONTENT _HRESULT_TYPEDEF_(0x887A002AL)")]
    public const int DXGI_ERROR_CANNOT_PROTECT_CONTENT = unchecked((int)(0x887A002A));

    [NativeTypeName("#define DXGI_ERROR_ACCESS_DENIED _HRESULT_TYPEDEF_(0x887A002BL)")]
    public const int DXGI_ERROR_ACCESS_DENIED = unchecked((int)(0x887A002B));

    [NativeTypeName("#define DXGI_ERROR_NAME_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x887A002CL)")]
    public const int DXGI_ERROR_NAME_ALREADY_EXISTS = unchecked((int)(0x887A002C));

    [NativeTypeName("#define DXGI_ERROR_SDK_COMPONENT_MISSING _HRESULT_TYPEDEF_(0x887A002DL)")]
    public const int DXGI_ERROR_SDK_COMPONENT_MISSING = unchecked((int)(0x887A002D));

    [NativeTypeName("#define DXGI_ERROR_NOT_CURRENT _HRESULT_TYPEDEF_(0x887A002EL)")]
    public const int DXGI_ERROR_NOT_CURRENT = unchecked((int)(0x887A002E));

    [NativeTypeName("#define DXGI_ERROR_HW_PROTECTION_OUTOFMEMORY _HRESULT_TYPEDEF_(0x887A0030L)")]
    public const int DXGI_ERROR_HW_PROTECTION_OUTOFMEMORY = unchecked((int)(0x887A0030));

    [NativeTypeName(
        "#define DXGI_ERROR_DYNAMIC_CODE_POLICY_VIOLATION _HRESULT_TYPEDEF_(0x887A0031L)"
    )]
    public const int DXGI_ERROR_DYNAMIC_CODE_POLICY_VIOLATION = unchecked((int)(0x887A0031));

    [NativeTypeName("#define DXGI_ERROR_NON_COMPOSITED_UI _HRESULT_TYPEDEF_(0x887A0032L)")]
    public const int DXGI_ERROR_NON_COMPOSITED_UI = unchecked((int)(0x887A0032));

    [NativeTypeName("#define DXGI_STATUS_UNOCCLUDED _HRESULT_TYPEDEF_(0x087A0009L)")]
    public const int DXGI_STATUS_UNOCCLUDED = ((int)(0x087A0009));

    [NativeTypeName("#define DXGI_STATUS_DDA_WAS_STILL_DRAWING _HRESULT_TYPEDEF_(0x087A000AL)")]
    public const int DXGI_STATUS_DDA_WAS_STILL_DRAWING = ((int)(0x087A000A));

    [NativeTypeName("#define DXGI_ERROR_MODE_CHANGE_IN_PROGRESS _HRESULT_TYPEDEF_(0x887A0025L)")]
    public const int DXGI_ERROR_MODE_CHANGE_IN_PROGRESS = unchecked((int)(0x887A0025));

    [NativeTypeName("#define DXGI_STATUS_PRESENT_REQUIRED _HRESULT_TYPEDEF_(0x087A002FL)")]
    public const int DXGI_STATUS_PRESENT_REQUIRED = ((int)(0x087A002F));

    [NativeTypeName("#define DXGI_ERROR_CACHE_CORRUPT _HRESULT_TYPEDEF_(0x887A0033L)")]
    public const int DXGI_ERROR_CACHE_CORRUPT = unchecked((int)(0x887A0033));

    [NativeTypeName("#define DXGI_ERROR_CACHE_FULL _HRESULT_TYPEDEF_(0x887A0034L)")]
    public const int DXGI_ERROR_CACHE_FULL = unchecked((int)(0x887A0034));

    [NativeTypeName("#define DXGI_ERROR_CACHE_HASH_COLLISION _HRESULT_TYPEDEF_(0x887A0035L)")]
    public const int DXGI_ERROR_CACHE_HASH_COLLISION = unchecked((int)(0x887A0035));

    [NativeTypeName("#define DXGI_ERROR_ALREADY_EXISTS _HRESULT_TYPEDEF_(0x887A0036L)")]
    public const int DXGI_ERROR_ALREADY_EXISTS = unchecked((int)(0x887A0036));

    [NativeTypeName("#define DXGI_ERROR_MPO_UNPINNED _HRESULT_TYPEDEF_(0x887A0064L)")]
    public const int DXGI_ERROR_MPO_UNPINNED = unchecked((int)(0x887A0064));

    [NativeTypeName("#define DXGI_ERROR_SETDISPLAYMODE_REQUIRED _HRESULT_TYPEDEF_(0x887A0065L)")]
    public const int DXGI_ERROR_SETDISPLAYMODE_REQUIRED = unchecked((int)(0x887A0065));

    [NativeTypeName("#define DXGI_DDI_ERR_WASSTILLDRAWING _HRESULT_TYPEDEF_(0x887B0001L)")]
    public const int DXGI_DDI_ERR_WASSTILLDRAWING = unchecked((int)(0x887B0001));

    [NativeTypeName("#define DXGI_DDI_ERR_UNSUPPORTED _HRESULT_TYPEDEF_(0x887B0002L)")]
    public const int DXGI_DDI_ERR_UNSUPPORTED = unchecked((int)(0x887B0002));

    [NativeTypeName("#define DXGI_DDI_ERR_NONEXCLUSIVE _HRESULT_TYPEDEF_(0x887B0003L)")]
    public const int DXGI_DDI_ERR_NONEXCLUSIVE = unchecked((int)(0x887B0003));
}
