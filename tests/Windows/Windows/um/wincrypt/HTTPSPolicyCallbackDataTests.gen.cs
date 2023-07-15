// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HTTPSPolicyCallbackData"/> struct.</summary>
public static unsafe partial class HTTPSPolicyCallbackDataTests
{
    /// <summary>Validates that the <see cref = "HTTPSPolicyCallbackData"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTTPSPolicyCallbackData>(), Is.EqualTo(sizeof(HTTPSPolicyCallbackData)));
    }

    /// <summary>Validates that the <see cref = "HTTPSPolicyCallbackData"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTTPSPolicyCallbackData).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTTPSPolicyCallbackData"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(HTTPSPolicyCallbackData), Is.EqualTo(24));
        }
        else
        {
            Assert.That(sizeof(HTTPSPolicyCallbackData), Is.EqualTo(16));
        }
    }
}