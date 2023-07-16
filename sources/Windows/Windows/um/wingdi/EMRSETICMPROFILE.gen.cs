// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EMRSETICMPROFILE.xml' path='doc/member[@name="EMRSETICMPROFILE"]/*'/>
public unsafe partial struct EMRSETICMPROFILE
{
    /// <include file='EMRSETICMPROFILE.xml' path='doc/member[@name="EMRSETICMPROFILE.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRSETICMPROFILE.xml' path='doc/member[@name="EMRSETICMPROFILE.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='EMRSETICMPROFILE.xml' path='doc/member[@name="EMRSETICMPROFILE.cbName"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbName;
    /// <include file='EMRSETICMPROFILE.xml' path='doc/member[@name="EMRSETICMPROFILE.cbData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbData;
    /// <include file='EMRSETICMPROFILE.xml' path='doc/member[@name="EMRSETICMPROFILE.Data"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte Data[1];
}