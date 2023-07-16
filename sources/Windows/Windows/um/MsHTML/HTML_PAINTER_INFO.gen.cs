// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='HTML_PAINTER_INFO.xml' path='doc/member[@name="HTML_PAINTER_INFO"]/*'/>
public partial struct HTML_PAINTER_INFO
{
    /// <include file='HTML_PAINTER_INFO.xml' path='doc/member[@name="HTML_PAINTER_INFO.lFlags"]/*'/>
    [NativeTypeName("LONG")]
    public int lFlags;
    /// <include file='HTML_PAINTER_INFO.xml' path='doc/member[@name="HTML_PAINTER_INFO.lZOrder"]/*'/>
    [NativeTypeName("LONG")]
    public int lZOrder;
    /// <include file='HTML_PAINTER_INFO.xml' path='doc/member[@name="HTML_PAINTER_INFO.iidDrawObject"]/*'/>
    [NativeTypeName("IID")]
    public Guid iidDrawObject;
    /// <include file='HTML_PAINTER_INFO.xml' path='doc/member[@name="HTML_PAINTER_INFO.rcExpand"]/*'/>
    public RECT rcExpand;
}