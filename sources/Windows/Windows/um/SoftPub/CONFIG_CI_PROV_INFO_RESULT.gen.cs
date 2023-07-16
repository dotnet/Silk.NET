// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CONFIG_CI_PROV_INFO_RESULT.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO_RESULT"]/*'/>
public unsafe partial struct CONFIG_CI_PROV_INFO_RESULT
{
    /// <include file='CONFIG_CI_PROV_INFO_RESULT.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO_RESULT.hr"]/*'/>
    public HRESULT hr;
    /// <include file='CONFIG_CI_PROV_INFO_RESULT.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO_RESULT.dwResult"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwResult;
    /// <include file='CONFIG_CI_PROV_INFO_RESULT.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO_RESULT.dwPolicyIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPolicyIndex;
    /// <include file='CONFIG_CI_PROV_INFO_RESULT.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO_RESULT.fIsExplicitDeny"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte fIsExplicitDeny;
    /// <include file='CONFIG_CI_PROV_INFO_RESULT.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO_RESULT.pbCalculatedFileHash"]/*'/>
    public byte* pbCalculatedFileHash;
    /// <include file='CONFIG_CI_PROV_INFO_RESULT.xml' path='doc/member[@name="CONFIG_CI_PROV_INFO_RESULT.cbCalculatedFileHash"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbCalculatedFileHash;
}