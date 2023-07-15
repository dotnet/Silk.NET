// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class FCIDM
{
    [NativeTypeName("#define FCIDM_SHVIEWFIRST 0x0000")]
    public const int FCIDM_SHVIEWFIRST = 0x0000;
    [NativeTypeName("#define FCIDM_SHVIEWLAST 0x7fff")]
    public const int FCIDM_SHVIEWLAST = 0x7fff;
    [NativeTypeName("#define FCIDM_BROWSERFIRST 0xa000")]
    public const int FCIDM_BROWSERFIRST = 0xa000;
    [NativeTypeName("#define FCIDM_BROWSERLAST 0xbf00")]
    public const int FCIDM_BROWSERLAST = 0xbf00;
    [NativeTypeName("#define FCIDM_GLOBALFIRST 0x8000")]
    public const int FCIDM_GLOBALFIRST = 0x8000;
    [NativeTypeName("#define FCIDM_GLOBALLAST 0x9fff")]
    public const int FCIDM_GLOBALLAST = 0x9fff;
    [NativeTypeName("#define FCIDM_MENU_FILE (FCIDM_GLOBALFIRST+0x0000)")]
    public const int FCIDM_MENU_FILE = (0x8000 + 0x0000);
    [NativeTypeName("#define FCIDM_MENU_EDIT (FCIDM_GLOBALFIRST+0x0040)")]
    public const int FCIDM_MENU_EDIT = (0x8000 + 0x0040);
    [NativeTypeName("#define FCIDM_MENU_VIEW (FCIDM_GLOBALFIRST+0x0080)")]
    public const int FCIDM_MENU_VIEW = (0x8000 + 0x0080);
    [NativeTypeName("#define FCIDM_MENU_VIEW_SEP_OPTIONS (FCIDM_GLOBALFIRST+0x0081)")]
    public const int FCIDM_MENU_VIEW_SEP_OPTIONS = (0x8000 + 0x0081);
    [NativeTypeName("#define FCIDM_MENU_TOOLS (FCIDM_GLOBALFIRST+0x00c0)")]
    public const int FCIDM_MENU_TOOLS = (0x8000 + 0x00c0);
    [NativeTypeName("#define FCIDM_MENU_TOOLS_SEP_GOTO (FCIDM_GLOBALFIRST+0x00c1)")]
    public const int FCIDM_MENU_TOOLS_SEP_GOTO = (0x8000 + 0x00c1);
    [NativeTypeName("#define FCIDM_MENU_HELP (FCIDM_GLOBALFIRST+0x0100)")]
    public const int FCIDM_MENU_HELP = (0x8000 + 0x0100);
    [NativeTypeName("#define FCIDM_MENU_FIND (FCIDM_GLOBALFIRST+0x0140)")]
    public const int FCIDM_MENU_FIND = (0x8000 + 0x0140);
    [NativeTypeName("#define FCIDM_MENU_EXPLORE (FCIDM_GLOBALFIRST+0x0150)")]
    public const int FCIDM_MENU_EXPLORE = (0x8000 + 0x0150);
    [NativeTypeName("#define FCIDM_MENU_FAVORITES (FCIDM_GLOBALFIRST+0x0170)")]
    public const int FCIDM_MENU_FAVORITES = (0x8000 + 0x0170);
}