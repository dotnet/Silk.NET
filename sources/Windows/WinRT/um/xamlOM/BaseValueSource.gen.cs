// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.WinRT;

/// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource"]/*' />
[SupportedOSPlatform("windows10.0")]
public enum BaseValueSource
{
    /// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource.BaseValueSourceUnknown"]/*' />
    BaseValueSourceUnknown = 0,

    /// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource.BaseValueSourceDefault"]/*' />
    BaseValueSourceDefault = (BaseValueSourceUnknown + 1),

    /// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource.BaseValueSourceBuiltInStyle"]/*' />
    BaseValueSourceBuiltInStyle = (BaseValueSourceDefault + 1),

    /// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource.BaseValueSourceStyle"]/*' />
    BaseValueSourceStyle = (BaseValueSourceBuiltInStyle + 1),

    /// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource.BaseValueSourceLocal"]/*' />
    BaseValueSourceLocal = (BaseValueSourceStyle + 1),

    /// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource.Inherited"]/*' />
    Inherited = (BaseValueSourceLocal + 1),

    /// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource.DefaultStyleTrigger"]/*' />
    DefaultStyleTrigger = (Inherited + 1),

    /// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource.TemplateTrigger"]/*' />
    TemplateTrigger = (DefaultStyleTrigger + 1),

    /// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource.StyleTrigger"]/*' />
    StyleTrigger = (TemplateTrigger + 1),

    /// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource.ImplicitStyleReference"]/*' />
    ImplicitStyleReference = (StyleTrigger + 1),

    /// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource.ParentTemplate"]/*' />
    ParentTemplate = (ImplicitStyleReference + 1),

    /// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource.ParentTemplateTrigger"]/*' />
    ParentTemplateTrigger = (ParentTemplate + 1),

    /// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource.Animation"]/*' />
    Animation = (ParentTemplateTrigger + 1),

    /// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource.Coercion"]/*' />
    Coercion = (Animation + 1),

    /// <include file='BaseValueSource.xml' path='doc/member[@name="BaseValueSource.BaseValueSourceVisualState"]/*' />
    BaseValueSourceVisualState = (Coercion + 1),
}
