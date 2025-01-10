// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE"/> struct.</summary>
public static unsafe partial class STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGETests
{
    /// <summary>Validates that the <see cref = "STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE>(),
            Is.EqualTo(sizeof(STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE))
        );
    }

    /// <summary>Validates that the <see cref = "STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutExplicitTest()
    {
        Assert.That(typeof(STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE).IsExplicitLayout, Is.True);
    }

    /// <summary>Validates that the <see cref = "STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_PROTOCOL_DATA_SUBVALUE_GET_LOG_PAGE), Is.EqualTo(4));
    }
}
