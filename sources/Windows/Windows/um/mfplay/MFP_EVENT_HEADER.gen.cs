// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfplay.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='MFP_EVENT_HEADER.xml' path='doc/member[@name="MFP_EVENT_HEADER"]/*' />
public unsafe partial struct MFP_EVENT_HEADER
{
    /// <include file='MFP_EVENT_HEADER.xml' path='doc/member[@name="MFP_EVENT_HEADER.eEventType"]/*' />
    public MFP_EVENT_TYPE eEventType;

    /// <include file='MFP_EVENT_HEADER.xml' path='doc/member[@name="MFP_EVENT_HEADER.hrEvent"]/*' />
    public HRESULT hrEvent;

    /// <include file='MFP_EVENT_HEADER.xml' path='doc/member[@name="MFP_EVENT_HEADER.pMediaPlayer"]/*' />
    public IMFPMediaPlayer* pMediaPlayer;

    /// <include file='MFP_EVENT_HEADER.xml' path='doc/member[@name="MFP_EVENT_HEADER.eState"]/*' />
    public MFP_MEDIAPLAYER_STATE eState;

    /// <include file='MFP_EVENT_HEADER.xml' path='doc/member[@name="MFP_EVENT_HEADER.pPropertyStore"]/*' />
    public IPropertyStore* pPropertyStore;
}
