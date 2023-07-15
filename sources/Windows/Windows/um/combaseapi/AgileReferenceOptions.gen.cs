// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/combaseapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='AgileReferenceOptions.xml' path='doc/member[@name="AgileReferenceOptions"]/*'/>
[SupportedOSPlatform("windows6.3")]
public enum AgileReferenceOptions
{
    /// <include file='AgileReferenceOptions.xml' path='doc/member[@name="AgileReferenceOptions.AGILEREFERENCE_DEFAULT"]/*'/>
    AGILEREFERENCE_DEFAULT = 0,
    /// <include file='AgileReferenceOptions.xml' path='doc/member[@name="AgileReferenceOptions.AGILEREFERENCE_DELAYEDMARSHAL"]/*'/>
    AGILEREFERENCE_DELAYEDMARSHAL = 1,
}