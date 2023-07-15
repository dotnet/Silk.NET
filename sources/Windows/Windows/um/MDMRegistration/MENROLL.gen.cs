// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MDMRegistration.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class MENROLL
{
    [NativeTypeName("#define MENROLL_E_DEVICE_CERTIFCATEREQUEST_ERROR MAKE_HRESULT(SEVERITY_ERROR, DEVICE_ENROLLER_FACILITY_CODE, 4)")]
    public const int MENROLL_E_DEVICE_CERTIFCATEREQUEST_ERROR = unchecked((int)(((uint)(1) << 31) | ((uint)(24) << 16) | ((uint)(4))));
    [NativeTypeName("#define MENROLL_E_DEVICE_NOT_ENROLLED MAKE_HRESULT(SEVERITY_ERROR, DEVICE_ENROLLER_FACILITY_CODE, 11)")]
    public const int MENROLL_E_DEVICE_NOT_ENROLLED = unchecked((int)(((uint)(1) << 31) | ((uint)(24) << 16) | ((uint)(11))));
    [NativeTypeName("#define MENROLL_E_NOTSUPPORTED MAKE_HRESULT(SEVERITY_ERROR, DEVICE_ENROLLER_FACILITY_CODE, 21)")]
    public const int MENROLL_E_NOTSUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(24) << 16) | ((uint)(21))));
    [NativeTypeName("#define MENROLL_E_USERLICENSE MAKE_HRESULT(SEVERITY_ERROR, DEVICE_ENROLLER_FACILITY_CODE, 24)")]
    public const int MENROLL_E_USERLICENSE = unchecked((int)(((uint)(1) << 31) | ((uint)(24) << 16) | ((uint)(24))));
    [NativeTypeName("#define MENROLL_E_USER_CANCELED MAKE_HRESULT(SEVERITY_ERROR, DEVICE_ENROLLER_FACILITY_CODE, 42)")]
    public const int MENROLL_E_USER_CANCELED = unchecked((int)(((uint)(1) << 31) | ((uint)(24) << 16) | ((uint)(42))));
}