// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EMRCREATEMONOBRUSH.xml' path='doc/member[@name="EMRCREATEMONOBRUSH"]/*'/>
public partial struct EMRCREATEMONOBRUSH
{
    /// <include file='EMRCREATEMONOBRUSH.xml' path='doc/member[@name="EMRCREATEMONOBRUSH.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRCREATEMONOBRUSH.xml' path='doc/member[@name="EMRCREATEMONOBRUSH.ihBrush"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ihBrush;
    /// <include file='EMRCREATEMONOBRUSH.xml' path='doc/member[@name="EMRCREATEMONOBRUSH.iUsage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iUsage;
    /// <include file='EMRCREATEMONOBRUSH.xml' path='doc/member[@name="EMRCREATEMONOBRUSH.offBmi"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offBmi;
    /// <include file='EMRCREATEMONOBRUSH.xml' path='doc/member[@name="EMRCREATEMONOBRUSH.cbBmi"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbBmi;
    /// <include file='EMRCREATEMONOBRUSH.xml' path='doc/member[@name="EMRCREATEMONOBRUSH.offBits"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offBits;
    /// <include file='EMRCREATEMONOBRUSH.xml' path='doc/member[@name="EMRCREATEMONOBRUSH.cbBits"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbBits;
}