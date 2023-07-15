// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='METAFILEPICT.xml' path='doc/member[@name="METAFILEPICT"]/*'/>
public partial struct METAFILEPICT
{
    /// <include file='METAFILEPICT.xml' path='doc/member[@name="METAFILEPICT.mm"]/*'/>
    [NativeTypeName("LONG")]
    public int mm;
    /// <include file='METAFILEPICT.xml' path='doc/member[@name="METAFILEPICT.xExt"]/*'/>
    [NativeTypeName("LONG")]
    public int xExt;
    /// <include file='METAFILEPICT.xml' path='doc/member[@name="METAFILEPICT.yExt"]/*'/>
    [NativeTypeName("LONG")]
    public int yExt;
    /// <include file='METAFILEPICT.xml' path='doc/member[@name="METAFILEPICT.hMF"]/*'/>
    public HMETAFILE hMF;
}