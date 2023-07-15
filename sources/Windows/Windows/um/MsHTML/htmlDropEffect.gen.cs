// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='htmlDropEffect.xml' path='doc/member[@name="htmlDropEffect"]/*'/>
public enum htmlDropEffect
{
    /// <include file='htmlDropEffect.xml' path='doc/member[@name="htmlDropEffect.htmlDropEffectCopy"]/*'/>
    htmlDropEffectCopy = 0,
    /// <include file='htmlDropEffect.xml' path='doc/member[@name="htmlDropEffect.htmlDropEffectLink"]/*'/>
    htmlDropEffectLink = 1,
    /// <include file='htmlDropEffect.xml' path='doc/member[@name="htmlDropEffect.htmlDropEffectMove"]/*'/>
    htmlDropEffectMove = 2,
    /// <include file='htmlDropEffect.xml' path='doc/member[@name="htmlDropEffect.htmlDropEffectNone"]/*'/>
    htmlDropEffectNone = 3,
    /// <include file='htmlDropEffect.xml' path='doc/member[@name="htmlDropEffect.htmlDropEffect_Max"]/*'/>
    htmlDropEffect_Max = 2147483647,
}