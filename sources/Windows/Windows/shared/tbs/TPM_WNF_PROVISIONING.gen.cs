// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/tbs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TPM_WNF_PROVISIONING.xml' path='doc/member[@name="TPM_WNF_PROVISIONING"]/*'/>
public unsafe partial struct TPM_WNF_PROVISIONING
{
    /// <include file='TPM_WNF_PROVISIONING.xml' path='doc/member[@name="TPM_WNF_PROVISIONING.status"]/*'/>
    [NativeTypeName("UINT32")]
    public uint status;
    /// <include file='TPM_WNF_PROVISIONING.xml' path='doc/member[@name="TPM_WNF_PROVISIONING.message"]/*'/>
    [NativeTypeName("BYTE[28]")]
    public fixed byte message[28];
}