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
    [NativeName("Name", "ALLEGRO_USER_EVENT")]
    public unsafe partial struct AllegroUserEvent
    {
        public AllegroUserEvent
        (
            uint type = default,
            AllegroEventSource* source = default,
            double timestamp = default,
            AllegroUserEventDescriptor* internaldescr = default,
            int data1 = default,
            int data2 = default,
            int data3 = default,
            int data4 = default
        )
        {
            Type = type;
            Source = source;
            Timestamp = timestamp;
            Internaldescr = internaldescr;
            Data1 = data1;
            Data2 = data2;
            Data3 = data3;
            Data4 = data4;
        }


        [NativeName("Type", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Type.Name", "ALLEGRO_EVENT_TYPE")]
        [NativeName("Name", "type")]
        public uint Type;

        [NativeName("Type", "struct ALLEGRO_EVENT_SOURCE *")]
        [NativeName("Type.Name", "struct ALLEGRO_EVENT_SOURCE *")]
        [NativeName("Name", "source")]
        public AllegroEventSource* Source;

        [NativeName("Type", "double")]
        [NativeName("Type.Name", "double")]
        [NativeName("Name", "timestamp")]
        public double Timestamp;

        [NativeName("Type", "struct ALLEGRO_USER_EVENT_DESCRIPTOR *")]
        [NativeName("Type.Name", "struct ALLEGRO_USER_EVENT_DESCRIPTOR *")]
        [NativeName("Name", "__internal__descr")]
        public AllegroUserEventDescriptor* Internaldescr;

        [NativeName("Type", "intptr_t")]
        [NativeName("Type.Name", "intptr_t")]
        [NativeName("Name", "data1")]
        public int Data1;

        [NativeName("Type", "intptr_t")]
        [NativeName("Type.Name", "intptr_t")]
        [NativeName("Name", "data2")]
        public int Data2;

        [NativeName("Type", "intptr_t")]
        [NativeName("Type.Name", "intptr_t")]
        [NativeName("Name", "data3")]
        public int Data3;

        [NativeName("Type", "intptr_t")]
        [NativeName("Type.Name", "intptr_t")]
        [NativeName("Name", "data4")]
        public int Data4;
    }
}
