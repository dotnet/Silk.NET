// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WINHTTP_CREDS_EX"/> struct.</summary>
public static unsafe partial class WINHTTP_CREDS_EXTests
{
    /// <summary>Validates that the <see cref = "WINHTTP_CREDS_EX"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WINHTTP_CREDS_EX>(), Is.EqualTo(sizeof(WINHTTP_CREDS_EX)));
    }

    /// <summary>Validates that the <see cref = "WINHTTP_CREDS_EX"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WINHTTP_CREDS_EX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WINHTTP_CREDS_EX"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WINHTTP_CREDS_EX), Is.EqualTo(56));
        }
        else
        {
            Assert.That(sizeof(WINHTTP_CREDS_EX), Is.EqualTo(28));
        }
    }
}