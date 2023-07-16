// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='FILE_DISPOSITION_INFO_EX.xml' path='doc/member[@name="FILE_DISPOSITION_INFO_EX"]/*'/>
public partial struct FILE_DISPOSITION_INFO_EX
{
    /// <include file='FILE_DISPOSITION_INFO_EX.xml' path='doc/member[@name="FILE_DISPOSITION_INFO_EX.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
}