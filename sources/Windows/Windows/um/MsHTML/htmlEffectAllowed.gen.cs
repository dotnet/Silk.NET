// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='htmlEffectAllowed.xml' path='doc/member[@name="htmlEffectAllowed"]/*'/>
public enum htmlEffectAllowed
{
    /// <include file='htmlEffectAllowed.xml' path='doc/member[@name="htmlEffectAllowed.htmlEffectAllowedCopy"]/*'/>
    htmlEffectAllowedCopy = 0,
    /// <include file='htmlEffectAllowed.xml' path='doc/member[@name="htmlEffectAllowed.htmlEffectAllowedLink"]/*'/>
    htmlEffectAllowedLink = 1,
    /// <include file='htmlEffectAllowed.xml' path='doc/member[@name="htmlEffectAllowed.htmlEffectAllowedMove"]/*'/>
    htmlEffectAllowedMove = 2,
    /// <include file='htmlEffectAllowed.xml' path='doc/member[@name="htmlEffectAllowed.htmlEffectAllowedCopyLink"]/*'/>
    htmlEffectAllowedCopyLink = 3,
    /// <include file='htmlEffectAllowed.xml' path='doc/member[@name="htmlEffectAllowed.htmlEffectAllowedCopyMove"]/*'/>
    htmlEffectAllowedCopyMove = 4,
    /// <include file='htmlEffectAllowed.xml' path='doc/member[@name="htmlEffectAllowed.htmlEffectAllowedLinkMove"]/*'/>
    htmlEffectAllowedLinkMove = 5,
    /// <include file='htmlEffectAllowed.xml' path='doc/member[@name="htmlEffectAllowed.htmlEffectAllowedAll"]/*'/>
    htmlEffectAllowedAll = 6,
    /// <include file='htmlEffectAllowed.xml' path='doc/member[@name="htmlEffectAllowed.htmlEffectAllowedNone"]/*'/>
    htmlEffectAllowedNone = 7,
    /// <include file='htmlEffectAllowed.xml' path='doc/member[@name="htmlEffectAllowed.htmlEffectAllowedUninitialized"]/*'/>
    htmlEffectAllowedUninitialized = 8,
    /// <include file='htmlEffectAllowed.xml' path='doc/member[@name="htmlEffectAllowed.htmlEffectAllowed_Max"]/*'/>
    htmlEffectAllowed_Max = 2147483647,
}