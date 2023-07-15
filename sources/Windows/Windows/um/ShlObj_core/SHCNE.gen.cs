// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class SHCNE
{
    [NativeTypeName("#define SHCNE_RENAMEITEM 0x00000001L")]
    public const int SHCNE_RENAMEITEM = 0x00000001;
    [NativeTypeName("#define SHCNE_CREATE 0x00000002L")]
    public const int SHCNE_CREATE = 0x00000002;
    [NativeTypeName("#define SHCNE_DELETE 0x00000004L")]
    public const int SHCNE_DELETE = 0x00000004;
    [NativeTypeName("#define SHCNE_MKDIR 0x00000008L")]
    public const int SHCNE_MKDIR = 0x00000008;
    [NativeTypeName("#define SHCNE_RMDIR 0x00000010L")]
    public const int SHCNE_RMDIR = 0x00000010;
    [NativeTypeName("#define SHCNE_MEDIAINSERTED 0x00000020L")]
    public const int SHCNE_MEDIAINSERTED = 0x00000020;
    [NativeTypeName("#define SHCNE_MEDIAREMOVED 0x00000040L")]
    public const int SHCNE_MEDIAREMOVED = 0x00000040;
    [NativeTypeName("#define SHCNE_DRIVEREMOVED 0x00000080L")]
    public const int SHCNE_DRIVEREMOVED = 0x00000080;
    [NativeTypeName("#define SHCNE_DRIVEADD 0x00000100L")]
    public const int SHCNE_DRIVEADD = 0x00000100;
    [NativeTypeName("#define SHCNE_NETSHARE 0x00000200L")]
    public const int SHCNE_NETSHARE = 0x00000200;
    [NativeTypeName("#define SHCNE_NETUNSHARE 0x00000400L")]
    public const int SHCNE_NETUNSHARE = 0x00000400;
    [NativeTypeName("#define SHCNE_ATTRIBUTES 0x00000800L")]
    public const int SHCNE_ATTRIBUTES = 0x00000800;
    [NativeTypeName("#define SHCNE_UPDATEDIR 0x00001000L")]
    public const int SHCNE_UPDATEDIR = 0x00001000;
    [NativeTypeName("#define SHCNE_UPDATEITEM 0x00002000L")]
    public const int SHCNE_UPDATEITEM = 0x00002000;
    [NativeTypeName("#define SHCNE_SERVERDISCONNECT 0x00004000L")]
    public const int SHCNE_SERVERDISCONNECT = 0x00004000;
    [NativeTypeName("#define SHCNE_UPDATEIMAGE 0x00008000L")]
    public const int SHCNE_UPDATEIMAGE = 0x00008000;
    [NativeTypeName("#define SHCNE_DRIVEADDGUI 0x00010000L")]
    public const int SHCNE_DRIVEADDGUI = 0x00010000;
    [NativeTypeName("#define SHCNE_RENAMEFOLDER 0x00020000L")]
    public const int SHCNE_RENAMEFOLDER = 0x00020000;
    [NativeTypeName("#define SHCNE_FREESPACE 0x00040000L")]
    public const int SHCNE_FREESPACE = 0x00040000;
    [NativeTypeName("#define SHCNE_EXTENDED_EVENT 0x04000000L")]
    public const int SHCNE_EXTENDED_EVENT = 0x04000000;
    [NativeTypeName("#define SHCNE_ASSOCCHANGED 0x08000000L")]
    public const int SHCNE_ASSOCCHANGED = 0x08000000;
    [NativeTypeName("#define SHCNE_DISKEVENTS 0x0002381FL")]
    public const int SHCNE_DISKEVENTS = 0x0002381F;
    [NativeTypeName("#define SHCNE_GLOBALEVENTS 0x0C0581E0L")]
    public const int SHCNE_GLOBALEVENTS = 0x0C0581E0;
    [NativeTypeName("#define SHCNE_ALLEVENTS 0x7FFFFFFFL")]
    public const int SHCNE_ALLEVENTS = 0x7FFFFFFF;
    [NativeTypeName("#define SHCNE_INTERRUPT 0x80000000L")]
    public const uint SHCNE_INTERRUPT = 0x80000000;
}