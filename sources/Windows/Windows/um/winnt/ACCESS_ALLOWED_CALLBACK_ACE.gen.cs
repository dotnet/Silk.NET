// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ACCESS_ALLOWED_CALLBACK_ACE.xml' path='doc/member[@name="ACCESS_ALLOWED_CALLBACK_ACE"]/*'/>
public partial struct ACCESS_ALLOWED_CALLBACK_ACE
{
    /// <include file='ACCESS_ALLOWED_CALLBACK_ACE.xml' path='doc/member[@name="ACCESS_ALLOWED_CALLBACK_ACE.Header"]/*'/>
    public ACE_HEADER Header;
    /// <include file='ACCESS_ALLOWED_CALLBACK_ACE.xml' path='doc/member[@name="ACCESS_ALLOWED_CALLBACK_ACE.Mask"]/*'/>
    [NativeTypeName("ACCESS_MASK")]
    public uint Mask;
    /// <include file='ACCESS_ALLOWED_CALLBACK_ACE.xml' path='doc/member[@name="ACCESS_ALLOWED_CALLBACK_ACE.SidStart"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SidStart;
}