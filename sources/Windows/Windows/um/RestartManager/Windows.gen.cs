// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/RestartManager.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RmStartSession"]/*'/>
    [DllImport("rstrtmgr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RmStartSession([NativeTypeName("DWORD *")] uint* pSessionHandle, [NativeTypeName("DWORD")] uint dwSessionFlags, [NativeTypeName("WCHAR[]")] ushort* strSessionKey);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RmJoinSession"]/*'/>
    [DllImport("rstrtmgr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RmJoinSession([NativeTypeName("DWORD *")] uint* pSessionHandle, [NativeTypeName("const WCHAR[]")] ushort* strSessionKey);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RmEndSession"]/*'/>
    [DllImport("rstrtmgr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RmEndSession([NativeTypeName("DWORD")] uint dwSessionHandle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RmRegisterResources"]/*'/>
    [DllImport("rstrtmgr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RmRegisterResources([NativeTypeName("DWORD")] uint dwSessionHandle, uint nFiles, [NativeTypeName("LPCWSTR[]")] ushort** rgsFileNames, uint nApplications, [NativeTypeName("RM_UNIQUE_PROCESS[]")] RM_UNIQUE_PROCESS* rgApplications, uint nServices, [NativeTypeName("LPCWSTR[]")] ushort** rgsServiceNames);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RmGetList"]/*'/>
    [DllImport("rstrtmgr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RmGetList([NativeTypeName("DWORD")] uint dwSessionHandle, uint* pnProcInfoNeeded, uint* pnProcInfo, [NativeTypeName("RM_PROCESS_INFO[]")] RM_PROCESS_INFO* rgAffectedApps, [NativeTypeName("LPDWORD")] uint* lpdwRebootReasons);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RmShutdown"]/*'/>
    [DllImport("rstrtmgr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RmShutdown([NativeTypeName("DWORD")] uint dwSessionHandle, [NativeTypeName("ULONG")] uint lActionFlags, [NativeTypeName("RM_WRITE_STATUS_CALLBACK")] delegate* unmanaged<uint, void> fnStatus);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RmRestart"]/*'/>
    [DllImport("rstrtmgr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RmRestart([NativeTypeName("DWORD")] uint dwSessionHandle, [NativeTypeName("DWORD")] uint dwRestartFlags, [NativeTypeName("RM_WRITE_STATUS_CALLBACK")] delegate* unmanaged<uint, void> fnStatus);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RmCancelCurrentTask"]/*'/>
    [DllImport("rstrtmgr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RmCancelCurrentTask([NativeTypeName("DWORD")] uint dwSessionHandle);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RmAddFilter"]/*'/>
    [DllImport("rstrtmgr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RmAddFilter([NativeTypeName("DWORD")] uint dwSessionHandle, [NativeTypeName("LPCWSTR")] ushort* strModuleName, RM_UNIQUE_PROCESS* pProcess, [NativeTypeName("LPCWSTR")] ushort* strServiceShortName, RM_FILTER_ACTION FilterAction);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RmRemoveFilter"]/*'/>
    [DllImport("rstrtmgr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RmRemoveFilter([NativeTypeName("DWORD")] uint dwSessionHandle, [NativeTypeName("LPCWSTR")] ushort* strModuleName, RM_UNIQUE_PROCESS* pProcess, [NativeTypeName("LPCWSTR")] ushort* strServiceShortName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.RmGetFilterList"]/*'/>
    [DllImport("rstrtmgr", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    public static extern uint RmGetFilterList([NativeTypeName("DWORD")] uint dwSessionHandle, [NativeTypeName("PBYTE")] byte* pbFilterBuf, [NativeTypeName("DWORD")] uint cbFilterBuf, [NativeTypeName("LPDWORD")] uint* cbFilterBufNeeded);
    [NativeTypeName("#define RM_SESSION_KEY_LEN sizeof(GUID)")]
    public const uint RM_SESSION_KEY_LEN = 16;
    [NativeTypeName("#define CCH_RM_SESSION_KEY RM_SESSION_KEY_LEN*2")]
    public const uint CCH_RM_SESSION_KEY = 16 * 2;
    [NativeTypeName("#define CCH_RM_MAX_APP_NAME 255")]
    public const int CCH_RM_MAX_APP_NAME = 255;
    [NativeTypeName("#define CCH_RM_MAX_SVC_NAME 63")]
    public const int CCH_RM_MAX_SVC_NAME = 63;
    [NativeTypeName("#define RM_INVALID_TS_SESSION -1")]
    public const int RM_INVALID_TS_SESSION = -1;
    [NativeTypeName("#define RM_INVALID_PROCESS -1")]
    public const int RM_INVALID_PROCESS = -1;
}