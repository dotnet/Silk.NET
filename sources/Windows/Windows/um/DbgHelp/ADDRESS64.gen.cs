// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ADDRESS64.xml' path='doc/member[@name="ADDRESS64"]/*'/>
public partial struct ADDRESS64
{
    /// <include file='ADDRESS64.xml' path='doc/member[@name="ADDRESS64.Offset"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Offset;
    /// <include file='ADDRESS64.xml' path='doc/member[@name="ADDRESS64.Segment"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Segment;
    /// <include file='ADDRESS64.xml' path='doc/member[@name="ADDRESS64.Mode"]/*'/>
    public ADDRESS_MODE Mode;
}