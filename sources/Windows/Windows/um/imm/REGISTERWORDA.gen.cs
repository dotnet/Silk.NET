// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='REGISTERWORDA.xml' path='doc/member[@name="REGISTERWORDA"]/*'/>
public unsafe partial struct REGISTERWORDA
{
    /// <include file='REGISTERWORDA.xml' path='doc/member[@name="REGISTERWORDA.lpReading"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpReading;
    /// <include file='REGISTERWORDA.xml' path='doc/member[@name="REGISTERWORDA.lpWord"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpWord;
}