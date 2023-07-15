// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsCtfMonitorApi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.InitLocalMsCtfMonitor"]/*'/>
    [DllImport("msctfmonitor", ExactSpelling = true)]
    public static extern HRESULT InitLocalMsCtfMonitor([NativeTypeName("DWORD")] uint dwFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.UninitLocalMsCtfMonitor"]/*'/>
    [DllImport("msctfmonitor", ExactSpelling = true)]
    public static extern HRESULT UninitLocalMsCtfMonitor();
    [NativeTypeName("#define DCM_FLAGS_TASKENG 0x00000001")]
    public const int DCM_FLAGS_TASKENG = 0x00000001;
    [NativeTypeName("#define DCM_FLAGS_CTFMON 0x00000002")]
    public const int DCM_FLAGS_CTFMON = 0x00000002;
    [NativeTypeName("#define DCM_FLAGS_LOCALTHREADTSF 0x00000004")]
    public const int DCM_FLAGS_LOCALTHREADTSF = 0x00000004;
    [NativeTypeName("#define ILMCM_CHECKLAYOUTANDTIPENABLED 0x00001")]
    public const int ILMCM_CHECKLAYOUTANDTIPENABLED = 0x00001;
    [NativeTypeName("#define ILMCM_LANGUAGEBAROFF 0x00002")]
    public const int ILMCM_LANGUAGEBAROFF = 0x00002;
}