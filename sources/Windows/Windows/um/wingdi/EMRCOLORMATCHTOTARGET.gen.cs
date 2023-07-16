// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EMRCOLORMATCHTOTARGET.xml' path='doc/member[@name="EMRCOLORMATCHTOTARGET"]/*'/>
public unsafe partial struct EMRCOLORMATCHTOTARGET
{
    /// <include file='EMRCOLORMATCHTOTARGET.xml' path='doc/member[@name="EMRCOLORMATCHTOTARGET.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRCOLORMATCHTOTARGET.xml' path='doc/member[@name="EMRCOLORMATCHTOTARGET.dwAction"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwAction;
    /// <include file='EMRCOLORMATCHTOTARGET.xml' path='doc/member[@name="EMRCOLORMATCHTOTARGET.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='EMRCOLORMATCHTOTARGET.xml' path='doc/member[@name="EMRCOLORMATCHTOTARGET.cbName"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbName;
    /// <include file='EMRCOLORMATCHTOTARGET.xml' path='doc/member[@name="EMRCOLORMATCHTOTARGET.cbData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbData;
    /// <include file='EMRCOLORMATCHTOTARGET.xml' path='doc/member[@name="EMRCOLORMATCHTOTARGET.Data"]/*'/>
    [NativeTypeName("BYTE[1]")]
    public fixed byte Data[1];
}