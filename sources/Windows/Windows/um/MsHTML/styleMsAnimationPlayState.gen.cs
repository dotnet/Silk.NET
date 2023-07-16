// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='styleMsAnimationPlayState.xml' path='doc/member[@name="styleMsAnimationPlayState"]/*'/>
public enum styleMsAnimationPlayState
{
    /// <include file='styleMsAnimationPlayState.xml' path='doc/member[@name="styleMsAnimationPlayState.styleMsAnimationPlayStateRunning"]/*'/>
    styleMsAnimationPlayStateRunning = 0,
    /// <include file='styleMsAnimationPlayState.xml' path='doc/member[@name="styleMsAnimationPlayState.styleMsAnimationPlayStatePaused"]/*'/>
    styleMsAnimationPlayStatePaused = 1,
    /// <include file='styleMsAnimationPlayState.xml' path='doc/member[@name="styleMsAnimationPlayState.styleMsAnimationPlayStateNotSet"]/*'/>
    styleMsAnimationPlayStateNotSet = 2,
    /// <include file='styleMsAnimationPlayState.xml' path='doc/member[@name="styleMsAnimationPlayState.styleMsAnimationPlayState_Max"]/*'/>
    styleMsAnimationPlayState_Max = 2147483647,
}