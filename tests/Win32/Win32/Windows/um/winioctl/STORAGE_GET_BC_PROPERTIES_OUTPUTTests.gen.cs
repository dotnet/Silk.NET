// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "STORAGE_GET_BC_PROPERTIES_OUTPUT"/> struct.</summary>
public static unsafe partial class STORAGE_GET_BC_PROPERTIES_OUTPUTTests
{
    /// <summary>Validates that the <see cref = "STORAGE_GET_BC_PROPERTIES_OUTPUT"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<STORAGE_GET_BC_PROPERTIES_OUTPUT>(),
            Is.EqualTo(sizeof(STORAGE_GET_BC_PROPERTIES_OUTPUT))
        );
    }

    /// <summary>Validates that the <see cref = "STORAGE_GET_BC_PROPERTIES_OUTPUT"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STORAGE_GET_BC_PROPERTIES_OUTPUT).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "STORAGE_GET_BC_PROPERTIES_OUTPUT"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STORAGE_GET_BC_PROPERTIES_OUTPUT), Is.EqualTo(32));
    }
}
