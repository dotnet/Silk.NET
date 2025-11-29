// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/inspectable.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using Silk.NET.Core;
#pragma warning disable CS1589, CS1591, CS0419, CA1416, CS0618
namespace Silk.NET.Core;

/// <include file='TrustLevel.xml' path='doc/member[@name="TrustLevel"]/*'/>
public enum TrustLevel
{
    /// <include file='TrustLevel.xml' path='doc/member[@name="TrustLevel.BaseTrust"]/*'/>

    BaseTrust = 0,

    /// <include file='TrustLevel.xml' path='doc/member[@name="TrustLevel.PartialTrust"]/*'/>

    PartialTrust = (BaseTrust + 1),

    /// <include file='TrustLevel.xml' path='doc/member[@name="TrustLevel.FullTrust"]/*'/>

    FullTrust = (PartialTrust + 1),
}
