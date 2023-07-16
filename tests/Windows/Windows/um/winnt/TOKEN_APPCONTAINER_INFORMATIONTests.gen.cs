// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TOKEN_APPCONTAINER_INFORMATION"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class TOKEN_APPCONTAINER_INFORMATIONTests
{
    /// <summary>Validates that the <see cref = "TOKEN_APPCONTAINER_INFORMATION"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TOKEN_APPCONTAINER_INFORMATION>(), Is.EqualTo(sizeof(TOKEN_APPCONTAINER_INFORMATION)));
    }

    /// <summary>Validates that the <see cref = "TOKEN_APPCONTAINER_INFORMATION"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TOKEN_APPCONTAINER_INFORMATION).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TOKEN_APPCONTAINER_INFORMATION"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TOKEN_APPCONTAINER_INFORMATION), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(TOKEN_APPCONTAINER_INFORMATION), Is.EqualTo(4));
        }
    }
}