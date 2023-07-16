// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/wtypesbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HYPER_SIZEDARR.xml' path='doc/member[@name="HYPER_SIZEDARR"]/*'/>
public unsafe partial struct HYPER_SIZEDARR
{
    /// <include file='HYPER_SIZEDARR.xml' path='doc/member[@name="HYPER_SIZEDARR.clSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint clSize;
    /// <include file='HYPER_SIZEDARR.xml' path='doc/member[@name="HYPER_SIZEDARR.pData"]/*'/>
    [NativeTypeName("long long *")]
    public long* pData;
}