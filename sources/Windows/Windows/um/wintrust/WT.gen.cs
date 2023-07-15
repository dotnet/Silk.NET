// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class WT
{
    [NativeTypeName("#define WT_CURRENT_VERSION 0x00000200")]
    public const int WT_CURRENT_VERSION = 0x00000200;
    [NativeTypeName("#define WT_PROVIDER_DLL_NAME L\"WINTRUST.DLL\"")]
    public const string WT_PROVIDER_DLL_NAME = "WINTRUST.DLL";
    [NativeTypeName("#define WT_PROVIDER_CERTTRUST_FUNCTION L\"WintrustCertificateTrust\"")]
    public const string WT_PROVIDER_CERTTRUST_FUNCTION = "WintrustCertificateTrust";
    [NativeTypeName("#define WT_ADD_ACTION_ID_RET_RESULT_FLAG 0x1")]
    public const int WT_ADD_ACTION_ID_RET_RESULT_FLAG = 0x1;
    [NativeTypeName("#define WT_TRUSTDBDIALOG_NO_UI_FLAG 0x00000001")]
    public const int WT_TRUSTDBDIALOG_NO_UI_FLAG = 0x00000001;
    [NativeTypeName("#define WT_TRUSTDBDIALOG_ONLY_PUB_TAB_FLAG 0x00000002")]
    public const int WT_TRUSTDBDIALOG_ONLY_PUB_TAB_FLAG = 0x00000002;
    [NativeTypeName("#define WT_TRUSTDBDIALOG_WRITE_LEGACY_REG_FLAG 0x00000100")]
    public const int WT_TRUSTDBDIALOG_WRITE_LEGACY_REG_FLAG = 0x00000100;
    [NativeTypeName("#define WT_TRUSTDBDIALOG_WRITE_IEAK_STORE_FLAG 0x00000200")]
    public const int WT_TRUSTDBDIALOG_WRITE_IEAK_STORE_FLAG = 0x00000200;
}