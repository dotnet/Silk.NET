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
    [NativeName("Name", "ALLEGRO_ANY_EVENT")]
    public unsafe partial struct AllegroAnyEvent
    {
        public AllegroAnyEvent
        (
            uint type = default,
            AllegroEventSource* source = default,
            double timestamp = default
        )
        {
            Type = type;
            Source = source;
            Timestamp = timestamp;
        }


        [NativeName("Type", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Type.Name", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "ALLEGRO_EVENT_SOURCE *")]
        [NativeName("Type.Name", "ALLEGRO_EVENT_SOURCE *")]
        [NativeName("Name", "source")]
        public AllegroEventSource* Source;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "timestamp")]
        public double Timestamp;
    }
}
