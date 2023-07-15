// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='eAVDecVideoCodecType.xml' path='doc/member[@name="eAVDecVideoCodecType"]/*'/>
public enum eAVDecVideoCodecType
{
    /// <include file='eAVDecVideoCodecType.xml' path='doc/member[@name="eAVDecVideoCodecType.eAVDecVideoCodecType_NOTPLAYING"]/*'/>
    eAVDecVideoCodecType_NOTPLAYING = 0,
    /// <include file='eAVDecVideoCodecType.xml' path='doc/member[@name="eAVDecVideoCodecType.eAVDecVideoCodecType_MPEG2"]/*'/>
    eAVDecVideoCodecType_MPEG2 = 1,
    /// <include file='eAVDecVideoCodecType.xml' path='doc/member[@name="eAVDecVideoCodecType.eAVDecVideoCodecType_H264"]/*'/>
    eAVDecVideoCodecType_H264 = 2,
}