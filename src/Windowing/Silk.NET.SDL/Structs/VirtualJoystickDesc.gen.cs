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
    [NativeName("Name", "SDL_VirtualJoystickDesc")]
    public unsafe partial struct VirtualJoystickDesc
    {
        public VirtualJoystickDesc
        (
            ushort? version = null,
            ushort? type = null,
            ushort? naxes = null,
            ushort? nbuttons = null,
            ushort? nhats = null,
            ushort? vendorId = null,
            ushort? productId = null,
            ushort? padding = null,
            uint? buttonMask = null,
            uint? axisMask = null,
            byte* name = null,
            void* userdata = null,
            PfnFreeFunc? update = null,
            PfnVvIV? setPlayerIndex = null,
            PfnVvUsUsI? rumble = null,
            PfnVvUsUsI? rumbleTriggers = null,
            PfnVvBBBI? setLED = null,
            PfnVvVvII? sendEffect = null
        ) : this()
        {
            if (version is not null)
            {
                Version = version.Value;
            }

            if (type is not null)
            {
                Type = type.Value;
            }

            if (naxes is not null)
            {
                Naxes = naxes.Value;
            }

            if (nbuttons is not null)
            {
                Nbuttons = nbuttons.Value;
            }

            if (nhats is not null)
            {
                Nhats = nhats.Value;
            }

            if (vendorId is not null)
            {
                VendorId = vendorId.Value;
            }

            if (productId is not null)
            {
                ProductId = productId.Value;
            }

            if (padding is not null)
            {
                Padding = padding.Value;
            }

            if (buttonMask is not null)
            {
                ButtonMask = buttonMask.Value;
            }

            if (axisMask is not null)
            {
                AxisMask = axisMask.Value;
            }

            if (name is not null)
            {
                Name = name;
            }

            if (userdata is not null)
            {
                Userdata = userdata;
            }

            if (update is not null)
            {
                Update = update.Value;
            }

            if (setPlayerIndex is not null)
            {
                SetPlayerIndex = setPlayerIndex.Value;
            }

            if (rumble is not null)
            {
                Rumble = rumble.Value;
            }

            if (rumbleTriggers is not null)
            {
                RumbleTriggers = rumbleTriggers.Value;
            }

            if (setLED is not null)
            {
                SetLED = setLED.Value;
            }

            if (sendEffect is not null)
            {
                SendEffect = sendEffect.Value;
            }
        }


        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "version")]
        public ushort Version;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "type")]
        public ushort Type;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "naxes")]
        public ushort Naxes;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "nbuttons")]
        public ushort Nbuttons;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "nhats")]
        public ushort Nhats;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "vendor_id")]
        public ushort VendorId;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "product_id")]
        public ushort ProductId;

        [NativeName("Type", "Uint16")]
        [NativeName("Type.Name", "Uint16")]
        [NativeName("Name", "padding")]
        public ushort Padding;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "button_mask")]
        public uint ButtonMask;

        [NativeName("Type", "Uint32")]
        [NativeName("Type.Name", "Uint32")]
        [NativeName("Name", "axis_mask")]
        public uint AxisMask;

        [NativeName("Type", "const char *")]
        [NativeName("Type.Name", "const char *")]
        [NativeName("Name", "name")]
        public byte* Name;

        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "userdata")]
        public void* Userdata;

        [NativeName("Type", "void (*)(void *) __attribute__((cdecl))")]
        [NativeName("Type.Name", "void (*)(void *) __attribute__((cdecl))")]
        [NativeName("Name", "Update")]
        public PfnFreeFunc Update;

        [NativeName("Type", "void (*)(void *, int) __attribute__((cdecl))")]
        [NativeName("Type.Name", "void (*)(void *, int) __attribute__((cdecl))")]
        [NativeName("Name", "SetPlayerIndex")]
        public PfnVvIV SetPlayerIndex;

        [NativeName("Type", "int (*)(void *, Uint16, Uint16) __attribute__((cdecl))")]
        [NativeName("Type.Name", "int (*)(void *, Uint16, Uint16) __attribute__((cdecl))")]
        [NativeName("Name", "Rumble")]
        public PfnVvUsUsI Rumble;

        [NativeName("Type", "int (*)(void *, Uint16, Uint16) __attribute__((cdecl))")]
        [NativeName("Type.Name", "int (*)(void *, Uint16, Uint16) __attribute__((cdecl))")]
        [NativeName("Name", "RumbleTriggers")]
        public PfnVvUsUsI RumbleTriggers;

        [NativeName("Type", "int (*)(void *, Uint8, Uint8, Uint8) __attribute__((cdecl))")]
        [NativeName("Type.Name", "int (*)(void *, Uint8, Uint8, Uint8) __attribute__((cdecl))")]
        [NativeName("Name", "SetLED")]
        public PfnVvBBBI SetLED;

        [NativeName("Type", "int (*)(void *, const void *, int) __attribute__((cdecl))")]
        [NativeName("Type.Name", "int (*)(void *, const void *, int) __attribute__((cdecl))")]
        [NativeName("Name", "SendEffect")]
        public PfnVvVvII SendEffect;
    }
}
