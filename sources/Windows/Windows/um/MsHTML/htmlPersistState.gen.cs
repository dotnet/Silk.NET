// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='htmlPersistState.xml' path='doc/member[@name="htmlPersistState"]/*'/>
public enum htmlPersistState
{
    /// <include file='htmlPersistState.xml' path='doc/member[@name="htmlPersistState.htmlPersistStateNormal"]/*'/>
    htmlPersistStateNormal = 0,
    /// <include file='htmlPersistState.xml' path='doc/member[@name="htmlPersistState.htmlPersistStateFavorite"]/*'/>
    htmlPersistStateFavorite = 1,
    /// <include file='htmlPersistState.xml' path='doc/member[@name="htmlPersistState.htmlPersistStateHistory"]/*'/>
    htmlPersistStateHistory = 2,
    /// <include file='htmlPersistState.xml' path='doc/member[@name="htmlPersistState.htmlPersistStateSnapshot"]/*'/>
    htmlPersistStateSnapshot = 3,
    /// <include file='htmlPersistState.xml' path='doc/member[@name="htmlPersistState.htmlPersistStateUserData"]/*'/>
    htmlPersistStateUserData = 4,
    /// <include file='htmlPersistState.xml' path='doc/member[@name="htmlPersistState.htmlPersistState_Max"]/*'/>
    htmlPersistState_Max = 2147483647,
}