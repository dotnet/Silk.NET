// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Allegro
{
    [NativeName("Name", "ALLEGRO_TIMER_EVENT")]
    public unsafe partial struct AllegroTimerEvent
    {
        public AllegroTimerEvent
        (
            uint type = default,
            AllegroTimer* source = default,
            double timestamp = default,
            long count = default,
            double error = default
        )
        {
            Type = type;
            Source = source;
            Timestamp = timestamp;
            Count = count;
            Error = error;
        }


        [NativeName("Type", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Type.Name", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "struct ALLEGRO_TIMER *")]
        [NativeName("Type.Name", "struct ALLEGRO_TIMER *")]
        [NativeName("Name", "source")]
        public AllegroTimer* Source;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "timestamp")]
        public double Timestamp;

        [NativeName("Type", "int64_t")]
        [NativeName("Type.Name", "int64_t")]
        [NativeName("Name", "count")]
        public long Count;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "error")]
        public double Error;
    }
}
