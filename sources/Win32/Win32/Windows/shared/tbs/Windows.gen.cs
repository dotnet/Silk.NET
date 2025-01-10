// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("tbs", ExactSpelling = true)]
    [return: NativeTypeName("TBS_RESULT")]
    public static extern uint Tbsi_Context_Create(
        [NativeTypeName("PCTBS_CONTEXT_PARAMS")] TBS_CONTEXT_PARAMS* pContextParams,
        [NativeTypeName("PTBS_HCONTEXT")] void** phContext
    );

    [DllImport("tbs", ExactSpelling = true)]
    [return: NativeTypeName("TBS_RESULT")]
    public static extern uint Tbsip_Context_Close([NativeTypeName("TBS_HCONTEXT")] void* hContext);

    [DllImport("tbs", ExactSpelling = true)]
    [return: NativeTypeName("TBS_RESULT")]
    public static extern uint Tbsip_Submit_Command(
        [NativeTypeName("TBS_HCONTEXT")] void* hContext,
        [NativeTypeName("TBS_COMMAND_LOCALITY")] uint Locality,
        [NativeTypeName("TBS_COMMAND_PRIORITY")] uint Priority,
        [NativeTypeName("PCBYTE")] byte* pabCommand,
        [NativeTypeName("UINT32")] uint cbCommand,
        [NativeTypeName("PBYTE")] byte* pabResult,
        [NativeTypeName("PUINT32")] uint* pcbResult
    );

    [DllImport("tbs", ExactSpelling = true)]
    [return: NativeTypeName("TBS_RESULT")]
    public static extern uint Tbsip_Cancel_Commands(
        [NativeTypeName("TBS_HCONTEXT")] void* hContext
    );

    [DllImport("tbs", ExactSpelling = true)]
    [return: NativeTypeName("TBS_RESULT")]
    public static extern uint Tbsi_Physical_Presence_Command(
        [NativeTypeName("TBS_HCONTEXT")] void* hContext,
        [NativeTypeName("PCBYTE")] byte* pabInput,
        [NativeTypeName("UINT32")] uint cbInput,
        [NativeTypeName("PBYTE")] byte* pabOutput,
        [NativeTypeName("PUINT32")] uint* pcbOutput
    );

    [DllImport("tbs", ExactSpelling = true)]
    [return: NativeTypeName("TBS_RESULT")]
    public static extern uint Tbsi_Get_TCG_Log(
        [NativeTypeName("TBS_HCONTEXT")] void* hContext,
        [NativeTypeName("PBYTE")] byte* pOutputBuf,
        [NativeTypeName("PUINT32")] uint* pOutputBufLen
    );

    [DllImport("tbs", ExactSpelling = true)]
    [return: NativeTypeName("TBS_RESULT")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint Tbsi_GetDeviceInfo(
        [NativeTypeName("UINT32")] uint Size,
        [NativeTypeName("PVOID")] void* Info
    );

    [DllImport("tbs", ExactSpelling = true)]
    [return: NativeTypeName("TBS_RESULT")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint Tbsi_Get_OwnerAuth(
        [NativeTypeName("TBS_HCONTEXT")] void* hContext,
        [NativeTypeName("TBS_OWNERAUTH_TYPE")] uint ownerauthType,
        [NativeTypeName("PBYTE")] byte* pOutputBuf,
        [NativeTypeName("PUINT32")] uint* pOutputBufLen
    );

    [DllImport("tbs", ExactSpelling = true)]
    [return: NativeTypeName("TBS_RESULT")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint Tbsi_Revoke_Attestation();

    [DllImport("tbs", ExactSpelling = true)]
    public static extern HRESULT GetDeviceID(
        [NativeTypeName("PBYTE")] byte* pbWindowsAIK,
        [NativeTypeName("UINT32")] uint cbWindowsAIK,
        [NativeTypeName("PUINT32")] uint* pcbResult,
        BOOL* pfProtectedByTPM
    );

    [DllImport("tbs", ExactSpelling = true)]
    public static extern HRESULT GetDeviceIDString(
        [NativeTypeName("PWSTR")] ushort* pszWindowsAIK,
        [NativeTypeName("UINT32")] uint cchWindowsAIK,
        [NativeTypeName("PUINT32")] uint* pcchResult,
        BOOL* pfProtectedByTPM
    );

    [DllImport("tbs", ExactSpelling = true)]
    [return: NativeTypeName("TBS_RESULT")]
    public static extern uint Tbsi_Create_Windows_Key(
        [NativeTypeName("TBS_HANDLE")] uint keyHandle
    );

    [DllImport("tbs", ExactSpelling = true)]
    [return: NativeTypeName("TBS_RESULT")]
    [SupportedOSPlatform("windows10.0.17134.0")]
    public static extern uint Tbsi_Get_TCG_Log_Ex(
        [NativeTypeName("UINT32")] uint logType,
        [NativeTypeName("PBYTE")] byte* pbOutput,
        [NativeTypeName("PUINT32")] uint* pcbOutput
    );

    [DllImport("tbs", ExactSpelling = true)]
    [SupportedOSPlatform("windows10.0.22621.0")]
    public static extern BOOL Tbsi_Is_Tpm_Present();
}
