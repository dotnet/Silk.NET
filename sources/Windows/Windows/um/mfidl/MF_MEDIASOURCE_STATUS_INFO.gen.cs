// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='MF_MEDIASOURCE_STATUS_INFO.xml' path='doc/member[@name="MF_MEDIASOURCE_STATUS_INFO"]/*'/>
public enum MF_MEDIASOURCE_STATUS_INFO
{
    /// <include file='MF_MEDIASOURCE_STATUS_INFO.xml' path='doc/member[@name="MF_MEDIASOURCE_STATUS_INFO.MF_MEDIASOURCE_STATUS_INFO_FULLYSUPPORTED"]/*'/>
    MF_MEDIASOURCE_STATUS_INFO_FULLYSUPPORTED = 0,
    /// <include file='MF_MEDIASOURCE_STATUS_INFO.xml' path='doc/member[@name="MF_MEDIASOURCE_STATUS_INFO.MF_MEDIASOURCE_STATUS_INFO_UNKNOWN"]/*'/>
    MF_MEDIASOURCE_STATUS_INFO_UNKNOWN = 1,
}