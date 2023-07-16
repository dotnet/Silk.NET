// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/windef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='RECT.xml' path='doc/member[@name="RECT"]/*'/>
public partial struct RECT
{
    /// <include file='RECT.xml' path='doc/member[@name="RECT.left"]/*'/>
    [NativeTypeName("LONG")]
    public int left;
    /// <include file='RECT.xml' path='doc/member[@name="RECT.top"]/*'/>
    [NativeTypeName("LONG")]
    public int top;
    /// <include file='RECT.xml' path='doc/member[@name="RECT.right"]/*'/>
    [NativeTypeName("LONG")]
    public int right;
    /// <include file='RECT.xml' path='doc/member[@name="RECT.bottom"]/*'/>
    [NativeTypeName("LONG")]
    public int bottom;
}