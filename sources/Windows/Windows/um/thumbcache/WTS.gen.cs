// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class WTS
{
    [NativeTypeName("#define WTS_E_FAILEDEXTRACTION MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB200)")]
    public const int WTS_E_FAILEDEXTRACTION = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB200))));
    [NativeTypeName("#define WTS_E_EXTRACTIONTIMEDOUT MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB201)")]
    public const int WTS_E_EXTRACTIONTIMEDOUT = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB201))));
    [NativeTypeName("#define WTS_E_SURROGATEUNAVAILABLE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB202)")]
    public const int WTS_E_SURROGATEUNAVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB202))));
    [NativeTypeName("#define WTS_E_FASTEXTRACTIONNOTSUPPORTED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB203)")]
    public const int WTS_E_FASTEXTRACTIONNOTSUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB203))));
    [NativeTypeName("#define WTS_E_DATAFILEUNAVAILABLE MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB204)")]
    public const int WTS_E_DATAFILEUNAVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB204))));
    [NativeTypeName("#define WTS_E_EXTRACTIONPENDING MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB205)")]
    public const int WTS_E_EXTRACTIONPENDING = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB205))));
    [NativeTypeName("#define WTS_E_EXTRACTIONBLOCKED MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB206)")]
    public const int WTS_E_EXTRACTIONBLOCKED = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB206))));
    [NativeTypeName("#define WTS_E_NOSTORAGEPROVIDERTHUMBNAILHANDLER MAKE_HRESULT(SEVERITY_ERROR, FACILITY_ITF, 0xB207)")]
    public const int WTS_E_NOSTORAGEPROVIDERTHUMBNAILHANDLER = unchecked((int)(((uint)(1) << 31) | ((uint)(4) << 16) | ((uint)(0xB207))));
}