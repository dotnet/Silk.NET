// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/strsafe.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Win32.S;

namespace Silk.NET.Win32;

public static unsafe partial class Windows
{
    public static HRESULT StringLengthWorkerA([NativeTypeName("STRSAFE_PCNZCH")] sbyte* psz, [NativeTypeName("size_t")] nuint cchMax, [NativeTypeName("size_t *")] nuint* pcchLength)
    {
        HRESULT hr = S_OK;
        nuint cchOriginalMax = cchMax;

        while ((cchMax) != 0 && (*psz != '\0'))
        {
            psz++;
            cchMax--;
        }

        if (cchMax == 0)
        {
            hr = STRSAFE_E_INVALID_PARAMETER;
        }

        if ((pcchLength) != null)
        {
            if (SUCCEEDED(hr))
            {
                *pcchLength = cchOriginalMax - cchMax;
            }
            else
            {
                *pcchLength = 0;
            }
        }

        return hr;
    }

    public static HRESULT StringLengthWorkerW([NativeTypeName("STRSAFE_PCNZWCH")] char* psz, [NativeTypeName("size_t")] nuint cchMax, [NativeTypeName("size_t *")] nuint* pcchLength)
    {
        HRESULT hr = S_OK;
        nuint cchOriginalMax = cchMax;

        while ((cchMax) != 0 && (*psz != '\0'))
        {
            psz++;
            cchMax--;
        }

        if (cchMax == 0)
        {
            hr = STRSAFE_E_INVALID_PARAMETER;
        }

        if ((pcchLength) != null)
        {
            if (SUCCEEDED(hr))
            {
                *pcchLength = cchOriginalMax - cchMax;
            }
            else
            {
                *pcchLength = 0;
            }
        }

        return hr;
    }

    public static HRESULT UnalignedStringLengthWorkerW([NativeTypeName("STRSAFE_PCUNZWCH")] char* psz, [NativeTypeName("size_t")] nuint cchMax, [NativeTypeName("size_t *")] nuint* pcchLength)
    {
        HRESULT hr = S_OK;
        nuint cchOriginalMax = cchMax;

        while ((cchMax) != 0 && (*psz != '\0'))
        {
            psz++;
            cchMax--;
        }

        if (cchMax == 0)
        {
            hr = STRSAFE_E_INVALID_PARAMETER;
        }

        if ((pcchLength) != null)
        {
            if (SUCCEEDED(hr))
            {
                *pcchLength = cchOriginalMax - cchMax;
            }
            else
            {
                *pcchLength = 0;
            }
        }

        return hr;
    }

    public static HRESULT StringExValidateSrcA([NativeTypeName("STRSAFE_PCNZCH *")] sbyte** ppszSrc, [NativeTypeName("size_t *")] nuint* pcchToRead, [NativeTypeName("const size_t")] nuint cchMax, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr = S_OK;

        if ((pcchToRead) != null && (*pcchToRead >= cchMax))
        {
            hr = STRSAFE_E_INVALID_PARAMETER;
        }
        else if ((dwFlags & STRSAFE_IGNORE_NULLS) != 0 && (*ppszSrc == null))
        {
            *ppszSrc = (sbyte*)(Unsafe.AsPointer(ref MemoryMarshal.GetReference(""u8)));
            if ((pcchToRead) != null)
            {
                *pcchToRead = 0;
            }
        }

        return hr;
    }

    public static HRESULT StringExValidateSrcW([NativeTypeName("STRSAFE_PCNZWCH *")] char** ppszSrc, [NativeTypeName("size_t *")] nuint* pcchToRead, [NativeTypeName("const size_t")] nuint cchMax, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr = S_OK;

        if ((pcchToRead) != null && (*pcchToRead >= cchMax))
        {
            hr = STRSAFE_E_INVALID_PARAMETER;
        }
        else if ((dwFlags & STRSAFE_IGNORE_NULLS) != 0 && (*ppszSrc == null))
        {
            *ppszSrc = (char*)(Unsafe.AsPointer(ref MemoryMarshal.GetReference(['\0'])));
            if ((pcchToRead) != null)
            {
                *pcchToRead = 0;
            }
        }

        return hr;
    }

