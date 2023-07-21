// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='STORAGE_DEVICE_FORM_FACTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FORM_FACTOR"]/*' />
[SupportedOSPlatform("windows10.0")]
public enum STORAGE_DEVICE_FORM_FACTOR
{
    /// <include file='STORAGE_DEVICE_FORM_FACTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FORM_FACTOR.FormFactorUnknown"]/*' />
    FormFactorUnknown = 0,

    /// <include file='STORAGE_DEVICE_FORM_FACTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FORM_FACTOR.FormFactor3_5"]/*' />
    FormFactor3_5,

    /// <include file='STORAGE_DEVICE_FORM_FACTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FORM_FACTOR.FormFactor2_5"]/*' />
    FormFactor2_5,

    /// <include file='STORAGE_DEVICE_FORM_FACTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FORM_FACTOR.FormFactor1_8"]/*' />
    FormFactor1_8,

    /// <include file='STORAGE_DEVICE_FORM_FACTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FORM_FACTOR.FormFactor1_8Less"]/*' />
    FormFactor1_8Less,

    /// <include file='STORAGE_DEVICE_FORM_FACTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FORM_FACTOR.FormFactorEmbedded"]/*' />
    FormFactorEmbedded,

    /// <include file='STORAGE_DEVICE_FORM_FACTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FORM_FACTOR.FormFactorMemoryCard"]/*' />
    FormFactorMemoryCard,

    /// <include file='STORAGE_DEVICE_FORM_FACTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FORM_FACTOR.FormFactormSata"]/*' />
    FormFactormSata,

    /// <include file='STORAGE_DEVICE_FORM_FACTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FORM_FACTOR.FormFactorM_2"]/*' />
    FormFactorM_2,

    /// <include file='STORAGE_DEVICE_FORM_FACTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FORM_FACTOR.FormFactorPCIeBoard"]/*' />
    FormFactorPCIeBoard,

    /// <include file='STORAGE_DEVICE_FORM_FACTOR.xml' path='doc/member[@name="STORAGE_DEVICE_FORM_FACTOR.FormFactorDimm"]/*' />
    FormFactorDimm,
}
