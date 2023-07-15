// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CORRELATION_VECTOR.xml' path='doc/member[@name="CORRELATION_VECTOR"]/*'/>
public unsafe partial struct CORRELATION_VECTOR
{
    /// <include file='CORRELATION_VECTOR.xml' path='doc/member[@name="CORRELATION_VECTOR.Version"]/*'/>
    [NativeTypeName("CHAR")]
    public sbyte Version;
    /// <include file='CORRELATION_VECTOR.xml' path='doc/member[@name="CORRELATION_VECTOR.Vector"]/*'/>
    [NativeTypeName("CHAR[129]")]
    public fixed sbyte Vector[129];
}