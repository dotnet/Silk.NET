// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/evntprov.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EVENT_FILTER_DESCRIPTOR.xml' path='doc/member[@name="EVENT_FILTER_DESCRIPTOR"]/*'/>
public partial struct EVENT_FILTER_DESCRIPTOR
{
    /// <include file='EVENT_FILTER_DESCRIPTOR.xml' path='doc/member[@name="EVENT_FILTER_DESCRIPTOR.Ptr"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong Ptr;
    /// <include file='EVENT_FILTER_DESCRIPTOR.xml' path='doc/member[@name="EVENT_FILTER_DESCRIPTOR.Size"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Size;
    /// <include file='EVENT_FILTER_DESCRIPTOR.xml' path='doc/member[@name="EVENT_FILTER_DESCRIPTOR.Type"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Type;
}