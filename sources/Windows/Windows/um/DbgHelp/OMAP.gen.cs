// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='OMAP.xml' path='doc/member[@name="OMAP"]/*' />
public partial struct OMAP
{
    /// <include file='OMAP.xml' path='doc/member[@name="OMAP.rva"]/*' />
    [NativeTypeName("ULONG")]
    public uint rva;

    /// <include file='OMAP.xml' path='doc/member[@name="OMAP.rvaTo"]/*' />
    [NativeTypeName("ULONG")]
    public uint rvaTo;
}