    public static HRESULT StringValidateDestA([NativeTypeName("STRSAFE_PCNZCH")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("const size_t")] nuint cchMax)
    {
        HRESULT hr = S_OK;

        if ((cchDest == 0) || (cchDest > cchMax))
        {
            hr = STRSAFE_E_INVALID_PARAMETER;
        }

        return hr;
    }

    public static HRESULT StringValidateDestAndLengthA([NativeTypeName("STRSAFE_LPCSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("size_t *")] nuint* pcchDestLength, [NativeTypeName("const size_t")] nuint cchMax)
    {
        HRESULT hr;

        hr = StringValidateDestA(pszDest, cchDest, cchMax);
        if (SUCCEEDED(hr))
        {
            hr = StringLengthWorkerA(pszDest, cchDest, pcchDestLength);
        }
        else
        {
            *pcchDestLength = 0;
        }

        return hr;
    }

    public static HRESULT StringValidateDestW([NativeTypeName("STRSAFE_PCNZWCH")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("const size_t")] nuint cchMax)
    {
        HRESULT hr = S_OK;

        if ((cchDest == 0) || (cchDest > cchMax))
        {
            hr = STRSAFE_E_INVALID_PARAMETER;
        }

        return hr;
    }

    public static HRESULT StringValidateDestAndLengthW([NativeTypeName("STRSAFE_LPCWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("size_t *")] nuint* pcchDestLength, [NativeTypeName("const size_t")] nuint cchMax)
    {
        HRESULT hr;

        hr = StringValidateDestW(pszDest, cchDest, cchMax);
        if (SUCCEEDED(hr))
        {
            hr = StringLengthWorkerW(pszDest, cchDest, pcchDestLength);
        }
        else
        {
            *pcchDestLength = 0;
        }

        return hr;
    }

    public static HRESULT StringExValidateDestA([NativeTypeName("STRSAFE_PCNZCH")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("const size_t")] nuint cchMax, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr = S_OK;

        if ((dwFlags & STRSAFE_IGNORE_NULLS) != 0)
        {
            if (((pszDest == null) && (cchDest != 0)) || (cchDest > cchMax))
            {
                hr = STRSAFE_E_INVALID_PARAMETER;
            }
        }
        else
        {
            hr = StringValidateDestA(pszDest, cchDest, cchMax);
        }

        return hr;
    }

    public static HRESULT StringExValidateDestAndLengthA([NativeTypeName("STRSAFE_LPCSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("size_t *")] nuint* pcchDestLength, [NativeTypeName("const size_t")] nuint cchMax, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;

        if ((dwFlags & STRSAFE_IGNORE_NULLS) != 0)
        {
            hr = StringExValidateDestA(pszDest, cchDest, cchMax, dwFlags);
            if (FAILED(hr) || (cchDest == 0))
            {
                *pcchDestLength = 0;
            }
            else
            {
                hr = StringLengthWorkerA(pszDest, cchDest, pcchDestLength);
            }
        }
        else
        {
            hr = StringValidateDestAndLengthA(pszDest, cchDest, pcchDestLength, cchMax);
        }

        return hr;
    }

    public static HRESULT StringExValidateDestW([NativeTypeName("STRSAFE_PCNZWCH")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("const size_t")] nuint cchMax, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr = S_OK;

        if ((dwFlags & STRSAFE_IGNORE_NULLS) != 0)
        {
            if (((pszDest == null) && (cchDest != 0)) || (cchDest > cchMax))
            {
                hr = STRSAFE_E_INVALID_PARAMETER;
            }
        }
        else
        {
            hr = StringValidateDestW(pszDest, cchDest, cchMax);
        }

        return hr;
    }

    public static HRESULT StringExValidateDestAndLengthW([NativeTypeName("STRSAFE_LPCWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("size_t *")] nuint* pcchDestLength, [NativeTypeName("const size_t")] nuint cchMax, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;

        if ((dwFlags & STRSAFE_IGNORE_NULLS) != 0)
        {
            hr = StringExValidateDestW(pszDest, cchDest, cchMax, dwFlags);
            if (FAILED(hr) || (cchDest == 0))
            {
                *pcchDestLength = 0;
            }
            else
            {
                hr = StringLengthWorkerW(pszDest, cchDest, pcchDestLength);
            }
        }
        else
        {
            hr = StringValidateDestAndLengthW(pszDest, cchDest, pcchDestLength, cchMax);
        }

        return hr;
    }

    public static HRESULT StringCopyWorkerA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("size_t *")] nuint* pcchNewDestLength, [NativeTypeName("STRSAFE_PCNZCH")] sbyte* pszSrc, [NativeTypeName("size_t")] nuint cchToCopy)
    {
        HRESULT hr = S_OK;
        nuint cchNewDestLength = 0;

        while ((cchDest) != 0 && (cchToCopy) != 0 && (*pszSrc != '\0'))
        {
            *pszDest++ = *pszSrc++;
            cchDest--;
            cchToCopy--;
            cchNewDestLength++;
        }

        if (cchDest == 0)
        {
            pszDest--;
            cchNewDestLength--;
            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
        }

        *pszDest = (sbyte)('\0');
        if ((pcchNewDestLength) != null)
        {
            *pcchNewDestLength = cchNewDestLength;
        }

        return hr;
    }

    public static HRESULT StringCopyWorkerW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("size_t *")] nuint* pcchNewDestLength, [NativeTypeName("STRSAFE_PCNZWCH")] char* pszSrc, [NativeTypeName("size_t")] nuint cchToCopy)
    {
        HRESULT hr = S_OK;
        nuint cchNewDestLength = 0;

        while ((cchDest) != 0 && (cchToCopy) != 0 && (*pszSrc != '\0'))
        {
            *pszDest++ = *pszSrc++;
            cchDest--;
            cchToCopy--;
            cchNewDestLength++;
        }

        if (cchDest == 0)
        {
            pszDest--;
            cchNewDestLength--;
            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
        }

        *pszDest = '\0';
        if ((pcchNewDestLength) != null)
        {
            *pcchNewDestLength = cchNewDestLength;
        }

        return hr;
    }

    public static HRESULT StringGetsWorkerA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("size_t *")] nuint* pcchNewDestLength)
    {
        HRESULT hr = S_OK;
        nuint cchNewDestLength = 0;

        if (cchDest == 1)
        {
            *pszDest = (sbyte)('\0');
            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
        }
        else
        {
            while (cchDest > 1)
            {
                sbyte ch;
                int i = Console.Read();

                if (i == (-1))
                {
                    if (cchNewDestLength == 0)
                    {
                        hr = STRSAFE_E_END_OF_FILE;
                    }

                    break;
                }

                ch = (sbyte)(i);
                if (ch == '\n')
                {
                    break;
                }

                *pszDest++ = ch;
                cchDest--;
                cchNewDestLength++;
            }

            *pszDest = (sbyte)('\0');
        }

        if ((pcchNewDestLength) != null)
        {
            *pcchNewDestLength = cchNewDestLength;
        }

        return hr;
    }

    public static HRESULT StringGetsWorkerW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cchDest, [NativeTypeName("size_t *")] nuint* pcchNewDestLength)
    {
        HRESULT hr = S_OK;
        nuint cchNewDestLength = 0;

        if (cchDest == 1)
        {
            *pszDest = '\0';
            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
        }
        else
        {
            while (cchDest > 1)
            {
                char ch = (char)(Console.Read());

                if (ch == unchecked((ushort)(0xFFFF)))
                {
                    if (cchNewDestLength == 0)
                    {
                        hr = STRSAFE_E_END_OF_FILE;
                    }

                    break;
                }

                if (ch == '\n')
                {
                    break;
                }

                *pszDest++ = ch;
                cchDest--;
                cchNewDestLength++;
            }

            *pszDest = '\0';
        }

        if ((pcchNewDestLength) != null)
        {
            *pcchNewDestLength = cchNewDestLength;
        }

        return hr;
    }

    public static HRESULT StringExHandleFillBehindNullA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDestEnd, [NativeTypeName("size_t")] nuint cbRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        if (cbRemaining > unchecked(sizeof(sbyte)))
        {
            NativeMemory.Fill(pszDestEnd + 1, cbRemaining - sizeof(sbyte), unchecked((byte)(dwFlags & 0x000000FF)));
        }

        return S_OK;
    }

    public static HRESULT StringExHandleFillBehindNullW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDestEnd, [NativeTypeName("size_t")] nuint cbRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        if (cbRemaining > unchecked(sizeof(char)))
        {
            NativeMemory.Fill(pszDestEnd + 1, cbRemaining - sizeof(char), unchecked((byte)(dwFlags & 0x000000FF)));
        }

        return S_OK;
    }

    public static HRESULT StringExHandleOtherFlagsA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("size_t")] nuint cchOriginalDestLength, [NativeTypeName("STRSAFE_LPSTR *")] sbyte** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        nuint cchDest = cbDest / 1;

