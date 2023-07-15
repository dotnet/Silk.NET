// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using static TerraFX.Interop.Windows.OLECMDEXECOPT;
using static TerraFX.Interop.Windows.OLECMDF;
using static TerraFX.Interop.Windows.OLECMDTEXTF;

namespace TerraFX.Interop.Windows;
public static partial class Windows
{
    [NativeTypeName("#define PAGESET_TOLASTPAGE ((WORD)(-1L))")]
    public const ushort PAGESET_TOLASTPAGE = unchecked((ushort)(-1));
    [NativeTypeName("#define OLECMDERR_E_FIRST (OLE_E_LAST+1)")]
    public const int OLECMDERR_E_FIRST = unchecked(((int)(0x800400FF)) + 1);
    [NativeTypeName("#define OLECMDERR_E_NOTSUPPORTED (OLECMDERR_E_FIRST)")]
    public const int OLECMDERR_E_NOTSUPPORTED = unchecked((((int)(0x800400FF)) + 1));
    [NativeTypeName("#define OLECMDERR_E_DISABLED (OLECMDERR_E_FIRST+1)")]
    public const int OLECMDERR_E_DISABLED = unchecked((((int)(0x800400FF)) + 1) + 1);
    [NativeTypeName("#define OLECMDERR_E_NOHELP (OLECMDERR_E_FIRST+2)")]
    public const int OLECMDERR_E_NOHELP = unchecked((((int)(0x800400FF)) + 1) + 2);
    [NativeTypeName("#define OLECMDERR_E_CANCELED (OLECMDERR_E_FIRST+3)")]
    public const int OLECMDERR_E_CANCELED = unchecked((((int)(0x800400FF)) + 1) + 3);
    [NativeTypeName("#define OLECMDERR_E_UNKNOWNGROUP (OLECMDERR_E_FIRST+4)")]
    public const int OLECMDERR_E_UNKNOWNGROUP = unchecked((((int)(0x800400FF)) + 1) + 4);
    [NativeTypeName("#define MSOCMDERR_E_FIRST OLECMDERR_E_FIRST")]
    public const int MSOCMDERR_E_FIRST = unchecked(((int)(0x800400FF)) + 1);
    [NativeTypeName("#define MSOCMDERR_E_NOTSUPPORTED OLECMDERR_E_NOTSUPPORTED")]
    public const int MSOCMDERR_E_NOTSUPPORTED = unchecked((((int)(0x800400FF)) + 1));
    [NativeTypeName("#define MSOCMDERR_E_DISABLED OLECMDERR_E_DISABLED")]
    public const int MSOCMDERR_E_DISABLED = unchecked((((int)(0x800400FF)) + 1) + 1);
    [NativeTypeName("#define MSOCMDERR_E_NOHELP OLECMDERR_E_NOHELP")]
    public const int MSOCMDERR_E_NOHELP = unchecked((((int)(0x800400FF)) + 1) + 2);
    [NativeTypeName("#define MSOCMDERR_E_CANCELED OLECMDERR_E_CANCELED")]
    public const int MSOCMDERR_E_CANCELED = unchecked((((int)(0x800400FF)) + 1) + 3);
    [NativeTypeName("#define MSOCMDERR_E_UNKNOWNGROUP OLECMDERR_E_UNKNOWNGROUP")]
    public const int MSOCMDERR_E_UNKNOWNGROUP = unchecked((((int)(0x800400FF)) + 1) + 4);
    [NativeTypeName("#define OLECMD_TASKDLGID_ONBEFOREUNLOAD 1")]
    public const int OLECMD_TASKDLGID_ONBEFOREUNLOAD = 1;
    [NativeTypeName("#define OLECMDARGINDEX_SHOWPAGEACTIONMENU_HWND 0")]
    public const int OLECMDARGINDEX_SHOWPAGEACTIONMENU_HWND = 0;
    [NativeTypeName("#define OLECMDARGINDEX_SHOWPAGEACTIONMENU_X 1")]
    public const int OLECMDARGINDEX_SHOWPAGEACTIONMENU_X = 1;
    [NativeTypeName("#define OLECMDARGINDEX_SHOWPAGEACTIONMENU_Y 2")]
    public const int OLECMDARGINDEX_SHOWPAGEACTIONMENU_Y = 2;
    [NativeTypeName("#define OLECMDARGINDEX_ACTIVEXINSTALL_PUBLISHER 0")]
    public const int OLECMDARGINDEX_ACTIVEXINSTALL_PUBLISHER = 0;
    [NativeTypeName("#define OLECMDARGINDEX_ACTIVEXINSTALL_DISPLAYNAME 1")]
    public const int OLECMDARGINDEX_ACTIVEXINSTALL_DISPLAYNAME = 1;
    [NativeTypeName("#define OLECMDARGINDEX_ACTIVEXINSTALL_CLSID 2")]
    public const int OLECMDARGINDEX_ACTIVEXINSTALL_CLSID = 2;
    [NativeTypeName("#define OLECMDARGINDEX_ACTIVEXINSTALL_INSTALLSCOPE 3")]
    public const int OLECMDARGINDEX_ACTIVEXINSTALL_INSTALLSCOPE = 3;
    [NativeTypeName("#define OLECMDARGINDEX_ACTIVEXINSTALL_SOURCEURL 4")]
    public const int OLECMDARGINDEX_ACTIVEXINSTALL_SOURCEURL = 4;
    [NativeTypeName("#define INSTALL_SCOPE_INVALID 0")]
    public const int INSTALL_SCOPE_INVALID = 0;
    [NativeTypeName("#define INSTALL_SCOPE_MACHINE 1")]
    public const int INSTALL_SCOPE_MACHINE = 1;
    [NativeTypeName("#define INSTALL_SCOPE_USER 2")]
    public const int INSTALL_SCOPE_USER = 2;
    [NativeTypeName("#define MSOCMDF_SUPPORTED OLECMDF_SUPPORTED")]
    public const OLECMDF MSOCMDF_SUPPORTED = OLECMDF_SUPPORTED;
    [NativeTypeName("#define MSOCMDF_ENABLED OLECMDF_ENABLED")]
    public const OLECMDF MSOCMDF_ENABLED = OLECMDF_ENABLED;
    [NativeTypeName("#define MSOCMDF_LATCHED OLECMDF_LATCHED")]
    public const OLECMDF MSOCMDF_LATCHED = OLECMDF_LATCHED;
    [NativeTypeName("#define MSOCMDF_NINCHED OLECMDF_NINCHED")]
    public const OLECMDF MSOCMDF_NINCHED = OLECMDF_NINCHED;
    [NativeTypeName("#define MSOCMDTEXTF_NONE OLECMDTEXTF_NONE")]
    public const OLECMDTEXTF MSOCMDTEXTF_NONE = OLECMDTEXTF_NONE;
    [NativeTypeName("#define MSOCMDTEXTF_NAME OLECMDTEXTF_NAME")]
    public const OLECMDTEXTF MSOCMDTEXTF_NAME = OLECMDTEXTF_NAME;
    [NativeTypeName("#define MSOCMDTEXTF_STATUS OLECMDTEXTF_STATUS")]
    public const OLECMDTEXTF MSOCMDTEXTF_STATUS = OLECMDTEXTF_STATUS;
    [NativeTypeName("#define MSOCMDEXECOPT_DODEFAULT OLECMDEXECOPT_DODEFAULT")]
    public const OLECMDEXECOPT MSOCMDEXECOPT_DODEFAULT = OLECMDEXECOPT_DODEFAULT;
    [NativeTypeName("#define MSOCMDEXECOPT_PROMPTUSER OLECMDEXECOPT_PROMPTUSER")]
    public const OLECMDEXECOPT MSOCMDEXECOPT_PROMPTUSER = OLECMDEXECOPT_PROMPTUSER;
    [NativeTypeName("#define MSOCMDEXECOPT_DONTPROMPTUSER OLECMDEXECOPT_DONTPROMPTUSER")]
    public const OLECMDEXECOPT MSOCMDEXECOPT_DONTPROMPTUSER = OLECMDEXECOPT_DONTPROMPTUSER;
    [NativeTypeName("#define MSOCMDEXECOPT_SHOWHELP OLECMDEXECOPT_SHOWHELP")]
    public const OLECMDEXECOPT MSOCMDEXECOPT_SHOWHELP = OLECMDEXECOPT_SHOWHELP;
}