// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/LsaLookup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='LSA_UNICODE_STRING.xml' path='doc/member[@name="LSA_UNICODE_STRING"]/*' />
public unsafe partial struct LSA_UNICODE_STRING
{
    /// <include file='LSA_UNICODE_STRING.xml' path='doc/member[@name="LSA_UNICODE_STRING.Length"]/*' />
    public ushort Length;

    /// <include file='LSA_UNICODE_STRING.xml' path='doc/member[@name="LSA_UNICODE_STRING.MaximumLength"]/*' />
    public ushort MaximumLength;

    /// <include file='LSA_UNICODE_STRING.xml' path='doc/member[@name="LSA_UNICODE_STRING.Buffer"]/*' />
    [NativeTypeName("PWSTR")]
    public ushort* Buffer;
}