        Debug.Assert((dwFlags & (STRSAFE_NO_TRUNCATION | STRSAFE_FILL_ON_FAILURE | STRSAFE_NULL_ON_FAILURE)) != 0);

        if (unchecked(cchDest > 0) && (dwFlags & STRSAFE_NO_TRUNCATION) != 0)
        {
            sbyte* pszOriginalDestEnd;

            pszOriginalDestEnd = pszDest + cchOriginalDestLength;
            *ppszDestEnd = pszOriginalDestEnd;
            *pcchRemaining = unchecked(cchDest - cchOriginalDestLength);
            *pszOriginalDestEnd = (sbyte)('\0');
        }

        if ((dwFlags & STRSAFE_FILL_ON_FAILURE) != 0)
        {
            NativeMemory.Fill(pszDest, cbDest, unchecked((byte)(dwFlags & 0x000000FF)));
            if (((byte)(dwFlags & 0x000000FF)) == 0)
            {
                *ppszDestEnd = pszDest;
                *pcchRemaining = unchecked(cchDest);
                Debug.Assert(*pszDest == '\0');
            }
            else if (unchecked(cchDest) > 0)
            {
                sbyte* pszDestEnd;

                pszDestEnd = pszDest + cchDest - 1;
                *ppszDestEnd = pszDestEnd;
                *pcchRemaining = 1;
                *pszDestEnd = (sbyte)('\0');
            }
        }

