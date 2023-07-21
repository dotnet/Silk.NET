// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/InteractionContext.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='TRANSLATION_PARAMETER.xml' path='doc/member[@name="TRANSLATION_PARAMETER"]/*' />
public enum TRANSLATION_PARAMETER
{
    /// <include file='TRANSLATION_PARAMETER.xml' path='doc/member[@name="TRANSLATION_PARAMETER.TRANSLATION_PARAMETER_MIN_CONTACT_COUNT"]/*' />
    TRANSLATION_PARAMETER_MIN_CONTACT_COUNT = 0x00000000,

    /// <include file='TRANSLATION_PARAMETER.xml' path='doc/member[@name="TRANSLATION_PARAMETER.TRANSLATION_PARAMETER_MAX_CONTACT_COUNT"]/*' />
    TRANSLATION_PARAMETER_MAX_CONTACT_COUNT = 0x00000001,

    /// <include file='TRANSLATION_PARAMETER.xml' path='doc/member[@name="TRANSLATION_PARAMETER.TRANSLATION_PARAMETER_MAX"]/*' />
    TRANSLATION_PARAMETER_MAX = unchecked((int)(0xffffffff)),
}
