// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MF_MSE_APPEND_MODE.xml' path='doc/member[@name="MF_MSE_APPEND_MODE"]/*'/>
public enum MF_MSE_APPEND_MODE
{
    /// <include file='MF_MSE_APPEND_MODE.xml' path='doc/member[@name="MF_MSE_APPEND_MODE.MF_MSE_APPEND_MODE_SEGMENTS"]/*'/>
    MF_MSE_APPEND_MODE_SEGMENTS = 0,
    /// <include file='MF_MSE_APPEND_MODE.xml' path='doc/member[@name="MF_MSE_APPEND_MODE.MF_MSE_APPEND_MODE_SEQUENCE"]/*'/>
    MF_MSE_APPEND_MODE_SEQUENCE = 1,
}