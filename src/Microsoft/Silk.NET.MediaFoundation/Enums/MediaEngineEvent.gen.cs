// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_MEDIA_ENGINE_EVENT")]
    public enum MediaEngineEvent : int
    {
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_LOADSTART")]
        Loadstart = 0x1,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_PROGRESS")]
        Progress = 0x2,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_SUSPEND")]
        Suspend = 0x3,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_ABORT")]
        Abort = 0x4,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_ERROR")]
        Error = 0x5,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_EMPTIED")]
        Emptied = 0x6,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_STALLED")]
        Stalled = 0x7,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_PLAY")]
        Play = 0x8,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_PAUSE")]
        Pause = 0x9,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_LOADEDMETADATA")]
        Loadedmetadata = 0xA,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_LOADEDDATA")]
        Loadeddata = 0xB,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_WAITING")]
        Waiting = 0xC,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_PLAYING")]
        Playing = 0xD,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_CANPLAY")]
        Canplay = 0xE,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_CANPLAYTHROUGH")]
        Canplaythrough = 0xF,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_SEEKING")]
        Seeking = 0x10,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_SEEKED")]
        Seeked = 0x11,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_TIMEUPDATE")]
        Timeupdate = 0x12,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_ENDED")]
        Ended = 0x13,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_RATECHANGE")]
        Ratechange = 0x14,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_DURATIONCHANGE")]
        Durationchange = 0x15,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_VOLUMECHANGE")]
        Volumechange = 0x16,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_FORMATCHANGE")]
        Formatchange = 0x3E8,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_PURGEQUEUEDEVENTS")]
        Purgequeuedevents = 0x3E9,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_TIMELINE_MARKER")]
        TimelineMarker = 0x3EA,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_BALANCECHANGE")]
        Balancechange = 0x3EB,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_DOWNLOADCOMPLETE")]
        Downloadcomplete = 0x3EC,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_BUFFERINGSTARTED")]
        Bufferingstarted = 0x3ED,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_BUFFERINGENDED")]
        Bufferingended = 0x3EE,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_FRAMESTEPCOMPLETED")]
        Framestepcompleted = 0x3EF,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_NOTIFYSTABLESTATE")]
        Notifystablestate = 0x3F0,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_FIRSTFRAMEREADY")]
        Firstframeready = 0x3F1,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_TRACKSCHANGE")]
        Trackschange = 0x3F2,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_OPMINFO")]
        Opminfo = 0x3F3,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_RESOURCELOST")]
        Resourcelost = 0x3F4,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_DELAYLOADEVENT_CHANGED")]
        DelayloadeventChanged = 0x3F5,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_STREAMRENDERINGERROR")]
        Streamrenderingerror = 0x3F6,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_SUPPORTEDRATES_CHANGED")]
        SupportedratesChanged = 0x3F7,
        [NativeName("Name", "MF_MEDIA_ENGINE_EVENT_AUDIOENDPOINTCHANGE")]
        Audioendpointchange = 0x3F8,
    }
}
