// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EVENT_FILTER_EVENT_ID.xml' path='doc/member[@name="EVENT_FILTER_EVENT_ID"]/*'/>
public unsafe partial struct EVENT_FILTER_EVENT_ID
{
    /// <include file='EVENT_FILTER_EVENT_ID.xml' path='doc/member[@name="EVENT_FILTER_EVENT_ID.FilterIn"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte FilterIn;
    /// <include file='EVENT_FILTER_EVENT_ID.xml' path='doc/member[@name="EVENT_FILTER_EVENT_ID.Reserved"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte Reserved;
    /// <include file='EVENT_FILTER_EVENT_ID.xml' path='doc/member[@name="EVENT_FILTER_EVENT_ID.Count"]/*'/>
    public ushort Count;
    /// <include file='EVENT_FILTER_EVENT_ID.xml' path='doc/member[@name="EVENT_FILTER_EVENT_ID.Events"]/*'/>
    [NativeTypeName("USHORT[1]")]
    public fixed ushort Events[1];
}