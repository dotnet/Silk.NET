// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='RAWKEYBOARD.xml' path='doc/member[@name="RAWKEYBOARD"]/*'/>
public partial struct RAWKEYBOARD
{
    /// <include file='RAWKEYBOARD.xml' path='doc/member[@name="RAWKEYBOARD.MakeCode"]/*'/>
    public ushort MakeCode;
    /// <include file='RAWKEYBOARD.xml' path='doc/member[@name="RAWKEYBOARD.Flags"]/*'/>
    public ushort Flags;
    /// <include file='RAWKEYBOARD.xml' path='doc/member[@name="RAWKEYBOARD.Reserved"]/*'/>
    public ushort Reserved;
    /// <include file='RAWKEYBOARD.xml' path='doc/member[@name="RAWKEYBOARD.VKey"]/*'/>
    public ushort VKey;
    /// <include file='RAWKEYBOARD.xml' path='doc/member[@name="RAWKEYBOARD.Message"]/*'/>
    public uint Message;
    /// <include file='RAWKEYBOARD.xml' path='doc/member[@name="RAWKEYBOARD.ExtraInformation"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ExtraInformation;
}