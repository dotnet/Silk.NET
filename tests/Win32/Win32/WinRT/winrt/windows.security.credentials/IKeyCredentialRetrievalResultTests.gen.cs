// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.security.credentials.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT.UnitTests;

/// <summary>Provides validation of the <see cref = "IKeyCredentialRetrievalResult"/> struct.</summary>
public static unsafe partial class IKeyCredentialRetrievalResultTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IKeyCredentialRetrievalResult"/> struct is correct.</summary>

    [Test]
    public static void GuidOfTest()
    {
        Assert.That(
            typeof(IKeyCredentialRetrievalResult).GUID,
            Is.EqualTo(IID_IKeyCredentialRetrievalResult)
        );
    }

    /// <summary>Validates that the <see cref = "IKeyCredentialRetrievalResult"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<IKeyCredentialRetrievalResult>(),
            Is.EqualTo(sizeof(IKeyCredentialRetrievalResult))
        );
    }

    /// <summary>Validates that the <see cref = "IKeyCredentialRetrievalResult"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IKeyCredentialRetrievalResult).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IKeyCredentialRetrievalResult"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IKeyCredentialRetrievalResult), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IKeyCredentialRetrievalResult), Is.EqualTo(4));
        }
    }
}
