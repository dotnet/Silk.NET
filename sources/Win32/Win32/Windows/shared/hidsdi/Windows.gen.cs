// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidsdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetAttributes(
        HANDLE HidDeviceObject,
        [NativeTypeName("PHIDD_ATTRIBUTES")] HIDD_ATTRIBUTES* Attributes
    );

    [DllImport("hid", ExactSpelling = true)]
    public static extern void HidD_GetHidGuid([NativeTypeName("LPGUID")] Guid* HidGuid);

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetPreparsedData(
        HANDLE HidDeviceObject,
        PHIDP_PREPARSED_DATA* PreparsedData
    );

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_FreePreparsedData(PHIDP_PREPARSED_DATA PreparsedData);

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_FlushQueue(HANDLE HidDeviceObject);

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetConfiguration(
        HANDLE HidDeviceObject,
        [NativeTypeName("PHIDD_CONFIGURATION")] HIDD_CONFIGURATION* Configuration,
        [NativeTypeName("ULONG")] uint ConfigurationLength
    );

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_SetConfiguration(
        HANDLE HidDeviceObject,
        [NativeTypeName("PHIDD_CONFIGURATION")] HIDD_CONFIGURATION* Configuration,
        [NativeTypeName("ULONG")] uint ConfigurationLength
    );

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetFeature(
        HANDLE HidDeviceObject,
        [NativeTypeName("PVOID")] void* ReportBuffer,
        [NativeTypeName("ULONG")] uint ReportBufferLength
    );

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_SetFeature(
        HANDLE HidDeviceObject,
        [NativeTypeName("PVOID")] void* ReportBuffer,
        [NativeTypeName("ULONG")] uint ReportBufferLength
    );

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetInputReport(
        HANDLE HidDeviceObject,
        [NativeTypeName("PVOID")] void* ReportBuffer,
        [NativeTypeName("ULONG")] uint ReportBufferLength
    );

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_SetOutputReport(
        HANDLE HidDeviceObject,
        [NativeTypeName("PVOID")] void* ReportBuffer,
        [NativeTypeName("ULONG")] uint ReportBufferLength
    );

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetNumInputBuffers(
        HANDLE HidDeviceObject,
        [NativeTypeName("PULONG")] uint* NumberBuffers
    );

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_SetNumInputBuffers(
        HANDLE HidDeviceObject,
        [NativeTypeName("ULONG")] uint NumberBuffers
    );

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetPhysicalDescriptor(
        HANDLE HidDeviceObject,
        [NativeTypeName("PVOID")] void* Buffer,
        [NativeTypeName("ULONG")] uint BufferLength
    );

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetManufacturerString(
        HANDLE HidDeviceObject,
        [NativeTypeName("PVOID")] void* Buffer,
        [NativeTypeName("ULONG")] uint BufferLength
    );

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetProductString(
        HANDLE HidDeviceObject,
        [NativeTypeName("PVOID")] void* Buffer,
        [NativeTypeName("ULONG")] uint BufferLength
    );

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetIndexedString(
        HANDLE HidDeviceObject,
        [NativeTypeName("ULONG")] uint StringIndex,
        [NativeTypeName("PVOID")] void* Buffer,
        [NativeTypeName("ULONG")] uint BufferLength
    );

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetSerialNumberString(
        HANDLE HidDeviceObject,
        [NativeTypeName("PVOID")] void* Buffer,
        [NativeTypeName("ULONG")] uint BufferLength
    );

    [DllImport("hid", ExactSpelling = true)]
    [return: NativeTypeName("BOOLEAN")]
    public static extern byte HidD_GetMsGenreDescriptor(
        HANDLE HidDeviceObject,
        [NativeTypeName("PVOID")] void* Buffer,
        [NativeTypeName("ULONG")] uint BufferLength
    );
}
