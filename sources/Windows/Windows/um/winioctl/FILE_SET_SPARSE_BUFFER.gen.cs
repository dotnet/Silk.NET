// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FILE_SET_SPARSE_BUFFER.xml' path='doc/member[@name="FILE_SET_SPARSE_BUFFER"]/*'/>
public partial struct FILE_SET_SPARSE_BUFFER
{
    /// <include file='FILE_SET_SPARSE_BUFFER.xml' path='doc/member[@name="FILE_SET_SPARSE_BUFFER.SetSparse"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte SetSparse;
}