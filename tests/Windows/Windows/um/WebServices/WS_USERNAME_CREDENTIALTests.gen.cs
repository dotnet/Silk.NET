// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WS_USERNAME_CREDENTIAL"/> struct.</summary>
public static unsafe partial class WS_USERNAME_CREDENTIALTests
{
    /// <summary>Validates that the <see cref = "WS_USERNAME_CREDENTIAL"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WS_USERNAME_CREDENTIAL>(), Is.EqualTo(sizeof(WS_USERNAME_CREDENTIAL)));
    }

    /// <summary>Validates that the <see cref = "WS_USERNAME_CREDENTIAL"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WS_USERNAME_CREDENTIAL).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WS_USERNAME_CREDENTIAL"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(WS_USERNAME_CREDENTIAL), Is.EqualTo(4));
    }
}