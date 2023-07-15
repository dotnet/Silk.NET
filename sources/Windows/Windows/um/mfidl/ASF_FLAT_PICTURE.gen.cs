// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='ASF_FLAT_PICTURE.xml' path='doc/member[@name="ASF_FLAT_PICTURE"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct ASF_FLAT_PICTURE
{
    /// <include file='ASF_FLAT_PICTURE.xml' path='doc/member[@name="ASF_FLAT_PICTURE.bPictureType"]/*'/>
    public byte bPictureType;
    /// <include file='ASF_FLAT_PICTURE.xml' path='doc/member[@name="ASF_FLAT_PICTURE.dwDataLen"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDataLen;
}