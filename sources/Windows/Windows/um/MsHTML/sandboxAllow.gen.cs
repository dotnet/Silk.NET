// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='sandboxAllow.xml' path='doc/member[@name="sandboxAllow"]/*' />
public enum sandboxAllow
{
    /// <include file='sandboxAllow.xml' path='doc/member[@name="sandboxAllow.sandboxAllowScripts"]/*' />
    sandboxAllowScripts = 0,

    /// <include file='sandboxAllow.xml' path='doc/member[@name="sandboxAllow.sandboxAllowSameOrigin"]/*' />
    sandboxAllowSameOrigin = 1,

    /// <include file='sandboxAllow.xml' path='doc/member[@name="sandboxAllow.sandboxAllowTopNavigation"]/*' />
    sandboxAllowTopNavigation = 2,

    /// <include file='sandboxAllow.xml' path='doc/member[@name="sandboxAllow.sandboxAllowForms"]/*' />
    sandboxAllowForms = 3,

    /// <include file='sandboxAllow.xml' path='doc/member[@name="sandboxAllow.sandboxAllowPopups"]/*' />
    sandboxAllowPopups = 4,

    /// <include file='sandboxAllow.xml' path='doc/member[@name="sandboxAllow.sandboxAllow_Max"]/*' />
    sandboxAllow_Max = 2147483647,
}
