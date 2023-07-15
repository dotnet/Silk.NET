// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='REMSECURITY_ATTRIBUTES.xml' path='doc/member[@name="REMSECURITY_ATTRIBUTES"]/*'/>
public partial struct REMSECURITY_ATTRIBUTES
{
    /// <include file='REMSECURITY_ATTRIBUTES.xml' path='doc/member[@name="REMSECURITY_ATTRIBUTES.nLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nLength;
    /// <include file='REMSECURITY_ATTRIBUTES.xml' path='doc/member[@name="REMSECURITY_ATTRIBUTES.lpSecurityDescriptor"]/*'/>
    [NativeTypeName("DWORD")]
    public uint lpSecurityDescriptor;
    /// <include file='REMSECURITY_ATTRIBUTES.xml' path='doc/member[@name="REMSECURITY_ATTRIBUTES.bInheritHandle"]/*'/>
    public BOOL bInheritHandle;
}