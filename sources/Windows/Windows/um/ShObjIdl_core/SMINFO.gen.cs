// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SMINFO.xml' path='doc/member[@name="SMINFO"]/*'/>
public partial struct SMINFO
{
    /// <include file='SMINFO.xml' path='doc/member[@name="SMINFO.dwMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMask;
    /// <include file='SMINFO.xml' path='doc/member[@name="SMINFO.dwType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwType;
    /// <include file='SMINFO.xml' path='doc/member[@name="SMINFO.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='SMINFO.xml' path='doc/member[@name="SMINFO.iIcon"]/*'/>
    public int iIcon;
}