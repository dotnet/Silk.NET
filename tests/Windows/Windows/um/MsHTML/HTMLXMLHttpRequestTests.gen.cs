// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "HTMLXMLHttpRequest"/> struct.</summary>
public static unsafe partial class HTMLXMLHttpRequestTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "HTMLXMLHttpRequest"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(HTMLXMLHttpRequest).GUID, Is.EqualTo(IID_HTMLXMLHttpRequest));
    }

    /// <summary>Validates that the <see cref = "HTMLXMLHttpRequest"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<HTMLXMLHttpRequest>(), Is.EqualTo(sizeof(HTMLXMLHttpRequest)));
    }

    /// <summary>Validates that the <see cref = "HTMLXMLHttpRequest"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(HTMLXMLHttpRequest).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "HTMLXMLHttpRequest"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(HTMLXMLHttpRequest), Is.EqualTo(1));
    }
}