// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='MFT_REGISTRATION_INFO.xml' path='doc/member[@name="MFT_REGISTRATION_INFO"]/*'/>
public unsafe partial struct MFT_REGISTRATION_INFO
{
    /// <include file='MFT_REGISTRATION_INFO.xml' path='doc/member[@name="MFT_REGISTRATION_INFO.clsid"]/*'/>
    [NativeTypeName("CLSID")]
    public Guid clsid;
    /// <include file='MFT_REGISTRATION_INFO.xml' path='doc/member[@name="MFT_REGISTRATION_INFO.guidCategory"]/*'/>
    public Guid guidCategory;
    /// <include file='MFT_REGISTRATION_INFO.xml' path='doc/member[@name="MFT_REGISTRATION_INFO.uiFlags"]/*'/>
    [NativeTypeName("UINT32")]
    public uint uiFlags;
    /// <include file='MFT_REGISTRATION_INFO.xml' path='doc/member[@name="MFT_REGISTRATION_INFO.pszName"]/*'/>
    [NativeTypeName("LPCWSTR")]
    public ushort* pszName;
    /// <include file='MFT_REGISTRATION_INFO.xml' path='doc/member[@name="MFT_REGISTRATION_INFO.cInTypes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cInTypes;
    /// <include file='MFT_REGISTRATION_INFO.xml' path='doc/member[@name="MFT_REGISTRATION_INFO.pInTypes"]/*'/>
    public MFT_REGISTER_TYPE_INFO* pInTypes;
    /// <include file='MFT_REGISTRATION_INFO.xml' path='doc/member[@name="MFT_REGISTRATION_INFO.cOutTypes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cOutTypes;
    /// <include file='MFT_REGISTRATION_INFO.xml' path='doc/member[@name="MFT_REGISTRATION_INFO.pOutTypes"]/*'/>
    public MFT_REGISTER_TYPE_INFO* pOutTypes;
}