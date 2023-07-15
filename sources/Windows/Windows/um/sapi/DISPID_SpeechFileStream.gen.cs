// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechFileStream.xml' path='doc/member[@name="DISPID_SpeechFileStream"]/*'/>
public enum DISPID_SpeechFileStream
{
    /// <include file='DISPID_SpeechFileStream.xml' path='doc/member[@name="DISPID_SpeechFileStream.DISPID_SFSOpen"]/*'/>
    DISPID_SFSOpen = 100,
    /// <include file='DISPID_SpeechFileStream.xml' path='doc/member[@name="DISPID_SpeechFileStream.DISPID_SFSClose"]/*'/>
    DISPID_SFSClose = (DISPID_SFSOpen + 1),
}