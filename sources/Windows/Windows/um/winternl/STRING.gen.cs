// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='STRING.xml' path='doc/member[@name="STRING"]/*'/>
public unsafe partial struct STRING
{
    /// <include file='STRING.xml' path='doc/member[@name="STRING.Length"]/*'/>
    public ushort Length;
    /// <include file='STRING.xml' path='doc/member[@name="STRING.MaximumLength"]/*'/>
    public ushort MaximumLength;
    /// <include file='STRING.xml' path='doc/member[@name="STRING.Buffer"]/*'/>
    [NativeTypeName("PCHAR")]
    public sbyte* Buffer;
}