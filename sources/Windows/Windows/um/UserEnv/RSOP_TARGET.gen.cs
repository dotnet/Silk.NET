// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='RSOP_TARGET.xml' path='doc/member[@name="RSOP_TARGET"]/*'/>
public unsafe partial struct RSOP_TARGET
{
    /// <include file='RSOP_TARGET.xml' path='doc/member[@name="RSOP_TARGET.pwszAccountName"]/*'/>
    [NativeTypeName("WCHAR *")]
    public ushort* pwszAccountName;
    /// <include file='RSOP_TARGET.xml' path='doc/member[@name="RSOP_TARGET.pwszNewSOM"]/*'/>
    [NativeTypeName("WCHAR *")]
    public ushort* pwszNewSOM;
    /// <include file='RSOP_TARGET.xml' path='doc/member[@name="RSOP_TARGET.psaSecurityGroups"]/*'/>
    public SAFEARRAY* psaSecurityGroups;
    /// <include file='RSOP_TARGET.xml' path='doc/member[@name="RSOP_TARGET.pRsopToken"]/*'/>
    [NativeTypeName("PRSOPTOKEN")]
    public void* pRsopToken;
    /// <include file='RSOP_TARGET.xml' path='doc/member[@name="RSOP_TARGET.pGPOList"]/*'/>
    [NativeTypeName("PGROUP_POLICY_OBJECT")]
    public GROUP_POLICY_OBJECTW* pGPOList;
    /// <include file='RSOP_TARGET.xml' path='doc/member[@name="RSOP_TARGET.pWbemServices"]/*'/>
    public IWbemServices* pWbemServices;
}