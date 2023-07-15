// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "TOKEN_PRIMARY_GROUP"/> struct.</summary>
public static unsafe partial class TOKEN_PRIMARY_GROUPTests
{
    /// <summary>Validates that the <see cref = "TOKEN_PRIMARY_GROUP"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<TOKEN_PRIMARY_GROUP>(), Is.EqualTo(sizeof(TOKEN_PRIMARY_GROUP)));
    }

    /// <summary>Validates that the <see cref = "TOKEN_PRIMARY_GROUP"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(TOKEN_PRIMARY_GROUP).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "TOKEN_PRIMARY_GROUP"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(TOKEN_PRIMARY_GROUP), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(TOKEN_PRIMARY_GROUP), Is.EqualTo(4));
        }
    }
}