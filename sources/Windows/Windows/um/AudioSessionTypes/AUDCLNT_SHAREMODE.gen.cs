// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AudioSessionTypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='AUDCLNT_SHAREMODE.xml' path='doc/member[@name="AUDCLNT_SHAREMODE"]/*'/>
public enum AUDCLNT_SHAREMODE
{
    /// <include file='AUDCLNT_SHAREMODE.xml' path='doc/member[@name="AUDCLNT_SHAREMODE.AUDCLNT_SHAREMODE_SHARED"]/*'/>
    AUDCLNT_SHAREMODE_SHARED,
    /// <include file='AUDCLNT_SHAREMODE.xml' path='doc/member[@name="AUDCLNT_SHAREMODE.AUDCLNT_SHAREMODE_EXCLUSIVE"]/*'/>
    AUDCLNT_SHAREMODE_EXCLUSIVE,
}