// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DDGAMMARAMP.xml' path='doc/member[@name="DDGAMMARAMP"]/*'/>
public unsafe partial struct DDGAMMARAMP
{
    /// <include file='DDGAMMARAMP.xml' path='doc/member[@name="DDGAMMARAMP.red"]/*'/>
    [NativeTypeName("WORD[256]")]
    public fixed ushort red[256];
    /// <include file='DDGAMMARAMP.xml' path='doc/member[@name="DDGAMMARAMP.green"]/*'/>
    [NativeTypeName("WORD[256]")]
    public fixed ushort green[256];
    /// <include file='DDGAMMARAMP.xml' path='doc/member[@name="DDGAMMARAMP.blue"]/*'/>
    [NativeTypeName("WORD[256]")]
    public fixed ushort blue[256];
}