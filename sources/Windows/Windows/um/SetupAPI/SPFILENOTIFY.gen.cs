// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class SPFILENOTIFY
{
    [NativeTypeName("#define SPFILENOTIFY_STARTQUEUE 0x00000001")]
    public const int SPFILENOTIFY_STARTQUEUE = 0x00000001;
    [NativeTypeName("#define SPFILENOTIFY_ENDQUEUE 0x00000002")]
    public const int SPFILENOTIFY_ENDQUEUE = 0x00000002;
    [NativeTypeName("#define SPFILENOTIFY_STARTSUBQUEUE 0x00000003")]
    public const int SPFILENOTIFY_STARTSUBQUEUE = 0x00000003;
    [NativeTypeName("#define SPFILENOTIFY_ENDSUBQUEUE 0x00000004")]
    public const int SPFILENOTIFY_ENDSUBQUEUE = 0x00000004;
    [NativeTypeName("#define SPFILENOTIFY_STARTDELETE 0x00000005")]
    public const int SPFILENOTIFY_STARTDELETE = 0x00000005;
    [NativeTypeName("#define SPFILENOTIFY_ENDDELETE 0x00000006")]
    public const int SPFILENOTIFY_ENDDELETE = 0x00000006;
    [NativeTypeName("#define SPFILENOTIFY_DELETEERROR 0x00000007")]
    public const int SPFILENOTIFY_DELETEERROR = 0x00000007;
    [NativeTypeName("#define SPFILENOTIFY_STARTRENAME 0x00000008")]
    public const int SPFILENOTIFY_STARTRENAME = 0x00000008;
    [NativeTypeName("#define SPFILENOTIFY_ENDRENAME 0x00000009")]
    public const int SPFILENOTIFY_ENDRENAME = 0x00000009;
    [NativeTypeName("#define SPFILENOTIFY_RENAMEERROR 0x0000000a")]
    public const int SPFILENOTIFY_RENAMEERROR = 0x0000000a;
    [NativeTypeName("#define SPFILENOTIFY_STARTCOPY 0x0000000b")]
    public const int SPFILENOTIFY_STARTCOPY = 0x0000000b;
    [NativeTypeName("#define SPFILENOTIFY_ENDCOPY 0x0000000c")]
    public const int SPFILENOTIFY_ENDCOPY = 0x0000000c;
    [NativeTypeName("#define SPFILENOTIFY_COPYERROR 0x0000000d")]
    public const int SPFILENOTIFY_COPYERROR = 0x0000000d;
    [NativeTypeName("#define SPFILENOTIFY_NEEDMEDIA 0x0000000e")]
    public const int SPFILENOTIFY_NEEDMEDIA = 0x0000000e;
    [NativeTypeName("#define SPFILENOTIFY_QUEUESCAN 0x0000000f")]
    public const int SPFILENOTIFY_QUEUESCAN = 0x0000000f;
    [NativeTypeName("#define SPFILENOTIFY_CABINETINFO 0x00000010")]
    public const int SPFILENOTIFY_CABINETINFO = 0x00000010;
    [NativeTypeName("#define SPFILENOTIFY_FILEINCABINET 0x00000011")]
    public const int SPFILENOTIFY_FILEINCABINET = 0x00000011;
    [NativeTypeName("#define SPFILENOTIFY_NEEDNEWCABINET 0x00000012")]
    public const int SPFILENOTIFY_NEEDNEWCABINET = 0x00000012;
    [NativeTypeName("#define SPFILENOTIFY_FILEEXTRACTED 0x00000013")]
    public const int SPFILENOTIFY_FILEEXTRACTED = 0x00000013;
    [NativeTypeName("#define SPFILENOTIFY_FILEOPDELAYED 0x00000014")]
    public const int SPFILENOTIFY_FILEOPDELAYED = 0x00000014;
    [NativeTypeName("#define SPFILENOTIFY_STARTBACKUP 0x00000015")]
    public const int SPFILENOTIFY_STARTBACKUP = 0x00000015;
    [NativeTypeName("#define SPFILENOTIFY_BACKUPERROR 0x00000016")]
    public const int SPFILENOTIFY_BACKUPERROR = 0x00000016;
    [NativeTypeName("#define SPFILENOTIFY_ENDBACKUP 0x00000017")]
    public const int SPFILENOTIFY_ENDBACKUP = 0x00000017;
    [NativeTypeName("#define SPFILENOTIFY_QUEUESCAN_EX 0x00000018")]
    public const int SPFILENOTIFY_QUEUESCAN_EX = 0x00000018;
    [NativeTypeName("#define SPFILENOTIFY_STARTREGISTRATION 0x00000019")]
    public const int SPFILENOTIFY_STARTREGISTRATION = 0x00000019;
    [NativeTypeName("#define SPFILENOTIFY_ENDREGISTRATION 0x00000020")]
    public const int SPFILENOTIFY_ENDREGISTRATION = 0x00000020;
    [NativeTypeName("#define SPFILENOTIFY_QUEUESCAN_SIGNERINFO 0x00000040")]
    public const int SPFILENOTIFY_QUEUESCAN_SIGNERINFO = 0x00000040;
    [NativeTypeName("#define SPFILENOTIFY_LANGMISMATCH 0x00010000")]
    public const int SPFILENOTIFY_LANGMISMATCH = 0x00010000;
    [NativeTypeName("#define SPFILENOTIFY_TARGETEXISTS 0x00020000")]
    public const int SPFILENOTIFY_TARGETEXISTS = 0x00020000;
    [NativeTypeName("#define SPFILENOTIFY_TARGETNEWER 0x00040000")]
    public const int SPFILENOTIFY_TARGETNEWER = 0x00040000;
}