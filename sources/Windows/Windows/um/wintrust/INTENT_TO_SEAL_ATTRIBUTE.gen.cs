// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='INTENT_TO_SEAL_ATTRIBUTE.xml' path='doc/member[@name="INTENT_TO_SEAL_ATTRIBUTE"]/*' />
public partial struct INTENT_TO_SEAL_ATTRIBUTE
{
    /// <include file='INTENT_TO_SEAL_ATTRIBUTE.xml' path='doc/member[@name="INTENT_TO_SEAL_ATTRIBUTE.version"]/*' />
    [NativeTypeName("ULONG")]
    public uint version;

    /// <include file='INTENT_TO_SEAL_ATTRIBUTE.xml' path='doc/member[@name="INTENT_TO_SEAL_ATTRIBUTE.seal"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte seal;
}
