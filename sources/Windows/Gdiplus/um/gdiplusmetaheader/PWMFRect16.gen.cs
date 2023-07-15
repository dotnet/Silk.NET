// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusmetaheader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
/// <include file='PWMFRect16.xml' path='doc/member[@name="PWMFRect16"]/*'/>
public partial struct PWMFRect16
{
    /// <include file='PWMFRect16.xml' path='doc/member[@name="PWMFRect16.Left"]/*'/>
    [NativeTypeName("INT16")]
    public short Left;
    /// <include file='PWMFRect16.xml' path='doc/member[@name="PWMFRect16.Top"]/*'/>
    [NativeTypeName("INT16")]
    public short Top;
    /// <include file='PWMFRect16.xml' path='doc/member[@name="PWMFRect16.Right"]/*'/>
    [NativeTypeName("INT16")]
    public short Right;
    /// <include file='PWMFRect16.xml' path='doc/member[@name="PWMFRect16.Bottom"]/*'/>
    [NativeTypeName("INT16")]
    public short Bottom;
}