// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfobjects.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using static Silk.NET.Windows.VARENUM;

namespace Silk.NET.Windows;

/// <include file='MF_ATTRIBUTE_TYPE.xml' path='doc/member[@name="MF_ATTRIBUTE_TYPE"]/*' />
public enum MF_ATTRIBUTE_TYPE
{
    /// <include file='MF_ATTRIBUTE_TYPE.xml' path='doc/member[@name="MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_UINT32"]/*' />
    MF_ATTRIBUTE_UINT32 = VT_UI4,

    /// <include file='MF_ATTRIBUTE_TYPE.xml' path='doc/member[@name="MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_UINT64"]/*' />
    MF_ATTRIBUTE_UINT64 = VT_UI8,

    /// <include file='MF_ATTRIBUTE_TYPE.xml' path='doc/member[@name="MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_DOUBLE"]/*' />
    MF_ATTRIBUTE_DOUBLE = VT_R8,

    /// <include file='MF_ATTRIBUTE_TYPE.xml' path='doc/member[@name="MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_GUID"]/*' />
    MF_ATTRIBUTE_GUID = VT_CLSID,

    /// <include file='MF_ATTRIBUTE_TYPE.xml' path='doc/member[@name="MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_STRING"]/*' />
    MF_ATTRIBUTE_STRING = VT_LPWSTR,

    /// <include file='MF_ATTRIBUTE_TYPE.xml' path='doc/member[@name="MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_BLOB"]/*' />
    MF_ATTRIBUTE_BLOB = (VT_VECTOR | VT_UI1),

    /// <include file='MF_ATTRIBUTE_TYPE.xml' path='doc/member[@name="MF_ATTRIBUTE_TYPE.MF_ATTRIBUTE_IUNKNOWN"]/*' />
    MF_ATTRIBUTE_IUNKNOWN = VT_UNKNOWN,
}
