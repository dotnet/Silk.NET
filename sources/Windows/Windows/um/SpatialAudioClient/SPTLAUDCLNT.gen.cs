// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SPTLAUDCLNT
{
    [NativeTypeName("#define SPTLAUDCLNT_E_DESTROYED AUDCLNT_ERR(0x0100)")]
    public const int SPTLAUDCLNT_E_DESTROYED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0100))));
    [NativeTypeName("#define SPTLAUDCLNT_E_OUT_OF_ORDER AUDCLNT_ERR(0x0101)")]
    public const int SPTLAUDCLNT_E_OUT_OF_ORDER = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0101))));
    [NativeTypeName("#define SPTLAUDCLNT_E_RESOURCES_INVALIDATED AUDCLNT_ERR(0x0102)")]
    public const int SPTLAUDCLNT_E_RESOURCES_INVALIDATED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0102))));
    [NativeTypeName("#define SPTLAUDCLNT_E_NO_MORE_OBJECTS AUDCLNT_ERR(0x0103)")]
    public const int SPTLAUDCLNT_E_NO_MORE_OBJECTS = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0103))));
    [NativeTypeName("#define SPTLAUDCLNT_E_PROPERTY_NOT_SUPPORTED AUDCLNT_ERR(0x0104)")]
    public const int SPTLAUDCLNT_E_PROPERTY_NOT_SUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0104))));
    [NativeTypeName("#define SPTLAUDCLNT_E_ERRORS_IN_OBJECT_CALLS AUDCLNT_ERR(0x0105)")]
    public const int SPTLAUDCLNT_E_ERRORS_IN_OBJECT_CALLS = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0105))));
    [NativeTypeName("#define SPTLAUDCLNT_E_METADATA_FORMAT_NOT_SUPPORTED AUDCLNT_ERR(0x0106)")]
    public const int SPTLAUDCLNT_E_METADATA_FORMAT_NOT_SUPPORTED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0106))));
    [NativeTypeName("#define SPTLAUDCLNT_E_STREAM_NOT_AVAILABLE AUDCLNT_ERR(0x0107)")]
    public const int SPTLAUDCLNT_E_STREAM_NOT_AVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0107))));
    [NativeTypeName("#define SPTLAUDCLNT_E_INVALID_LICENSE AUDCLNT_ERR(0x0108)")]
    public const int SPTLAUDCLNT_E_INVALID_LICENSE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x0108))));
    [NativeTypeName("#define SPTLAUDCLNT_E_STREAM_NOT_STOPPED AUDCLNT_ERR(0x010a)")]
    public const int SPTLAUDCLNT_E_STREAM_NOT_STOPPED = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x010a))));
    [NativeTypeName("#define SPTLAUDCLNT_E_STATIC_OBJECT_NOT_AVAILABLE AUDCLNT_ERR(0x010b)")]
    public const int SPTLAUDCLNT_E_STATIC_OBJECT_NOT_AVAILABLE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x010b))));
    [NativeTypeName("#define SPTLAUDCLNT_E_OBJECT_ALREADY_ACTIVE AUDCLNT_ERR(0x010c)")]
    public const int SPTLAUDCLNT_E_OBJECT_ALREADY_ACTIVE = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x010c))));
    [NativeTypeName("#define SPTLAUDCLNT_E_INTERNAL AUDCLNT_ERR(0x010d)")]
    public const int SPTLAUDCLNT_E_INTERNAL = unchecked((int)(((uint)(1) << 31) | ((uint)(2185) << 16) | ((uint)(0x010d))));
}