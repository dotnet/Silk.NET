// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SCH_CRED_SECRET_CAPI.xml' path='doc/member[@name="SCH_CRED_SECRET_CAPI"]/*'/>
public partial struct SCH_CRED_SECRET_CAPI
{
    /// <include file='SCH_CRED_SECRET_CAPI.xml' path='doc/member[@name="SCH_CRED_SECRET_CAPI.dwType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwType;
    /// <include file='SCH_CRED_SECRET_CAPI.xml' path='doc/member[@name="SCH_CRED_SECRET_CAPI.hProv"]/*'/>
    public HCRYPTPROV hProv;
}