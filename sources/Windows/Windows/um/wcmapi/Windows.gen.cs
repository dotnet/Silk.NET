// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcmQueryProperty"]/*'/>
    [DllImport("wcmapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint WcmQueryProperty([NativeTypeName("const GUID *")] Guid* pInterface, [NativeTypeName("LPCWSTR")] ushort* strProfileName, WCM_PROPERTY Property, void* pReserved, [NativeTypeName("PDWORD")] uint* pdwDataSize, [NativeTypeName("PBYTE *")] byte** ppData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcmSetProperty"]/*'/>
    [DllImport("wcmapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint WcmSetProperty([NativeTypeName("const GUID *")] Guid* pInterface, [NativeTypeName("LPCWSTR")] ushort* strProfileName, WCM_PROPERTY Property, void* pReserved, [NativeTypeName("DWORD")] uint dwDataSize, [NativeTypeName("const BYTE *")] byte* pbData);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcmGetProfileList"]/*'/>
    [DllImport("wcmapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint WcmGetProfileList(void* pReserved, WCM_PROFILE_INFO_LIST** ppProfileList);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcmSetProfileList"]/*'/>
    [DllImport("wcmapi", ExactSpelling = true)]
    [return: NativeTypeName("DWORD")]
    [SupportedOSPlatform("windows6.2")]
    public static extern uint WcmSetProfileList(WCM_PROFILE_INFO_LIST* pProfileList, [NativeTypeName("DWORD")] uint dwPosition, BOOL fIgnoreUnknownProfiles, void* pReserved);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.WcmFreeMemory"]/*'/>
    [DllImport("wcmapi", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern void WcmFreeMemory(void* pMemory);
    [NativeTypeName("#define WCM_API_VERSION_1_0 0x00000001")]
    public const int WCM_API_VERSION_1_0 = 0x00000001;
    [NativeTypeName("#define WCM_API_VERSION WCM_API_VERSION_1_0")]
    public const int WCM_API_VERSION = 0x00000001;
    [NativeTypeName("#define WCM_UNKNOWN_DATAPLAN_STATUS 0xFFFFFFFF")]
    public const uint WCM_UNKNOWN_DATAPLAN_STATUS = 0xFFFFFFFF;
    [NativeTypeName("#define WCM_MAX_PROFILE_NAME 256")]
    public const int WCM_MAX_PROFILE_NAME = 256;
}