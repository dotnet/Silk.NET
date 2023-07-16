// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PUBLIC_OBJECT_TYPE_INFORMATION.xml' path='doc/member[@name="PUBLIC_OBJECT_TYPE_INFORMATION"]/*'/>
public unsafe partial struct PUBLIC_OBJECT_TYPE_INFORMATION
{
    /// <include file='PUBLIC_OBJECT_TYPE_INFORMATION.xml' path='doc/member[@name="PUBLIC_OBJECT_TYPE_INFORMATION.TypeName"]/*'/>
    public UNICODE_STRING TypeName;
    /// <include file='PUBLIC_OBJECT_TYPE_INFORMATION.xml' path='doc/member[@name="PUBLIC_OBJECT_TYPE_INFORMATION.Reserved"]/*'/>
    [NativeTypeName("ULONG[22]")]
    public fixed uint Reserved[22];
}