// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KEY_VALUE_ENTRY.xml' path='doc/member[@name="KEY_VALUE_ENTRY"]/*'/>
public unsafe partial struct KEY_VALUE_ENTRY
{
    /// <include file='KEY_VALUE_ENTRY.xml' path='doc/member[@name="KEY_VALUE_ENTRY.ValueName"]/*'/>
    [NativeTypeName("PUNICODE_STRING")]
    public UNICODE_STRING* ValueName;
    /// <include file='KEY_VALUE_ENTRY.xml' path='doc/member[@name="KEY_VALUE_ENTRY.DataLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint DataLength;
    /// <include file='KEY_VALUE_ENTRY.xml' path='doc/member[@name="KEY_VALUE_ENTRY.DataOffset"]/*'/>
    [NativeTypeName("ULONG")]
    public uint DataOffset;
    /// <include file='KEY_VALUE_ENTRY.xml' path='doc/member[@name="KEY_VALUE_ENTRY.Type"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Type;
}