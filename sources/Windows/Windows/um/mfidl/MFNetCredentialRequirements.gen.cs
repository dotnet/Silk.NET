// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFNetCredentialRequirements.xml' path='doc/member[@name="MFNetCredentialRequirements"]/*' />
public enum MFNetCredentialRequirements
{
    /// <include file='MFNetCredentialRequirements.xml' path='doc/member[@name="MFNetCredentialRequirements.REQUIRE_PROMPT"]/*' />
    REQUIRE_PROMPT = 0x1,

    /// <include file='MFNetCredentialRequirements.xml' path='doc/member[@name="MFNetCredentialRequirements.REQUIRE_SAVE_SELECTED"]/*' />
    REQUIRE_SAVE_SELECTED = 0x2,
}
