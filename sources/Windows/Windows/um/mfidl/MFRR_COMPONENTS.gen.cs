// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MFRR_COMPONENTS.xml' path='doc/member[@name="MFRR_COMPONENTS"]/*'/>
public unsafe partial struct MFRR_COMPONENTS
{
    /// <include file='MFRR_COMPONENTS.xml' path='doc/member[@name="MFRR_COMPONENTS.dwRRInfoVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRRInfoVersion;
    /// <include file='MFRR_COMPONENTS.xml' path='doc/member[@name="MFRR_COMPONENTS.dwRRComponents"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRRComponents;
    /// <include file='MFRR_COMPONENTS.xml' path='doc/member[@name="MFRR_COMPONENTS.pRRComponents"]/*'/>
    [NativeTypeName("PMFRR_COMPONENT_HASH_INFO")]
    public MFRR_COMPONENT_HASH_INFO* pRRComponents;
}