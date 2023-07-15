// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='FILE_ZERO_DATA_INFORMATION_EX.xml' path='doc/member[@name="FILE_ZERO_DATA_INFORMATION_EX"]/*'/>
public partial struct FILE_ZERO_DATA_INFORMATION_EX
{
    /// <include file='FILE_ZERO_DATA_INFORMATION_EX.xml' path='doc/member[@name="FILE_ZERO_DATA_INFORMATION_EX.FileOffset"]/*'/>
    public LARGE_INTEGER FileOffset;
    /// <include file='FILE_ZERO_DATA_INFORMATION_EX.xml' path='doc/member[@name="FILE_ZERO_DATA_INFORMATION_EX.BeyondFinalZero"]/*'/>
    public LARGE_INTEGER BeyondFinalZero;
    /// <include file='FILE_ZERO_DATA_INFORMATION_EX.xml' path='doc/member[@name="FILE_ZERO_DATA_INFORMATION_EX.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
}