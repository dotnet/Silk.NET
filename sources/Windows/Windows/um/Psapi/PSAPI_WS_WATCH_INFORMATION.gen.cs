// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PSAPI_WS_WATCH_INFORMATION.xml' path='doc/member[@name="PSAPI_WS_WATCH_INFORMATION"]/*'/>
public unsafe partial struct PSAPI_WS_WATCH_INFORMATION
{
    /// <include file='PSAPI_WS_WATCH_INFORMATION.xml' path='doc/member[@name="PSAPI_WS_WATCH_INFORMATION.FaultingPc"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* FaultingPc;
    /// <include file='PSAPI_WS_WATCH_INFORMATION.xml' path='doc/member[@name="PSAPI_WS_WATCH_INFORMATION.FaultingVa"]/*'/>
    [NativeTypeName("LPVOID")]
    public void* FaultingVa;
}