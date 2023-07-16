// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='EVENT_FILTER_EVENT_NAME.xml' path='doc/member[@name="EVENT_FILTER_EVENT_NAME"]/*'/>
public unsafe partial struct EVENT_FILTER_EVENT_NAME
{
    /// <include file='EVENT_FILTER_EVENT_NAME.xml' path='doc/member[@name="EVENT_FILTER_EVENT_NAME.MatchAnyKeyword"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong MatchAnyKeyword;
    /// <include file='EVENT_FILTER_EVENT_NAME.xml' path='doc/member[@name="EVENT_FILTER_EVENT_NAME.MatchAllKeyword"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong MatchAllKeyword;
    /// <include file='EVENT_FILTER_EVENT_NAME.xml' path='doc/member[@name="EVENT_FILTER_EVENT_NAME.Level"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte Level;
    /// <include file='EVENT_FILTER_EVENT_NAME.xml' path='doc/member[@name="EVENT_FILTER_EVENT_NAME.FilterIn"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte FilterIn;
    /// <include file='EVENT_FILTER_EVENT_NAME.xml' path='doc/member[@name="EVENT_FILTER_EVENT_NAME.NameCount"]/*'/>
    public ushort NameCount;
    /// <include file='EVENT_FILTER_EVENT_NAME.xml' path='doc/member[@name="EVENT_FILTER_EVENT_NAME.Names"]/*'/>
    [NativeTypeName("UCHAR[1]")]
    public fixed byte Names[1];
}