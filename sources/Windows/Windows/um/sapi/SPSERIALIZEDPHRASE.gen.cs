// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SPSERIALIZEDPHRASE.xml' path='doc/member[@name="SPSERIALIZEDPHRASE"]/*'/>
public partial struct SPSERIALIZEDPHRASE
{
    /// <include file='SPSERIALIZEDPHRASE.xml' path='doc/member[@name="SPSERIALIZEDPHRASE.ulSerializedSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulSerializedSize;
}