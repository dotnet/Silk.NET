// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dvdmedia.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AM_DvdKaraokeData.xml' path='doc/member[@name="AM_DvdKaraokeData"]/*'/>
public partial struct AM_DvdKaraokeData
{
    /// <include file='AM_DvdKaraokeData.xml' path='doc/member[@name="AM_DvdKaraokeData.dwDownmix"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwDownmix;
    /// <include file='AM_DvdKaraokeData.xml' path='doc/member[@name="AM_DvdKaraokeData.dwSpeakerAssignment"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSpeakerAssignment;
}