// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class OFN
{
    [NativeTypeName("#define OFN_READONLY 0x00000001")]
    public const int OFN_READONLY = 0x00000001;
    [NativeTypeName("#define OFN_OVERWRITEPROMPT 0x00000002")]
    public const int OFN_OVERWRITEPROMPT = 0x00000002;
    [NativeTypeName("#define OFN_HIDEREADONLY 0x00000004")]
    public const int OFN_HIDEREADONLY = 0x00000004;
    [NativeTypeName("#define OFN_NOCHANGEDIR 0x00000008")]
    public const int OFN_NOCHANGEDIR = 0x00000008;
    [NativeTypeName("#define OFN_SHOWHELP 0x00000010")]
    public const int OFN_SHOWHELP = 0x00000010;
    [NativeTypeName("#define OFN_ENABLEHOOK 0x00000020")]
    public const int OFN_ENABLEHOOK = 0x00000020;
    [NativeTypeName("#define OFN_ENABLETEMPLATE 0x00000040")]
    public const int OFN_ENABLETEMPLATE = 0x00000040;
    [NativeTypeName("#define OFN_ENABLETEMPLATEHANDLE 0x00000080")]
    public const int OFN_ENABLETEMPLATEHANDLE = 0x00000080;
    [NativeTypeName("#define OFN_NOVALIDATE 0x00000100")]
    public const int OFN_NOVALIDATE = 0x00000100;
    [NativeTypeName("#define OFN_ALLOWMULTISELECT 0x00000200")]
    public const int OFN_ALLOWMULTISELECT = 0x00000200;
    [NativeTypeName("#define OFN_EXTENSIONDIFFERENT 0x00000400")]
    public const int OFN_EXTENSIONDIFFERENT = 0x00000400;
    [NativeTypeName("#define OFN_PATHMUSTEXIST 0x00000800")]
    public const int OFN_PATHMUSTEXIST = 0x00000800;
    [NativeTypeName("#define OFN_FILEMUSTEXIST 0x00001000")]
    public const int OFN_FILEMUSTEXIST = 0x00001000;
    [NativeTypeName("#define OFN_CREATEPROMPT 0x00002000")]
    public const int OFN_CREATEPROMPT = 0x00002000;
    [NativeTypeName("#define OFN_SHAREAWARE 0x00004000")]
    public const int OFN_SHAREAWARE = 0x00004000;
    [NativeTypeName("#define OFN_NOREADONLYRETURN 0x00008000")]
    public const int OFN_NOREADONLYRETURN = 0x00008000;
    [NativeTypeName("#define OFN_NOTESTFILECREATE 0x00010000")]
    public const int OFN_NOTESTFILECREATE = 0x00010000;
    [NativeTypeName("#define OFN_NONETWORKBUTTON 0x00020000")]
    public const int OFN_NONETWORKBUTTON = 0x00020000;
    [NativeTypeName("#define OFN_NOLONGNAMES 0x00040000")]
    public const int OFN_NOLONGNAMES = 0x00040000;
    [NativeTypeName("#define OFN_EXPLORER 0x00080000")]
    public const int OFN_EXPLORER = 0x00080000;
    [NativeTypeName("#define OFN_NODEREFERENCELINKS 0x00100000")]
    public const int OFN_NODEREFERENCELINKS = 0x00100000;
    [NativeTypeName("#define OFN_LONGNAMES 0x00200000")]
    public const int OFN_LONGNAMES = 0x00200000;
    [NativeTypeName("#define OFN_ENABLEINCLUDENOTIFY 0x00400000")]
    public const int OFN_ENABLEINCLUDENOTIFY = 0x00400000;
    [NativeTypeName("#define OFN_ENABLESIZING 0x00800000")]
    public const int OFN_ENABLESIZING = 0x00800000;
    [NativeTypeName("#define OFN_DONTADDTORECENT 0x02000000")]
    public const int OFN_DONTADDTORECENT = 0x02000000;
    [NativeTypeName("#define OFN_FORCESHOWHIDDEN 0x10000000")]
    public const int OFN_FORCESHOWHIDDEN = 0x10000000;
    [NativeTypeName("#define OFN_EX_NOPLACESBAR 0x00000001")]
    public const int OFN_EX_NOPLACESBAR = 0x00000001;
    [NativeTypeName("#define OFN_SHAREFALLTHROUGH 2")]
    public const int OFN_SHAREFALLTHROUGH = 2;
    [NativeTypeName("#define OFN_SHARENOWARN 1")]
    public const int OFN_SHARENOWARN = 1;
    [NativeTypeName("#define OFN_SHAREWARN 0")]
    public const int OFN_SHAREWARN = 0;
}