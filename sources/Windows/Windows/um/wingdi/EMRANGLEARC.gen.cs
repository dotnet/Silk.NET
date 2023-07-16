// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EMRANGLEARC.xml' path='doc/member[@name="EMRANGLEARC"]/*'/>
public partial struct EMRANGLEARC
{
    /// <include file='EMRANGLEARC.xml' path='doc/member[@name="EMRANGLEARC.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRANGLEARC.xml' path='doc/member[@name="EMRANGLEARC.ptlCenter"]/*'/>
    public POINTL ptlCenter;
    /// <include file='EMRANGLEARC.xml' path='doc/member[@name="EMRANGLEARC.nRadius"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nRadius;
    /// <include file='EMRANGLEARC.xml' path='doc/member[@name="EMRANGLEARC.eStartAngle"]/*'/>
    public float eStartAngle;
    /// <include file='EMRANGLEARC.xml' path='doc/member[@name="EMRANGLEARC.eSweepAngle"]/*'/>
    public float eSweepAngle;
}