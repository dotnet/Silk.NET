// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/UserEnv.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SETTINGSTATUS.xml' path='doc/member[@name="SETTINGSTATUS"]/*' />
public enum SETTINGSTATUS
{
    /// <include file='SETTINGSTATUS.xml' path='doc/member[@name="SETTINGSTATUS.RSOPUnspecified"]/*' />
    RSOPUnspecified = 0,

    /// <include file='SETTINGSTATUS.xml' path='doc/member[@name="SETTINGSTATUS.RSOPApplied"]/*' />
    RSOPApplied,

    /// <include file='SETTINGSTATUS.xml' path='doc/member[@name="SETTINGSTATUS.RSOPIgnored"]/*' />
    RSOPIgnored,

    /// <include file='SETTINGSTATUS.xml' path='doc/member[@name="SETTINGSTATUS.RSOPFailed"]/*' />
    RSOPFailed,

    /// <include file='SETTINGSTATUS.xml' path='doc/member[@name="SETTINGSTATUS.RSOPSubsettingFailed"]/*' />
    RSOPSubsettingFailed,
}
