// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AMPROPERTY_PIN.xml' path='doc/member[@name="AMPROPERTY_PIN"]/*' />
public enum AMPROPERTY_PIN
{
    /// <include file='AMPROPERTY_PIN.xml' path='doc/member[@name="AMPROPERTY_PIN.AMPROPERTY_PIN_CATEGORY"]/*' />
    AMPROPERTY_PIN_CATEGORY = 0,

    /// <include file='AMPROPERTY_PIN.xml' path='doc/member[@name="AMPROPERTY_PIN.AMPROPERTY_PIN_MEDIUM"]/*' />
    AMPROPERTY_PIN_MEDIUM = (AMPROPERTY_PIN_CATEGORY + 1),
}
