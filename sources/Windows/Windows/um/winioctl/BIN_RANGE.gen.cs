// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='BIN_RANGE.xml' path='doc/member[@name="BIN_RANGE"]/*'/>
public partial struct BIN_RANGE
{
    /// <include file='BIN_RANGE.xml' path='doc/member[@name="BIN_RANGE.StartValue"]/*'/>
    public LARGE_INTEGER StartValue;
    /// <include file='BIN_RANGE.xml' path='doc/member[@name="BIN_RANGE.Length"]/*'/>
    public LARGE_INTEGER Length;
}