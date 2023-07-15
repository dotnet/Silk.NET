// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WINHTTP_FAILED_CONNECTION_RETRIES"/> struct.</summary>
public static unsafe partial class WINHTTP_FAILED_CONNECTION_RETRIESTests
{
    /// <summary>Validates that the <see cref = "WINHTTP_FAILED_CONNECTION_RETRIES"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WINHTTP_FAILED_CONNECTION_RETRIES>(), Is.EqualTo(sizeof(WINHTTP_FAILED_CONNECTION_RETRIES)));
    }

    /// <summary>Validates that the <see cref = "WINHTTP_FAILED_CONNECTION_RETRIES"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WINHTTP_FAILED_CONNECTION_RETRIES).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WINHTTP_FAILED_CONNECTION_RETRIES"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WINHTTP_FAILED_CONNECTION_RETRIES), Is.EqualTo(8));
    }
}