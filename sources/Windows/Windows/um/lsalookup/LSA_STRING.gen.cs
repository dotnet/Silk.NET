// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/LsaLookup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='LSA_STRING.xml' path='doc/member[@name="LSA_STRING"]/*'/>
public unsafe partial struct LSA_STRING
{
    /// <include file='LSA_STRING.xml' path='doc/member[@name="LSA_STRING.Length"]/*'/>
    public ushort Length;
    /// <include file='LSA_STRING.xml' path='doc/member[@name="LSA_STRING.MaximumLength"]/*'/>
    public ushort MaximumLength;
    /// <include file='LSA_STRING.xml' path='doc/member[@name="LSA_STRING.Buffer"]/*'/>
    [NativeTypeName("PCHAR")]
    public sbyte* Buffer;
}