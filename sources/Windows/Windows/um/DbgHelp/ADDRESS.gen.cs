// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ADDRESS.xml' path='doc/member[@name="ADDRESS"]/*'/>
public partial struct ADDRESS
{
    /// <include file='ADDRESS.xml' path='doc/member[@name="ADDRESS.Offset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Offset;
    /// <include file='ADDRESS.xml' path='doc/member[@name="ADDRESS.Segment"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Segment;
    /// <include file='ADDRESS.xml' path='doc/member[@name="ADDRESS.Mode"]/*'/>
    public ADDRESS_MODE Mode;
}