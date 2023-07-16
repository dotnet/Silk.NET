// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AM_PROPERTY_SPHLI.xml' path='doc/member[@name="AM_PROPERTY_SPHLI"]/*'/>
public partial struct AM_PROPERTY_SPHLI
{
    /// <include file='AM_PROPERTY_SPHLI.xml' path='doc/member[@name="AM_PROPERTY_SPHLI.HLISS"]/*'/>
    public ushort HLISS;
    /// <include file='AM_PROPERTY_SPHLI.xml' path='doc/member[@name="AM_PROPERTY_SPHLI.Reserved"]/*'/>
    public ushort Reserved;
    /// <include file='AM_PROPERTY_SPHLI.xml' path='doc/member[@name="AM_PROPERTY_SPHLI.StartPTM"]/*'/>
    [NativeTypeName("ULONG")]
    public uint StartPTM;
    /// <include file='AM_PROPERTY_SPHLI.xml' path='doc/member[@name="AM_PROPERTY_SPHLI.EndPTM"]/*'/>
    [NativeTypeName("ULONG")]
    public uint EndPTM;
    /// <include file='AM_PROPERTY_SPHLI.xml' path='doc/member[@name="AM_PROPERTY_SPHLI.StartX"]/*'/>
    public ushort StartX;
    /// <include file='AM_PROPERTY_SPHLI.xml' path='doc/member[@name="AM_PROPERTY_SPHLI.StartY"]/*'/>
    public ushort StartY;
    /// <include file='AM_PROPERTY_SPHLI.xml' path='doc/member[@name="AM_PROPERTY_SPHLI.StopX"]/*'/>
    public ushort StopX;
    /// <include file='AM_PROPERTY_SPHLI.xml' path='doc/member[@name="AM_PROPERTY_SPHLI.StopY"]/*'/>
    public ushort StopY;
    /// <include file='AM_PROPERTY_SPHLI.xml' path='doc/member[@name="AM_PROPERTY_SPHLI.ColCon"]/*'/>
    public AM_COLCON ColCon;
}