        if (unchecked(cchDest > 0) && (dwFlags & STRSAFE_NULL_ON_FAILURE) != 0)
        {
            *ppszDestEnd = pszDest;
            *pcchRemaining = unchecked(cchDest);
            *pszDest = (sbyte)('\0');
        }

        return S_OK;
    }

    public static HRESULT StringExHandleOtherFlagsW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("size_t")] nuint cchOriginalDestLength, [NativeTypeName("STRSAFE_LPWSTR *")] char** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcchRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        nuint cchDest = cbDest / 2;

        Debug.Assert((dwFlags & (STRSAFE_NO_TRUNCATION | STRSAFE_FILL_ON_FAILURE | STRSAFE_NULL_ON_FAILURE)) != 0);

        if (unchecked(cchDest > 0) && (dwFlags & STRSAFE_NO_TRUNCATION) != 0)
        {
            char* pszOriginalDestEnd;

            pszOriginalDestEnd = pszDest + cchOriginalDestLength;
            *ppszDestEnd = pszOriginalDestEnd;
            *pcchRemaining = unchecked(cchDest - cchOriginalDestLength);
            *pszOriginalDestEnd = '\0';
        }

        if ((dwFlags & STRSAFE_FILL_ON_FAILURE) != 0)
        {
            NativeMemory.Fill(pszDest, cbDest, unchecked((byte)(dwFlags & 0x000000FF)));
            if (((byte)(dwFlags & 0x000000FF)) == 0)
            {
                *ppszDestEnd = pszDest;
                *pcchRemaining = unchecked(cchDest);
                Debug.Assert(cchDest == 0 || *pszDest == '\0');
            }
            else if (unchecked(cchDest) > 0)
            {
                char* pszDestEnd;

                pszDestEnd = pszDest + cchDest - 1;
                *ppszDestEnd = pszDestEnd;
                *pcchRemaining = 1;
                *pszDestEnd = '\0';
            }
        }

        if (unchecked(cchDest > 0) && (dwFlags & STRSAFE_NULL_ON_FAILURE) != 0)
        {
            *ppszDestEnd = pszDest;
            *pcchRemaining = unchecked(cchDest);
            *pszDest = '\0';
        }

        return S_OK;
    }

    public static HRESULT StringCbCopyExA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_LPCSTR")] sbyte* pszSrc, [NativeTypeName("STRSAFE_LPSTR *")] sbyte** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcbRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 1;

        hr = StringExValidateDestA(pszDest, cchDest, STRSAFE_MAX_CCH, dwFlags);
        if (SUCCEEDED(hr))
        {
            sbyte* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;

            hr = StringExValidateSrcA(&pszSrc, null, STRSAFE_MAX_CCH, dwFlags);
            if (SUCCEEDED(hr))
            {
                if ((dwFlags & ~STRSAFE_VALID_FLAGS) != 0)
                {
                    hr = STRSAFE_E_INVALID_PARAMETER;
                    if (unchecked(cchDest) != 0)
                    {
                        *pszDest = (sbyte)('\0');
                    }
                }
                else if (unchecked(cchDest) == 0)
                {
                    if (*pszSrc != (sbyte)('\0'))
                    {
                        if (pszDest == null)
                        {
                            hr = STRSAFE_E_INVALID_PARAMETER;
                        }
                        else
                        {
                            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerA(pszDest, cchDest, &cchCopied, pszSrc, (STRSAFE_MAX_CCH - 1));
                    pszDestEnd = pszDest + cchCopied;
                    unchecked(cchRemaining) = unchecked(cchDest - cchCopied);
                    if (SUCCEEDED(hr) && (dwFlags & STRSAFE_FILL_BEHIND_NULL) != 0 && unchecked(cchRemaining > 1))
                    {
                        nuint cbRemaining;

                        cbRemaining = unchecked((cchRemaining * sizeof(sbyte)) + (cbDest % sizeof(sbyte)));
                        _ = StringExHandleFillBehindNullA(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }
            else
            {
                if (unchecked(cchDest) != 0)
                {
                    *pszDest = (sbyte)('\0');
                }
            }

            if (FAILED(hr) && (dwFlags & (STRSAFE_NO_TRUNCATION | STRSAFE_FILL_ON_FAILURE | STRSAFE_NULL_ON_FAILURE)) != 0 && (cbDest != 0))
            {
                _ = StringExHandleOtherFlagsA(pszDest, cbDest, 0, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if (SUCCEEDED(hr) || (hr == STRSAFE_E_INSUFFICIENT_BUFFER))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcbRemaining) != null)
                {
                    *pcbRemaining = unchecked((cchRemaining * sizeof(sbyte)) + (cbDest % sizeof(sbyte)));
                }
            }
        }
        else if (unchecked(cchDest) > 0)
        {
            *pszDest = (sbyte)('\0');
        }

        return hr;
    }

    public static HRESULT StringCbCopyExW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_LPCWSTR")] char* pszSrc, [NativeTypeName("STRSAFE_LPWSTR *")] char** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcbRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 2;

        hr = StringExValidateDestW(pszDest, cchDest, STRSAFE_MAX_CCH, dwFlags);
        if (SUCCEEDED(hr))
        {
            char* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;

            hr = StringExValidateSrcW(&pszSrc, null, STRSAFE_MAX_CCH, dwFlags);
            if (SUCCEEDED(hr))
            {
                if ((dwFlags & ~STRSAFE_VALID_FLAGS) != 0)
                {
                    hr = STRSAFE_E_INVALID_PARAMETER;
                    if (unchecked(cchDest) != 0)
                    {
                        *pszDest = '\0';
                    }
                }
                else if (unchecked(cchDest) == 0)
                {
                    if (*pszSrc != '\0')
                    {
                        if (pszDest == null)
                        {
                            hr = STRSAFE_E_INVALID_PARAMETER;
                        }
                        else
                        {
                            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerW(pszDest, cchDest, &cchCopied, pszSrc, (STRSAFE_MAX_CCH - 1));
                    pszDestEnd = pszDest + cchCopied;
                    unchecked(cchRemaining) = unchecked(cchDest - cchCopied);
                    if (SUCCEEDED(hr) && (dwFlags & STRSAFE_FILL_BEHIND_NULL) != 0)
                    {
                        nuint cbRemaining;

                        cbRemaining = unchecked((cchRemaining * sizeof(char)) + (cbDest % sizeof(char)));
                        _ = StringExHandleFillBehindNullW(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }
            else
            {
                if (unchecked(cchDest) != 0)
                {
                    *pszDest = '\0';
                }
            }

            if (FAILED(hr) && (dwFlags & (STRSAFE_NO_TRUNCATION | STRSAFE_FILL_ON_FAILURE | STRSAFE_NULL_ON_FAILURE)) != 0 && (cbDest != 0))
            {
                _ = StringExHandleOtherFlagsW(pszDest, cbDest, 0, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if (SUCCEEDED(hr) || (hr == STRSAFE_E_INSUFFICIENT_BUFFER))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcbRemaining) != null)
                {
                    *pcbRemaining = unchecked((cchRemaining * sizeof(char)) + (cbDest % sizeof(char)));
                }
            }
        }
        else if (unchecked(cchDest) > 0)
        {
            *pszDest = '\0';
        }

        return hr;
    }

    public static HRESULT StringCbCopyNExA([NativeTypeName("STRSAFE_LPSTR")] sbyte* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_PCNZCH")] sbyte* pszSrc, [NativeTypeName("size_t")] nuint cbToCopy, [NativeTypeName("STRSAFE_LPSTR *")] sbyte** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcbRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 1;

        hr = StringExValidateDestA(pszDest, cchDest, STRSAFE_MAX_CCH, dwFlags);
        if (SUCCEEDED(hr))
        {
            sbyte* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;
            nuint cchToCopy = cbToCopy / 1;

            hr = StringExValidateSrcA(&pszSrc, &cchToCopy, STRSAFE_MAX_CCH, dwFlags);
            if (SUCCEEDED(hr))
            {
                if ((dwFlags & ~STRSAFE_VALID_FLAGS) != 0)
                {
                    hr = STRSAFE_E_INVALID_PARAMETER;
                    if (unchecked(cchDest) != 0)
                    {
                        *pszDest = (sbyte)('\0');
                    }
                }
                else if (unchecked(cchDest) == 0)
                {
                    if (unchecked(cchToCopy != 0) && (*pszSrc != (sbyte)('\0')))
                    {
                        if (pszDest == null)
                        {
                            hr = STRSAFE_E_INVALID_PARAMETER;
                        }
                        else
                        {
                            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerA(pszDest, cchDest, &cchCopied, pszSrc, cchToCopy);
                    pszDestEnd = pszDest + cchCopied;
                    unchecked(cchRemaining) = unchecked(cchDest - cchCopied);
                    if (SUCCEEDED(hr) && (dwFlags & STRSAFE_FILL_BEHIND_NULL) != 0 && unchecked(cchRemaining > 1))
                    {
                        nuint cbRemaining;

                        cbRemaining = unchecked((cchRemaining * sizeof(sbyte)) + (cbDest % sizeof(sbyte)));
                        _ = StringExHandleFillBehindNullA(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }
            else
            {
                if (unchecked(cchDest) != 0)
                {
                    *pszDest = (sbyte)('\0');
                }
            }

            if (FAILED(hr) && (dwFlags & (STRSAFE_NO_TRUNCATION | STRSAFE_FILL_ON_FAILURE | STRSAFE_NULL_ON_FAILURE)) != 0 && (cbDest != 0))
            {
                _ = StringExHandleOtherFlagsA(pszDest, cbDest, 0, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if (SUCCEEDED(hr) || (hr == STRSAFE_E_INSUFFICIENT_BUFFER))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcbRemaining) != null)
                {
                    *pcbRemaining = unchecked((cchRemaining * sizeof(sbyte)) + (cbDest % sizeof(sbyte)));
                }
            }
        }

        return hr;
    }

    public static HRESULT StringCbCopyNExW([NativeTypeName("STRSAFE_LPWSTR")] char* pszDest, [NativeTypeName("size_t")] nuint cbDest, [NativeTypeName("STRSAFE_PCNZWCH")] char* pszSrc, [NativeTypeName("size_t")] nuint cbToCopy, [NativeTypeName("STRSAFE_LPWSTR *")] char** ppszDestEnd, [NativeTypeName("size_t *")] nuint* pcbRemaining, [NativeTypeName("DWORD")] uint dwFlags)
    {
        HRESULT hr;
        nuint cchDest = cbDest / 2;

        hr = StringExValidateDestW(pszDest, cchDest, STRSAFE_MAX_CCH, dwFlags);
        if (SUCCEEDED(hr))
        {
            char* pszDestEnd = pszDest;
            nuint cchRemaining = cchDest;
            nuint cchToCopy = cbToCopy / 2;

            hr = StringExValidateSrcW(&pszSrc, &cchToCopy, STRSAFE_MAX_CCH, dwFlags);
            if (SUCCEEDED(hr))
            {
                if ((dwFlags & ~STRSAFE_VALID_FLAGS) != 0)
                {
                    hr = STRSAFE_E_INVALID_PARAMETER;
                    if (unchecked(cchDest) != 0)
                    {
                        *pszDest = '\0';
                    }
                }
                else if (unchecked(cchDest) == 0)
                {
                    if (unchecked(cchToCopy != 0) && (*pszSrc != '\0'))
                    {
                        if (pszDest == null)
                        {
                            hr = STRSAFE_E_INVALID_PARAMETER;
                        }
                        else
                        {
                            hr = STRSAFE_E_INSUFFICIENT_BUFFER;
                        }
                    }
                }
                else
                {
                    nuint cchCopied = 0;

                    hr = StringCopyWorkerW(pszDest, cchDest, &cchCopied, pszSrc, cchToCopy);
                    pszDestEnd = pszDest + cchCopied;
                    unchecked(cchRemaining) = unchecked(cchDest - cchCopied);
                    if (SUCCEEDED(hr) && (dwFlags & STRSAFE_FILL_BEHIND_NULL) != 0)
                    {
                        nuint cbRemaining;

                        cbRemaining = unchecked((cchRemaining * sizeof(char)) + (cbDest % sizeof(char)));
                        _ = StringExHandleFillBehindNullW(pszDestEnd, cbRemaining, dwFlags);
                    }
                }
            }
            else
            {
                if (unchecked(cchDest) != 0)
                {
                    *pszDest = '\0';
                }
            }

            if (FAILED(hr) && (dwFlags & (STRSAFE_NO_TRUNCATION | STRSAFE_FILL_ON_FAILURE | STRSAFE_NULL_ON_FAILURE)) != 0 && (cbDest != 0))
            {
                _ = StringExHandleOtherFlagsW(pszDest, cbDest, 0, &pszDestEnd, &cchRemaining, dwFlags);
            }

            if (SUCCEEDED(hr) || (hr == STRSAFE_E_INSUFFICIENT_BUFFER))
            {
                if ((ppszDestEnd) != null)
                {
                    *ppszDestEnd = pszDestEnd;
                }

                if ((pcbRemaining) != null)
                {
                    *pcbRemaining = unchecked((cchRemaining * sizeof(char)) + (cbDest % sizeof(char)));
                }
            }
        }

        return hr;
    }
}
