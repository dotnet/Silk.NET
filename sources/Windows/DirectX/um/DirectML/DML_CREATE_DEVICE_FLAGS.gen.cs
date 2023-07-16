// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.DirectX;
/// <include file='DML_CREATE_DEVICE_FLAGS.xml' path='doc/member[@name="DML_CREATE_DEVICE_FLAGS"]/*'/>
[Flags]
public enum DML_CREATE_DEVICE_FLAGS
{
    /// <include file='DML_CREATE_DEVICE_FLAGS.xml' path='doc/member[@name="DML_CREATE_DEVICE_FLAGS.DML_CREATE_DEVICE_FLAG_NONE"]/*'/>
    DML_CREATE_DEVICE_FLAG_NONE = 0,
    /// <include file='DML_CREATE_DEVICE_FLAGS.xml' path='doc/member[@name="DML_CREATE_DEVICE_FLAGS.DML_CREATE_DEVICE_FLAG_DEBUG"]/*'/>
    DML_CREATE_DEVICE_FLAG_DEBUG = 0x1,
}