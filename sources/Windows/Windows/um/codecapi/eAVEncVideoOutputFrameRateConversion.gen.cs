// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='eAVEncVideoOutputFrameRateConversion.xml' path='doc/member[@name="eAVEncVideoOutputFrameRateConversion"]/*' />
public enum eAVEncVideoOutputFrameRateConversion
{
    /// <include file='eAVEncVideoOutputFrameRateConversion.xml' path='doc/member[@name="eAVEncVideoOutputFrameRateConversion.eAVEncVideoOutputFrameRateConversion_Disable"]/*' />
    eAVEncVideoOutputFrameRateConversion_Disable = 0,

    /// <include file='eAVEncVideoOutputFrameRateConversion.xml' path='doc/member[@name="eAVEncVideoOutputFrameRateConversion.eAVEncVideoOutputFrameRateConversion_Enable"]/*' />
    eAVEncVideoOutputFrameRateConversion_Enable = 1,

    /// <include file='eAVEncVideoOutputFrameRateConversion.xml' path='doc/member[@name="eAVEncVideoOutputFrameRateConversion.eAVEncVideoOutputFrameRateConversion_Alias"]/*' />
    eAVEncVideoOutputFrameRateConversion_Alias = 2,
}
