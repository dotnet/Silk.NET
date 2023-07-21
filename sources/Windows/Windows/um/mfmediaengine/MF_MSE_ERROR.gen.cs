// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='MF_MSE_ERROR.xml' path='doc/member[@name="MF_MSE_ERROR"]/*' />
[SupportedOSPlatform("windows6.3")]
public enum MF_MSE_ERROR
{
    /// <include file='MF_MSE_ERROR.xml' path='doc/member[@name="MF_MSE_ERROR.MF_MSE_ERROR_NOERROR"]/*' />
    MF_MSE_ERROR_NOERROR = 0,

    /// <include file='MF_MSE_ERROR.xml' path='doc/member[@name="MF_MSE_ERROR.MF_MSE_ERROR_NETWORK"]/*' />
    MF_MSE_ERROR_NETWORK = 1,

    /// <include file='MF_MSE_ERROR.xml' path='doc/member[@name="MF_MSE_ERROR.MF_MSE_ERROR_DECODE"]/*' />
    MF_MSE_ERROR_DECODE = 2,

    /// <include file='MF_MSE_ERROR.xml' path='doc/member[@name="MF_MSE_ERROR.MF_MSE_ERROR_UNKNOWN_ERROR"]/*' />
    MF_MSE_ERROR_UNKNOWN_ERROR = 3,
}
