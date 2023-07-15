// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/CommDlg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class PD
{
    [NativeTypeName("#define PD_ALLPAGES 0x00000000")]
    public const int PD_ALLPAGES = 0x00000000;
    [NativeTypeName("#define PD_SELECTION 0x00000001")]
    public const int PD_SELECTION = 0x00000001;
    [NativeTypeName("#define PD_PAGENUMS 0x00000002")]
    public const int PD_PAGENUMS = 0x00000002;
    [NativeTypeName("#define PD_NOSELECTION 0x00000004")]
    public const int PD_NOSELECTION = 0x00000004;
    [NativeTypeName("#define PD_NOPAGENUMS 0x00000008")]
    public const int PD_NOPAGENUMS = 0x00000008;
    [NativeTypeName("#define PD_COLLATE 0x00000010")]
    public const int PD_COLLATE = 0x00000010;
    [NativeTypeName("#define PD_PRINTTOFILE 0x00000020")]
    public const int PD_PRINTTOFILE = 0x00000020;
    [NativeTypeName("#define PD_PRINTSETUP 0x00000040")]
    public const int PD_PRINTSETUP = 0x00000040;
    [NativeTypeName("#define PD_NOWARNING 0x00000080")]
    public const int PD_NOWARNING = 0x00000080;
    [NativeTypeName("#define PD_RETURNDC 0x00000100")]
    public const int PD_RETURNDC = 0x00000100;
    [NativeTypeName("#define PD_RETURNIC 0x00000200")]
    public const int PD_RETURNIC = 0x00000200;
    [NativeTypeName("#define PD_RETURNDEFAULT 0x00000400")]
    public const int PD_RETURNDEFAULT = 0x00000400;
    [NativeTypeName("#define PD_SHOWHELP 0x00000800")]
    public const int PD_SHOWHELP = 0x00000800;
    [NativeTypeName("#define PD_ENABLEPRINTHOOK 0x00001000")]
    public const int PD_ENABLEPRINTHOOK = 0x00001000;
    [NativeTypeName("#define PD_ENABLESETUPHOOK 0x00002000")]
    public const int PD_ENABLESETUPHOOK = 0x00002000;
    [NativeTypeName("#define PD_ENABLEPRINTTEMPLATE 0x00004000")]
    public const int PD_ENABLEPRINTTEMPLATE = 0x00004000;
    [NativeTypeName("#define PD_ENABLESETUPTEMPLATE 0x00008000")]
    public const int PD_ENABLESETUPTEMPLATE = 0x00008000;
    [NativeTypeName("#define PD_ENABLEPRINTTEMPLATEHANDLE 0x00010000")]
    public const int PD_ENABLEPRINTTEMPLATEHANDLE = 0x00010000;
    [NativeTypeName("#define PD_ENABLESETUPTEMPLATEHANDLE 0x00020000")]
    public const int PD_ENABLESETUPTEMPLATEHANDLE = 0x00020000;
    [NativeTypeName("#define PD_USEDEVMODECOPIES 0x00040000")]
    public const int PD_USEDEVMODECOPIES = 0x00040000;
    [NativeTypeName("#define PD_USEDEVMODECOPIESANDCOLLATE 0x00040000")]
    public const int PD_USEDEVMODECOPIESANDCOLLATE = 0x00040000;
    [NativeTypeName("#define PD_DISABLEPRINTTOFILE 0x00080000")]
    public const int PD_DISABLEPRINTTOFILE = 0x00080000;
    [NativeTypeName("#define PD_HIDEPRINTTOFILE 0x00100000")]
    public const int PD_HIDEPRINTTOFILE = 0x00100000;
    [NativeTypeName("#define PD_NONETWORKBUTTON 0x00200000")]
    public const int PD_NONETWORKBUTTON = 0x00200000;
    [NativeTypeName("#define PD_CURRENTPAGE 0x00400000")]
    public const int PD_CURRENTPAGE = 0x00400000;
    [NativeTypeName("#define PD_NOCURRENTPAGE 0x00800000")]
    public const int PD_NOCURRENTPAGE = 0x00800000;
    [NativeTypeName("#define PD_EXCLUSIONFLAGS 0x01000000")]
    public const int PD_EXCLUSIONFLAGS = 0x01000000;
    [NativeTypeName("#define PD_USELARGETEMPLATE 0x10000000")]
    public const int PD_USELARGETEMPLATE = 0x10000000;
    [NativeTypeName("#define PD_EXCL_COPIESANDCOLLATE (DM_COPIES | DM_COLLATE)")]
    public const int PD_EXCL_COPIESANDCOLLATE = (0x00000100 | 0x00008000);
    [NativeTypeName("#define PD_RESULT_CANCEL 0")]
    public const int PD_RESULT_CANCEL = 0;
    [NativeTypeName("#define PD_RESULT_PRINT 1")]
    public const int PD_RESULT_PRINT = 1;
    [NativeTypeName("#define PD_RESULT_APPLY 2")]
    public const int PD_RESULT_APPLY = 2;
}