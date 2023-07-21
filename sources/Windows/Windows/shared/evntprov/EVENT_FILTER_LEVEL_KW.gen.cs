// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EVENT_FILTER_LEVEL_KW.xml' path='doc/member[@name="EVENT_FILTER_LEVEL_KW"]/*' />
public partial struct EVENT_FILTER_LEVEL_KW
{
    /// <include file='EVENT_FILTER_LEVEL_KW.xml' path='doc/member[@name="EVENT_FILTER_LEVEL_KW.MatchAnyKeyword"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong MatchAnyKeyword;

    /// <include file='EVENT_FILTER_LEVEL_KW.xml' path='doc/member[@name="EVENT_FILTER_LEVEL_KW.MatchAllKeyword"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong MatchAllKeyword;

    /// <include file='EVENT_FILTER_LEVEL_KW.xml' path='doc/member[@name="EVENT_FILTER_LEVEL_KW.Level"]/*' />
    [NativeTypeName("UCHAR")]
    public byte Level;

    /// <include file='EVENT_FILTER_LEVEL_KW.xml' path='doc/member[@name="EVENT_FILTER_LEVEL_KW.FilterIn"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte FilterIn;
}
