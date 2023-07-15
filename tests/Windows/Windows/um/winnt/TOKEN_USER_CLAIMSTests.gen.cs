// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TOKEN_USER_CLAIMS"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class TOKEN_USER_CLAIMSTests
{
    /// <summary>Validates that the <see cref = "TOKEN_USER_CLAIMS"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TOKEN_USER_CLAIMS>(), Is.EqualTo(sizeof(TOKEN_USER_CLAIMS)));
    }

    /// <summary>Validates that the <see cref = "TOKEN_USER_CLAIMS"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TOKEN_USER_CLAIMS).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TOKEN_USER_CLAIMS"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TOKEN_USER_CLAIMS), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(TOKEN_USER_CLAIMS), Is.EqualTo(4));
        }
    }
}