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
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    [NativeName("Name", "SDL_hid_device_info")]
    public unsafe partial struct HidDeviceInfo
    {
        public HidDeviceInfo
        (
            byte* path = null,
            ushort? vendorId = null,
            ushort? productId = null,
            char* serialNumber = null,
            ushort? releaseNumber = null,
            char* manufacturerString = null,
            char* productString = null,
            ushort? usagePage = null,
            ushort? usage = null,
            int? interfaceNumber = null,
            int? interfaceClass = null,
            int? interfaceSubclass = null,
            int? interfaceProtocol = null,
            HidDeviceInfo* next = null
        ) : this()
        {
            if (path is not null)
            {
                Path = path;
            }

            if (vendorId is not null)
            {
                VendorId = vendorId.Value;
            }

            if (productId is not null)
            {
                ProductId = productId.Value;
            }

            if (serialNumber is not null)
            {
                SerialNumber = serialNumber;
            }

            if (releaseNumber is not null)
            {
                ReleaseNumber = releaseNumber.Value;
            }

            if (manufacturerString is not null)
            {
                ManufacturerString = manufacturerString;
            }

            if (productString is not null)
            {
                ProductString = productString;
            }

            if (usagePage is not null)
            {
                UsagePage = usagePage.Value;
            }

            if (usage is not null)
            {
                Usage = usage.Value;
            }

            if (interfaceNumber is not null)
            {
                InterfaceNumber = interfaceNumber.Value;
            }

            if (interfaceClass is not null)
            {
                InterfaceClass = interfaceClass.Value;
            }

            if (interfaceSubclass is not null)
            {
                InterfaceSubclass = interfaceSubclass.Value;
            }

            if (interfaceProtocol is not null)
            {
                InterfaceProtocol = interfaceProtocol.Value;
            }

            if (next is not null)
            {
                Next = next;
            }
        }


        [NativeName("Type", "char *")]
        [NativeName("Type.Name", "char *")]
        [NativeName("Name", "path")]
        public byte* Path;

        [NativeName("Type", "unsigned short")]
        [NativeName("Type.Name", "unsigned short")]
        [NativeName("Name", "vendor_id")]
        public ushort VendorId;

        [NativeName("Type", "unsigned short")]
        [NativeName("Type.Name", "unsigned short")]
        [NativeName("Name", "product_id")]
        public ushort ProductId;

        [NativeName("Type", "wchar_t *")]
        [NativeName("Type.Name", "wchar_t *")]
        [NativeName("Name", "serial_number")]
        public char* SerialNumber;

        [NativeName("Type", "unsigned short")]
        [NativeName("Type.Name", "unsigned short")]
        [NativeName("Name", "release_number")]
        public ushort ReleaseNumber;

        [NativeName("Type", "wchar_t *")]
        [NativeName("Type.Name", "wchar_t *")]
        [NativeName("Name", "manufacturer_string")]
        public char* ManufacturerString;

        [NativeName("Type", "wchar_t *")]
        [NativeName("Type.Name", "wchar_t *")]
        [NativeName("Name", "product_string")]
        public char* ProductString;

        [NativeName("Type", "unsigned short")]
        [NativeName("Type.Name", "unsigned short")]
        [NativeName("Name", "usage_page")]
        public ushort UsagePage;

        [NativeName("Type", "unsigned short")]
        [NativeName("Type.Name", "unsigned short")]
        [NativeName("Name", "usage")]
        public ushort Usage;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "interface_number")]
        public int InterfaceNumber;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "interface_class")]
        public int InterfaceClass;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "interface_subclass")]
        public int InterfaceSubclass;

        [NativeName("Type", "int")]
        [NativeName("Type.Name", "int")]
        [NativeName("Name", "interface_protocol")]
        public int InterfaceProtocol;

        [NativeName("Type", "struct SDL_hid_device_info *")]
        [NativeName("Type.Name", "struct SDL_hid_device_info *")]
        [NativeName("Name", "next")]
        public HidDeviceInfo* Next;
    }
}
