// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FILE_ZERO_DATA_INFORMATION.xml' path='doc/member[@name="FILE_ZERO_DATA_INFORMATION"]/*'/>
public partial struct FILE_ZERO_DATA_INFORMATION
{
    /// <include file='FILE_ZERO_DATA_INFORMATION.xml' path='doc/member[@name="FILE_ZERO_DATA_INFORMATION.FileOffset"]/*'/>
    public LARGE_INTEGER FileOffset;
    /// <include file='FILE_ZERO_DATA_INFORMATION.xml' path='doc/member[@name="FILE_ZERO_DATA_INFORMATION.BeyondFinalZero"]/*'/>
    public LARGE_INTEGER BeyondFinalZero;
}