// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SPC_SERIALIZED_OBJECT.xml' path='doc/member[@name="SPC_SERIALIZED_OBJECT"]/*'/>
public unsafe partial struct SPC_SERIALIZED_OBJECT
{
    /// <include file='SPC_SERIALIZED_OBJECT.xml' path='doc/member[@name="SPC_SERIALIZED_OBJECT.ClassId"]/*'/>
    [NativeTypeName("SPC_UUID")]
    public fixed byte ClassId[16];
    /// <include file='SPC_SERIALIZED_OBJECT.xml' path='doc/member[@name="SPC_SERIALIZED_OBJECT.SerializedData"]/*'/>
    public CRYPT_DATA_BLOB SerializedData;
}