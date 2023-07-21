// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

public static partial class APPX
{
    [NativeTypeName("#define APPX_E_PACKAGING_INTERNAL _HRESULT_TYPEDEF_(0x80080200L)")]
    public const int APPX_E_PACKAGING_INTERNAL = unchecked((int)(0x80080200));

    [NativeTypeName("#define APPX_E_INTERLEAVING_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80080201L)")]
    public const int APPX_E_INTERLEAVING_NOT_ALLOWED = unchecked((int)(0x80080201));

    [NativeTypeName("#define APPX_E_RELATIONSHIPS_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80080202L)")]
    public const int APPX_E_RELATIONSHIPS_NOT_ALLOWED = unchecked((int)(0x80080202));

    [NativeTypeName("#define APPX_E_MISSING_REQUIRED_FILE _HRESULT_TYPEDEF_(0x80080203L)")]
    public const int APPX_E_MISSING_REQUIRED_FILE = unchecked((int)(0x80080203));

    [NativeTypeName("#define APPX_E_INVALID_MANIFEST _HRESULT_TYPEDEF_(0x80080204L)")]
    public const int APPX_E_INVALID_MANIFEST = unchecked((int)(0x80080204));

    [NativeTypeName("#define APPX_E_INVALID_BLOCKMAP _HRESULT_TYPEDEF_(0x80080205L)")]
    public const int APPX_E_INVALID_BLOCKMAP = unchecked((int)(0x80080205));

    [NativeTypeName("#define APPX_E_CORRUPT_CONTENT _HRESULT_TYPEDEF_(0x80080206L)")]
    public const int APPX_E_CORRUPT_CONTENT = unchecked((int)(0x80080206));

    [NativeTypeName("#define APPX_E_BLOCK_HASH_INVALID _HRESULT_TYPEDEF_(0x80080207L)")]
    public const int APPX_E_BLOCK_HASH_INVALID = unchecked((int)(0x80080207));

    [NativeTypeName("#define APPX_E_REQUESTED_RANGE_TOO_LARGE _HRESULT_TYPEDEF_(0x80080208L)")]
    public const int APPX_E_REQUESTED_RANGE_TOO_LARGE = unchecked((int)(0x80080208));

    [NativeTypeName("#define APPX_E_INVALID_SIP_CLIENT_DATA _HRESULT_TYPEDEF_(0x80080209L)")]
    public const int APPX_E_INVALID_SIP_CLIENT_DATA = unchecked((int)(0x80080209));

    [NativeTypeName("#define APPX_E_INVALID_KEY_INFO _HRESULT_TYPEDEF_(0x8008020AL)")]
    public const int APPX_E_INVALID_KEY_INFO = unchecked((int)(0x8008020A));

    [NativeTypeName("#define APPX_E_INVALID_CONTENTGROUPMAP _HRESULT_TYPEDEF_(0x8008020BL)")]
    public const int APPX_E_INVALID_CONTENTGROUPMAP = unchecked((int)(0x8008020B));

    [NativeTypeName("#define APPX_E_INVALID_APPINSTALLER _HRESULT_TYPEDEF_(0x8008020CL)")]
    public const int APPX_E_INVALID_APPINSTALLER = unchecked((int)(0x8008020C));

    [NativeTypeName("#define APPX_E_DELTA_BASELINE_VERSION_MISMATCH _HRESULT_TYPEDEF_(0x8008020DL)")]
    public const int APPX_E_DELTA_BASELINE_VERSION_MISMATCH = unchecked((int)(0x8008020D));

    [NativeTypeName("#define APPX_E_DELTA_PACKAGE_MISSING_FILE _HRESULT_TYPEDEF_(0x8008020EL)")]
    public const int APPX_E_DELTA_PACKAGE_MISSING_FILE = unchecked((int)(0x8008020E));

    [NativeTypeName("#define APPX_E_INVALID_DELTA_PACKAGE _HRESULT_TYPEDEF_(0x8008020FL)")]
    public const int APPX_E_INVALID_DELTA_PACKAGE = unchecked((int)(0x8008020F));

    [NativeTypeName("#define APPX_E_DELTA_APPENDED_PACKAGE_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80080210L)")]
    public const int APPX_E_DELTA_APPENDED_PACKAGE_NOT_ALLOWED = unchecked((int)(0x80080210));

    [NativeTypeName("#define APPX_E_INVALID_PACKAGING_LAYOUT _HRESULT_TYPEDEF_(0x80080211L)")]
    public const int APPX_E_INVALID_PACKAGING_LAYOUT = unchecked((int)(0x80080211));

    [NativeTypeName("#define APPX_E_INVALID_PACKAGESIGNCONFIG _HRESULT_TYPEDEF_(0x80080212L)")]
    public const int APPX_E_INVALID_PACKAGESIGNCONFIG = unchecked((int)(0x80080212));

    [NativeTypeName("#define APPX_E_RESOURCESPRI_NOT_ALLOWED _HRESULT_TYPEDEF_(0x80080213L)")]
    public const int APPX_E_RESOURCESPRI_NOT_ALLOWED = unchecked((int)(0x80080213));

    [NativeTypeName("#define APPX_E_FILE_COMPRESSION_MISMATCH _HRESULT_TYPEDEF_(0x80080214L)")]
    public const int APPX_E_FILE_COMPRESSION_MISMATCH = unchecked((int)(0x80080214));

    [NativeTypeName("#define APPX_E_INVALID_PAYLOAD_PACKAGE_EXTENSION _HRESULT_TYPEDEF_(0x80080215L)")]
    public const int APPX_E_INVALID_PAYLOAD_PACKAGE_EXTENSION = unchecked((int)(0x80080215));

    [NativeTypeName("#define APPX_E_INVALID_ENCRYPTION_EXCLUSION_FILE_LIST _HRESULT_TYPEDEF_(0x80080216L)")]
    public const int APPX_E_INVALID_ENCRYPTION_EXCLUSION_FILE_LIST = unchecked((int)(0x80080216));

    [NativeTypeName("#define APPX_E_INVALID_PACKAGE_FOLDER_ACLS _HRESULT_TYPEDEF_(0x80080217L)")]
    public const int APPX_E_INVALID_PACKAGE_FOLDER_ACLS = unchecked((int)(0x80080217));

    [NativeTypeName("#define APPX_E_INVALID_PUBLISHER_BRIDGING _HRESULT_TYPEDEF_(0x80080218L)")]
    public const int APPX_E_INVALID_PUBLISHER_BRIDGING = unchecked((int)(0x80080218));

    [NativeTypeName("#define APPX_E_DIGEST_MISMATCH _HRESULT_TYPEDEF_(0x80080219L)")]
    public const int APPX_E_DIGEST_MISMATCH = unchecked((int)(0x80080219));
}
