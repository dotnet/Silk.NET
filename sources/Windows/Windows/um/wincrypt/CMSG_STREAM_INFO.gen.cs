// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CMSG_STREAM_INFO.xml' path='doc/member[@name="CMSG_STREAM_INFO"]/*'/>
public unsafe partial struct CMSG_STREAM_INFO
{
    /// <include file='CMSG_STREAM_INFO.xml' path='doc/member[@name="CMSG_STREAM_INFO.cbContent"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbContent;
    /// <include file='CMSG_STREAM_INFO.xml' path='doc/member[@name="CMSG_STREAM_INFO.pfnStreamOutput"]/*'/>
    [NativeTypeName("PFN_CMSG_STREAM_OUTPUT")]
    public delegate* unmanaged<void*, byte*, uint, BOOL, BOOL> pfnStreamOutput;
    /// <include file='CMSG_STREAM_INFO.xml' path='doc/member[@name="CMSG_STREAM_INFO.pvArg"]/*'/>
    public void* pvArg;
}