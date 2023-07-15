// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/fileapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "BY_HANDLE_FILE_INFORMATION"/> struct.</summary>
public static unsafe partial class BY_HANDLE_FILE_INFORMATIONTests
{
    /// <summary>Validates that the <see cref = "BY_HANDLE_FILE_INFORMATION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<BY_HANDLE_FILE_INFORMATION>(), Is.EqualTo(sizeof(BY_HANDLE_FILE_INFORMATION)));
    }

    /// <summary>Validates that the <see cref = "BY_HANDLE_FILE_INFORMATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(BY_HANDLE_FILE_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "BY_HANDLE_FILE_INFORMATION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(BY_HANDLE_FILE_INFORMATION), Is.EqualTo(52));
    }
}