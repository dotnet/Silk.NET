// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CMS_KEY_INFO.xml' path='doc/member[@name="CMS_KEY_INFO"]/*'/>
public unsafe partial struct CMS_KEY_INFO
{
    /// <include file='CMS_KEY_INFO.xml' path='doc/member[@name="CMS_KEY_INFO.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='CMS_KEY_INFO.xml' path='doc/member[@name="CMS_KEY_INFO.Algid"]/*'/>
    [NativeTypeName("ALG_ID")]
    public uint Algid;
    /// <include file='CMS_KEY_INFO.xml' path='doc/member[@name="CMS_KEY_INFO.pbOID"]/*'/>
    public byte* pbOID;
    /// <include file='CMS_KEY_INFO.xml' path='doc/member[@name="CMS_KEY_INFO.cbOID"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbOID;
}