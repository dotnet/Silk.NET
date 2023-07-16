// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='WS_DEFAULT_VALUE.xml' path='doc/member[@name="WS_DEFAULT_VALUE"]/*'/>
public unsafe partial struct WS_DEFAULT_VALUE
{
    /// <include file='WS_DEFAULT_VALUE.xml' path='doc/member[@name="WS_DEFAULT_VALUE.value"]/*'/>
    public void* value;
    /// <include file='WS_DEFAULT_VALUE.xml' path='doc/member[@name="WS_DEFAULT_VALUE.valueSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint valueSize;
}