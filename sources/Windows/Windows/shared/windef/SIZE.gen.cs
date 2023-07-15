// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/windef.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SIZE.xml' path='doc/member[@name="SIZE"]/*'/>
public partial struct SIZE
{
    /// <include file='SIZE.xml' path='doc/member[@name="SIZE.cx"]/*'/>
    [NativeTypeName("LONG")]
    public int cx;
    /// <include file='SIZE.xml' path='doc/member[@name="SIZE.cy"]/*'/>
    [NativeTypeName("LONG")]
    public int cy;
}