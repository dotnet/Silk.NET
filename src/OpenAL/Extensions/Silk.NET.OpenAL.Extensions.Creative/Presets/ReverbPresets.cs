// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Numerics;

namespace Silk.NET.OpenAL.Extensions.Creative
{
    /// <summary>
    /// A set of reverb presets that can be used with the extension.
    /// </summary>
    public static class ReverbPresets
    {
        /// <summary>
        /// A reverb preset (approximating a generic location).
        /// </summary>
        public static readonly ReverbProperties Generic = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.8913f,
            1.0000f,
            1.4900f,
            0.8300f,
            1.0000f,
            0.0500f,
            0.0070f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.2589f,
            0.0110f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a padded cell).
        /// </summary>
        public static readonly ReverbProperties PaddedCell = new ReverbProperties
        (
            0.1715f,
            1.0000f,
            0.3162f,
            0.0010f,
            1.0000f,
            0.1700f,
            0.1000f,
            1.0000f,
            0.2500f,
            0.0010f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.2691f,
            0.0020f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a room).
        /// </summary>
        public static readonly ReverbProperties Room = new ReverbProperties
        (
            0.4287f,
            1.0000f,
            0.3162f,
            0.5929f,
            1.0000f,
            0.4000f,
            0.8300f,
            1.0000f,
            0.1503f,
            0.0020f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.0629f,
            0.0030f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a bathroom).
        /// </summary>
        public static readonly ReverbProperties Bathroom = new ReverbProperties
        (
            0.1715f,
            1.0000f,
            0.3162f,
            0.2512f,
            1.0000f,
            1.4900f,
            0.5400f,
            1.0000f,
            0.6531f,
            0.0070f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            3.2734f,
            0.0110f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a living room).
        /// </summary>
        public static readonly ReverbProperties LivingRoom = new ReverbProperties
        (
            0.9766f,
            1.0000f,
            0.3162f,
            0.0010f,
            1.0000f,
            0.5000f,
            0.1000f,
            1.0000f,
            0.2051f,
            0.0030f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2805f,
            0.0040f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a stone room).
        /// </summary>
        public static readonly ReverbProperties StoneRoom = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.7079f,
            1.0000f,
            2.3100f,
            0.6400f,
            1.0000f,
            0.4411f,
            0.0120f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.1003f,
            0.0170f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating an auditorium).
        /// </summary>
        public static readonly ReverbProperties Auditorium = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.5781f,
            1.0000f,
            4.3200f,
            0.5900f,
            1.0000f,
            0.4032f,
            0.0200f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.7170f,
            0.0300f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a concert hall).
        /// </summary>
        public static readonly ReverbProperties ConcertHall = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.5623f,
            1.0000f,
            3.9200f,
            0.7000f,
            1.0000f,
            0.2427f,
            0.0200f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.9977f,
            0.0290f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a cave).
        /// </summary>
        public static readonly ReverbProperties Cave = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            1.0000f,
            1.0000f,
            2.9100f,
            1.3000f,
            1.0000f,
            0.5000f,
            0.0150f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.7063f,
            0.0220f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating an arena).
        /// </summary>
        public static readonly ReverbProperties Arena = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.4477f,
            1.0000f,
            7.2400f,
            0.3300f,
            1.0000f,
            0.2612f,
            0.0200f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.0186f,
            0.0300f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a hangar).
        /// </summary>
        public static readonly ReverbProperties Hangar = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.3162f,
            1.0000f,
            10.0500f,
            0.2300f,
            1.0000f,
            0.5000f,
            0.0200f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.2560f,
            0.0300f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a carpeted hallway).
        /// </summary>
        public static readonly ReverbProperties CarpetedHallway = new ReverbProperties
        (
            0.4287f,
            1.0000f,
            0.3162f,
            0.0100f,
            1.0000f,
            0.3000f,
            0.1000f,
            1.0000f,
            0.1215f,
            0.0020f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1531f,
            0.0300f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a hallway).
        /// </summary>
        public static readonly ReverbProperties Hallway = new ReverbProperties
        (
            0.3645f,
            1.0000f,
            0.3162f,
            0.7079f,
            1.0000f,
            1.4900f,
            0.5900f,
            1.0000f,
            0.2458f,
            0.0070f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.6615f,
            0.0110f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a stone corridor).
        /// </summary>
        public static readonly ReverbProperties StoneCorridor = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.7612f,
            1.0000f,
            2.7000f,
            0.7900f,
            1.0000f,
            0.2472f,
            0.0130f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.5758f,
            0.0200f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating an alley).
        /// </summary>
        public static readonly ReverbProperties Alley = new ReverbProperties
        (
            1.0000f,
            0.3000f,
            0.3162f,
            0.7328f,
            1.0000f,
            1.4900f,
            0.8600f,
            1.0000f,
            0.2500f,
            0.0070f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.9954f,
            0.0110f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1250f,
            0.9500f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a forest).
        /// </summary>
        public static readonly ReverbProperties Forest = new ReverbProperties
        (
            1.0000f,
            0.3000f,
            0.3162f,
            0.0224f,
            1.0000f,
            1.4900f,
            0.5400f,
            1.0000f,
            0.0525f,
            0.1620f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.7682f,
            0.0880f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1250f,
            1.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a city).
        /// </summary>
        public static readonly ReverbProperties City = new ReverbProperties
        (
            1.0000f,
            0.5000f,
            0.3162f,
            0.3981f,
            1.0000f,
            1.4900f,
            0.6700f,
            1.0000f,
            0.0730f,
            0.0070f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1427f,
            0.0110f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a mountain).
        /// </summary>
        public static readonly ReverbProperties Mountains = new ReverbProperties
        (
            1.0000f,
            0.2700f,
            0.3162f,
            0.0562f,
            1.0000f,
            1.4900f,
            0.2100f,
            1.0000f,
            0.0407f,
            0.3000f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1919f,
            0.1000f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            1.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating a quarry).
        /// </summary>
        public static readonly ReverbProperties Quarry = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.3162f,
            1.0000f,
            1.4900f,
            0.8300f,
            1.0000f,
            0.0000f,
            0.0610f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.7783f,
            0.0250f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1250f,
            0.7000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a plain).
        /// </summary>
        public static readonly ReverbProperties Plain = new ReverbProperties
        (
            1.0000f,
            0.2100f,
            0.3162f,
            0.1000f,
            1.0000f,
            1.4900f,
            0.5000f,
            1.0000f,
            0.0585f,
            0.1790f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1089f,
            0.1000f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            1.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a parking lot).
        /// </summary>
        public static readonly ReverbProperties ParkingLot = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            1.0000f,
            1.0000f,
            1.6500f,
            1.5000f,
            1.0000f,
            0.2082f,
            0.0080f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2652f,
            0.0120f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating a sewer pipe).
        /// </summary>
        public static readonly ReverbProperties Sewerpipe = new ReverbProperties
        (
            0.3071f,
            0.8000f,
            0.3162f,
            0.3162f,
            1.0000f,
            2.8100f,
            0.1400f,
            1.0000f,
            1.6387f,
            0.0140f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            3.2471f,
            0.0210f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating an underwater location).
        /// </summary>
        public static readonly ReverbProperties Underwater = new ReverbProperties
        (
            0.3645f,
            1.0000f,
            0.3162f,
            0.0100f,
            1.0000f,
            1.4900f,
            0.1000f,
            1.0000f,
            0.5963f,
            0.0070f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            7.0795f,
            0.0110f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            1.1800f,
            0.3480f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a drugged state).
        /// </summary>
        public static readonly ReverbProperties Drugged = new ReverbProperties
        (
            0.4287f,
            0.5000f,
            0.3162f,
            1.0000f,
            1.0000f,
            8.3900f,
            1.3900f,
            1.0000f,
            0.8760f,
            0.0020f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            3.1081f,
            0.0300f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            1.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating a dizzy state).
        /// </summary>
        public static readonly ReverbProperties Dizzy = new ReverbProperties
        (
            0.3645f,
            0.6000f,
            0.3162f,
            0.6310f,
            1.0000f,
            17.2300f,
            0.5600f,
            1.0000f,
            0.1392f,
            0.0200f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.4937f,
            0.0300f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            1.0000f,
            0.8100f,
            0.3100f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating a psychotic state).
        /// </summary>
        public static readonly ReverbProperties Psychotic = new ReverbProperties
        (
            0.0625f,
            0.5000f,
            0.3162f,
            0.8404f,
            1.0000f,
            7.5600f,
            0.9100f,
            1.0000f,
            0.4864f,
            0.0200f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            2.4378f,
            0.0300f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            4.0000f,
            1.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x0
        );

        /* Castle Presets */

        /// <summary>
        /// A reverb preset (approximating a small room in a castle).
        /// </summary>
        public static readonly ReverbProperties CastleSmallRoom = new ReverbProperties
        (
            1.0000f,
            0.8900f,
            0.3162f,
            0.3981f,
            0.1000f,
            1.2200f,
            0.8300f,
            0.3100f,
            0.8913f,
            0.0220f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.9953f,
            0.0110f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1380f,
            0.0800f,
            0.2500f,
            0.0000f,
            0.9943f,
            5168.6001f,
            139.5000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a short passage in a castle).
        /// </summary>
        public static readonly ReverbProperties CastleShortPassage = new ReverbProperties
        (
            1.0000f,
            0.8900f,
            0.3162f,
            0.3162f,
            0.1000f,
            2.3200f,
            0.8300f,
            0.3100f,
            0.8913f,
            0.0070f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.2589f,
            0.0230f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1380f,
            0.0800f,
            0.2500f,
            0.0000f,
            0.9943f,
            5168.6001f,
            139.5000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a medium room in a castle).
        /// </summary>
        public static readonly ReverbProperties CastleMediumRoom = new ReverbProperties
        (
            1.0000f,
            0.9300f,
            0.3162f,
            0.2818f,
            0.1000f,
            2.0400f,
            0.8300f,
            0.4600f,
            0.6310f,
            0.0220f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.5849f,
            0.0110f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1550f,
            0.0300f,
            0.2500f,
            0.0000f,
            0.9943f,
            5168.6001f,
            139.5000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a large room in a castle).
        /// </summary>
        public static readonly ReverbProperties CastleLargeRoom = new ReverbProperties
        (
            1.0000f,
            0.8200f,
            0.3162f,
            0.2818f,
            0.1259f,
            2.5300f,
            0.8300f,
            0.5000f,
            0.4467f,
            0.0340f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.2589f,
            0.0160f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1850f,
            0.0700f,
            0.2500f,
            0.0000f,
            0.9943f,
            5168.6001f,
            139.5000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a long passage in a castle).
        /// </summary>
        public static readonly ReverbProperties CastleLongPassage = new ReverbProperties
        (
            1.0000f,
            0.8900f,
            0.3162f,
            0.3981f,
            0.1000f,
            3.4200f,
            0.8300f,
            0.3100f,
            0.8913f,
            0.0070f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.4125f,
            0.0230f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1380f,
            0.0800f,
            0.2500f,
            0.0000f,
            0.9943f,
            5168.6001f,
            139.5000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a hall in a castle).
        /// </summary>
        public static readonly ReverbProperties CastleHall = new ReverbProperties
        (
            1.0000f,
            0.8100f,
            0.3162f,
            0.2818f,
            0.1778f,
            3.1400f,
            0.7900f,
            0.6200f,
            0.1778f,
            0.0560f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.1220f,
            0.0240f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5168.6001f,
            139.5000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a cupboard in a castle).
        /// </summary>
        public static readonly ReverbProperties CastleCupboard = new ReverbProperties
        (
            1.0000f,
            0.8900f,
            0.3162f,
            0.2818f,
            0.1000f,
            0.6700f,
            0.8700f,
            0.3100f,
            1.4125f,
            0.0100f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            3.5481f,
            0.0070f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1380f,
            0.0800f,
            0.2500f,
            0.0000f,
            0.9943f,
            5168.6001f,
            139.5000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a castle courtyard).
        /// </summary>
        public static readonly ReverbProperties CastleCourtyard = new ReverbProperties
        (
            1.0000f,
            0.4200f,
            0.3162f,
            0.4467f,
            0.1995f,
            2.1300f,
            0.6100f,
            0.2300f,
            0.2239f,
            0.1600f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.7079f,
            0.0360f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.3700f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating an alcove in a castle).
        /// </summary>
        public static readonly ReverbProperties CastleAlcove = new ReverbProperties
        (
            1.0000f,
            0.8900f,
            0.3162f,
            0.5012f,
            0.1000f,
            1.6400f,
            0.8700f,
            0.3100f,
            1.0000f,
            0.0070f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.4125f,
            0.0340f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1380f,
            0.0800f,
            0.2500f,
            0.0000f,
            0.9943f,
            5168.6001f,
            139.5000f,
            0.0000f,
            0x1
        );

        /* Factory Presets */

        /// <summary>
        /// A reverb preset (approximating a small room in a factory).
        /// </summary>
        public static readonly ReverbProperties FactorySmallRoom = new ReverbProperties
        (
            0.3645f,
            0.8200f,
            0.3162f,
            0.7943f,
            0.5012f,
            1.7200f,
            0.6500f,
            1.3100f,
            0.7079f,
            0.0100f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.7783f,
            0.0240f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1190f,
            0.0700f,
            0.2500f,
            0.0000f,
            0.9943f,
            3762.6001f,
            362.5000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a short passage in a factory).
        /// </summary>
        public static readonly ReverbProperties FactoryShortPassage = new ReverbProperties
        (
            0.3645f,
            0.6400f,
            0.2512f,
            0.7943f,
            0.5012f,
            2.5300f,
            0.6500f,
            1.3100f,
            1.0000f,
            0.0100f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.2589f,
            0.0380f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1350f,
            0.2300f,
            0.2500f,
            0.0000f,
            0.9943f,
            3762.6001f,
            362.5000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a medium room in a factory).
        /// </summary>
        public static readonly ReverbProperties FactoryMediumRoom = new ReverbProperties
        (
            0.4287f,
            0.8200f,
            0.2512f,
            0.7943f,
            0.5012f,
            2.7600f,
            0.6500f,
            1.3100f,
            0.2818f,
            0.0220f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.4125f,
            0.0230f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1740f,
            0.0700f,
            0.2500f,
            0.0000f,
            0.9943f,
            3762.6001f,
            362.5000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a large room in a factory).
        /// </summary>
        public static readonly ReverbProperties FactoryLargeRoom = new ReverbProperties
        (
            0.4287f,
            0.7500f,
            0.2512f,
            0.7079f,
            0.6310f,
            4.2400f,
            0.5100f,
            1.3100f,
            0.1778f,
            0.0390f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.1220f,
            0.0230f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2310f,
            0.0700f,
            0.2500f,
            0.0000f,
            0.9943f,
            3762.6001f,
            362.5000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a long passage in a factory).
        /// </summary>
        public static readonly ReverbProperties FactoryLongPassage = new ReverbProperties
        (
            0.3645f,
            0.6400f,
            0.2512f,
            0.7943f,
            0.5012f,
            4.0600f,
            0.6500f,
            1.3100f,
            1.0000f,
            0.0200f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.2589f,
            0.0370f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1350f,
            0.2300f,
            0.2500f,
            0.0000f,
            0.9943f,
            3762.6001f,
            362.5000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a hall in a factory).
        /// </summary>
        public static readonly ReverbProperties FactoryHall = new ReverbProperties
        (
            0.4287f,
            0.7500f,
            0.3162f,
            0.7079f,
            0.6310f,
            7.4300f,
            0.5100f,
            1.3100f,
            0.0631f,
            0.0730f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.8913f,
            0.0270f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0700f,
            0.2500f,
            0.0000f,
            0.9943f,
            3762.6001f,
            362.5000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a cupboard in a factory).
        /// </summary>
        public static readonly ReverbProperties FactoryCupboard = new ReverbProperties
        (
            0.3071f,
            0.6300f,
            0.2512f,
            0.7943f,
            0.5012f,
            0.4900f,
            0.6500f,
            1.3100f,
            1.2589f,
            0.0100f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.9953f,
            0.0320f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1070f,
            0.0700f,
            0.2500f,
            0.0000f,
            0.9943f,
            3762.6001f,
            362.5000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a factory courtyard).
        /// </summary>
        public static readonly ReverbProperties FactoryCourtyard = new ReverbProperties
        (
            0.3071f,
            0.5700f,
            0.3162f,
            0.3162f,
            0.6310f,
            2.3200f,
            0.2900f,
            0.5600f,
            0.2239f,
            0.1400f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.3981f,
            0.0390f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.2900f,
            0.2500f,
            0.0000f,
            0.9943f,
            3762.6001f,
            362.5000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating an alcove in a factory).
        /// </summary>
        public static readonly ReverbProperties FactoryAlcove = new ReverbProperties
        (
            0.3645f,
            0.5900f,
            0.2512f,
            0.7943f,
            0.5012f,
            3.1400f,
            0.6500f,
            1.3100f,
            1.4125f,
            0.0100f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.0000f,
            0.0380f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1140f,
            0.1000f,
            0.2500f,
            0.0000f,
            0.9943f,
            3762.6001f,
            362.5000f,
            0.0000f,
            0x1
        );

        /* Ice Palace Presets */

        /// <summary>
        /// A reverb preset (approximating a small room in an ice palace).
        /// </summary>
        public static readonly ReverbProperties IcePalaceSmallRoom = new ReverbProperties
        (
            1.0000f,
            0.8400f,
            0.3162f,
            0.5623f,
            0.2818f,
            1.5100f,
            1.5300f,
            0.2700f,
            0.8913f,
            0.0100f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.4125f,
            0.0110f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1640f,
            0.1400f,
            0.2500f,
            0.0000f,
            0.9943f,
            12428.5000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a short passage in an ice palace).
        /// </summary>
        public static readonly ReverbProperties IcePalaceShortPassage = new ReverbProperties
        (
            1.0000f,
            0.7500f,
            0.3162f,
            0.5623f,
            0.2818f,
            1.7900f,
            1.4600f,
            0.2800f,
            0.5012f,
            0.0100f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.1220f,
            0.0190f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1770f,
            0.0900f,
            0.2500f,
            0.0000f,
            0.9943f,
            12428.5000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a medium room in an ice palace).
        /// </summary>
        public static readonly ReverbProperties IcePalaceMediumRoom = new ReverbProperties
        (
            1.0000f,
            0.8700f,
            0.3162f,
            0.5623f,
            0.4467f,
            2.2200f,
            1.5300f,
            0.3200f,
            0.3981f,
            0.0390f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.1220f,
            0.0270f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1860f,
            0.1200f,
            0.2500f,
            0.0000f,
            0.9943f,
            12428.5000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a large room in an ice palace).
        /// </summary>
        public static readonly ReverbProperties IcePalaceLargeRoom = new ReverbProperties
        (
            1.0000f,
            0.8100f,
            0.3162f,
            0.5623f,
            0.4467f,
            3.1400f,
            1.5300f,
            0.3200f,
            0.2512f,
            0.0390f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.0000f,
            0.0270f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2140f,
            0.1100f,
            0.2500f,
            0.0000f,
            0.9943f,
            12428.5000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a long passage in an ice palace).
        /// </summary>
        public static readonly ReverbProperties IcePalaceLongPassage = new ReverbProperties
        (
            1.0000f,
            0.7700f,
            0.3162f,
            0.5623f,
            0.3981f,
            3.0100f,
            1.4600f,
            0.2800f,
            0.7943f,
            0.0120f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.2589f,
            0.0250f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1860f,
            0.0400f,
            0.2500f,
            0.0000f,
            0.9943f,
            12428.5000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a hall in an ice palace).
        /// </summary>
        public static readonly ReverbProperties IcePalaceHall = new ReverbProperties
        (
            1.0000f,
            0.7600f,
            0.3162f,
            0.4467f,
            0.5623f,
            5.4900f,
            1.5300f,
            0.3800f,
            0.1122f,
            0.0540f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.6310f,
            0.0520f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2260f,
            0.1100f,
            0.2500f,
            0.0000f,
            0.9943f,
            12428.5000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a cupboard in an ice palace).
        /// </summary>
        public static readonly ReverbProperties IcePalaceCupboard = new ReverbProperties
        (
            1.0000f,
            0.8300f,
            0.3162f,
            0.5012f,
            0.2239f,
            0.7600f,
            1.5300f,
            0.2600f,
            1.1220f,
            0.0120f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.9953f,
            0.0160f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1430f,
            0.0800f,
            0.2500f,
            0.0000f,
            0.9943f,
            12428.5000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating an ice palace courtyard).
        /// </summary>
        public static readonly ReverbProperties IcePalaceCourtyard = new ReverbProperties
        (
            1.0000f,
            0.5900f,
            0.3162f,
            0.2818f,
            0.3162f,
            2.0400f,
            1.2000f,
            0.3800f,
            0.3162f,
            0.1730f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.3162f,
            0.0430f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2350f,
            0.4800f,
            0.2500f,
            0.0000f,
            0.9943f,
            12428.5000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating an alcove in an ice palace).
        /// </summary>
        public static readonly ReverbProperties IcePalaceAlcove = new ReverbProperties
        (
            1.0000f,
            0.8400f,
            0.3162f,
            0.5623f,
            0.2818f,
            2.7600f,
            1.4600f,
            0.2800f,
            1.1220f,
            0.0100f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.8913f,
            0.0300f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1610f,
            0.0900f,
            0.2500f,
            0.0000f,
            0.9943f,
            12428.5000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /* Space Station Presets */

        /// <summary>
        /// A reverb preset (approximating a small room in a space station).
        /// </summary>
        public static readonly ReverbProperties SpaceStationSmallRoom = new ReverbProperties
        (
            0.2109f,
            0.7000f,
            0.3162f,
            0.7079f,
            0.8913f,
            1.7200f,
            0.8200f,
            0.5500f,
            0.7943f,
            0.0070f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.4125f,
            0.0130f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1880f,
            0.2600f,
            0.2500f,
            0.0000f,
            0.9943f,
            3316.1001f,
            458.2000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a short passage in a space station).
        /// </summary>
        public static readonly ReverbProperties SpaceStationShortPassage = new ReverbProperties
        (
            0.2109f,
            0.8700f,
            0.3162f,
            0.6310f,
            0.8913f,
            3.5700f,
            0.5000f,
            0.5500f,
            1.0000f,
            0.0120f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.1220f,
            0.0160f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1720f,
            0.2000f,
            0.2500f,
            0.0000f,
            0.9943f,
            3316.1001f,
            458.2000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a medium room in a space station).
        /// </summary>
        public static readonly ReverbProperties SpaceStationMediumRoom = new ReverbProperties
        (
            0.2109f,
            0.7500f,
            0.3162f,
            0.6310f,
            0.8913f,
            3.0100f,
            0.5000f,
            0.5500f,
            0.3981f,
            0.0340f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.1220f,
            0.0350f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2090f,
            0.3100f,
            0.2500f,
            0.0000f,
            0.9943f,
            3316.1001f,
            458.2000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a large room in a space station).
        /// </summary>
        public static readonly ReverbProperties SpaceStationLargeRoom = new ReverbProperties
        (
            0.3645f,
            0.8100f,
            0.3162f,
            0.6310f,
            0.8913f,
            3.8900f,
            0.3800f,
            0.6100f,
            0.3162f,
            0.0560f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.8913f,
            0.0350f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2330f,
            0.2800f,
            0.2500f,
            0.0000f,
            0.9943f,
            3316.1001f,
            458.2000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a long passage in a space station).
        /// </summary>
        public static readonly ReverbProperties SpaceStationLongPassage = new ReverbProperties
        (
            0.4287f,
            0.8200f,
            0.3162f,
            0.6310f,
            0.8913f,
            4.6200f,
            0.6200f,
            0.5500f,
            1.0000f,
            0.0120f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.2589f,
            0.0310f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.2300f,
            0.2500f,
            0.0000f,
            0.9943f,
            3316.1001f,
            458.2000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a hall in a space station).
        /// </summary>
        public static readonly ReverbProperties SpaceStationHall = new ReverbProperties
        (
            0.4287f,
            0.8700f,
            0.3162f,
            0.6310f,
            0.8913f,
            7.1100f,
            0.3800f,
            0.6100f,
            0.1778f,
            0.1000f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.6310f,
            0.0470f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.2500f,
            0.2500f,
            0.0000f,
            0.9943f,
            3316.1001f,
            458.2000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a cupboard in a space station).
        /// </summary>
        public static readonly ReverbProperties SpaceStationCupboard = new ReverbProperties
        (
            0.1715f,
            0.5600f,
            0.3162f,
            0.7079f,
            0.8913f,
            0.7900f,
            0.8100f,
            0.5500f,
            1.4125f,
            0.0070f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.7783f,
            0.0180f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1810f,
            0.3100f,
            0.2500f,
            0.0000f,
            0.9943f,
            3316.1001f,
            458.2000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating an alcove in a space station).
        /// </summary>
        public static readonly ReverbProperties SpaceStationAlcove = new ReverbProperties
        (
            0.2109f,
            0.7800f,
            0.3162f,
            0.7079f,
            0.8913f,
            1.1600f,
            0.8100f,
            0.5500f,
            1.4125f,
            0.0070f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.0000f,
            0.0180f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1920f,
            0.2100f,
            0.2500f,
            0.0000f,
            0.9943f,
            3316.1001f,
            458.2000f,
            0.0000f,
            0x1
        );

        /* Wooden Galleon Presets */

        /// <summary>
        /// A reverb preset (approximating a small room in a wooden galleon).
        /// </summary>
        public static readonly ReverbProperties WoodenGalleonSmallRoom = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.1122f,
            0.3162f,
            0.7900f,
            0.3200f,
            0.8700f,
            1.0000f,
            0.0320f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.8913f,
            0.0290f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            4705.0000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a short passage in a wooden galleon).
        /// </summary>
        public static readonly ReverbProperties WoodenGalleonShortPassage = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.1259f,
            0.3162f,
            1.7500f,
            0.5000f,
            0.8700f,
            0.8913f,
            0.0120f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.6310f,
            0.0240f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            4705.0000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a medium room in a wooden galleon).
        /// </summary>
        public static readonly ReverbProperties WoodenGalleonMediumRoom = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.1000f,
            0.2818f,
            1.4700f,
            0.4200f,
            0.8200f,
            0.8913f,
            0.0490f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.8913f,
            0.0290f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            4705.0000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a large room in a wooden galleon).
        /// </summary>
        public static readonly ReverbProperties WoodenGalleonLargeRoom = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.0891f,
            0.2818f,
            2.6500f,
            0.3300f,
            0.8200f,
            0.8913f,
            0.0660f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.7943f,
            0.0490f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            4705.0000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a long passsage in a wooden galleon).
        /// </summary>
        public static readonly ReverbProperties WoodenGalleonLongPassage = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.1000f,
            0.3162f,
            1.9900f,
            0.4000f,
            0.7900f,
            1.0000f,
            0.0200f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.4467f,
            0.0360f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            4705.0000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a hall in a wooden galleon).
        /// </summary>
        public static readonly ReverbProperties WoodenGalleonHall = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.0794f,
            0.2818f,
            3.4500f,
            0.3000f,
            0.8200f,
            0.8913f,
            0.0880f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.7943f,
            0.0630f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            4705.0000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a cupboard in a wooden galleon).
        /// </summary>
        public static readonly ReverbProperties WoodenGalleonCupboard = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.1413f,
            0.3162f,
            0.5600f,
            0.4600f,
            0.9100f,
            1.1220f,
            0.0120f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.1220f,
            0.0280f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            4705.0000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a courtyard on a wooden galleon).
        /// </summary>
        public static readonly ReverbProperties WoodenGalleonCourtyard = new ReverbProperties
        (
            1.0000f,
            0.6500f,
            0.3162f,
            0.0794f,
            0.3162f,
            1.7900f,
            0.3500f,
            0.7900f,
            0.5623f,
            0.1230f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1000f,
            0.0320f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            4705.0000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating an alcove in a wooden galleon).
        /// </summary>
        public static readonly ReverbProperties WoodenGalleonAlcove = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.1259f,
            0.3162f,
            1.2200f,
            0.6200f,
            0.9100f,
            1.1220f,
            0.0120f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.7079f,
            0.0240f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            4705.0000f,
            99.6000f,
            0.0000f,
            0x1
        );

        /* Sports Presets */

        /// <summary>
        /// A reverb preset (approximating an empty sports stadium).
        /// </summary>
        public static readonly ReverbProperties SportEmptyStadium = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.4467f,
            0.7943f,
            6.2600f,
            0.5100f,
            1.1000f,
            0.0631f,
            0.1830f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.3981f,
            0.0380f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a squash court).
        /// </summary>
        public static readonly ReverbProperties SportSquashCourt = new ReverbProperties
        (
            1.0000f,
            0.7500f,
            0.3162f,
            0.3162f,
            0.7943f,
            2.2200f,
            0.9100f,
            1.1600f,
            0.4467f,
            0.0070f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.7943f,
            0.0110f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1260f,
            0.1900f,
            0.2500f,
            0.0000f,
            0.9943f,
            7176.8999f,
            211.2000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a small swimming pool).
        /// </summary>
        public static readonly ReverbProperties SportSmallSwimmingPool = new ReverbProperties
        (
            1.0000f,
            0.7000f,
            0.3162f,
            0.7943f,
            0.8913f,
            2.7600f,
            1.2500f,
            1.1400f,
            0.6310f,
            0.0200f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.7943f,
            0.0300f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1790f,
            0.1500f,
            0.8950f,
            0.1900f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating a large swimming pool).
        /// </summary>
        public static readonly ReverbProperties SportLargeSwimmingPool = new ReverbProperties
        (
            1.0000f,
            0.8200f,
            0.3162f,
            0.7943f,
            1.0000f,
            5.4900f,
            1.3100f,
            1.1400f,
            0.4467f,
            0.0390f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.5012f,
            0.0490f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2220f,
            0.5500f,
            1.1590f,
            0.2100f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating a gymnasium).
        /// </summary>
        public static readonly ReverbProperties SportGymnasium = new ReverbProperties
        (
            1.0000f,
            0.8100f,
            0.3162f,
            0.4467f,
            0.8913f,
            3.1400f,
            1.0600f,
            1.3500f,
            0.3981f,
            0.0290f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.5623f,
            0.0450f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1460f,
            0.1400f,
            0.2500f,
            0.0000f,
            0.9943f,
            7176.8999f,
            211.2000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a full stadium).
        /// </summary>
        public static readonly ReverbProperties SportFullStadium = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.0708f,
            0.7943f,
            5.2500f,
            0.1700f,
            0.8000f,
            0.1000f,
            0.1880f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2818f,
            0.0380f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a tannoy stadium).
        /// </summary>
        public static readonly ReverbProperties SportStadiumTannoy = new ReverbProperties
        (
            1.0000f,
            0.7800f,
            0.3162f,
            0.5623f,
            0.5012f,
            2.5300f,
            0.8800f,
            0.6800f,
            0.2818f,
            0.2300f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.5012f,
            0.0630f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.2000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /* Prefab Presets */

        /// <summary>
        /// A reverb preset (approximating a workshop).
        /// </summary>
        public static readonly ReverbProperties PrefabWorkshop = new ReverbProperties
        (
            0.4287f,
            1.0000f,
            0.3162f,
            0.1413f,
            0.3981f,
            0.7600f,
            1.0000f,
            1.0000f,
            1.0000f,
            0.0120f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.1220f,
            0.0120f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating a school room).
        /// </summary>
        public static readonly ReverbProperties PrefabSchoolRoom = new ReverbProperties
        (
            0.4022f,
            0.6900f,
            0.3162f,
            0.6310f,
            0.5012f,
            0.9800f,
            0.4500f,
            0.1800f,
            1.4125f,
            0.0170f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.4125f,
            0.0150f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.0950f,
            0.1400f,
            0.2500f,
            0.0000f,
            0.9943f,
            7176.8999f,
            211.2000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a practise room).
        /// </summary>
        public static readonly ReverbProperties PrefabPractiseRoom = new ReverbProperties
        (
            0.4022f,
            0.8700f,
            0.3162f,
            0.3981f,
            0.5012f,
            1.1200f,
            0.5600f,
            0.1800f,
            1.2589f,
            0.0100f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.4125f,
            0.0110f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.0950f,
            0.1400f,
            0.2500f,
            0.0000f,
            0.9943f,
            7176.8999f,
            211.2000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating an outhouse).
        /// </summary>
        public static readonly ReverbProperties PrefabOuthouse = new ReverbProperties
        (
            1.0000f,
            0.8200f,
            0.3162f,
            0.1122f,
            0.1585f,
            1.3800f,
            0.3800f,
            0.3500f,
            0.8913f,
            0.0240f,
            new Vector3(0.0000f, 0.0000f, -0.0000f),
            0.6310f,
            0.0440f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1210f,
            0.1700f,
            0.2500f,
            0.0000f,
            0.9943f,
            2854.3999f,
            107.5000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating a caravan).
        /// </summary>
        public static readonly ReverbProperties PrefabCaravan = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.0891f,
            0.1259f,
            0.4300f,
            1.5000f,
            1.0000f,
            1.0000f,
            0.0120f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.9953f,
            0.0120f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x0
        );

        /* Dome and Pipe Presets */

        /// <summary>
        /// A reverb preset (approximating a dome in a tomb).
        /// </summary>
        public static readonly ReverbProperties DomeTomb = new ReverbProperties
        (
            1.0000f,
            0.7900f,
            0.3162f,
            0.3548f,
            0.2239f,
            4.1800f,
            0.2100f,
            0.1000f,
            0.3868f,
            0.0300f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.6788f,
            0.0220f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1770f,
            0.1900f,
            0.2500f,
            0.0000f,
            0.9943f,
            2854.3999f,
            20.0000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating a small pipe).
        /// </summary>
        public static readonly ReverbProperties PipeSmall = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.3548f,
            0.2239f,
            5.0400f,
            0.1000f,
            0.1000f,
            0.5012f,
            0.0320f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            2.5119f,
            0.0150f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            2854.3999f,
            20.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating the dome in St. Paul's Cathedral, London).
        /// </summary>
        public static readonly ReverbProperties DomeSaintPauls = new ReverbProperties
        (
            1.0000f,
            0.8700f,
            0.3162f,
            0.3548f,
            0.2239f,
            10.4800f,
            0.1900f,
            0.1000f,
            0.1778f,
            0.0900f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.2589f,
            0.0420f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.1200f,
            0.2500f,
            0.0000f,
            0.9943f,
            2854.3999f,
            20.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a long, thin pipe).
        /// </summary>
        public static readonly ReverbProperties PipeLongThin = new ReverbProperties
        (
            0.2560f,
            0.9100f,
            0.3162f,
            0.4467f,
            0.2818f,
            9.2100f,
            0.1800f,
            0.1000f,
            0.7079f,
            0.0100f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.7079f,
            0.0220f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            2854.3999f,
            20.0000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating a large pipe).
        /// </summary>
        public static readonly ReverbProperties PipeLarge = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.3548f,
            0.2239f,
            8.4500f,
            0.1000f,
            0.1000f,
            0.3981f,
            0.0460f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.5849f,
            0.0320f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            2854.3999f,
            20.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a resonant pipe).
        /// </summary>
        public static readonly ReverbProperties PipeResonant = new ReverbProperties
        (
            0.1373f,
            0.9100f,
            0.3162f,
            0.4467f,
            0.2818f,
            6.8100f,
            0.1800f,
            0.1000f,
            0.7079f,
            0.0100f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.0000f,
            0.0220f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            2854.3999f,
            20.0000f,
            0.0000f,
            0x0
        );

        /* Outdoors Presets */

        /// <summary>
        /// A reverb preset (approximating an outdoors backyard).
        /// </summary>
        public static readonly ReverbProperties OutdoorsBackyard = new ReverbProperties
        (
            1.0000f,
            0.4500f,
            0.3162f,
            0.2512f,
            0.5012f,
            1.1200f,
            0.3400f,
            0.4600f,
            0.4467f,
            0.0690f,
            new Vector3(0.0000f, 0.0000f, -0.0000f),
            0.7079f,
            0.0230f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2180f,
            0.3400f,
            0.2500f,
            0.0000f,
            0.9943f,
            4399.1001f,
            242.9000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating rolling plains).
        /// </summary>
        public static readonly ReverbProperties OutdoorsRollingPlains = new ReverbProperties
        (
            1.0000f,
            0.0000f,
            0.3162f,
            0.0112f,
            0.6310f,
            2.1300f,
            0.2100f,
            0.4600f,
            0.1778f,
            0.3000f,
            new Vector3(0.0000f, 0.0000f, -0.0000f),
            0.4467f,
            0.0190f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            1.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            4399.1001f,
            242.9000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating a deep canyon).
        /// </summary>
        public static readonly ReverbProperties OutdoorsDeepCanyon = new ReverbProperties
        (
            1.0000f,
            0.7400f,
            0.3162f,
            0.1778f,
            0.6310f,
            3.8900f,
            0.2100f,
            0.4600f,
            0.3162f,
            0.2230f,
            new Vector3(0.0000f, 0.0000f, -0.0000f),
            0.3548f,
            0.0190f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            1.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            4399.1001f,
            242.9000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating a creek).
        /// </summary>
        public static readonly ReverbProperties OutdoorsCreek = new ReverbProperties
        (
            1.0000f,
            0.3500f,
            0.3162f,
            0.1778f,
            0.5012f,
            2.1300f,
            0.2100f,
            0.4600f,
            0.3981f,
            0.1150f,
            new Vector3(0.0000f, 0.0000f, -0.0000f),
            0.1995f,
            0.0310f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2180f,
            0.3400f,
            0.2500f,
            0.0000f,
            0.9943f,
            4399.1001f,
            242.9000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating a valley).
        /// </summary>
        public static readonly ReverbProperties OutdoorsValley = new ReverbProperties
        (
            1.0000f,
            0.2800f,
            0.3162f,
            0.0282f,
            0.1585f,
            2.8800f,
            0.2600f,
            0.3500f,
            0.1413f,
            0.2630f,
            new Vector3(0.0000f, 0.0000f, -0.0000f),
            0.3981f,
            0.1000f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.3400f,
            0.2500f,
            0.0000f,
            0.9943f,
            2854.3999f,
            107.5000f,
            0.0000f,
            0x0
        );

        /* Mood Presets */

        /// <summary>
        /// A reverb preset (approximating a heavenly mood).
        /// </summary>
        public static readonly ReverbProperties MoodHeaven = new ReverbProperties
        (
            1.0000f,
            0.9400f,
            0.3162f,
            0.7943f,
            0.4467f,
            5.0400f,
            1.1200f,
            0.5600f,
            0.2427f,
            0.0200f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.2589f,
            0.0290f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0800f,
            2.7420f,
            0.0500f,
            0.9977f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a hellish mood).
        /// </summary>
        public static readonly ReverbProperties MoodHell = new ReverbProperties
        (
            1.0000f,
            0.5700f,
            0.3162f,
            0.3548f,
            0.4467f,
            3.5700f,
            0.4900f,
            2.0000f,
            0.0000f,
            0.0200f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.4125f,
            0.0300f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1100f,
            0.0400f,
            2.1090f,
            0.5200f,
            0.9943f,
            5000.0000f,
            139.5000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating an abstract memory).
        /// </summary>
        public static readonly ReverbProperties MoodMemory = new ReverbProperties
        (
            1.0000f,
            0.8500f,
            0.3162f,
            0.6310f,
            0.3548f,
            4.0600f,
            0.8200f,
            0.5600f,
            0.0398f,
            0.0000f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.1220f,
            0.0000f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.4740f,
            0.4500f,
            0.9886f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x0
        );

        /* Driving Presets */

        /// <summary>
        /// A reverb preset (approximating a person in the commentator's seat).
        /// </summary>
        public static readonly ReverbProperties DrivingCommentator = new ReverbProperties
        (
            1.0000f,
            0.0000f,
            0.3162f,
            0.5623f,
            0.5012f,
            2.4200f,
            0.8800f,
            0.6800f,
            0.1995f,
            0.0930f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2512f,
            0.0170f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            1.0000f,
            0.2500f,
            0.0000f,
            0.9886f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a pit or garage).
        /// </summary>
        public static readonly ReverbProperties DrivingPitGarage = new ReverbProperties
        (
            0.4287f,
            0.5900f,
            0.3162f,
            0.7079f,
            0.5623f,
            1.7200f,
            0.9300f,
            0.8700f,
            0.5623f,
            0.0000f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.2589f,
            0.0160f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.1100f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating driving in a race car).
        /// </summary>
        public static readonly ReverbProperties DrivingInCarRacer = new ReverbProperties
        (
            0.0832f,
            0.8000f,
            0.3162f,
            1.0000f,
            0.7943f,
            0.1700f,
            2.0000f,
            0.4100f,
            1.7783f,
            0.0070f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.7079f,
            0.0150f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            10268.2002f,
            251.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating driving in a sports car).
        /// </summary>
        public static readonly ReverbProperties DrivingInCarSports = new ReverbProperties
        (
            0.0832f,
            0.8000f,
            0.3162f,
            0.6310f,
            1.0000f,
            0.1700f,
            0.7500f,
            0.4100f,
            1.0000f,
            0.0100f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.5623f,
            0.0000f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            10268.2002f,
            251.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating driving in a luxury car).
        /// </summary>
        public static readonly ReverbProperties DrivingInCarLuxury = new ReverbProperties
        (
            0.2560f,
            1.0000f,
            0.3162f,
            0.1000f,
            0.5012f,
            0.1300f,
            0.4100f,
            0.4600f,
            0.7943f,
            0.0100f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.5849f,
            0.0100f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            10268.2002f,
            251.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating driving on a course with a full grand stand).
        /// </summary>
        public static readonly ReverbProperties DrivingFullGrandStand = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            0.2818f,
            0.6310f,
            3.0100f,
            1.3700f,
            1.2800f,
            0.3548f,
            0.0900f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1778f,
            0.0490f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            10420.2002f,
            250.0000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating an empty grand stand).
        /// </summary>
        public static readonly ReverbProperties DrivingEmptyGrandStand = new ReverbProperties
        (
            1.0000f,
            1.0000f,
            0.3162f,
            1.0000f,
            0.7943f,
            4.6200f,
            1.7500f,
            1.4000f,
            0.2082f,
            0.0900f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2512f,
            0.0490f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.0000f,
            0.9943f,
            10420.2002f,
            250.0000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating driving in a tunnel).
        /// </summary>
        public static readonly ReverbProperties DrivingTunnel = new ReverbProperties
        (
            1.0000f,
            0.8100f,
            0.3162f,
            0.3981f,
            0.8913f,
            3.4200f,
            0.9400f,
            1.3100f,
            0.7079f,
            0.0510f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.7079f,
            0.0470f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2140f,
            0.0500f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            155.3000f,
            0.0000f,
            0x1
        );

        /* City Presets */

        /// <summary>
        /// A reverb preset (approximating city streets).
        /// </summary>
        public static readonly ReverbProperties CityStreets = new ReverbProperties
        (
            1.0000f,
            0.7800f,
            0.3162f,
            0.7079f,
            0.8913f,
            1.7900f,
            1.1200f,
            0.9100f,
            0.2818f,
            0.0460f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1995f,
            0.0280f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.2000f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a subway).
        /// </summary>
        public static readonly ReverbProperties CitySubway = new ReverbProperties
        (
            1.0000f,
            0.7400f,
            0.3162f,
            0.7079f,
            0.8913f,
            3.0100f,
            1.2300f,
            0.9100f,
            0.7079f,
            0.0460f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.2589f,
            0.0280f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1250f,
            0.2100f,
            0.2500f,
            0.0000f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a museum).
        /// </summary>
        public static readonly ReverbProperties CityMuseum = new ReverbProperties
        (
            1.0000f,
            0.8200f,
            0.3162f,
            0.1778f,
            0.1778f,
            3.2800f,
            1.4000f,
            0.5700f,
            0.2512f,
            0.0390f,
            new Vector3(0.0000f, 0.0000f, -0.0000f),
            0.8913f,
            0.0340f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1300f,
            0.1700f,
            0.2500f,
            0.0000f,
            0.9943f,
            2854.3999f,
            107.5000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating a library).
        /// </summary>
        public static readonly ReverbProperties CityLibrary = new ReverbProperties
        (
            1.0000f,
            0.8200f,
            0.3162f,
            0.2818f,
            0.0891f,
            2.7600f,
            0.8900f,
            0.4100f,
            0.3548f,
            0.0290f,
            new Vector3(0.0000f, 0.0000f, -0.0000f),
            0.8913f,
            0.0200f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1300f,
            0.1700f,
            0.2500f,
            0.0000f,
            0.9943f,
            2854.3999f,
            107.5000f,
            0.0000f,
            0x0
        );

        /// <summary>
        /// A reverb preset (approximating an underpass).
        /// </summary>
        public static readonly ReverbProperties CityUnderpass = new ReverbProperties
        (
            1.0000f,
            0.8200f,
            0.3162f,
            0.4467f,
            0.8913f,
            3.5700f,
            1.1200f,
            0.9100f,
            0.3981f,
            0.0590f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.8913f,
            0.0370f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.1400f,
            0.2500f,
            0.0000f,
            0.9920f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating an abandoned location).
        /// </summary>
        public static readonly ReverbProperties CityAbandoned = new ReverbProperties
        (
            1.0000f,
            0.6900f,
            0.3162f,
            0.7943f,
            0.8913f,
            3.2800f,
            1.1700f,
            0.9100f,
            0.4467f,
            0.0440f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2818f,
            0.0240f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.2000f,
            0.2500f,
            0.0000f,
            0.9966f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /* Misc. Presets */

        /// <summary>
        /// A reverb preset (approximating a dusty room).
        /// </summary>
        public static readonly ReverbProperties DustyRoom = new ReverbProperties
        (
            0.3645f,
            0.5600f,
            0.3162f,
            0.7943f,
            0.7079f,
            1.7900f,
            0.3800f,
            0.2100f,
            0.5012f,
            0.0020f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.2589f,
            0.0060f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2020f,
            0.0500f,
            0.2500f,
            0.0000f,
            0.9886f,
            13046.0000f,
            163.3000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a chapel).
        /// </summary>
        public static readonly ReverbProperties Chapel = new ReverbProperties
        (
            1.0000f,
            0.8400f,
            0.3162f,
            0.5623f,
            1.0000f,
            4.6200f,
            0.6400f,
            1.2300f,
            0.4467f,
            0.0320f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.7943f,
            0.0490f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.2500f,
            0.0000f,
            0.2500f,
            0.1100f,
            0.9943f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x1
        );

        /// <summary>
        /// A reverb preset (approximating a small, water-filled room).
        /// </summary>
        public static readonly ReverbProperties SmallWaterRoom = new ReverbProperties
        (
            1.0000f,
            0.7000f,
            0.3162f,
            0.4477f,
            1.0000f,
            1.5100f,
            1.2500f,
            1.1400f,
            0.8913f,
            0.0200f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            1.4125f,
            0.0300f,
            new Vector3(0.0000f, 0.0000f, 0.0000f),
            0.1790f,
            0.1500f,
            0.8950f,
            0.1900f,
            0.9920f,
            5000.0000f,
            250.0000f,
            0.0000f,
            0x0
        );
    }
}
