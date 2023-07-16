// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EMRCREATEDIBPATTERNBRUSHPT.xml' path='doc/member[@name="EMRCREATEDIBPATTERNBRUSHPT"]/*'/>
public partial struct EMRCREATEDIBPATTERNBRUSHPT
{
    /// <include file='EMRCREATEDIBPATTERNBRUSHPT.xml' path='doc/member[@name="EMRCREATEDIBPATTERNBRUSHPT.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRCREATEDIBPATTERNBRUSHPT.xml' path='doc/member[@name="EMRCREATEDIBPATTERNBRUSHPT.ihBrush"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ihBrush;
    /// <include file='EMRCREATEDIBPATTERNBRUSHPT.xml' path='doc/member[@name="EMRCREATEDIBPATTERNBRUSHPT.iUsage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iUsage;
    /// <include file='EMRCREATEDIBPATTERNBRUSHPT.xml' path='doc/member[@name="EMRCREATEDIBPATTERNBRUSHPT.offBmi"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offBmi;
    /// <include file='EMRCREATEDIBPATTERNBRUSHPT.xml' path='doc/member[@name="EMRCREATEDIBPATTERNBRUSHPT.cbBmi"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbBmi;
    /// <include file='EMRCREATEDIBPATTERNBRUSHPT.xml' path='doc/member[@name="EMRCREATEDIBPATTERNBRUSHPT.offBits"]/*'/>
    [NativeTypeName("DWORD")]
    public uint offBits;
    /// <include file='EMRCREATEDIBPATTERNBRUSHPT.xml' path='doc/member[@name="EMRCREATEDIBPATTERNBRUSHPT.cbBits"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbBits;
}