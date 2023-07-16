// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MF_OBJECT_TYPE.xml' path='doc/member[@name="MF_OBJECT_TYPE"]/*'/>
public enum MF_OBJECT_TYPE
{
    /// <include file='MF_OBJECT_TYPE.xml' path='doc/member[@name="MF_OBJECT_TYPE.MF_OBJECT_MEDIASOURCE"]/*'/>
    MF_OBJECT_MEDIASOURCE = 0,
    /// <include file='MF_OBJECT_TYPE.xml' path='doc/member[@name="MF_OBJECT_TYPE.MF_OBJECT_BYTESTREAM"]/*'/>
    MF_OBJECT_BYTESTREAM = (MF_OBJECT_MEDIASOURCE + 1),
    /// <include file='MF_OBJECT_TYPE.xml' path='doc/member[@name="MF_OBJECT_TYPE.MF_OBJECT_INVALID"]/*'/>
    MF_OBJECT_INVALID = (MF_OBJECT_BYTESTREAM + 1),
}