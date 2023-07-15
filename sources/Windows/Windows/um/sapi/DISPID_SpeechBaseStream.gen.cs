// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='DISPID_SpeechBaseStream.xml' path='doc/member[@name="DISPID_SpeechBaseStream"]/*'/>
public enum DISPID_SpeechBaseStream
{
    /// <include file='DISPID_SpeechBaseStream.xml' path='doc/member[@name="DISPID_SpeechBaseStream.DISPID_SBSFormat"]/*'/>
    DISPID_SBSFormat = 1,
    /// <include file='DISPID_SpeechBaseStream.xml' path='doc/member[@name="DISPID_SpeechBaseStream.DISPID_SBSRead"]/*'/>
    DISPID_SBSRead = (DISPID_SBSFormat + 1),
    /// <include file='DISPID_SpeechBaseStream.xml' path='doc/member[@name="DISPID_SpeechBaseStream.DISPID_SBSWrite"]/*'/>
    DISPID_SBSWrite = (DISPID_SBSRead + 1),
    /// <include file='DISPID_SpeechBaseStream.xml' path='doc/member[@name="DISPID_SpeechBaseStream.DISPID_SBSSeek"]/*'/>
    DISPID_SBSSeek = (DISPID_SBSWrite + 1),
}