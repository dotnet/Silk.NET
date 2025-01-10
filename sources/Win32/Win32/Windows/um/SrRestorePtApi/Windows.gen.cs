// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SrRestorePtApi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("srclient", ExactSpelling = true)]
    public static extern BOOL SRSetRestorePointA(
        [NativeTypeName("PRESTOREPOINTINFOA")] RESTOREPOINTINFOA* pRestorePtSpec,
        [NativeTypeName("PSTATEMGRSTATUS")] STATEMGRSTATUS* pSMgrStatus
    );

    [DllImport("srclient", ExactSpelling = true)]
    public static extern BOOL SRSetRestorePointW(
        [NativeTypeName("PRESTOREPOINTINFOW")] RESTOREPOINTINFOW* pRestorePtSpec,
        [NativeTypeName("PSTATEMGRSTATUS")] STATEMGRSTATUS* pSMgrStatus
    );

    [DllImport("srclient", ExactSpelling = true)]
    public static extern BOOL SRSetRestorePointInternal(
        [NativeTypeName("PRESTOREPOINTINFOW")] RESTOREPOINTINFOW* pRestorePtSpec,
        [NativeTypeName("PSTATEMGRSTATUS")] STATEMGRSTATUS* pSMgrStatus,
        BOOL fForceSurrogate
    );

    [DllImport("srclient", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint SRRemoveRestorePoint([NativeTypeName("DWORD")] uint dwRPNum);

    [NativeTypeName("#define MIN_EVENT 100")]
    public const int MIN_EVENT = 100;

    [NativeTypeName("#define BEGIN_SYSTEM_CHANGE 100")]
    public const int BEGIN_SYSTEM_CHANGE = 100;

    [NativeTypeName("#define END_SYSTEM_CHANGE 101")]
    public const int END_SYSTEM_CHANGE = 101;

    [NativeTypeName("#define BEGIN_NESTED_SYSTEM_CHANGE 102")]
    public const int BEGIN_NESTED_SYSTEM_CHANGE = 102;

    [NativeTypeName("#define END_NESTED_SYSTEM_CHANGE 103")]
    public const int END_NESTED_SYSTEM_CHANGE = 103;

    [NativeTypeName("#define BEGIN_NESTED_SYSTEM_CHANGE_NORP 104")]
    public const int BEGIN_NESTED_SYSTEM_CHANGE_NORP = 104;

    [NativeTypeName("#define END_NESTED_SYSTEM_CHANGE_NORP END_NESTED_SYSTEM_CHANGE")]
    public const int END_NESTED_SYSTEM_CHANGE_NORP = 103;

    [NativeTypeName("#define MIN_RPT 0")]
    public const int MIN_RPT = 0;

    [NativeTypeName("#define APPLICATION_INSTALL 0")]
    public const int APPLICATION_INSTALL = 0;

    [NativeTypeName("#define APPLICATION_UNINSTALL 1")]
    public const int APPLICATION_UNINSTALL = 1;

    [NativeTypeName("#define ACCESSIBILITY_SETTING 3")]
    public const int ACCESSIBILITY_SETTING = 3;

    [NativeTypeName("#define OE_SETTING 4")]
    public const int OE_SETTING = 4;

    [NativeTypeName("#define APPLICATION_RUN 5")]
    public const int APPLICATION_RUN = 5;

    [NativeTypeName("#define RESTORE 6")]
    public const int RESTORE = 6;

    [NativeTypeName("#define CHECKPOINT 7")]
    public const int CHECKPOINT = 7;

    [NativeTypeName("#define WINDOWS_SHUTDOWN 8")]
    public const int WINDOWS_SHUTDOWN = 8;

    [NativeTypeName("#define WINDOWS_BOOT 9")]
    public const int WINDOWS_BOOT = 9;

    [NativeTypeName("#define FIRSTRUN 11")]
    public const int FIRSTRUN = 11;

    [NativeTypeName("#define MODIFY_SETTINGS 12")]
    public const int MODIFY_SETTINGS = 12;

    [NativeTypeName("#define CANCELLED_OPERATION 13")]
    public const int CANCELLED_OPERATION = 13;

    [NativeTypeName("#define BACKUP 15")]
    public const int BACKUP = 15;

    [NativeTypeName("#define MANUAL_CHECKPOINT 16")]
    public const int MANUAL_CHECKPOINT = 16;

    [NativeTypeName("#define WINDOWS_UPDATE 17")]
    public const int WINDOWS_UPDATE = 17;

    [NativeTypeName("#define CRITICAL_UPDATE 18")]
    public const int CRITICAL_UPDATE = 18;

    [NativeTypeName("#define SRSetRestorePoint SRSetRestorePointW")]
    public static delegate* <RESTOREPOINTINFOW*, STATEMGRSTATUS*, BOOL> SRSetRestorePoint =>
        &SRSetRestorePointW;
}
