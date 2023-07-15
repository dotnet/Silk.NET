// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WORD_SIZEDARR.xml' path='doc/member[@name="WORD_SIZEDARR"]/*'/>
public unsafe partial struct WORD_SIZEDARR
{
    /// <include file='WORD_SIZEDARR.xml' path='doc/member[@name="WORD_SIZEDARR.clSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint clSize;
    /// <include file='WORD_SIZEDARR.xml' path='doc/member[@name="WORD_SIZEDARR.pData"]/*'/>
    [NativeTypeName("unsigned short *")]
    public ushort* pData;
}