// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='RemFORMATETC.xml' path='doc/member[@name="RemFORMATETC"]/*'/>
public partial struct RemFORMATETC
{
    /// <include file='RemFORMATETC.xml' path='doc/member[@name="RemFORMATETC.cfFormat"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cfFormat;
    /// <include file='RemFORMATETC.xml' path='doc/member[@name="RemFORMATETC.ptd"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ptd;
    /// <include file='RemFORMATETC.xml' path='doc/member[@name="RemFORMATETC.dwAspect"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAspect;
    /// <include file='RemFORMATETC.xml' path='doc/member[@name="RemFORMATETC.lindex"]/*'/>
    [NativeTypeName("LONG")]
    public int lindex;
    /// <include file='RemFORMATETC.xml' path='doc/member[@name="RemFORMATETC.tymed"]/*'/>
    [NativeTypeName("DWORD")]
    public uint tymed;
}