// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MF_TIMED_TEXT_ERROR_CODE.xml' path='doc/member[@name="MF_TIMED_TEXT_ERROR_CODE"]/*'/>
public enum MF_TIMED_TEXT_ERROR_CODE
{
    /// <include file='MF_TIMED_TEXT_ERROR_CODE.xml' path='doc/member[@name="MF_TIMED_TEXT_ERROR_CODE.MF_TIMED_TEXT_ERROR_CODE_NOERROR"]/*'/>
    MF_TIMED_TEXT_ERROR_CODE_NOERROR = 0,
    /// <include file='MF_TIMED_TEXT_ERROR_CODE.xml' path='doc/member[@name="MF_TIMED_TEXT_ERROR_CODE.MF_TIMED_TEXT_ERROR_CODE_FATAL"]/*'/>
    MF_TIMED_TEXT_ERROR_CODE_FATAL = 1,
    /// <include file='MF_TIMED_TEXT_ERROR_CODE.xml' path='doc/member[@name="MF_TIMED_TEXT_ERROR_CODE.MF_TIMED_TEXT_ERROR_CODE_DATA_FORMAT"]/*'/>
    MF_TIMED_TEXT_ERROR_CODE_DATA_FORMAT = 2,
    /// <include file='MF_TIMED_TEXT_ERROR_CODE.xml' path='doc/member[@name="MF_TIMED_TEXT_ERROR_CODE.MF_TIMED_TEXT_ERROR_CODE_NETWORK"]/*'/>
    MF_TIMED_TEXT_ERROR_CODE_NETWORK = 3,
    /// <include file='MF_TIMED_TEXT_ERROR_CODE.xml' path='doc/member[@name="MF_TIMED_TEXT_ERROR_CODE.MF_TIMED_TEXT_ERROR_CODE_INTERNAL"]/*'/>
    MF_TIMED_TEXT_ERROR_CODE_INTERNAL = 4,
}