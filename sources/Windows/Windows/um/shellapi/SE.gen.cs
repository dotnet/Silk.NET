// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SE
{
    [NativeTypeName("#define SE_ERR_FNF 2")]
    public const int SE_ERR_FNF = 2;
    [NativeTypeName("#define SE_ERR_PNF 3")]
    public const int SE_ERR_PNF = 3;
    [NativeTypeName("#define SE_ERR_ACCESSDENIED 5")]
    public const int SE_ERR_ACCESSDENIED = 5;
    [NativeTypeName("#define SE_ERR_OOM 8")]
    public const int SE_ERR_OOM = 8;
    [NativeTypeName("#define SE_ERR_DLLNOTFOUND 32")]
    public const int SE_ERR_DLLNOTFOUND = 32;
    [NativeTypeName("#define SE_ERR_SHARE 26")]
    public const int SE_ERR_SHARE = 26;
    [NativeTypeName("#define SE_ERR_ASSOCINCOMPLETE 27")]
    public const int SE_ERR_ASSOCINCOMPLETE = 27;
    [NativeTypeName("#define SE_ERR_DDETIMEOUT 28")]
    public const int SE_ERR_DDETIMEOUT = 28;
    [NativeTypeName("#define SE_ERR_DDEFAIL 29")]
    public const int SE_ERR_DDEFAIL = 29;
    [NativeTypeName("#define SE_ERR_DDEBUSY 30")]
    public const int SE_ERR_DDEBUSY = 30;
    [NativeTypeName("#define SE_ERR_NOASSOC 31")]
    public const int SE_ERR_NOASSOC = 31;
}