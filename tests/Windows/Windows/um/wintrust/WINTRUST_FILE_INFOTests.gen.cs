// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "WINTRUST_FILE_INFO"/> struct.</summary>
public static unsafe partial class WINTRUST_FILE_INFOTests
{
    /// <summary>Validates that the <see cref = "WINTRUST_FILE_INFO"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<WINTRUST_FILE_INFO>(), Is.EqualTo(sizeof(WINTRUST_FILE_INFO)));
    }

    /// <summary>Validates that the <see cref = "WINTRUST_FILE_INFO"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(WINTRUST_FILE_INFO).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "WINTRUST_FILE_INFO"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(WINTRUST_FILE_INFO), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(WINTRUST_FILE_INFO), Is.EqualTo(16));
        }
    }
}