// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PELARRAY.xml' path='doc/member[@name="PELARRAY"]/*'/>
public partial struct PELARRAY
{
    /// <include file='PELARRAY.xml' path='doc/member[@name="PELARRAY.paXCount"]/*'/>
    [NativeTypeName("LONG")]
    public int paXCount;
    /// <include file='PELARRAY.xml' path='doc/member[@name="PELARRAY.paYCount"]/*'/>
    [NativeTypeName("LONG")]
    public int paYCount;
    /// <include file='PELARRAY.xml' path='doc/member[@name="PELARRAY.paXExt"]/*'/>
    [NativeTypeName("LONG")]
    public int paXExt;
    /// <include file='PELARRAY.xml' path='doc/member[@name="PELARRAY.paYExt"]/*'/>
    [NativeTypeName("LONG")]
    public int paYExt;
    /// <include file='PELARRAY.xml' path='doc/member[@name="PELARRAY.paRGBs"]/*'/>
    public byte paRGBs;
}