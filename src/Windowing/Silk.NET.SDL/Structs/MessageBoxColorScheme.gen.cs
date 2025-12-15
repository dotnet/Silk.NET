// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.SDL
{
    [NativeName("AnonymousName", "__AnonymousRecord_SDL_messagebox_L86_C9")]
    [NativeName("Name", "SDL_MessageBoxColorScheme")]
    public unsafe partial struct MessageBoxColorScheme
    {
        
        [NativeName("Type", "SDL_MessageBoxColor[5]")]
        [NativeName("Type.Name", "SDL_MessageBoxColor[5]")]
        [NativeName("Name", "colors")]
        public ColorsBuffer Colors;

        public struct ColorsBuffer
        {
            public MessageBoxColor Element0;
            public MessageBoxColor Element1;
            public MessageBoxColor Element2;
            public MessageBoxColor Element3;
            public MessageBoxColor Element4;
            public ref MessageBoxColor this[int index]
            {
                get
                {
                    if (index > 4 || index < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(index));
                    }

                    fixed (MessageBoxColor* ptr = &Element0)
                    {
                        return ref ptr[index];
                    }
                }
            }

#if NETSTANDARD2_1 || NETCOREAPP3_1 || NET5_0 || NET5_0_OR_GREATER
            public Span<MessageBoxColor> AsSpan()
                => MemoryMarshal.CreateSpan(ref Element0, 5);
#endif
        }

    }
}
