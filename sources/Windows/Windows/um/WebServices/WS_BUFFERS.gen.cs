// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_BUFFERS.xml' path='doc/member[@name="WS_BUFFERS"]/*'/>
public unsafe partial struct WS_BUFFERS
{
    /// <include file='WS_BUFFERS.xml' path='doc/member[@name="WS_BUFFERS.bufferCount"]/*'/>
    [NativeTypeName("ULONG")]
    public uint bufferCount;
    /// <include file='WS_BUFFERS.xml' path='doc/member[@name="WS_BUFFERS.buffers"]/*'/>
    public WS_BYTES* buffers;
}