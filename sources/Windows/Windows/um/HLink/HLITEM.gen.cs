// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/HLink.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='HLITEM.xml' path='doc/member[@name="HLITEM"]/*' />
public unsafe partial struct HLITEM
{
    /// <include file='HLITEM.xml' path='doc/member[@name="HLITEM.uHLID"]/*' />
    [NativeTypeName("ULONG")]
    public uint uHLID;

    /// <include file='HLITEM.xml' path='doc/member[@name="HLITEM.pwzFriendlyName"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* pwzFriendlyName;
}
