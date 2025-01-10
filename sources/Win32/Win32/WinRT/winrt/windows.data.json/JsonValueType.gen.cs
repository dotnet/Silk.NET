// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.data.json.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum JsonValueType
{
    JsonValueType_Null = 0,
    JsonValueType_Boolean = 1,
    JsonValueType_Number = 2,
    JsonValueType_String = 3,
    JsonValueType_Array = 4,
    JsonValueType_Object = 5,
}
