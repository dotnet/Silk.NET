// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class WPN
{
    [NativeTypeName("#define WPN_E_CHANNEL_CLOSED _HRESULT_TYPEDEF_(0x803E0100L)")]
    public const int WPN_E_CHANNEL_CLOSED = unchecked((int)(0x803E0100));
    [NativeTypeName("#define WPN_E_CHANNEL_REQUEST_NOT_COMPLETE _HRESULT_TYPEDEF_(0x803E0101L)")]
    public const int WPN_E_CHANNEL_REQUEST_NOT_COMPLETE = unchecked((int)(0x803E0101));
    [NativeTypeName("#define WPN_E_INVALID_APP _HRESULT_TYPEDEF_(0x803E0102L)")]
    public const int WPN_E_INVALID_APP = unchecked((int)(0x803E0102));
    [NativeTypeName("#define WPN_E_OUTSTANDING_CHANNEL_REQUEST _HRESULT_TYPEDEF_(0x803E0103L)")]
    public const int WPN_E_OUTSTANDING_CHANNEL_REQUEST = unchecked((int)(0x803E0103));
    [NativeTypeName("#define WPN_E_DUPLICATE_CHANNEL _HRESULT_TYPEDEF_(0x803E0104L)")]
    public const int WPN_E_DUPLICATE_CHANNEL = unchecked((int)(0x803E0104));
    [NativeTypeName("#define WPN_E_PLATFORM_UNAVAILABLE _HRESULT_TYPEDEF_(0x803E0105L)")]
    public const int WPN_E_PLATFORM_UNAVAILABLE = unchecked((int)(0x803E0105));
    [NativeTypeName("#define WPN_E_NOTIFICATION_POSTED _HRESULT_TYPEDEF_(0x803E0106L)")]
    public const int WPN_E_NOTIFICATION_POSTED = unchecked((int)(0x803E0106));
    [NativeTypeName("#define WPN_E_NOTIFICATION_HIDDEN _HRESULT_TYPEDEF_(0x803E0107L)")]
    public const int WPN_E_NOTIFICATION_HIDDEN = unchecked((int)(0x803E0107));
    [NativeTypeName("#define WPN_E_NOTIFICATION_NOT_POSTED _HRESULT_TYPEDEF_(0x803E0108L)")]
    public const int WPN_E_NOTIFICATION_NOT_POSTED = unchecked((int)(0x803E0108));
    [NativeTypeName("#define WPN_E_CLOUD_DISABLED _HRESULT_TYPEDEF_(0x803E0109L)")]
    public const int WPN_E_CLOUD_DISABLED = unchecked((int)(0x803E0109));
    [NativeTypeName("#define WPN_E_CLOUD_INCAPABLE _HRESULT_TYPEDEF_(0x803E0110L)")]
    public const int WPN_E_CLOUD_INCAPABLE = unchecked((int)(0x803E0110));
    [NativeTypeName("#define WPN_E_CLOUD_AUTH_UNAVAILABLE _HRESULT_TYPEDEF_(0x803E011AL)")]
    public const int WPN_E_CLOUD_AUTH_UNAVAILABLE = unchecked((int)(0x803E011A));
    [NativeTypeName("#define WPN_E_CLOUD_SERVICE_UNAVAILABLE _HRESULT_TYPEDEF_(0x803E011BL)")]
    public const int WPN_E_CLOUD_SERVICE_UNAVAILABLE = unchecked((int)(0x803E011B));
    [NativeTypeName("#define WPN_E_FAILED_LOCK_SCREEN_UPDATE_INTIALIZATION _HRESULT_TYPEDEF_(0x803E011CL)")]
    public const int WPN_E_FAILED_LOCK_SCREEN_UPDATE_INTIALIZATION = unchecked((int)(0x803E011C));
    [NativeTypeName("#define WPN_E_NOTIFICATION_DISABLED _HRESULT_TYPEDEF_(0x803E0111L)")]
    public const int WPN_E_NOTIFICATION_DISABLED = unchecked((int)(0x803E0111));
    [NativeTypeName("#define WPN_E_NOTIFICATION_INCAPABLE _HRESULT_TYPEDEF_(0x803E0112L)")]
    public const int WPN_E_NOTIFICATION_INCAPABLE = unchecked((int)(0x803E0112));
    [NativeTypeName("#define WPN_E_INTERNET_INCAPABLE _HRESULT_TYPEDEF_(0x803E0113L)")]
    public const int WPN_E_INTERNET_INCAPABLE = unchecked((int)(0x803E0113));
    [NativeTypeName("#define WPN_E_NOTIFICATION_TYPE_DISABLED _HRESULT_TYPEDEF_(0x803E0114L)")]
    public const int WPN_E_NOTIFICATION_TYPE_DISABLED = unchecked((int)(0x803E0114));
    [NativeTypeName("#define WPN_E_NOTIFICATION_SIZE _HRESULT_TYPEDEF_(0x803E0115L)")]
    public const int WPN_E_NOTIFICATION_SIZE = unchecked((int)(0x803E0115));
    [NativeTypeName("#define WPN_E_TAG_SIZE _HRESULT_TYPEDEF_(0x803E0116L)")]
    public const int WPN_E_TAG_SIZE = unchecked((int)(0x803E0116));
    [NativeTypeName("#define WPN_E_ACCESS_DENIED _HRESULT_TYPEDEF_(0x803E0117L)")]
    public const int WPN_E_ACCESS_DENIED = unchecked((int)(0x803E0117));
    [NativeTypeName("#define WPN_E_DUPLICATE_REGISTRATION _HRESULT_TYPEDEF_(0x803E0118L)")]
    public const int WPN_E_DUPLICATE_REGISTRATION = unchecked((int)(0x803E0118));
    [NativeTypeName("#define WPN_E_PUSH_NOTIFICATION_INCAPABLE _HRESULT_TYPEDEF_(0x803E0119L)")]
    public const int WPN_E_PUSH_NOTIFICATION_INCAPABLE = unchecked((int)(0x803E0119));
    [NativeTypeName("#define WPN_E_DEV_ID_SIZE _HRESULT_TYPEDEF_(0x803E0120L)")]
    public const int WPN_E_DEV_ID_SIZE = unchecked((int)(0x803E0120));
    [NativeTypeName("#define WPN_E_TAG_ALPHANUMERIC _HRESULT_TYPEDEF_(0x803E012AL)")]
    public const int WPN_E_TAG_ALPHANUMERIC = unchecked((int)(0x803E012A));
    [NativeTypeName("#define WPN_E_INVALID_HTTP_STATUS_CODE _HRESULT_TYPEDEF_(0x803E012BL)")]
    public const int WPN_E_INVALID_HTTP_STATUS_CODE = unchecked((int)(0x803E012B));
    [NativeTypeName("#define WPN_E_OUT_OF_SESSION _HRESULT_TYPEDEF_(0x803E0200L)")]
    public const int WPN_E_OUT_OF_SESSION = unchecked((int)(0x803E0200));
    [NativeTypeName("#define WPN_E_POWER_SAVE _HRESULT_TYPEDEF_(0x803E0201L)")]
    public const int WPN_E_POWER_SAVE = unchecked((int)(0x803E0201));
    [NativeTypeName("#define WPN_E_IMAGE_NOT_FOUND_IN_CACHE _HRESULT_TYPEDEF_(0x803E0202L)")]
    public const int WPN_E_IMAGE_NOT_FOUND_IN_CACHE = unchecked((int)(0x803E0202));
    [NativeTypeName("#define WPN_E_ALL_URL_NOT_COMPLETED _HRESULT_TYPEDEF_(0x803E0203L)")]
    public const int WPN_E_ALL_URL_NOT_COMPLETED = unchecked((int)(0x803E0203));
    [NativeTypeName("#define WPN_E_INVALID_CLOUD_IMAGE _HRESULT_TYPEDEF_(0x803E0204L)")]
    public const int WPN_E_INVALID_CLOUD_IMAGE = unchecked((int)(0x803E0204));
    [NativeTypeName("#define WPN_E_NOTIFICATION_ID_MATCHED _HRESULT_TYPEDEF_(0x803E0205L)")]
    public const int WPN_E_NOTIFICATION_ID_MATCHED = unchecked((int)(0x803E0205));
    [NativeTypeName("#define WPN_E_CALLBACK_ALREADY_REGISTERED _HRESULT_TYPEDEF_(0x803E0206L)")]
    public const int WPN_E_CALLBACK_ALREADY_REGISTERED = unchecked((int)(0x803E0206));
    [NativeTypeName("#define WPN_E_TOAST_NOTIFICATION_DROPPED _HRESULT_TYPEDEF_(0x803E0207L)")]
    public const int WPN_E_TOAST_NOTIFICATION_DROPPED = unchecked((int)(0x803E0207));
    [NativeTypeName("#define WPN_E_STORAGE_LOCKED _HRESULT_TYPEDEF_(0x803E0208L)")]
    public const int WPN_E_STORAGE_LOCKED = unchecked((int)(0x803E0208));
    [NativeTypeName("#define WPN_E_GROUP_SIZE _HRESULT_TYPEDEF_(0x803E0209L)")]
    public const int WPN_E_GROUP_SIZE = unchecked((int)(0x803E0209));
    [NativeTypeName("#define WPN_E_GROUP_ALPHANUMERIC _HRESULT_TYPEDEF_(0x803E020AL)")]
    public const int WPN_E_GROUP_ALPHANUMERIC = unchecked((int)(0x803E020A));
    [NativeTypeName("#define WPN_E_CLOUD_DISABLED_FOR_APP _HRESULT_TYPEDEF_(0x803E020BL)")]
    public const int WPN_E_CLOUD_DISABLED_FOR_APP = unchecked((int)(0x803E020B));
}