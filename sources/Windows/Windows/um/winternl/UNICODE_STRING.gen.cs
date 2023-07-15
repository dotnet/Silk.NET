// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='UNICODE_STRING.xml' path='doc/member[@name="UNICODE_STRING"]/*'/>
public unsafe partial struct UNICODE_STRING
{
    /// <include file='UNICODE_STRING.xml' path='doc/member[@name="UNICODE_STRING.Length"]/*'/>
    public ushort Length;
    /// <include file='UNICODE_STRING.xml' path='doc/member[@name="UNICODE_STRING.MaximumLength"]/*'/>
    public ushort MaximumLength;
    /// <include file='UNICODE_STRING.xml' path='doc/member[@name="UNICODE_STRING.Buffer"]/*'/>
    [NativeTypeName("PWSTR")]
    public ushort* Buffer;
}