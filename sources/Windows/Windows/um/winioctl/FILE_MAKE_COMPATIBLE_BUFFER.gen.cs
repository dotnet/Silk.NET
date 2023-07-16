// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FILE_MAKE_COMPATIBLE_BUFFER.xml' path='doc/member[@name="FILE_MAKE_COMPATIBLE_BUFFER"]/*'/>
public partial struct FILE_MAKE_COMPATIBLE_BUFFER
{
    /// <include file='FILE_MAKE_COMPATIBLE_BUFFER.xml' path='doc/member[@name="FILE_MAKE_COMPATIBLE_BUFFER.CloseDisc"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte CloseDisc;
}