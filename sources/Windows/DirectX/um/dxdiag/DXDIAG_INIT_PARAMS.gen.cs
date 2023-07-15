// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dxdiag.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='DXDIAG_INIT_PARAMS.xml' path='doc/member[@name="DXDIAG_INIT_PARAMS"]/*'/>
public unsafe partial struct DXDIAG_INIT_PARAMS
{
    /// <include file='DXDIAG_INIT_PARAMS.xml' path='doc/member[@name="DXDIAG_INIT_PARAMS.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='DXDIAG_INIT_PARAMS.xml' path='doc/member[@name="DXDIAG_INIT_PARAMS.dwDxDiagHeaderVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDxDiagHeaderVersion;
    /// <include file='DXDIAG_INIT_PARAMS.xml' path='doc/member[@name="DXDIAG_INIT_PARAMS.bAllowWHQLChecks"]/*'/>
    public BOOL bAllowWHQLChecks;
    /// <include file='DXDIAG_INIT_PARAMS.xml' path='doc/member[@name="DXDIAG_INIT_PARAMS.pReserved"]/*'/>
    public void* pReserved;
}