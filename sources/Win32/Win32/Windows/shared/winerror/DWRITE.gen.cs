// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

public static partial class DWRITE
{
    [NativeTypeName("#define DWRITE_E_FILEFORMAT _HRESULT_TYPEDEF_(0x88985000L)")]
    public const int DWRITE_E_FILEFORMAT = unchecked((int)(0x88985000));

    [NativeTypeName("#define DWRITE_E_UNEXPECTED _HRESULT_TYPEDEF_(0x88985001L)")]
    public const int DWRITE_E_UNEXPECTED = unchecked((int)(0x88985001));

    [NativeTypeName("#define DWRITE_E_NOFONT _HRESULT_TYPEDEF_(0x88985002L)")]
    public const int DWRITE_E_NOFONT = unchecked((int)(0x88985002));

    [NativeTypeName("#define DWRITE_E_FILENOTFOUND _HRESULT_TYPEDEF_(0x88985003L)")]
    public const int DWRITE_E_FILENOTFOUND = unchecked((int)(0x88985003));

    [NativeTypeName("#define DWRITE_E_FILEACCESS _HRESULT_TYPEDEF_(0x88985004L)")]
    public const int DWRITE_E_FILEACCESS = unchecked((int)(0x88985004));

    [NativeTypeName("#define DWRITE_E_FONTCOLLECTIONOBSOLETE _HRESULT_TYPEDEF_(0x88985005L)")]
    public const int DWRITE_E_FONTCOLLECTIONOBSOLETE = unchecked((int)(0x88985005));

    [NativeTypeName("#define DWRITE_E_ALREADYREGISTERED _HRESULT_TYPEDEF_(0x88985006L)")]
    public const int DWRITE_E_ALREADYREGISTERED = unchecked((int)(0x88985006));

    [NativeTypeName("#define DWRITE_E_CACHEFORMAT _HRESULT_TYPEDEF_(0x88985007L)")]
    public const int DWRITE_E_CACHEFORMAT = unchecked((int)(0x88985007));

    [NativeTypeName("#define DWRITE_E_CACHEVERSION _HRESULT_TYPEDEF_(0x88985008L)")]
    public const int DWRITE_E_CACHEVERSION = unchecked((int)(0x88985008));

    [NativeTypeName("#define DWRITE_E_UNSUPPORTEDOPERATION _HRESULT_TYPEDEF_(0x88985009L)")]
    public const int DWRITE_E_UNSUPPORTEDOPERATION = unchecked((int)(0x88985009));

    [NativeTypeName("#define DWRITE_E_TEXTRENDERERINCOMPATIBLE _HRESULT_TYPEDEF_(0x8898500AL)")]
    public const int DWRITE_E_TEXTRENDERERINCOMPATIBLE = unchecked((int)(0x8898500A));

    [NativeTypeName("#define DWRITE_E_FLOWDIRECTIONCONFLICTS _HRESULT_TYPEDEF_(0x8898500BL)")]
    public const int DWRITE_E_FLOWDIRECTIONCONFLICTS = unchecked((int)(0x8898500B));

    [NativeTypeName("#define DWRITE_E_NOCOLOR _HRESULT_TYPEDEF_(0x8898500CL)")]
    public const int DWRITE_E_NOCOLOR = unchecked((int)(0x8898500C));

    [NativeTypeName("#define DWRITE_E_REMOTEFONT _HRESULT_TYPEDEF_(0x8898500DL)")]
    public const int DWRITE_E_REMOTEFONT = unchecked((int)(0x8898500D));

    [NativeTypeName("#define DWRITE_E_DOWNLOADCANCELLED _HRESULT_TYPEDEF_(0x8898500EL)")]
    public const int DWRITE_E_DOWNLOADCANCELLED = unchecked((int)(0x8898500E));

    [NativeTypeName("#define DWRITE_E_DOWNLOADFAILED _HRESULT_TYPEDEF_(0x8898500FL)")]
    public const int DWRITE_E_DOWNLOADFAILED = unchecked((int)(0x8898500F));

    [NativeTypeName("#define DWRITE_E_TOOMANYDOWNLOADS _HRESULT_TYPEDEF_(0x88985010L)")]
    public const int DWRITE_E_TOOMANYDOWNLOADS = unchecked((int)(0x88985010));
}
