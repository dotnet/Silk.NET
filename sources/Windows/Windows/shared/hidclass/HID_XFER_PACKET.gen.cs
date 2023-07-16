// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidclass.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='HID_XFER_PACKET.xml' path='doc/member[@name="HID_XFER_PACKET"]/*'/>
public unsafe partial struct HID_XFER_PACKET
{
    /// <include file='HID_XFER_PACKET.xml' path='doc/member[@name="HID_XFER_PACKET.reportBuffer"]/*'/>
    [NativeTypeName("PUCHAR")]
    public byte* reportBuffer;
    /// <include file='HID_XFER_PACKET.xml' path='doc/member[@name="HID_XFER_PACKET.reportBufferLen"]/*'/>
    [NativeTypeName("ULONG")]
    public uint reportBufferLen;
    /// <include file='HID_XFER_PACKET.xml' path='doc/member[@name="HID_XFER_PACKET.reportId"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte reportId;
}