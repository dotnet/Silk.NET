// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ALLOCATOR_PROPERTIES.xml' path='doc/member[@name="ALLOCATOR_PROPERTIES"]/*'/>
public partial struct ALLOCATOR_PROPERTIES
{
    /// <include file='ALLOCATOR_PROPERTIES.xml' path='doc/member[@name="ALLOCATOR_PROPERTIES.cBuffers"]/*'/>
    [NativeTypeName("long")]
    public int cBuffers;
    /// <include file='ALLOCATOR_PROPERTIES.xml' path='doc/member[@name="ALLOCATOR_PROPERTIES.cbBuffer"]/*'/>
    [NativeTypeName("long")]
    public int cbBuffer;
    /// <include file='ALLOCATOR_PROPERTIES.xml' path='doc/member[@name="ALLOCATOR_PROPERTIES.cbAlign"]/*'/>
    [NativeTypeName("long")]
    public int cbAlign;
    /// <include file='ALLOCATOR_PROPERTIES.xml' path='doc/member[@name="ALLOCATOR_PROPERTIES.cbPrefix"]/*'/>
    [NativeTypeName("long")]
    public int cbPrefix;
}