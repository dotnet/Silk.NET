// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='GRADIENT_TRIANGLE.xml' path='doc/member[@name="GRADIENT_TRIANGLE"]/*'/>
public partial struct GRADIENT_TRIANGLE
{
    /// <include file='GRADIENT_TRIANGLE.xml' path='doc/member[@name="GRADIENT_TRIANGLE.Vertex1"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Vertex1;
    /// <include file='GRADIENT_TRIANGLE.xml' path='doc/member[@name="GRADIENT_TRIANGLE.Vertex2"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Vertex2;
    /// <include file='GRADIENT_TRIANGLE.xml' path='doc/member[@name="GRADIENT_TRIANGLE.Vertex3"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Vertex3;
}