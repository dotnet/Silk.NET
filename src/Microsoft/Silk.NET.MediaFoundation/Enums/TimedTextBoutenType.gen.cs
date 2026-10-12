// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.MediaFoundation
{
    [NativeName("Name", "MF_TIMED_TEXT_BOUTEN_TYPE")]
    public enum TimedTextBoutenType : int
    {
        [NativeName("Name", "MF_TIMED_TEXT_BOUTEN_TYPE_NONE")]
        None = 0x0,
        [NativeName("Name", "MF_TIMED_TEXT_BOUTEN_TYPE_AUTO")]
        Auto = 0x1,
        [NativeName("Name", "MF_TIMED_TEXT_BOUTEN_TYPE_FILLEDCIRCLE")]
        Filledcircle = 0x2,
        [NativeName("Name", "MF_TIMED_TEXT_BOUTEN_TYPE_OPENCIRCLE")]
        Opencircle = 0x3,
        [NativeName("Name", "MF_TIMED_TEXT_BOUTEN_TYPE_FILLEDDOT")]
        Filleddot = 0x4,
        [NativeName("Name", "MF_TIMED_TEXT_BOUTEN_TYPE_OPENDOT")]
        Opendot = 0x5,
        [NativeName("Name", "MF_TIMED_TEXT_BOUTEN_TYPE_FILLEDSESAME")]
        Filledsesame = 0x6,
        [NativeName("Name", "MF_TIMED_TEXT_BOUTEN_TYPE_OPENSESAME")]
        Opensesame = 0x7,
    }
}
