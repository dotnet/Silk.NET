// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='STREAM_EXTENT_ENTRY.xml' path='doc/member[@name="STREAM_EXTENT_ENTRY"]/*'/>
public partial struct STREAM_EXTENT_ENTRY
{
    /// <include file='STREAM_EXTENT_ENTRY.xml' path='doc/member[@name="STREAM_EXTENT_ENTRY.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='STREAM_EXTENT_ENTRY.xml' path='doc/member[@name="STREAM_EXTENT_ENTRY.ExtentInformation"]/*'/>
    [NativeTypeName("__AnonymousRecord_winioctl_L15331_C5")]
    public _ExtentInformation_e__Union ExtentInformation;
    /// <include file='_ExtentInformation_e__Union.xml' path='doc/member[@name="_ExtentInformation_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _ExtentInformation_e__Union
    {
        /// <include file='_ExtentInformation_e__Union.xml' path='doc/member[@name="_ExtentInformation_e__Union.RetrievalPointers"]/*'/>
        [FieldOffset(0)]
        public RETRIEVAL_POINTERS_BUFFER RetrievalPointers;
    }
}