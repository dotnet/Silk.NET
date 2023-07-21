// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ACTIVATION_CONTEXT_QUERY_INDEX.xml' path='doc/member[@name="ACTIVATION_CONTEXT_QUERY_INDEX"]/*' />
public partial struct ACTIVATION_CONTEXT_QUERY_INDEX
{
    /// <include file='ACTIVATION_CONTEXT_QUERY_INDEX.xml' path='doc/member[@name="ACTIVATION_CONTEXT_QUERY_INDEX.ulAssemblyIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulAssemblyIndex;

    /// <include file='ACTIVATION_CONTEXT_QUERY_INDEX.xml' path='doc/member[@name="ACTIVATION_CONTEXT_QUERY_INDEX.ulFileIndexInAssembly"]/*' />
    [NativeTypeName("DWORD")]
    public uint ulFileIndexInAssembly;
}
