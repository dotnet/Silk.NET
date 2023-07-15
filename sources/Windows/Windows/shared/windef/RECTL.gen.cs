// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/windef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='RECTL.xml' path='doc/member[@name="RECTL"]/*'/>
public partial struct RECTL
{
    /// <include file='RECTL.xml' path='doc/member[@name="RECTL.left"]/*'/>
    [NativeTypeName("LONG")]
    public int left;
    /// <include file='RECTL.xml' path='doc/member[@name="RECTL.top"]/*'/>
    [NativeTypeName("LONG")]
    public int top;
    /// <include file='RECTL.xml' path='doc/member[@name="RECTL.right"]/*'/>
    [NativeTypeName("LONG")]
    public int right;
    /// <include file='RECTL.xml' path='doc/member[@name="RECTL.bottom"]/*'/>
    [NativeTypeName("LONG")]
    public int bottom;
}