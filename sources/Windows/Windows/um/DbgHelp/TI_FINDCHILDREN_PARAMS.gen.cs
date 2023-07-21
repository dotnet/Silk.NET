// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TI_FINDCHILDREN_PARAMS.xml' path='doc/member[@name="TI_FINDCHILDREN_PARAMS"]/*' />
public unsafe partial struct TI_FINDCHILDREN_PARAMS
{
    /// <include file='TI_FINDCHILDREN_PARAMS.xml' path='doc/member[@name="TI_FINDCHILDREN_PARAMS.Count"]/*' />
    [NativeTypeName("ULONG")]
    public uint Count;

    /// <include file='TI_FINDCHILDREN_PARAMS.xml' path='doc/member[@name="TI_FINDCHILDREN_PARAMS.Start"]/*' />
    [NativeTypeName("ULONG")]
    public uint Start;

    /// <include file='TI_FINDCHILDREN_PARAMS.xml' path='doc/member[@name="TI_FINDCHILDREN_PARAMS.ChildId"]/*' />
    [NativeTypeName("ULONG[1]")]
    public fixed uint ChildId[1];
}
