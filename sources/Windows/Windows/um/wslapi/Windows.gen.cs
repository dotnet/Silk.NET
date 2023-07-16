// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wslapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using static Silk.NET.Windows.WSL_DISTRIBUTION_FLAGS;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WslIsDistributionRegistered"]/*'/>
    [DllImport("api-ms-win-wsl-api-l1-1-0", ExactSpelling = true)]
    public static extern BOOL WslIsDistributionRegistered([NativeTypeName("PCWSTR")] ushort* distributionName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WslRegisterDistribution"]/*'/>
    [DllImport("api-ms-win-wsl-api-l1-1-0", ExactSpelling = true)]
    public static extern HRESULT WslRegisterDistribution([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("PCWSTR")] ushort* tarGzFilename);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WslUnregisterDistribution"]/*'/>
    [DllImport("api-ms-win-wsl-api-l1-1-0", ExactSpelling = true)]
    public static extern HRESULT WslUnregisterDistribution([NativeTypeName("PCWSTR")] ushort* distributionName);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WslConfigureDistribution"]/*'/>
    [DllImport("api-ms-win-wsl-api-l1-1-0", ExactSpelling = true)]
    public static extern HRESULT WslConfigureDistribution([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("ULONG")] uint defaultUID, WSL_DISTRIBUTION_FLAGS wslDistributionFlags);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WslGetDistributionConfiguration"]/*'/>
    [DllImport("api-ms-win-wsl-api-l1-1-0", ExactSpelling = true)]
    public static extern HRESULT WslGetDistributionConfiguration([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("ULONG *")] uint* distributionVersion, [NativeTypeName("ULONG *")] uint* defaultUID, WSL_DISTRIBUTION_FLAGS* wslDistributionFlags, [NativeTypeName("PSTR **")] sbyte*** defaultEnvironmentVariables, [NativeTypeName("ULONG *")] uint* defaultEnvironmentVariableCount);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WslLaunchInteractive"]/*'/>
    [DllImport("api-ms-win-wsl-api-l1-1-0", ExactSpelling = true)]
    public static extern HRESULT WslLaunchInteractive([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("PCWSTR")] ushort* command, BOOL useCurrentWorkingDirectory, [NativeTypeName("DWORD *")] uint* exitCode);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WslLaunch"]/*'/>
    [DllImport("api-ms-win-wsl-api-l1-1-0", ExactSpelling = true)]
    public static extern HRESULT WslLaunch([NativeTypeName("PCWSTR")] ushort* distributionName, [NativeTypeName("PCWSTR")] ushort* command, BOOL useCurrentWorkingDirectory, HANDLE stdIn, HANDLE stdOut, HANDLE stdErr, HANDLE* process);
    [NativeTypeName("#define WSL_DISTRIBUTION_FLAGS_VALID (WSL_DISTRIBUTION_FLAGS_ENABLE_INTEROP | WSL_DISTRIBUTION_FLAGS_APPEND_NT_PATH | WSL_DISTRIBUTION_FLAGS_ENABLE_DRIVE_MOUNTING)")]
    public const WSL_DISTRIBUTION_FLAGS WSL_DISTRIBUTION_FLAGS_VALID = (WSL_DISTRIBUTION_FLAGS_ENABLE_INTEROP | WSL_DISTRIBUTION_FLAGS_APPEND_NT_PATH | WSL_DISTRIBUTION_FLAGS_ENABLE_DRIVE_MOUNTING);
    [NativeTypeName("#define WSL_DISTRIBUTION_FLAGS_DEFAULT (WSL_DISTRIBUTION_FLAGS_ENABLE_INTEROP | WSL_DISTRIBUTION_FLAGS_APPEND_NT_PATH | WSL_DISTRIBUTION_FLAGS_ENABLE_DRIVE_MOUNTING)")]
    public const WSL_DISTRIBUTION_FLAGS WSL_DISTRIBUTION_FLAGS_DEFAULT = (WSL_DISTRIBUTION_FLAGS_ENABLE_INTEROP | WSL_DISTRIBUTION_FLAGS_APPEND_NT_PATH | WSL_DISTRIBUTION_FLAGS_ENABLE_DRIVE_MOUNTING);
}