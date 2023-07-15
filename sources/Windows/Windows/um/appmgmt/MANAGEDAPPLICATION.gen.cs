// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/appmgmt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION"]/*'/>
public unsafe partial struct MANAGEDAPPLICATION
{
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.pszPackageName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszPackageName;
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.pszPublisher"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszPublisher;
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.dwVersionHi"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersionHi;
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.dwVersionLo"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersionLo;
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.dwRevision"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwRevision;
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.GpoId"]/*'/>
    public Guid GpoId;
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.pszPolicyName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszPolicyName;
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.ProductId"]/*'/>
    public Guid ProductId;
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.Language"]/*'/>
    [NativeTypeName("LANGID")]
    public ushort Language;
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.pszOwner"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszOwner;
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.pszCompany"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszCompany;
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.pszComments"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszComments;
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.pszContact"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszContact;
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.pszSupportUrl"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* pszSupportUrl;
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.dwPathType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPathType;
    /// <include file='MANAGEDAPPLICATION.xml' path='doc/member[@name="MANAGEDAPPLICATION.bInstalled"]/*'/>
    public BOOL bInstalled;
}