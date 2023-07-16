// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MFNETSOURCE_TRANSPORT_TYPE.xml' path='doc/member[@name="MFNETSOURCE_TRANSPORT_TYPE"]/*'/>
public enum MFNETSOURCE_TRANSPORT_TYPE
{
    /// <include file='MFNETSOURCE_TRANSPORT_TYPE.xml' path='doc/member[@name="MFNETSOURCE_TRANSPORT_TYPE.MFNETSOURCE_UDP"]/*'/>
    MFNETSOURCE_UDP = 0,
    /// <include file='MFNETSOURCE_TRANSPORT_TYPE.xml' path='doc/member[@name="MFNETSOURCE_TRANSPORT_TYPE.MFNETSOURCE_TCP"]/*'/>
    MFNETSOURCE_TCP = (MFNETSOURCE_UDP + 1),
}