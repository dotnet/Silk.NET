// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='BSTRBLOB.xml' path='doc/member[@name="BSTRBLOB"]/*'/>
public unsafe partial struct BSTRBLOB
{
    /// <include file='BSTRBLOB.xml' path='doc/member[@name="BSTRBLOB.cbSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbSize;
    /// <include file='BSTRBLOB.xml' path='doc/member[@name="BSTRBLOB.pData"]/*'/>
    public byte* pData;
}