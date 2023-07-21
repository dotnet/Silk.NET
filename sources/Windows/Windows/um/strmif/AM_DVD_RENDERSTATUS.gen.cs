// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='AM_DVD_RENDERSTATUS.xml' path='doc/member[@name="AM_DVD_RENDERSTATUS"]/*' />
public partial struct AM_DVD_RENDERSTATUS
{
    /// <include file='AM_DVD_RENDERSTATUS.xml' path='doc/member[@name="AM_DVD_RENDERSTATUS.hrVPEStatus"]/*' />
    public HRESULT hrVPEStatus;

    /// <include file='AM_DVD_RENDERSTATUS.xml' path='doc/member[@name="AM_DVD_RENDERSTATUS.bDvdVolInvalid"]/*' />
    public BOOL bDvdVolInvalid;

    /// <include file='AM_DVD_RENDERSTATUS.xml' path='doc/member[@name="AM_DVD_RENDERSTATUS.bDvdVolUnknown"]/*' />
    public BOOL bDvdVolUnknown;

    /// <include file='AM_DVD_RENDERSTATUS.xml' path='doc/member[@name="AM_DVD_RENDERSTATUS.bNoLine21In"]/*' />
    public BOOL bNoLine21In;

    /// <include file='AM_DVD_RENDERSTATUS.xml' path='doc/member[@name="AM_DVD_RENDERSTATUS.bNoLine21Out"]/*' />
    public BOOL bNoLine21Out;

    /// <include file='AM_DVD_RENDERSTATUS.xml' path='doc/member[@name="AM_DVD_RENDERSTATUS.iNumStreams"]/*' />
    public int iNumStreams;

    /// <include file='AM_DVD_RENDERSTATUS.xml' path='doc/member[@name="AM_DVD_RENDERSTATUS.iNumStreamsFailed"]/*' />
    public int iNumStreamsFailed;

    /// <include file='AM_DVD_RENDERSTATUS.xml' path='doc/member[@name="AM_DVD_RENDERSTATUS.dwFailedStreamsFlag"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFailedStreamsFlag;
}
