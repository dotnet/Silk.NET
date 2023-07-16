// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/icm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='NAMEDCOLOR.xml' path='doc/member[@name="NAMEDCOLOR"]/*'/>
public partial struct NAMEDCOLOR
{
    /// <include file='NAMEDCOLOR.xml' path='doc/member[@name="NAMEDCOLOR.dwIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwIndex;
}