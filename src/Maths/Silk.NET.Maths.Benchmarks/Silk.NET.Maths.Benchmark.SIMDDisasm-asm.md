## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128LessThanOrEqual_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vcmplepd  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Add_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vaddpd    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Subtract_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vsubpd    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Multiply_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vmulpd    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Divide_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vdivpd    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Min_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vminpd    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Max_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vmaxpd    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Equal_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vcmpeqpd  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128NotEqual_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vcmpneqpd xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256GreaterThan_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vcmpgtpd  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256LessThan_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vcmpltpd  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256GreaterThanOrEqual_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vcmpgepd  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256LessThanOrEqual_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vcmplepd  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Add_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vaddpd    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Subtract_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vsubpd    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Multiply_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vmulpd    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Divide_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vdivpd    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Min_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vminpd    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Max_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vmaxpd    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Equal_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vcmpeqpd  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256NotEqual_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vcmpneqpd ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThanOrEqual_long()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L04
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       mov       rcx,[rcx+r15*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r15*8]
       cmp       rcx,rdx
       setge     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA55B80]
       jmp       short M00_L03
M00_L02:
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA55BD8]
M00_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r15*8],r12
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 232
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThanOrEqual_long()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L04
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       mov       rcx,[rcx+r15*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r15*8]
       cmp       rcx,rdx
       setle     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA25B80]
       jmp       short M00_L03
M00_L02:
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA25BD8]
M00_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r15*8],r12
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 232
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Add_long()
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+30],r9
       test      r11d,r11d
       jne       short M00_L02
       lea       r11,[rsp+30]
       xor       esi,esi
       mov       r11,[r11+rsi*8]
       mov       [rsp+28],r8
       lea       rdi,[rsp+28]
       mov       rdi,[rdi+rsi*8]
       add       r11,rdi
       xor       edi,edi
       mov       [rsp+20],rdi
       lea       rdi,[rsp+20]
       mov       [rdi+rsi*8],r11
       mov       r11d,1
       test      r11d,r11d
       jle       short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 144
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Subtract_long()
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+30],r9
       test      r11d,r11d
       jne       short M00_L02
       lea       r11,[rsp+30]
       xor       esi,esi
       mov       r11,[r11+rsi*8]
       mov       [rsp+28],r8
       lea       rdi,[rsp+28]
       mov       rdi,[rdi+rsi*8]
       sub       r11,rdi
       xor       edi,edi
       mov       [rsp+20],rdi
       lea       rdi,[rsp+20]
       mov       [rdi+rsi*8],r11
       mov       r11d,1
       test      r11d,r11d
       jle       short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 144
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Multiply_long()
       push      rdi
       push      rsi
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+30],r9
       test      r11d,r11d
       jne       short M00_L02
       lea       r11,[rsp+30]
       xor       esi,esi
       mov       r11,[r11+rsi*8]
       mov       [rsp+28],r8
       lea       rdi,[rsp+28]
       mov       rdi,[rdi+rsi*8]
       imul      r11,rdi
       xor       edi,edi
       mov       [rsp+20],rdi
       lea       rdi,[rsp+20]
       mov       [rdi+rsi*8],r11
       mov       r11d,1
       test      r11d,r11d
       jle       short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 145
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Divide_long()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       r8d,r8d
M00_L00:
       mov       rax,[rcx+18]
       movsxd    rdx,r8d
       lea       r9,[rax+rdx*8]
       mov       rax,[rcx+8]
       mov       r10,[rax+rdx*8]
       mov       rax,[rcx+10]
       mov       r11,[rax+rdx*8]
       xor       esi,esi
       xor       edi,edi
M00_L01:
       mov       [rsp+38],r10
       test      edi,edi
       jne       short M00_L02
       lea       rax,[rsp+38]
       xor       edi,edi
       mov       rax,[rax+rdi*8]
       mov       [rsp+30],r11
       lea       rdx,[rsp+30]
       mov       rbx,[rdx+rdi*8]
       cqo
       idiv      rbx
       xor       edx,edx
       mov       [rsp+28],rdx
       lea       rdx,[rsp+28]
       mov       [rdx+rdi*8],rax
       mov       edi,1
       test      edi,edi
       jle       short M00_L01
       xor       eax,eax
       mov       [r9],rax
       inc       r8d
       cmp       r8d,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 145
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Min_long()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       test      r12d,r12d
       jne       short M00_L02
       lea       rcx,[rsp+38]
       xor       r12d,r12d
       mov       rcx,[rcx+r12*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r12*8]
       call      System.Math.Min(Int64, Int64)
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r12*8],rax
       mov       r12d,1
       test      r12d,r12d
       jle       short M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 165
```
```assembly
; System.Math.Min(Int64, Int64)
       cmp       rcx,rdx
       jle       short M01_L00
       mov       rax,rdx
       ret
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 13
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Max_long()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       test      r12d,r12d
       jne       short M00_L02
       lea       rcx,[rsp+38]
       xor       r12d,r12d
       mov       rcx,[rcx+r12*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r12*8]
       call      System.Math.Max(Int64, Int64)
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r12*8],rax
       mov       r12d,1
       test      r12d,r12d
       jle       short M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 165
```
```assembly
; System.Math.Max(Int64, Int64)
       cmp       rcx,rdx
       jge       short M01_L00
       mov       rax,rdx
       ret
M01_L00:
       mov       rax,rcx
       ret
; Total bytes of code 13
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Equal_long()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L04
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       mov       rcx,[rcx+r15*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r15*8]
       cmp       rcx,rdx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA25B80]
       jmp       short M00_L03
M00_L02:
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA25BD8]
M00_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r15*8],r12
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 232
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_30.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128GreaterThan_long()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       vmovaps   [rsp+70],xmm6
       vmovaps   [rsp+60],xmm7
       vmovaps   [rsp+50],xmm8
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,4
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   xmm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   xmm7,[rdx+rcx]
       vxorps    xmm8,xmm8,xmm8
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L05
       lea       rbp,[rsp+40]
       mov       r14,[rbp]
       vmovapd   [rsp+30],xmm7
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L05
       lea       r15,[rsp+30]
       mov       r12,[r15]
       cmp       r14,r12
       setg      r13b
       movzx     r13d,r13b
       test      r13d,r13d
       jne       short M00_L01
       mov       rcx,7FF91AAB70A8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,[7FF91AA35B80]
       jmp       short M00_L02
M00_L01:
       mov       rcx,7FF91AAB70A8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,[7FF91AA35BD8]
M00_L02:
       vmovapd   [rsp+20],xmm8
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       vmovapd   [rsp+40],xmm6
       mov       eax,2
       cmp       eax,1
       jbe       near ptr M00_L05
       lea       rbp,[rsp+40]
       mov       r14,[rbp+8]
       vmovapd   [rsp+30],xmm7
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L05
       lea       r15,[rsp+30]
       mov       r12,[r15+8]
       cmp       r14,r12
       setg      r13b
       movzx     r13d,r13b
       test      r13d,r13d
       jne       short M00_L03
       mov       rax,[7FF91AA35B80]
       jmp       short M00_L04
M00_L03:
       mov       rax,[7FF91AA35BD8]
M00_L04:
       vmovapd   [rsp+20],xmm8
       lea       rcx,[rsp+20]
       mov       [rcx+8],rax
       vmovupd   [rbx],xmm8
       inc       edi
       cmp       edi,28
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+70]
       vmovaps   xmm7,[rsp+60]
       vmovaps   xmm8,[rsp+50]
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 394
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128LessThan_long()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       vmovaps   [rsp+70],xmm6
       vmovaps   [rsp+60],xmm7
       vmovaps   [rsp+50],xmm8
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,4
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   xmm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   xmm7,[rdx+rcx]
       vxorps    xmm8,xmm8,xmm8
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L05
       lea       rbp,[rsp+40]
       mov       r14,[rbp]
       vmovapd   [rsp+30],xmm7
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L05
       lea       r15,[rsp+30]
       mov       r12,[r15]
       cmp       r14,r12
       setl      r13b
       movzx     r13d,r13b
       test      r13d,r13d
       jne       short M00_L01
       mov       rcx,7FF91AAC70A8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,[7FF91AA45B80]
       jmp       short M00_L02
M00_L01:
       mov       rcx,7FF91AAC70A8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,[7FF91AA45BD8]
M00_L02:
       vmovapd   [rsp+20],xmm8
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       vmovapd   [rsp+40],xmm6
       mov       eax,2
       cmp       eax,1
       jbe       near ptr M00_L05
       lea       rbp,[rsp+40]
       mov       r14,[rbp+8]
       vmovapd   [rsp+30],xmm7
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L05
       lea       r15,[rsp+30]
       mov       r12,[r15+8]
       cmp       r14,r12
       setl      r13b
       movzx     r13d,r13b
       test      r13d,r13d
       jne       short M00_L03
       mov       rax,[7FF91AA45B80]
       jmp       short M00_L04
M00_L03:
       mov       rax,[7FF91AA45BD8]
M00_L04:
       vmovapd   [rsp+20],xmm8
       lea       rcx,[rsp+20]
       mov       [rcx+8],rax
       vmovupd   [rbx],xmm8
       inc       edi
       cmp       edi,28
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+70]
       vmovaps   xmm7,[rsp+60]
       vmovaps   xmm8,[rsp+50]
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 394
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_33.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_34.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Add_long()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpaddq    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Subtract_long()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpsubq    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Multiply_long()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       vmovaps   [rsp+70],xmm6
       vmovaps   [rsp+60],xmm7
       vmovaps   [rsp+50],xmm8
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,4
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   xmm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   xmm7,[rdx+rcx]
       vxorps    xmm8,xmm8,xmm8
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L01
       lea       rbp,[rsp+40]
       mov       rcx,[rbp]
       vmovapd   [rsp+30],xmm7
       mov       edx,2
       test      edx,edx
       jbe       near ptr M00_L01
       lea       r14,[rsp+30]
       mov       rdx,[r14]
       call      Silk.NET.Maths.Scalar.<Multiply>g__Long|24_9[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L01
       vmovapd   [rsp+20],xmm8
       lea       r15,[rsp+20]
       mov       [r15],rax
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L01
       lea       rbp,[rsp+40]
       mov       rcx,[rbp+8]
       vmovapd   [rsp+30],xmm7
       mov       edx,2
       cmp       edx,1
       jbe       short M00_L01
       lea       r14,[rsp+30]
       mov       rdx,[r14+8]
       call      Silk.NET.Maths.Scalar.<Multiply>g__Long|24_9[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L01
       vmovapd   [rsp+20],xmm8
       lea       r15,[rsp+20]
       mov       [r15+8],rax
       vmovupd   [rbx],xmm8
       inc       edi
       cmp       edi,28
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+70]
       vmovaps   xmm7,[rsp+60]
       vmovaps   xmm8,[rsp+50]
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L01:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 317
```
```assembly
; Silk.NET.Maths.Scalar.<Multiply>g__Long|24_9[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       mov       rax,rcx
       imul      rax,rdx
       ret
; Total bytes of code 8
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Divide_long()
       push      rsi
       sub       rsp,50
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       xor       r8d,r8d
M00_L00:
       mov       r9,[rcx+18]
       movsxd    rax,r8d
       shl       rax,4
       add       r9,rax
       mov       rdx,[rcx+8]
       vmovupd   xmm0,[rdx+rax]
       mov       rdx,[rcx+10]
       vmovupd   xmm1,[rdx+rax]
       vxorps    xmm2,xmm2,xmm2
       vmovapd   [rsp+40],xmm0
       mov       eax,2
       test      eax,eax
       jbe       near ptr M00_L01
       lea       r10,[rsp+40]
       mov       rax,[r10]
       vmovapd   [rsp+30],xmm1
       mov       edx,2
       test      edx,edx
       jbe       near ptr M00_L01
       lea       r11,[rsp+30]
       mov       rsi,[r11]
       cqo
       idiv      rsi
       mov       r10d,2
       test      r10d,r10d
       jbe       near ptr M00_L01
       vmovapd   [rsp+20],xmm2
       lea       r10,[rsp+20]
       mov       [r10],rax
       vmovapd   [rsp+40],xmm0
       mov       r11d,2
       cmp       r11d,1
       jbe       short M00_L01
       lea       r10,[rsp+40]
       mov       rax,[r10+8]
       vmovapd   [rsp+30],xmm1
       mov       edx,2
       cmp       edx,1
       jbe       short M00_L01
       lea       r11,[rsp+30]
       mov       rsi,[r11+8]
       cqo
       idiv      rsi
       mov       edx,2
       cmp       edx,1
       jbe       short M00_L01
       vmovapd   [rsp+20],xmm2
       lea       r10,[rsp+20]
       mov       [r10+8],rax
       vmovupd   [r9],xmm2
       inc       r8d
       cmp       r8d,28
       jl        near ptr M00_L00
       add       rsp,50
       pop       rsi
       ret
M00_L01:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 264
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Min_long()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       vmovaps   [rsp+70],xmm6
       vmovaps   [rsp+60],xmm7
       vmovaps   [rsp+50],xmm8
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,4
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   xmm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   xmm7,[rdx+rcx]
       vxorps    xmm8,xmm8,xmm8
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L01
       lea       rbp,[rsp+40]
       mov       rcx,[rbp]
       vmovapd   [rsp+30],xmm7
       mov       edx,2
       test      edx,edx
       jbe       near ptr M00_L01
       lea       r14,[rsp+30]
       mov       rdx,[r14]
       call      Silk.NET.Maths.Scalar.<Min>g__Long|70_9[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L01
       vmovapd   [rsp+20],xmm8
       lea       r15,[rsp+20]
       mov       [r15],rax
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L01
       lea       rbp,[rsp+40]
       mov       rcx,[rbp+8]
       vmovapd   [rsp+30],xmm7
       mov       edx,2
       cmp       edx,1
       jbe       short M00_L01
       lea       r14,[rsp+30]
       mov       rdx,[r14+8]
       call      Silk.NET.Maths.Scalar.<Min>g__Long|70_9[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L01
       vmovapd   [rsp+20],xmm8
       lea       r15,[rsp+20]
       mov       [r15+8],rax
       vmovupd   [rbx],xmm8
       inc       edi
       cmp       edi,28
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+70]
       vmovaps   xmm7,[rsp+60]
       vmovaps   xmm8,[rsp+50]
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L01:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 317
```
```assembly
; Silk.NET.Maths.Scalar.<Min>g__Long|70_9[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       cmp       rcx,rdx
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,rcx
M01_L01:
       mov       rax,rdx
       ret
; Total bytes of code 14
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Max_long()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       vmovaps   [rsp+70],xmm6
       vmovaps   [rsp+60],xmm7
       vmovaps   [rsp+50],xmm8
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,4
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   xmm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   xmm7,[rdx+rcx]
       vxorps    xmm8,xmm8,xmm8
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L01
       lea       rbp,[rsp+40]
       mov       rcx,[rbp]
       vmovapd   [rsp+30],xmm7
       mov       edx,2
       test      edx,edx
       jbe       near ptr M00_L01
       lea       r14,[rsp+30]
       mov       rdx,[r14]
       call      Silk.NET.Maths.Scalar.<Max>g__Long|69_9[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L01
       vmovapd   [rsp+20],xmm8
       lea       r15,[rsp+20]
       mov       [r15],rax
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L01
       lea       rbp,[rsp+40]
       mov       rcx,[rbp+8]
       vmovapd   [rsp+30],xmm7
       mov       edx,2
       cmp       edx,1
       jbe       short M00_L01
       lea       r14,[rsp+30]
       mov       rdx,[r14+8]
       call      Silk.NET.Maths.Scalar.<Max>g__Long|69_9[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L01
       vmovapd   [rsp+20],xmm8
       lea       r15,[rsp+20]
       mov       [r15+8],rax
       vmovupd   [rbx],xmm8
       inc       edi
       cmp       edi,28
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+70]
       vmovaps   xmm7,[rsp+60]
       vmovaps   xmm8,[rsp+50]
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L01:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 317
```
```assembly
; Silk.NET.Maths.Scalar.<Max>g__Long|69_9[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       cmp       rcx,rdx
       jge       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,rcx
M01_L01:
       mov       rax,rdx
       ret
; Total bytes of code 14
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Equal_long()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       vmovaps   [rsp+70],xmm6
       vmovaps   [rsp+60],xmm7
       vmovaps   [rsp+50],xmm8
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,4
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   xmm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   xmm7,[rdx+rcx]
       vxorps    xmm8,xmm8,xmm8
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L05
       lea       rbp,[rsp+40]
       mov       r14,[rbp]
       vmovapd   [rsp+30],xmm7
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L05
       lea       r15,[rsp+30]
       mov       r12,[r15]
       cmp       r14,r12
       sete      r13b
       movzx     r13d,r13b
       test      r13d,r13d
       jne       short M00_L01
       mov       rcx,7FF91AAD70A8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,[7FF91AA55B80]
       jmp       short M00_L02
M00_L01:
       mov       rcx,7FF91AAD70A8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,[7FF91AA55BD8]
M00_L02:
       vmovapd   [rsp+20],xmm8
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       vmovapd   [rsp+40],xmm6
       mov       eax,2
       cmp       eax,1
       jbe       near ptr M00_L05
       lea       rbp,[rsp+40]
       mov       r14,[rbp+8]
       vmovapd   [rsp+30],xmm7
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L05
       lea       r15,[rsp+30]
       mov       r12,[r15+8]
       cmp       r14,r12
       sete      r13b
       movzx     r13d,r13b
       test      r13d,r13d
       jne       short M00_L03
       mov       rax,[7FF91AA55B80]
       jmp       short M00_L04
M00_L03:
       mov       rax,[7FF91AA55BD8]
M00_L04:
       vmovapd   [rsp+20],xmm8
       lea       rcx,[rsp+20]
       mov       [rcx+8],rax
       vmovupd   [rbx],xmm8
       inc       edi
       cmp       edi,28
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+70]
       vmovaps   xmm7,[rsp+60]
       vmovaps   xmm8,[rsp+50]
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 394
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_42.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256GreaterThan_long()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpcmpgtq  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_44.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_45.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_46.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Add_long()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpaddq    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Subtract_long()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpsubq    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Multiply_long()
       sub       rsp,98
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vxorps    ymm2,ymm2,ymm2
       xor       r8d,r8d
M00_L01:
       vmovupd   [rsp+60],ymm0
       cmp       r8d,4
       jae       short M00_L02
       lea       r9,[rsp+60]
       movsxd    r10,r8d
       mov       r9,[r9+r10*8]
       vmovupd   [rsp+40],ymm1
       cmp       r8d,4
       jae       short M00_L02
       lea       r11,[rsp+40]
       mov       r11,[r11+r10*8]
       imul      r9,r11
       cmp       r8d,4
       jae       short M00_L02
       vmovupd   [rsp+20],ymm2
       lea       r11,[rsp+20]
       mov       [r11+r10*8],r9
       inc       r8d
       cmp       r8d,4
       jl        short M00_L01
       vmovupd   [rdx],ymm2
       inc       eax
       cmp       eax,14
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,98
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 185
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Divide_long()
       push      rsi
       sub       rsp,90
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       r8d,r8d
M00_L00:
       mov       r9,[rcx+18]
       movsxd    rax,r8d
       shl       rax,5
       add       r9,rax
       mov       rdx,[rcx+8]
       vmovupd   ymm0,[rdx+rax]
       mov       rdx,[rcx+10]
       vmovupd   ymm1,[rdx+rax]
       vxorps    ymm2,ymm2,ymm2
       xor       r10d,r10d
M00_L01:
       vmovupd   [rsp+60],ymm0
       cmp       r10d,4
       jae       short M00_L02
       lea       rax,[rsp+60]
       movsxd    r11,r10d
       mov       rax,[rax+r11*8]
       vmovupd   [rsp+40],ymm1
       cmp       r10d,4
       jae       short M00_L02
       lea       rdx,[rsp+40]
       mov       rsi,[rdx+r11*8]
       cqo
       idiv      rsi
       cmp       r10d,4
       jae       short M00_L02
       vmovupd   [rsp+20],ymm2
       lea       rdx,[rsp+20]
       mov       [rdx+r11*8],rax
       inc       r10d
       cmp       r10d,4
       jl        short M00_L01
       vmovupd   [r9],ymm2
       inc       r8d
       cmp       r8d,14
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,90
       pop       rsi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 190
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Min_long()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0F0
       vzeroupper
       vmovaps   [rsp+0E0],xmm6
       vmovaps   [rsp+0D0],xmm7
       vmovaps   [rsp+0C0],xmm8
       vmovaps   [rsp+0B0],xmm9
       vmovaps   [rsp+0A0],xmm10
       vmovaps   [rsp+90],xmm11
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,5
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   ymm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   ymm7,[rdx+rcx]
       vxorps    ymm8,ymm8,ymm8
       xor       ebp,ebp
M00_L01:
       vmovupd   [rsp+60],ymm6
       cmp       ebp,4
       jae       near ptr M00_L02
       lea       rcx,[rsp+60]
       movsxd    r14,ebp
       mov       rcx,[rcx+r14*8]
       vmovupd   [rsp+40],ymm7
       cmp       ebp,4
       jae       near ptr M00_L02
       lea       rdx,[rsp+40]
       mov       rdx,[rdx+r14*8]
       vextractf128 xmm9,ymm8,1
       vextractf128 xmm10,ymm6,1
       vextractf128 xmm11,ymm7,1
       call      Silk.NET.Maths.Scalar.<Min>g__Long|70_9[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       cmp       ebp,4
       vinsertf128 ymm8,ymm8,xmm9,1
       vinsertf128 ymm6,ymm6,xmm10,1
       vinsertf128 ymm7,ymm7,xmm11,1
       jae       short M00_L02
       vmovupd   [rsp+20],ymm8
       lea       rcx,[rsp+20]
       mov       [rcx+r14*8],rax
       inc       ebp
       cmp       ebp,4
       jl        short M00_L01
       vmovupd   [rbx],ymm8
       inc       edi
       cmp       edi,14
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+0E0]
       vmovaps   xmm7,[rsp+0D0]
       vmovaps   xmm8,[rsp+0C0]
       vmovaps   xmm9,[rsp+0B0]
       vmovaps   xmm10,[rsp+0A0]
       vmovaps   xmm11,[rsp+90]
       vzeroupper
       add       rsp,0F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 346
```
```assembly
; Silk.NET.Maths.Scalar.<Min>g__Long|70_9[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       cmp       rcx,rdx
       jle       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,rcx
M01_L01:
       mov       rax,rdx
       ret
; Total bytes of code 14
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Max_long()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0F0
       vzeroupper
       vmovaps   [rsp+0E0],xmm6
       vmovaps   [rsp+0D0],xmm7
       vmovaps   [rsp+0C0],xmm8
       vmovaps   [rsp+0B0],xmm9
       vmovaps   [rsp+0A0],xmm10
       vmovaps   [rsp+90],xmm11
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,5
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   ymm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   ymm7,[rdx+rcx]
       vxorps    ymm8,ymm8,ymm8
       xor       ebp,ebp
M00_L01:
       vmovupd   [rsp+60],ymm6
       cmp       ebp,4
       jae       near ptr M00_L02
       lea       rcx,[rsp+60]
       movsxd    r14,ebp
       mov       rcx,[rcx+r14*8]
       vmovupd   [rsp+40],ymm7
       cmp       ebp,4
       jae       near ptr M00_L02
       lea       rdx,[rsp+40]
       mov       rdx,[rdx+r14*8]
       vextractf128 xmm9,ymm8,1
       vextractf128 xmm10,ymm6,1
       vextractf128 xmm11,ymm7,1
       call      Silk.NET.Maths.Scalar.<Max>g__Long|69_9[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       cmp       ebp,4
       vinsertf128 ymm8,ymm8,xmm9,1
       vinsertf128 ymm6,ymm6,xmm10,1
       vinsertf128 ymm7,ymm7,xmm11,1
       jae       short M00_L02
       vmovupd   [rsp+20],ymm8
       lea       rcx,[rsp+20]
       mov       [rcx+r14*8],rax
       inc       ebp
       cmp       ebp,4
       jl        short M00_L01
       vmovupd   [rbx],ymm8
       inc       edi
       cmp       edi,14
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+0E0]
       vmovaps   xmm7,[rsp+0D0]
       vmovaps   xmm8,[rsp+0C0]
       vmovaps   xmm9,[rsp+0B0]
       vmovaps   xmm10,[rsp+0A0]
       vmovaps   xmm11,[rsp+90]
       vzeroupper
       add       rsp,0F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 346
```
```assembly
; Silk.NET.Maths.Scalar.<Max>g__Long|69_9[[System.Int64, System.Private.CoreLib]](Int64, Int64)
       cmp       rcx,rdx
       jge       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,rcx
M01_L01:
       mov       rax,rdx
       ret
; Total bytes of code 14
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Equal_long()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpcmpeqq  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_54.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThan_float()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vzeroupper
       vmovaps   [rsp+40],xmm6
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+30],rbp
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+30]
       movsxd    r13,r12d
       vmovss    xmm0,dword ptr [rcx+r13*4]
       mov       [rsp+28],r14
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+28]
       vmovss    xmm1,dword ptr [rcx+r13*4]
       vucomiss  xmm0,xmm1
       seta      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+3C],eax
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovss    xmm6,dword ptr [7FF91AA25B68]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+3C],eax
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovss    xmm6,dword ptr [7FF91AA25B94]
M00_L03:
       cmp       dword ptr [rsp+3C],2
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       vmovss    dword ptr [rcx+r13*4],xmm6
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+40]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 290
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThan_float()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vzeroupper
       vmovaps   [rsp+40],xmm6
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+30],rbp
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+30]
       movsxd    r13,r12d
       vmovss    xmm0,dword ptr [rcx+r13*4]
       mov       [rsp+28],r14
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+28]
       vmovss    xmm1,dword ptr [rcx+r13*4]
       vucomiss  xmm1,xmm0
       seta      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+3C],eax
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovss    xmm6,dword ptr [7FF91AA25B68]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+3C],eax
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovss    xmm6,dword ptr [7FF91AA25B94]
M00_L03:
       cmp       dword ptr [rsp+3C],2
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       vmovss    dword ptr [rcx+r13*4],xmm6
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+40]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 290
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThanOrEqual_float()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vzeroupper
       vmovaps   [rsp+40],xmm6
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+30],rbp
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+30]
       movsxd    r13,r12d
       vmovss    xmm0,dword ptr [rcx+r13*4]
       mov       [rsp+28],r14
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+28]
       vmovss    xmm1,dword ptr [rcx+r13*4]
       vucomiss  xmm0,xmm1
       setae     cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+3C],eax
       mov       rcx,7FF91AA97080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovss    xmm6,dword ptr [7FF91AA15B68]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+3C],eax
       mov       rcx,7FF91AA97080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovss    xmm6,dword ptr [7FF91AA15B94]
M00_L03:
       cmp       dword ptr [rsp+3C],2
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       vmovss    dword ptr [rcx+r13*4],xmm6
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+40]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 290
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThanOrEqual_float()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vzeroupper
       vmovaps   [rsp+40],xmm6
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+30],rbp
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+30]
       movsxd    r13,r12d
       vmovss    xmm0,dword ptr [rcx+r13*4]
       mov       [rsp+28],r14
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+28]
       vmovss    xmm1,dword ptr [rcx+r13*4]
       vucomiss  xmm1,xmm0
       setae     cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+3C],eax
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovss    xmm6,dword ptr [7FF91AA55B68]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+3C],eax
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovss    xmm6,dword ptr [7FF91AA55B94]
M00_L03:
       cmp       dword ptr [rsp+3C],2
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       vmovss    dword ptr [rcx+r13*4],xmm6
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+40]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 290
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Add_float()
       push      rdi
       push      rsi
       sub       rsp,38
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+30],r9
       cmp       r11d,2
       jae       short M00_L02
       lea       rsi,[rsp+30]
       movsxd    rdi,r11d
       vmovss    xmm0,dword ptr [rsi+rdi*4]
       mov       [rsp+28],r8
       cmp       r11d,2
       jae       short M00_L02
       lea       rsi,[rsp+28]
       vmovss    xmm1,dword ptr [rsi+rdi*4]
       vaddss    xmm0,xmm0,xmm1
       cmp       r11d,2
       jae       short M00_L02
       xor       esi,esi
       mov       [rsp+20],rsi
       lea       rsi,[rsp+20]
       vmovss    dword ptr [rsi+rdi*4],xmm0
       inc       r11d
       cmp       r11d,2
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 163
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Subtract_float()
       push      rdi
       push      rsi
       sub       rsp,38
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+30],r9
       cmp       r11d,2
       jae       short M00_L02
       lea       rsi,[rsp+30]
       movsxd    rdi,r11d
       vmovss    xmm0,dword ptr [rsi+rdi*4]
       mov       [rsp+28],r8
       cmp       r11d,2
       jae       short M00_L02
       lea       rsi,[rsp+28]
       vmovss    xmm1,dword ptr [rsi+rdi*4]
       vsubss    xmm0,xmm0,xmm1
       cmp       r11d,2
       jae       short M00_L02
       xor       esi,esi
       mov       [rsp+20],rsi
       lea       rsi,[rsp+20]
       vmovss    dword ptr [rsi+rdi*4],xmm0
       inc       r11d
       cmp       r11d,2
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 163
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Multiply_float()
       push      rdi
       push      rsi
       sub       rsp,38
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+30],r9
       cmp       r11d,2
       jae       short M00_L02
       lea       rsi,[rsp+30]
       movsxd    rdi,r11d
       vmovss    xmm0,dword ptr [rsi+rdi*4]
       mov       [rsp+28],r8
       cmp       r11d,2
       jae       short M00_L02
       lea       rsi,[rsp+28]
       vmovss    xmm1,dword ptr [rsi+rdi*4]
       vmulss    xmm0,xmm0,xmm1
       cmp       r11d,2
       jae       short M00_L02
       xor       esi,esi
       mov       [rsp+20],rsi
       lea       rsi,[rsp+20]
       vmovss    dword ptr [rsi+rdi*4],xmm0
       inc       r11d
       cmp       r11d,2
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 163
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Divide_float()
       push      rdi
       push      rsi
       sub       rsp,38
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+30],r9
       cmp       r11d,2
       jae       short M00_L02
       lea       rsi,[rsp+30]
       movsxd    rdi,r11d
       vmovss    xmm0,dword ptr [rsi+rdi*4]
       mov       [rsp+28],r8
       cmp       r11d,2
       jae       short M00_L02
       lea       rsi,[rsp+28]
       vmovss    xmm1,dword ptr [rsi+rdi*4]
       vdivss    xmm0,xmm0,xmm1
       cmp       r11d,2
       jae       short M00_L02
       xor       esi,esi
       mov       [rsp+20],rsi
       lea       rsi,[rsp+20]
       vmovss    dword ptr [rsi+rdi*4],xmm0
       inc       r11d
       cmp       r11d,2
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 163
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Min_float()
       push      rdi
       push      rsi
       sub       rsp,38
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+30],r9
       cmp       r11d,2
       jae       near ptr M00_L07
       lea       rsi,[rsp+30]
       movsxd    rdi,r11d
       vmovss    xmm0,dword ptr [rsi+rdi*4]
       mov       [rsp+28],r8
       cmp       r11d,2
       jae       near ptr M00_L07
       lea       rsi,[rsp+28]
       vmovss    xmm1,dword ptr [rsi+rdi*4]
       vucomiss  xmm0,xmm1
       jp        short M00_L02
       je        short M00_L04
M00_L02:
       vucomiss  xmm0,xmm0
       jp        short M00_L04
       vucomiss  xmm1,xmm0
       ja        short M00_L03
       jmp       short M00_L06
M00_L03:
       vmovaps   xmm1,xmm0
       jmp       short M00_L06
M00_L04:
       vmovaps   xmm2,xmm0
       vmovd     esi,xmm2
       test      esi,esi
       jl        short M00_L05
       jmp       short M00_L06
M00_L05:
       vmovaps   xmm1,xmm0
M00_L06:
       cmp       r11d,2
       jae       short M00_L07
       xor       esi,esi
       mov       [rsp+20],rsi
       lea       rsi,[rsp+20]
       vmovss    dword ptr [rsi+rdi*4],xmm1
       inc       r11d
       cmp       r11d,2
       jl        near ptr M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L07:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 221
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Max_float()
       push      rdi
       push      rsi
       sub       rsp,38
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+30],r9
       cmp       r11d,2
       jae       near ptr M00_L08
       lea       rsi,[rsp+30]
       movsxd    rdi,r11d
       vmovss    xmm0,dword ptr [rsi+rdi*4]
       mov       [rsp+28],r8
       cmp       r11d,2
       jae       near ptr M00_L08
       lea       rsi,[rsp+28]
       vmovss    xmm1,dword ptr [rsi+rdi*4]
       vucomiss  xmm0,xmm1
       jp        short M00_L02
       je        short M00_L05
M00_L02:
       vucomiss  xmm0,xmm0
       jp        short M00_L04
       vucomiss  xmm0,xmm1
       ja        short M00_L03
       jmp       short M00_L07
M00_L03:
       vmovaps   xmm1,xmm0
       jmp       short M00_L07
M00_L04:
       vmovaps   xmm1,xmm0
       jmp       short M00_L07
M00_L05:
       vmovaps   xmm2,xmm1
       vmovd     esi,xmm2
       test      esi,esi
       jl        short M00_L06
       jmp       short M00_L07
M00_L06:
       vmovaps   xmm1,xmm0
M00_L07:
       cmp       r11d,2
       jae       short M00_L08
       xor       esi,esi
       mov       [rsp+20],rsi
       lea       rsi,[rsp+20]
       vmovss    dword ptr [rsi+rdi*4],xmm1
       inc       r11d
       cmp       r11d,2
       jl        near ptr M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,38
       pop       rsi
       pop       rdi
       ret
M00_L08:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 227
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Equal_float()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vzeroupper
       vmovaps   [rsp+40],xmm6
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+30],rbp
       cmp       r12d,2
       jae       near ptr M00_L05
       lea       rcx,[rsp+30]
       movsxd    r13,r12d
       vmovss    xmm0,dword ptr [rcx+r13*4]
       mov       [rsp+28],r14
       cmp       r12d,2
       jae       near ptr M00_L05
       lea       rcx,[rsp+28]
       vmovss    xmm1,dword ptr [rcx+r13*4]
       vucomiss  xmm0,xmm1
       setnp     cl
       jp        short M00_L02
       sete      cl
M00_L02:
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L03
       mov       [rsp+3C],eax
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovss    xmm6,dword ptr [7FF91AA35B68]
       jmp       short M00_L04
M00_L03:
       mov       [rsp+3C],eax
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovss    xmm6,dword ptr [7FF91AA35B94]
M00_L04:
       cmp       dword ptr [rsp+3C],2
       jae       short M00_L05
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       vmovss    dword ptr [rcx+r13*4],xmm6
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+40]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 295
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64NotEqual_float()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       vzeroupper
       vmovaps   [rsp+80],xmm6
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+30],rbp
       cmp       r12d,2
       jae       near ptr M00_L05
       lea       rcx,[rsp+30]
       movsxd    r13,r12d
       vmovss    xmm0,dword ptr [rcx+r13*4]
       mov       [rsp+28],r14
       cmp       r12d,2
       jae       near ptr M00_L05
       lea       rcx,[rsp+28]
       vmovss    xmm1,dword ptr [rcx+r13*4]
       vucomiss  xmm0,xmm1
       setp      cl
       jp        short M00_L02
       setne     cl
M00_L02:
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L03
       mov       [rsp+3C],eax
       mov       rcx,7FF91AAC7080
       mov       edx,1
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovss    xmm6,dword ptr [7FF91AA46A10]
       jmp       short M00_L04
M00_L03:
       mov       [rsp+3C],eax
       mov       rcx,7FF91AAC7080
       mov       edx,1
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovss    xmm6,dword ptr [7FF91AA46A3C]
M00_L04:
       cmp       dword ptr [rsp+3C],2
       jae       short M00_L05
       xor       ecx,ecx
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       vmovss    dword ptr [rcx+r13*4],xmm6
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+80]
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 357
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128GreaterThan_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vcmpgtps  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128LessThan_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vcmpltps  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128GreaterThanOrEqual_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vcmpgeps  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128LessThanOrEqual_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vcmpleps  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Add_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vaddps    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Subtract_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vsubps    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Multiply_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vmulps    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Divide_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vdivps    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Min_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vminps    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Max_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vmaxps    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Equal_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vcmpeqps  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128NotEqual_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vcmpneqps xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256GreaterThan_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vcmpgtps  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256LessThan_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vcmpltps  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256GreaterThanOrEqual_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vcmpgeps  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256LessThanOrEqual_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vcmpleps  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Add_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vaddps    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Subtract_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vsubps    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Multiply_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vmulps    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Divide_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vdivps    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Min_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vminps    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Max_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vmaxps    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Equal_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vcmpeqps  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256NotEqual_float()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vcmpneqps ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThan_double()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vzeroupper
       vmovaps   [rsp+40],xmm6
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L04
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       vmovsd    xmm0,qword ptr [rcx+r15*8]
       mov       [rsp+30],r14
       lea       rcx,[rsp+30]
       vmovsd    xmm1,qword ptr [rcx+r15*8]
       vucomisd  xmm0,xmm1
       seta      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,7FF91AA97080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovsd    xmm6,qword ptr [7FF91AA15B80]
       jmp       short M00_L03
M00_L02:
       mov       rcx,7FF91AA97080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovsd    xmm6,qword ptr [7FF91AA15BD8]
M00_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       vmovsd    qword ptr [rcx+r15*8],xmm6
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+40]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 252
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThan_double()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vzeroupper
       vmovaps   [rsp+40],xmm6
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L04
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       vmovsd    xmm0,qword ptr [rcx+r15*8]
       mov       [rsp+30],r14
       lea       rcx,[rsp+30]
       vmovsd    xmm1,qword ptr [rcx+r15*8]
       vucomisd  xmm1,xmm0
       seta      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovsd    xmm6,qword ptr [7FF91AA35B80]
       jmp       short M00_L03
M00_L02:
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovsd    xmm6,qword ptr [7FF91AA35BD8]
M00_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       vmovsd    qword ptr [rcx+r15*8],xmm6
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+40]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 252
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThanOrEqual_double()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vzeroupper
       vmovaps   [rsp+40],xmm6
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L04
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       vmovsd    xmm0,qword ptr [rcx+r15*8]
       mov       [rsp+30],r14
       lea       rcx,[rsp+30]
       vmovsd    xmm1,qword ptr [rcx+r15*8]
       vucomisd  xmm0,xmm1
       setae     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovsd    xmm6,qword ptr [7FF91AA45B80]
       jmp       short M00_L03
M00_L02:
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovsd    xmm6,qword ptr [7FF91AA45BD8]
M00_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       vmovsd    qword ptr [rcx+r15*8],xmm6
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+40]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 252
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThanOrEqual_double()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vzeroupper
       vmovaps   [rsp+40],xmm6
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L04
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       vmovsd    xmm0,qword ptr [rcx+r15*8]
       mov       [rsp+30],r14
       lea       rcx,[rsp+30]
       vmovsd    xmm1,qword ptr [rcx+r15*8]
       vucomisd  xmm1,xmm0
       setae     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovsd    xmm6,qword ptr [7FF91AA45B80]
       jmp       short M00_L03
M00_L02:
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovsd    xmm6,qword ptr [7FF91AA45BD8]
M00_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       vmovsd    qword ptr [rcx+r15*8],xmm6
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+40]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 252
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Add_double()
       push      rsi
       sub       rsp,40
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       test      r11d,r11d
       jne       short M00_L02
       lea       r11,[rsp+38]
       xor       esi,esi
       vmovsd    xmm0,qword ptr [r11+rsi*8]
       mov       [rsp+30],r8
       lea       r11,[rsp+30]
       vmovsd    xmm1,qword ptr [r11+rsi*8]
       vaddsd    xmm0,xmm0,xmm1
       xor       r11d,r11d
       mov       [rsp+28],r11
       lea       r11,[rsp+28]
       vmovsd    qword ptr [r11+rsi*8],xmm0
       mov       r11d,1
       test      r11d,r11d
       jle       short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rsi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 153
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Subtract_double()
       push      rsi
       sub       rsp,40
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       test      r11d,r11d
       jne       short M00_L02
       lea       r11,[rsp+38]
       xor       esi,esi
       vmovsd    xmm0,qword ptr [r11+rsi*8]
       mov       [rsp+30],r8
       lea       r11,[rsp+30]
       vmovsd    xmm1,qword ptr [r11+rsi*8]
       vsubsd    xmm0,xmm0,xmm1
       xor       r11d,r11d
       mov       [rsp+28],r11
       lea       r11,[rsp+28]
       vmovsd    qword ptr [r11+rsi*8],xmm0
       mov       r11d,1
       test      r11d,r11d
       jle       short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rsi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 153
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Multiply_double()
       push      rsi
       sub       rsp,40
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       test      r11d,r11d
       jne       short M00_L02
       lea       r11,[rsp+38]
       xor       esi,esi
       vmovsd    xmm0,qword ptr [r11+rsi*8]
       mov       [rsp+30],r8
       lea       r11,[rsp+30]
       vmovsd    xmm1,qword ptr [r11+rsi*8]
       vmulsd    xmm0,xmm0,xmm1
       xor       r11d,r11d
       mov       [rsp+28],r11
       lea       r11,[rsp+28]
       vmovsd    qword ptr [r11+rsi*8],xmm0
       mov       r11d,1
       test      r11d,r11d
       jle       short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rsi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 153
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Divide_double()
       push      rsi
       sub       rsp,40
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       test      r11d,r11d
       jne       short M00_L02
       lea       r11,[rsp+38]
       xor       esi,esi
       vmovsd    xmm0,qword ptr [r11+rsi*8]
       mov       [rsp+30],r8
       lea       r11,[rsp+30]
       vmovsd    xmm1,qword ptr [r11+rsi*8]
       vdivsd    xmm0,xmm0,xmm1
       xor       r11d,r11d
       mov       [rsp+28],r11
       lea       r11,[rsp+28]
       vmovsd    qword ptr [r11+rsi*8],xmm0
       mov       r11d,1
       test      r11d,r11d
       jle       short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rsi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 153
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Min_double()
       push      rsi
       sub       rsp,40
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       test      r11d,r11d
       jne       near ptr M00_L07
       lea       r11,[rsp+38]
       xor       esi,esi
       vmovsd    xmm0,qword ptr [r11+rsi*8]
       mov       [rsp+30],r8
       lea       r11,[rsp+30]
       vmovsd    xmm1,qword ptr [r11+rsi*8]
       vucomisd  xmm0,xmm1
       jp        short M00_L02
       je        short M00_L04
M00_L02:
       vucomisd  xmm0,xmm0
       jp        short M00_L04
       vucomisd  xmm1,xmm0
       ja        short M00_L03
       jmp       short M00_L06
M00_L03:
       vmovaps   xmm1,xmm0
       jmp       short M00_L06
M00_L04:
       vmovaps   xmm2,xmm0
       vmovq     r11,xmm2
       test      r11,r11
       jl        short M00_L05
       jmp       short M00_L06
M00_L05:
       vmovaps   xmm1,xmm0
M00_L06:
       xor       r11d,r11d
       mov       [rsp+28],r11
       lea       r11,[rsp+28]
       vmovsd    qword ptr [r11+rsi*8],xmm1
       mov       r11d,1
       test      r11d,r11d
       jle       short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rsi
       ret
M00_L07:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 205
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Max_double()
       push      rsi
       sub       rsp,40
       vzeroupper
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       test      r11d,r11d
       jne       near ptr M00_L08
       lea       r11,[rsp+38]
       xor       esi,esi
       vmovsd    xmm0,qword ptr [r11+rsi*8]
       mov       [rsp+30],r8
       lea       r11,[rsp+30]
       vmovsd    xmm1,qword ptr [r11+rsi*8]
       vucomisd  xmm0,xmm1
       jp        short M00_L02
       je        short M00_L05
M00_L02:
       vucomisd  xmm0,xmm0
       jp        short M00_L04
       vucomisd  xmm0,xmm1
       ja        short M00_L03
       jmp       short M00_L07
M00_L03:
       vmovaps   xmm1,xmm0
       jmp       short M00_L07
M00_L04:
       vmovaps   xmm1,xmm0
       jmp       short M00_L07
M00_L05:
       vmovaps   xmm2,xmm1
       vmovq     r11,xmm2
       test      r11,r11
       jl        short M00_L06
       jmp       short M00_L07
M00_L06:
       vmovaps   xmm1,xmm0
M00_L07:
       xor       r11d,r11d
       mov       [rsp+28],r11
       lea       r11,[rsp+28]
       vmovsd    qword ptr [r11+rsi*8],xmm1
       mov       r11d,1
       test      r11d,r11d
       jle       short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rsi
       ret
M00_L08:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 211
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Equal_double()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vzeroupper
       vmovaps   [rsp+40],xmm6
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L05
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       vmovsd    xmm0,qword ptr [rcx+r15*8]
       mov       [rsp+30],r14
       lea       rcx,[rsp+30]
       vmovsd    xmm1,qword ptr [rcx+r15*8]
       vucomisd  xmm0,xmm1
       setnp     cl
       jp        short M00_L02
       sete      cl
M00_L02:
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L03
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovsd    xmm6,qword ptr [7FF91AA25B80]
       jmp       short M00_L04
M00_L03:
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovsd    xmm6,qword ptr [7FF91AA25BD8]
M00_L04:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       vmovsd    qword ptr [rcx+r15*8],xmm6
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+40]
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 257
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64NotEqual_double()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,98
       vzeroupper
       vmovaps   [rsp+80],xmm6
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L05
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       vmovsd    xmm0,qword ptr [rcx+r15*8]
       mov       [rsp+30],r14
       lea       rcx,[rsp+30]
       vmovsd    xmm1,qword ptr [rcx+r15*8]
       vucomisd  xmm0,xmm1
       setp      cl
       jp        short M00_L02
       setne     cl
M00_L02:
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L03
       mov       rcx,7FF91AAC7080
       mov       edx,1
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovsd    xmm6,qword ptr [7FF91AA46A28]
       jmp       short M00_L04
M00_L03:
       mov       rcx,7FF91AAC7080
       mov       edx,1
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       vmovsd    xmm6,qword ptr [7FF91AA46A80]
M00_L04:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       vmovsd    qword ptr [rcx+r15*8],xmm6
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+80]
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 320
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128GreaterThan_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vcmpgtpd  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128LessThan_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vcmpltpd  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128GreaterThanOrEqual_double()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vcmpgepd  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_106.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_107.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_108.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Add_uint()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpaddd    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Subtract_uint()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpsubd    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Multiply_uint()
       sub       rsp,98
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vxorps    ymm2,ymm2,ymm2
       xor       r8d,r8d
M00_L01:
       vmovupd   [rsp+60],ymm0
       cmp       r8d,8
       jae       short M00_L02
       lea       r9,[rsp+60]
       movsxd    r10,r8d
       mov       r9d,[r9+r10*4]
       vmovupd   [rsp+40],ymm1
       cmp       r8d,8
       jae       short M00_L02
       lea       r11,[rsp+40]
       mov       r11d,[r11+r10*4]
       imul      r9d,r11d
       cmp       r8d,8
       jae       short M00_L02
       vmovupd   [rsp+20],ymm2
       lea       r11,[rsp+20]
       mov       [r11+r10*4],r9d
       inc       r8d
       cmp       r8d,8
       jl        short M00_L01
       vmovupd   [rdx],ymm2
       inc       eax
       cmp       eax,14
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,98
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 185
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_112.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_113.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_114.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Equal_uint()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpcmpeqd  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_116.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThan_int()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       mov       ecx,[rcx+r13*4]
       mov       [rsp+30],r14
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       mov       edx,[rdx+r13*4]
       cmp       ecx,edx
       setg      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA55B68]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA55B94]
M00_L03:
       cmp       dword ptr [rsp+44],2
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*4],eax
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 263
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThan_int()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       mov       ecx,[rcx+r13*4]
       mov       [rsp+30],r14
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       mov       edx,[rdx+r13*4]
       cmp       ecx,edx
       setl      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA35B68]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA35B94]
M00_L03:
       cmp       dword ptr [rsp+44],2
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*4],eax
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 263
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThanOrEqual_int()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       mov       ecx,[rcx+r13*4]
       mov       [rsp+30],r14
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       mov       edx,[rdx+r13*4]
       cmp       ecx,edx
       setge     cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA55B68]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA55B94]
M00_L03:
       cmp       dword ptr [rsp+44],2
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*4],eax
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 263
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThanOrEqual_int()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       mov       ecx,[rcx+r13*4]
       mov       [rsp+30],r14
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       mov       edx,[rdx+r13*4]
       cmp       ecx,edx
       setle     cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA45B68]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA45B94]
M00_L03:
       cmp       dword ptr [rsp+44],2
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*4],eax
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 263
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Add_int()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,2
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       mov       esi,[rsi+rdi*4]
       mov       [rsp+30],r8
       cmp       r11d,2
       jae       short M00_L02
       lea       rbx,[rsp+30]
       mov       ebx,[rbx+rdi*4]
       add       esi,ebx
       cmp       r11d,2
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi*4],esi
       inc       r11d
       cmp       r11d,2
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 154
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Subtract_int()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,2
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       mov       esi,[rsi+rdi*4]
       mov       [rsp+30],r8
       cmp       r11d,2
       jae       short M00_L02
       lea       rbx,[rsp+30]
       mov       ebx,[rbx+rdi*4]
       sub       esi,ebx
       cmp       r11d,2
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi*4],esi
       inc       r11d
       cmp       r11d,2
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 154
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Multiply_int()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,2
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       mov       esi,[rsi+rdi*4]
       mov       [rsp+30],r8
       cmp       r11d,2
       jae       short M00_L02
       lea       rbx,[rsp+30]
       mov       ebx,[rbx+rdi*4]
       imul      esi,ebx
       cmp       r11d,2
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi*4],esi
       inc       r11d
       cmp       r11d,2
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 155
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Divide_int()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+20],rax
       xor       r8d,r8d
M00_L00:
       mov       rax,[rcx+18]
       movsxd    rdx,r8d
       lea       r9,[rax+rdx*8]
       mov       rax,[rcx+8]
       mov       r10,[rax+rdx*8]
       mov       rax,[rcx+10]
       mov       r11,[rax+rdx*8]
       xor       esi,esi
       xor       edi,edi
M00_L01:
       mov       [rsp+30],r10
       cmp       edi,2
       jae       short M00_L02
       lea       rax,[rsp+30]
       movsxd    rbx,edi
       mov       eax,[rax+rbx*4]
       mov       [rsp+28],r11
       cmp       edi,2
       jae       short M00_L02
       lea       rdx,[rsp+28]
       mov       ebp,[rdx+rbx*4]
       cdq
       idiv      ebp
       cmp       edi,2
       jae       short M00_L02
       xor       edx,edx
       mov       [rsp+20],rdx
       lea       rdx,[rsp+20]
       mov       [rdx+rbx*4],eax
       inc       edi
       cmp       edi,2
       jl        short M00_L01
       xor       eax,eax
       mov       [r9],rax
       inc       r8d
       cmp       r8d,50
       jl        short M00_L00
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 152
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Min_int()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,2
       jae       short M00_L04
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       mov       esi,[rsi+rdi*4]
       mov       [rsp+30],r8
       cmp       r11d,2
       jae       short M00_L04
       lea       rbx,[rsp+30]
       mov       ebx,[rbx+rdi*4]
       cmp       esi,ebx
       jle       short M00_L02
       jmp       short M00_L03
M00_L02:
       mov       ebx,esi
M00_L03:
       cmp       r11d,2
       jae       short M00_L04
       xor       esi,esi
       mov       [rsp+28],rsi
       lea       rsi,[rsp+28]
       mov       [rsi+rdi*4],ebx
       inc       r11d
       cmp       r11d,2
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 160
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Max_int()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,2
       jae       short M00_L04
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       mov       esi,[rsi+rdi*4]
       mov       [rsp+30],r8
       cmp       r11d,2
       jae       short M00_L04
       lea       rbx,[rsp+30]
       mov       ebx,[rbx+rdi*4]
       cmp       esi,ebx
       jge       short M00_L02
       jmp       short M00_L03
M00_L02:
       mov       ebx,esi
M00_L03:
       cmp       r11d,2
       jae       short M00_L04
       xor       esi,esi
       mov       [rsp+28],rsi
       lea       rsi,[rsp+28]
       mov       [rsi+rdi*4],ebx
       inc       r11d
       cmp       r11d,2
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 160
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Equal_int()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       mov       ecx,[rcx+r13*4]
       mov       [rsp+30],r14
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       mov       edx,[rdx+r13*4]
       cmp       ecx,edx
       sete      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA55B68]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA55B94]
M00_L03:
       cmp       dword ptr [rsp+44],2
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*4],eax
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 263
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_128.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128GreaterThan_int()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpcmpgtd  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128LessThan_int()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpcmpgtd  xmm0,xmm1,xmm0
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_131.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_132.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Add_int()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpaddd    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Subtract_int()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpsubd    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Multiply_int()
       sub       rsp,58
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vxorps    xmm2,xmm2,xmm2
       xor       r8d,r8d
M00_L01:
       vmovapd   [rsp+40],xmm0
       cmp       r8d,4
       jae       short M00_L02
       lea       r9,[rsp+40]
       movsxd    r10,r8d
       mov       r9d,[r9+r10*4]
       vmovapd   [rsp+30],xmm1
       cmp       r8d,4
       jae       short M00_L02
       lea       r11,[rsp+30]
       mov       r11d,[r11+r10*4]
       imul      r9d,r11d
       cmp       r8d,4
       jae       short M00_L02
       vmovapd   [rsp+20],xmm2
       lea       r11,[rsp+20]
       mov       [r11+r10*4],r9d
       inc       r8d
       cmp       r8d,4
       jl        short M00_L01
       vmovupd   [rdx],xmm2
       inc       eax
       cmp       eax,28
       jl        near ptr M00_L00
       add       rsp,58
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 172
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_136.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Min_int()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpminsd   xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Max_int()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpmaxsd   xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Equal_int()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpcmpeqd  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_140.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256GreaterThan_int()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpcmpgtd  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_142.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_143.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_144.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Add_int()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpaddd    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Subtract_int()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpsubd    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Multiply_int()
       sub       rsp,98
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vxorps    ymm2,ymm2,ymm2
       xor       r8d,r8d
M00_L01:
       vmovupd   [rsp+60],ymm0
       cmp       r8d,8
       jae       short M00_L02
       lea       r9,[rsp+60]
       movsxd    r10,r8d
       mov       r9d,[r9+r10*4]
       vmovupd   [rsp+40],ymm1
       cmp       r8d,8
       jae       short M00_L02
       lea       r11,[rsp+40]
       mov       r11d,[r11+r10*4]
       imul      r9d,r11d
       cmp       r8d,8
       jae       short M00_L02
       vmovupd   [rsp+20],ymm2
       lea       r11,[rsp+20]
       mov       [r11+r10*4],r9d
       inc       r8d
       cmp       r8d,8
       jl        short M00_L01
       vmovupd   [rdx],ymm2
       inc       eax
       cmp       eax,14
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,98
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 185
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_148.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Min_int()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpminsd   ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Max_int()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpmaxsd   ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Equal_int()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpcmpeqd  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_152.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThan_ulong()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L04
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       mov       rcx,[rcx+r15*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r15*8]
       cmp       rcx,rdx
       seta      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA35B80]
       jmp       short M00_L03
M00_L02:
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA35BD8]
M00_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r15*8],r12
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 232
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThan_ulong()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L04
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       mov       rcx,[rcx+r15*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r15*8]
       cmp       rcx,rdx
       setb      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA55B80]
       jmp       short M00_L03
M00_L02:
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA55BD8]
M00_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r15*8],r12
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 232
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThanOrEqual_ulong()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L04
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       mov       rcx,[rcx+r15*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r15*8]
       cmp       rcx,rdx
       setae     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA35B80]
       jmp       short M00_L03
M00_L02:
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA35BD8]
M00_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r15*8],r12
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 232
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThanOrEqual_ulong()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L04
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       mov       rcx,[rcx+r15*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r15*8]
       cmp       rcx,rdx
       setbe     cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA45B80]
       jmp       short M00_L03
M00_L02:
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA45BD8]
M00_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r15*8],r12
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 232
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Add_ulong()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       test      r12d,r12d
       jne       short M00_L02
       lea       rcx,[rsp+38]
       xor       r12d,r12d
       mov       rcx,[rcx+r12*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r12*8]
       call      Silk.NET.Maths.Scalar.<Add>g__ULong|22_10[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r12*8],rax
       mov       r12d,1
       test      r12d,r12d
       jle       short M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 165
```
```assembly
; Silk.NET.Maths.Scalar.<Add>g__ULong|22_10[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       lea       rax,[rcx+rdx]
       ret
; Total bytes of code 5
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Subtract_ulong()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       test      r12d,r12d
       jne       short M00_L02
       lea       rcx,[rsp+38]
       xor       r12d,r12d
       mov       rcx,[rcx+r12*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r12*8]
       call      Silk.NET.Maths.Scalar.<Subtract>g__ULong|23_10[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r12*8],rax
       mov       r12d,1
       test      r12d,r12d
       jle       short M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 165
```
```assembly
; Silk.NET.Maths.Scalar.<Subtract>g__ULong|23_10[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       mov       rax,rcx
       sub       rax,rdx
       ret
; Total bytes of code 7
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Multiply_ulong()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       test      r12d,r12d
       jne       short M00_L02
       lea       rcx,[rsp+38]
       xor       r12d,r12d
       mov       rcx,[rcx+r12*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r12*8]
       call      Silk.NET.Maths.Scalar.<Multiply>g__ULong|24_10[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r12*8],rax
       mov       r12d,1
       test      r12d,r12d
       jle       short M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 165
```
```assembly
; Silk.NET.Maths.Scalar.<Multiply>g__ULong|24_10[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       mov       rax,rcx
       imul      rax,rdx
       ret
; Total bytes of code 8
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Divide_ulong()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       r8d,r8d
M00_L00:
       mov       rax,[rcx+18]
       movsxd    rdx,r8d
       lea       r9,[rax+rdx*8]
       mov       rax,[rcx+8]
       mov       r10,[rax+rdx*8]
       mov       rax,[rcx+10]
       mov       r11,[rax+rdx*8]
       xor       esi,esi
       xor       edi,edi
M00_L01:
       mov       [rsp+38],r10
       test      edi,edi
       jne       short M00_L02
       lea       rax,[rsp+38]
       xor       edi,edi
       mov       rax,[rax+rdi*8]
       mov       [rsp+30],r11
       lea       rdx,[rsp+30]
       mov       rbx,[rdx+rdi*8]
       xor       edx,edx
       div       rbx
       xor       edx,edx
       mov       [rsp+28],rdx
       lea       rdx,[rsp+28]
       mov       [rdx+rdi*8],rax
       mov       edi,1
       test      edi,edi
       jle       short M00_L01
       xor       eax,eax
       mov       [r9],rax
       inc       r8d
       cmp       r8d,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 145
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Min_ulong()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       test      r12d,r12d
       jne       short M00_L02
       lea       rcx,[rsp+38]
       xor       r12d,r12d
       mov       rcx,[rcx+r12*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r12*8]
       call      Silk.NET.Maths.Scalar.<Min>g__ULong|70_10[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r12*8],rax
       mov       r12d,1
       test      r12d,r12d
       jle       short M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 165
```
```assembly
; Silk.NET.Maths.Scalar.<Min>g__ULong|70_10[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       cmp       rcx,rdx
       jbe       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,rcx
M01_L01:
       mov       rax,rdx
       ret
; Total bytes of code 14
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Max_ulong()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       test      r12d,r12d
       jne       short M00_L02
       lea       rcx,[rsp+38]
       xor       r12d,r12d
       mov       rcx,[rcx+r12*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r12*8]
       call      Silk.NET.Maths.Scalar.<Max>g__ULong|69_10[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r12*8],rax
       mov       r12d,1
       test      r12d,r12d
       jle       short M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 165
```
```assembly
; Silk.NET.Maths.Scalar.<Max>g__ULong|69_10[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       cmp       rcx,rdx
       jae       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,rcx
M01_L01:
       mov       rax,rdx
       ret
; Total bytes of code 14
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Equal_ulong()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L04
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       mov       rcx,[rcx+r15*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r15*8]
       cmp       rcx,rdx
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA55B80]
       jmp       short M00_L03
M00_L02:
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA55BD8]
M00_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r15*8],r12
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 232
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_164.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128GreaterThan_ulong()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       vmovaps   [rsp+70],xmm6
       vmovaps   [rsp+60],xmm7
       vmovaps   [rsp+50],xmm8
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,4
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   xmm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   xmm7,[rdx+rcx]
       vxorps    xmm8,xmm8,xmm8
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L05
       lea       rbp,[rsp+40]
       mov       r14,[rbp]
       vmovapd   [rsp+30],xmm7
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L05
       lea       r15,[rsp+30]
       mov       r12,[r15]
       cmp       r14,r12
       seta      r13b
       movzx     r13d,r13b
       test      r13d,r13d
       jne       short M00_L01
       mov       rcx,7FF91AA96DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,[7FF91AA15B80]
       jmp       short M00_L02
M00_L01:
       mov       rcx,7FF91AA96DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,[7FF91AA15BD8]
M00_L02:
       vmovapd   [rsp+20],xmm8
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       vmovapd   [rsp+40],xmm6
       mov       eax,2
       cmp       eax,1
       jbe       near ptr M00_L05
       lea       rbp,[rsp+40]
       mov       r14,[rbp+8]
       vmovapd   [rsp+30],xmm7
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L05
       lea       r15,[rsp+30]
       mov       r12,[r15+8]
       cmp       r14,r12
       seta      r13b
       movzx     r13d,r13b
       test      r13d,r13d
       jne       short M00_L03
       mov       rax,[7FF91AA15B80]
       jmp       short M00_L04
M00_L03:
       mov       rax,[7FF91AA15BD8]
M00_L04:
       vmovapd   [rsp+20],xmm8
       lea       rcx,[rsp+20]
       mov       [rcx+8],rax
       vmovupd   [rbx],xmm8
       inc       edi
       cmp       edi,28
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+70]
       vmovaps   xmm7,[rsp+60]
       vmovaps   xmm8,[rsp+50]
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 394
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128LessThan_ulong()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       vmovaps   [rsp+70],xmm6
       vmovaps   [rsp+60],xmm7
       vmovaps   [rsp+50],xmm8
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,4
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   xmm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   xmm7,[rdx+rcx]
       vxorps    xmm8,xmm8,xmm8
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L05
       lea       rbp,[rsp+40]
       mov       r14,[rbp]
       vmovapd   [rsp+30],xmm7
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L05
       lea       r15,[rsp+30]
       mov       r12,[r15]
       cmp       r14,r12
       setb      r13b
       movzx     r13d,r13b
       test      r13d,r13d
       jne       short M00_L01
       mov       rcx,7FF91AAA6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,[7FF91AA25B80]
       jmp       short M00_L02
M00_L01:
       mov       rcx,7FF91AAA6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,[7FF91AA25BD8]
M00_L02:
       vmovapd   [rsp+20],xmm8
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       vmovapd   [rsp+40],xmm6
       mov       eax,2
       cmp       eax,1
       jbe       near ptr M00_L05
       lea       rbp,[rsp+40]
       mov       r14,[rbp+8]
       vmovapd   [rsp+30],xmm7
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L05
       lea       r15,[rsp+30]
       mov       r12,[r15+8]
       cmp       r14,r12
       setb      r13b
       movzx     r13d,r13b
       test      r13d,r13d
       jne       short M00_L03
       mov       rax,[7FF91AA25B80]
       jmp       short M00_L04
M00_L03:
       mov       rax,[7FF91AA25BD8]
M00_L04:
       vmovapd   [rsp+20],xmm8
       lea       rcx,[rsp+20]
       mov       [rcx+8],rax
       vmovupd   [rbx],xmm8
       inc       edi
       cmp       edi,28
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+70]
       vmovaps   xmm7,[rsp+60]
       vmovaps   xmm8,[rsp+50]
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 394
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_167.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_168.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Add_ulong()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpaddq    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Subtract_ulong()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpsubq    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Multiply_ulong()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       vmovaps   [rsp+70],xmm6
       vmovaps   [rsp+60],xmm7
       vmovaps   [rsp+50],xmm8
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,4
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   xmm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   xmm7,[rdx+rcx]
       vxorps    xmm8,xmm8,xmm8
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L01
       lea       rbp,[rsp+40]
       mov       rcx,[rbp]
       vmovapd   [rsp+30],xmm7
       mov       edx,2
       test      edx,edx
       jbe       near ptr M00_L01
       lea       r14,[rsp+30]
       mov       rdx,[r14]
       call      Silk.NET.Maths.Scalar.<Multiply>g__Long|24_9[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L01
       vmovapd   [rsp+20],xmm8
       lea       r15,[rsp+20]
       mov       [r15],rax
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L01
       lea       rbp,[rsp+40]
       mov       rcx,[rbp+8]
       vmovapd   [rsp+30],xmm7
       mov       edx,2
       cmp       edx,1
       jbe       short M00_L01
       lea       r14,[rsp+30]
       mov       rdx,[r14+8]
       call      Silk.NET.Maths.Scalar.<Multiply>g__Long|24_9[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L01
       vmovapd   [rsp+20],xmm8
       lea       r15,[rsp+20]
       mov       [r15+8],rax
       vmovupd   [rbx],xmm8
       inc       edi
       cmp       edi,28
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+70]
       vmovaps   xmm7,[rsp+60]
       vmovaps   xmm8,[rsp+50]
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L01:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 317
```
```assembly
; Silk.NET.Maths.Scalar.<Multiply>g__Long|24_9[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       mov       rax,rcx
       imul      rax,rdx
       ret
; Total bytes of code 8
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Divide_ulong()
       push      rsi
       sub       rsp,50
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       xor       r8d,r8d
M00_L00:
       mov       r9,[rcx+18]
       movsxd    rax,r8d
       shl       rax,4
       add       r9,rax
       mov       rdx,[rcx+8]
       vmovupd   xmm0,[rdx+rax]
       mov       rdx,[rcx+10]
       vmovupd   xmm1,[rdx+rax]
       vxorps    xmm2,xmm2,xmm2
       vmovapd   [rsp+40],xmm0
       mov       eax,2
       test      eax,eax
       jbe       near ptr M00_L01
       lea       r10,[rsp+40]
       mov       rax,[r10]
       vmovapd   [rsp+30],xmm1
       mov       edx,2
       test      edx,edx
       jbe       near ptr M00_L01
       lea       r11,[rsp+30]
       mov       rsi,[r11]
       xor       edx,edx
       div       rsi
       mov       r10d,2
       test      r10d,r10d
       jbe       near ptr M00_L01
       vmovapd   [rsp+20],xmm2
       lea       r10,[rsp+20]
       mov       [r10],rax
       vmovapd   [rsp+40],xmm0
       mov       r11d,2
       cmp       r11d,1
       jbe       short M00_L01
       lea       r10,[rsp+40]
       mov       rax,[r10+8]
       vmovapd   [rsp+30],xmm1
       mov       edx,2
       cmp       edx,1
       jbe       short M00_L01
       lea       r11,[rsp+30]
       mov       rsi,[r11+8]
       xor       edx,edx
       div       rsi
       mov       edx,2
       cmp       edx,1
       jbe       short M00_L01
       vmovapd   [rsp+20],xmm2
       lea       r10,[rsp+20]
       mov       [r10+8],rax
       vmovupd   [r9],xmm2
       inc       r8d
       cmp       r8d,28
       jl        near ptr M00_L00
       add       rsp,50
       pop       rsi
       ret
M00_L01:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 264
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Min_ulong()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       vmovaps   [rsp+70],xmm6
       vmovaps   [rsp+60],xmm7
       vmovaps   [rsp+50],xmm8
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,4
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   xmm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   xmm7,[rdx+rcx]
       vxorps    xmm8,xmm8,xmm8
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L01
       lea       rbp,[rsp+40]
       mov       rcx,[rbp]
       vmovapd   [rsp+30],xmm7
       mov       edx,2
       test      edx,edx
       jbe       near ptr M00_L01
       lea       r14,[rsp+30]
       mov       rdx,[r14]
       call      Silk.NET.Maths.Scalar.<Min>g__Long|70_9[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L01
       vmovapd   [rsp+20],xmm8
       lea       r15,[rsp+20]
       mov       [r15],rax
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L01
       lea       rbp,[rsp+40]
       mov       rcx,[rbp+8]
       vmovapd   [rsp+30],xmm7
       mov       edx,2
       cmp       edx,1
       jbe       short M00_L01
       lea       r14,[rsp+30]
       mov       rdx,[r14+8]
       call      Silk.NET.Maths.Scalar.<Min>g__Long|70_9[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L01
       vmovapd   [rsp+20],xmm8
       lea       r15,[rsp+20]
       mov       [r15+8],rax
       vmovupd   [rbx],xmm8
       inc       edi
       cmp       edi,28
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+70]
       vmovaps   xmm7,[rsp+60]
       vmovaps   xmm8,[rsp+50]
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L01:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 317
```
```assembly
; Silk.NET.Maths.Scalar.<Min>g__Long|70_9[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       cmp       rcx,rdx
       jbe       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,rcx
M01_L01:
       mov       rax,rdx
       ret
; Total bytes of code 14
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Max_ulong()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       vmovaps   [rsp+70],xmm6
       vmovaps   [rsp+60],xmm7
       vmovaps   [rsp+50],xmm8
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,4
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   xmm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   xmm7,[rdx+rcx]
       vxorps    xmm8,xmm8,xmm8
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L01
       lea       rbp,[rsp+40]
       mov       rcx,[rbp]
       vmovapd   [rsp+30],xmm7
       mov       edx,2
       test      edx,edx
       jbe       near ptr M00_L01
       lea       r14,[rsp+30]
       mov       rdx,[r14]
       call      Silk.NET.Maths.Scalar.<Max>g__Long|69_9[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L01
       vmovapd   [rsp+20],xmm8
       lea       r15,[rsp+20]
       mov       [r15],rax
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L01
       lea       rbp,[rsp+40]
       mov       rcx,[rbp+8]
       vmovapd   [rsp+30],xmm7
       mov       edx,2
       cmp       edx,1
       jbe       short M00_L01
       lea       r14,[rsp+30]
       mov       rdx,[r14+8]
       call      Silk.NET.Maths.Scalar.<Max>g__Long|69_9[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L01
       vmovapd   [rsp+20],xmm8
       lea       r15,[rsp+20]
       mov       [r15+8],rax
       vmovupd   [rbx],xmm8
       inc       edi
       cmp       edi,28
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+70]
       vmovaps   xmm7,[rsp+60]
       vmovaps   xmm8,[rsp+50]
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L01:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 317
```
```assembly
; Silk.NET.Maths.Scalar.<Max>g__Long|69_9[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       cmp       rcx,rdx
       jae       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,rcx
M01_L01:
       mov       rax,rdx
       ret
; Total bytes of code 14
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Equal_ulong()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vzeroupper
       vmovaps   [rsp+70],xmm6
       vmovaps   [rsp+60],xmm7
       vmovaps   [rsp+50],xmm8
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,4
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   xmm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   xmm7,[rdx+rcx]
       vxorps    xmm8,xmm8,xmm8
       vmovapd   [rsp+40],xmm6
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L05
       lea       rbp,[rsp+40]
       mov       r14,[rbp]
       vmovapd   [rsp+30],xmm7
       mov       ecx,2
       test      ecx,ecx
       jbe       near ptr M00_L05
       lea       r15,[rsp+30]
       mov       r12,[r15]
       cmp       r14,r12
       sete      r13b
       movzx     r13d,r13b
       test      r13d,r13d
       jne       short M00_L01
       mov       rcx,7FF91AAB6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,[7FF91AA35B80]
       jmp       short M00_L02
M00_L01:
       mov       rcx,7FF91AAB6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rax,[7FF91AA35BD8]
M00_L02:
       vmovapd   [rsp+20],xmm8
       lea       rcx,[rsp+20]
       mov       [rcx],rax
       vmovapd   [rsp+40],xmm6
       mov       eax,2
       cmp       eax,1
       jbe       near ptr M00_L05
       lea       rbp,[rsp+40]
       mov       r14,[rbp+8]
       vmovapd   [rsp+30],xmm7
       mov       ecx,2
       cmp       ecx,1
       jbe       short M00_L05
       lea       r15,[rsp+30]
       mov       r12,[r15+8]
       cmp       r14,r12
       sete      r13b
       movzx     r13d,r13b
       test      r13d,r13d
       jne       short M00_L03
       mov       rax,[7FF91AA35B80]
       jmp       short M00_L04
M00_L03:
       mov       rax,[7FF91AA35BD8]
M00_L04:
       vmovapd   [rsp+20],xmm8
       lea       rcx,[rsp+20]
       mov       [rcx+8],rax
       vmovupd   [rbx],xmm8
       inc       edi
       cmp       edi,28
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+70]
       vmovaps   xmm7,[rsp+60]
       vmovaps   xmm8,[rsp+50]
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 394
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_176.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_177.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_178.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_179.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_180.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Add_ulong()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpaddq    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Subtract_ulong()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpsubq    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Multiply_ulong()
       sub       rsp,98
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vxorps    ymm2,ymm2,ymm2
       xor       r8d,r8d
M00_L01:
       vmovupd   [rsp+60],ymm0
       cmp       r8d,4
       jae       short M00_L02
       lea       r9,[rsp+60]
       movsxd    r10,r8d
       mov       r9,[r9+r10*8]
       vmovupd   [rsp+40],ymm1
       cmp       r8d,4
       jae       short M00_L02
       lea       r11,[rsp+40]
       mov       r11,[r11+r10*8]
       imul      r9,r11
       cmp       r8d,4
       jae       short M00_L02
       vmovupd   [rsp+20],ymm2
       lea       r11,[rsp+20]
       mov       [r11+r10*8],r9
       inc       r8d
       cmp       r8d,4
       jl        short M00_L01
       vmovupd   [rdx],ymm2
       inc       eax
       cmp       eax,14
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,98
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 185
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_184.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Min_ulong()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0F0
       vzeroupper
       vmovaps   [rsp+0E0],xmm6
       vmovaps   [rsp+0D0],xmm7
       vmovaps   [rsp+0C0],xmm8
       vmovaps   [rsp+0B0],xmm9
       vmovaps   [rsp+0A0],xmm10
       vmovaps   [rsp+90],xmm11
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,5
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   ymm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   ymm7,[rdx+rcx]
       vxorps    ymm8,ymm8,ymm8
       xor       ebp,ebp
M00_L01:
       vmovupd   [rsp+60],ymm6
       cmp       ebp,4
       jae       near ptr M00_L02
       lea       rcx,[rsp+60]
       movsxd    r14,ebp
       mov       rcx,[rcx+r14*8]
       vmovupd   [rsp+40],ymm7
       cmp       ebp,4
       jae       near ptr M00_L02
       lea       rdx,[rsp+40]
       mov       rdx,[rdx+r14*8]
       vextractf128 xmm9,ymm8,1
       vextractf128 xmm10,ymm6,1
       vextractf128 xmm11,ymm7,1
       call      Silk.NET.Maths.Scalar.<Min>g__Long|70_9[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       cmp       ebp,4
       vinsertf128 ymm8,ymm8,xmm9,1
       vinsertf128 ymm6,ymm6,xmm10,1
       vinsertf128 ymm7,ymm7,xmm11,1
       jae       short M00_L02
       vmovupd   [rsp+20],ymm8
       lea       rcx,[rsp+20]
       mov       [rcx+r14*8],rax
       inc       ebp
       cmp       ebp,4
       jl        short M00_L01
       vmovupd   [rbx],ymm8
       inc       edi
       cmp       edi,14
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+0E0]
       vmovaps   xmm7,[rsp+0D0]
       vmovaps   xmm8,[rsp+0C0]
       vmovaps   xmm9,[rsp+0B0]
       vmovaps   xmm10,[rsp+0A0]
       vmovaps   xmm11,[rsp+90]
       vzeroupper
       add       rsp,0F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 346
```
```assembly
; Silk.NET.Maths.Scalar.<Min>g__Long|70_9[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       cmp       rcx,rdx
       jbe       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,rcx
M01_L01:
       mov       rax,rdx
       ret
; Total bytes of code 14
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Max_ulong()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0F0
       vzeroupper
       vmovaps   [rsp+0E0],xmm6
       vmovaps   [rsp+0D0],xmm7
       vmovaps   [rsp+0C0],xmm8
       vmovaps   [rsp+0B0],xmm9
       vmovaps   [rsp+0A0],xmm10
       vmovaps   [rsp+90],xmm11
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rbx,[rsi+18]
       movsxd    rcx,edi
       shl       rcx,5
       add       rbx,rcx
       mov       rdx,[rsi+8]
       vmovupd   ymm6,[rdx+rcx]
       mov       rdx,[rsi+10]
       vmovupd   ymm7,[rdx+rcx]
       vxorps    ymm8,ymm8,ymm8
       xor       ebp,ebp
M00_L01:
       vmovupd   [rsp+60],ymm6
       cmp       ebp,4
       jae       near ptr M00_L02
       lea       rcx,[rsp+60]
       movsxd    r14,ebp
       mov       rcx,[rcx+r14*8]
       vmovupd   [rsp+40],ymm7
       cmp       ebp,4
       jae       near ptr M00_L02
       lea       rdx,[rsp+40]
       mov       rdx,[rdx+r14*8]
       vextractf128 xmm9,ymm8,1
       vextractf128 xmm10,ymm6,1
       vextractf128 xmm11,ymm7,1
       call      Silk.NET.Maths.Scalar.<Max>g__Long|69_9[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       cmp       ebp,4
       vinsertf128 ymm8,ymm8,xmm9,1
       vinsertf128 ymm6,ymm6,xmm10,1
       vinsertf128 ymm7,ymm7,xmm11,1
       jae       short M00_L02
       vmovupd   [rsp+20],ymm8
       lea       rcx,[rsp+20]
       mov       [rcx+r14*8],rax
       inc       ebp
       cmp       ebp,4
       jl        short M00_L01
       vmovupd   [rbx],ymm8
       inc       edi
       cmp       edi,14
       jl        near ptr M00_L00
       vmovaps   xmm6,[rsp+0E0]
       vmovaps   xmm7,[rsp+0D0]
       vmovaps   xmm8,[rsp+0C0]
       vmovaps   xmm9,[rsp+0B0]
       vmovaps   xmm10,[rsp+0A0]
       vmovaps   xmm11,[rsp+90]
       vzeroupper
       add       rsp,0F0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 346
```
```assembly
; Silk.NET.Maths.Scalar.<Max>g__Long|69_9[[System.UInt64, System.Private.CoreLib]](UInt64, UInt64)
       cmp       rcx,rdx
       jae       short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,rcx
M01_L01:
       mov       rax,rdx
       ret
; Total bytes of code 14
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Equal_ulong()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpcmpeqq  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_188.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThan_long()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L04
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       mov       rcx,[rcx+r15*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r15*8]
       cmp       rcx,rdx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA35B80]
       jmp       short M00_L03
M00_L02:
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA35BD8]
M00_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r15*8],r12
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 232
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThan_long()
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
M00_L01:
       mov       [rsp+38],rbp
       test      r15d,r15d
       jne       near ptr M00_L04
       lea       rcx,[rsp+38]
       xor       r15d,r15d
       mov       rcx,[rcx+r15*8]
       mov       [rsp+30],r14
       lea       rdx,[rsp+30]
       mov       rdx,[rdx+r15*8]
       cmp       rcx,rdx
       setl      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA25B80]
       jmp       short M00_L03
M00_L02:
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       r12,[7FF91AA25BD8]
M00_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r15*8],r12
       mov       r15d,1
       test      r15d,r15d
       jle       near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 232
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_191.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_192.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_193.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_194.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Add_ushort()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpaddw    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Subtract_ushort()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpsubw    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Multiply_ushort()
       sub       rsp,58
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vxorps    xmm2,xmm2,xmm2
       xor       r8d,r8d
M00_L01:
       vmovapd   [rsp+40],xmm0
       cmp       r8d,8
       jae       short M00_L02
       lea       r9,[rsp+40]
       movsxd    r10,r8d
       movzx     r9d,word ptr [r9+r10*2]
       vmovapd   [rsp+30],xmm1
       cmp       r8d,8
       jae       short M00_L02
       lea       r11,[rsp+30]
       movzx     r11d,word ptr [r11+r10*2]
       movzx     r9d,r9w
       imul      r9d,r11d
       movzx     r9d,r9w
       cmp       r8d,8
       jae       short M00_L02
       vmovapd   [rsp+20],xmm2
       lea       r11,[rsp+20]
       mov       [r11+r10*2],r9w
       inc       r8d
       cmp       r8d,8
       jl        short M00_L01
       vmovupd   [rdx],xmm2
       inc       eax
       cmp       eax,28
       jl        near ptr M00_L00
       add       rsp,58
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 183
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_198.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_199.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_200.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Equal_ushort()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpcmpeqw  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_202.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_203.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_204.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_205.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_206.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Add_ushort()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpaddw    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Subtract_ushort()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpsubw    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Multiply_ushort()
       sub       rsp,98
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vxorps    ymm2,ymm2,ymm2
       xor       r8d,r8d
M00_L01:
       vmovupd   [rsp+60],ymm0
       cmp       r8d,10
       jae       short M00_L02
       lea       r9,[rsp+60]
       movsxd    r10,r8d
       movzx     r9d,word ptr [r9+r10*2]
       vmovupd   [rsp+40],ymm1
       cmp       r8d,10
       jae       short M00_L02
       lea       r11,[rsp+40]
       movzx     r11d,word ptr [r11+r10*2]
       movzx     r9d,r9w
       imul      r9d,r11d
       movzx     r9d,r9w
       cmp       r8d,10
       jae       short M00_L02
       vmovupd   [rsp+20],ymm2
       lea       r11,[rsp+20]
       mov       [r11+r10*2],r9w
       inc       r8d
       cmp       r8d,10
       jl        short M00_L01
       vmovupd   [rdx],ymm2
       inc       eax
       cmp       eax,14
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,98
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 196
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_210.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_211.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_212.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Equal_ushort()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpcmpeqw  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_214.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThan_short()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movsx     rcx,word ptr [rcx+r13*2]
       mov       [rsp+30],r14
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movsx     rdx,word ptr [rdx+r13*2]
       movsx     rcx,cx
       cmp       ecx,edx
       setg      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,word ptr [7FF91AA25B5C]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,word ptr [7FF91AA25B72]
M00_L03:
       cmp       dword ptr [rsp+44],4
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*2],ax
       inc       r12d
       cmp       r12d,4
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 274
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThan_short()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movsx     rcx,word ptr [rcx+r13*2]
       mov       [rsp+30],r14
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movsx     rdx,word ptr [rdx+r13*2]
       movsx     rcx,cx
       cmp       ecx,edx
       setl      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,word ptr [7FF91AA45B5C]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,word ptr [7FF91AA45B72]
M00_L03:
       cmp       dword ptr [rsp+44],4
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*2],ax
       inc       r12d
       cmp       r12d,4
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 274
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThanOrEqual_short()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movsx     rcx,word ptr [rcx+r13*2]
       mov       [rsp+30],r14
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movsx     rdx,word ptr [rdx+r13*2]
       movsx     rcx,cx
       cmp       ecx,edx
       setge     cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,word ptr [7FF91AA45B5C]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,word ptr [7FF91AA45B72]
M00_L03:
       cmp       dword ptr [rsp+44],4
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*2],ax
       inc       r12d
       cmp       r12d,4
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 274
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThanOrEqual_short()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movsx     rcx,word ptr [rcx+r13*2]
       mov       [rsp+30],r14
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movsx     rdx,word ptr [rdx+r13*2]
       movsx     rcx,cx
       cmp       ecx,edx
       setle     cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,word ptr [7FF91AA45B5C]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,word ptr [7FF91AA45B72]
M00_L03:
       cmp       dword ptr [rsp+44],4
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*2],ax
       inc       r12d
       cmp       r12d,4
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 274
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Add_short()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,4
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movsx     rsi,word ptr [rsi+rdi*2]
       mov       [rsp+30],r8
       cmp       r11d,4
       jae       short M00_L02
       lea       rbx,[rsp+30]
       movsx     rbx,word ptr [rbx+rdi*2]
       movsx     rsi,si
       add       esi,ebx
       movsx     rsi,si
       cmp       r11d,4
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi*2],si
       inc       r11d
       cmp       r11d,4
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 171
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Subtract_short()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,4
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movsx     rsi,word ptr [rsi+rdi*2]
       mov       [rsp+30],r8
       cmp       r11d,4
       jae       short M00_L02
       lea       rbx,[rsp+30]
       movsx     rbx,word ptr [rbx+rdi*2]
       movsx     rsi,si
       sub       esi,ebx
       movsx     rsi,si
       cmp       r11d,4
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi*2],si
       inc       r11d
       cmp       r11d,4
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 171
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Multiply_short()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,4
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movsx     rsi,word ptr [rsi+rdi*2]
       mov       [rsp+30],r8
       cmp       r11d,4
       jae       short M00_L02
       lea       rbx,[rsp+30]
       movsx     rbx,word ptr [rbx+rdi*2]
       movsx     rsi,si
       imul      esi,ebx
       movsx     rsi,si
       cmp       r11d,4
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi*2],si
       inc       r11d
       cmp       r11d,4
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 172
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_222.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Min_short()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,4
       jae       short M00_L04
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movsx     rsi,word ptr [rsi+rdi*2]
       mov       [rsp+30],r8
       cmp       r11d,4
       jae       short M00_L04
       lea       rbx,[rsp+30]
       movsx     rbx,word ptr [rbx+rdi*2]
       movsx     rsi,si
       cmp       esi,ebx
       jle       short M00_L02
       jmp       short M00_L03
M00_L02:
       mov       ebx,esi
M00_L03:
       cmp       r11d,4
       jae       short M00_L04
       xor       esi,esi
       mov       [rsp+28],rsi
       lea       rsi,[rsp+28]
       mov       [rsi+rdi*2],bx
       inc       r11d
       cmp       r11d,4
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 173
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Max_short()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,4
       jae       short M00_L04
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movsx     rsi,word ptr [rsi+rdi*2]
       mov       [rsp+30],r8
       cmp       r11d,4
       jae       short M00_L04
       lea       rbx,[rsp+30]
       movsx     rbx,word ptr [rbx+rdi*2]
       movsx     rsi,si
       cmp       esi,ebx
       jge       short M00_L02
       jmp       short M00_L03
M00_L02:
       mov       ebx,esi
M00_L03:
       cmp       r11d,4
       jae       short M00_L04
       xor       esi,esi
       mov       [rsp+28],rsi
       lea       rsi,[rsp+28]
       mov       [rsi+rdi*2],bx
       inc       r11d
       cmp       r11d,4
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 173
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Equal_short()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movsx     rcx,word ptr [rcx+r13*2]
       mov       [rsp+30],r14
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movsx     rdx,word ptr [rdx+r13*2]
       movsx     rcx,cx
       cmp       ecx,edx
       sete      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,word ptr [7FF91AA25B5C]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,word ptr [7FF91AA25B72]
M00_L03:
       cmp       dword ptr [rsp+44],4
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*2],ax
       inc       r12d
       cmp       r12d,4
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 274
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_226.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128GreaterThan_short()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpcmpgtw  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128LessThan_short()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpcmpgtw  xmm0,xmm1,xmm0
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_229.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_230.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Add_short()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpaddw    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Subtract_short()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpsubw    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Multiply_short()
       sub       rsp,58
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vxorps    xmm2,xmm2,xmm2
       xor       r8d,r8d
M00_L01:
       vmovapd   [rsp+40],xmm0
       cmp       r8d,8
       jae       short M00_L02
       lea       r9,[rsp+40]
       movsxd    r10,r8d
       movsx     r9,word ptr [r9+r10*2]
       vmovapd   [rsp+30],xmm1
       cmp       r8d,8
       jae       short M00_L02
       lea       r11,[rsp+30]
       movsx     r11,word ptr [r11+r10*2]
       movsx     r9,r9w
       imul      r9d,r11d
       movsx     r9,r9w
       cmp       r8d,8
       jae       short M00_L02
       vmovapd   [rsp+20],xmm2
       lea       r11,[rsp+20]
       mov       [r11+r10*2],r9w
       inc       r8d
       cmp       r8d,8
       jl        short M00_L01
       vmovupd   [rdx],xmm2
       inc       eax
       cmp       eax,28
       jl        near ptr M00_L00
       add       rsp,58
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 183
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_234.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Min_short()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpminsw   xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Max_short()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpmaxsw   xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Equal_short()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpcmpeqw  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_238.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256GreaterThan_short()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpcmpgtw  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_240.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_241.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_242.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Add_short()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpaddw    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Subtract_short()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpsubw    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Multiply_short()
       sub       rsp,98
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vxorps    ymm2,ymm2,ymm2
       xor       r8d,r8d
M00_L01:
       vmovupd   [rsp+60],ymm0
       cmp       r8d,10
       jae       short M00_L02
       lea       r9,[rsp+60]
       movsxd    r10,r8d
       movsx     r9,word ptr [r9+r10*2]
       vmovupd   [rsp+40],ymm1
       cmp       r8d,10
       jae       short M00_L02
       lea       r11,[rsp+40]
       movsx     r11,word ptr [r11+r10*2]
       movsx     r9,r9w
       imul      r9d,r11d
       movsx     r9,r9w
       cmp       r8d,10
       jae       short M00_L02
       vmovupd   [rsp+20],ymm2
       lea       r11,[rsp+20]
       mov       [r11+r10*2],r9w
       inc       r8d
       cmp       r8d,10
       jl        short M00_L01
       vmovupd   [rdx],ymm2
       inc       eax
       cmp       eax,14
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,98
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 196
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_246.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Min_short()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpminsw   ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Max_short()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpmaxsw   ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Equal_short()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpcmpeqw  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_250.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThan_uint()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       mov       ecx,[rcx+r13*4]
       mov       [rsp+30],r14
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       mov       edx,[rdx+r13*4]
       cmp       ecx,edx
       seta      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAA6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA25B68]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAA6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA25B94]
M00_L03:
       cmp       dword ptr [rsp+44],2
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*4],eax
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 263
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThan_uint()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       mov       ecx,[rcx+r13*4]
       mov       [rsp+30],r14
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       mov       edx,[rdx+r13*4]
       cmp       ecx,edx
       setb      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAB6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA35B68]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAB6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA35B94]
M00_L03:
       cmp       dword ptr [rsp+44],2
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*4],eax
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 263
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThanOrEqual_uint()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       mov       ecx,[rcx+r13*4]
       mov       [rsp+30],r14
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       mov       edx,[rdx+r13*4]
       cmp       ecx,edx
       setae     cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAD6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA55B68]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAD6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA55B94]
M00_L03:
       cmp       dword ptr [rsp+44],2
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*4],eax
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 263
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThanOrEqual_uint()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       mov       ecx,[rcx+r13*4]
       mov       [rsp+30],r14
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       mov       edx,[rdx+r13*4]
       cmp       ecx,edx
       setbe     cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA45B68]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA45B94]
M00_L03:
       cmp       dword ptr [rsp+44],2
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*4],eax
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 263
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Add_uint()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,2
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       mov       esi,[rsi+rdi*4]
       mov       [rsp+30],r8
       cmp       r11d,2
       jae       short M00_L02
       lea       rbx,[rsp+30]
       mov       ebx,[rbx+rdi*4]
       add       esi,ebx
       cmp       r11d,2
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi*4],esi
       inc       r11d
       cmp       r11d,2
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 154
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Subtract_uint()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,2
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       mov       esi,[rsi+rdi*4]
       mov       [rsp+30],r8
       cmp       r11d,2
       jae       short M00_L02
       lea       rbx,[rsp+30]
       mov       ebx,[rbx+rdi*4]
       sub       esi,ebx
       cmp       r11d,2
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi*4],esi
       inc       r11d
       cmp       r11d,2
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 154
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Multiply_uint()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,2
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       mov       esi,[rsi+rdi*4]
       mov       [rsp+30],r8
       cmp       r11d,2
       jae       short M00_L02
       lea       rbx,[rsp+30]
       mov       ebx,[rbx+rdi*4]
       imul      esi,ebx
       cmp       r11d,2
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi*4],esi
       inc       r11d
       cmp       r11d,2
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 155
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_258.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Min_uint()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,2
       jae       short M00_L04
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       mov       esi,[rsi+rdi*4]
       mov       [rsp+30],r8
       cmp       r11d,2
       jae       short M00_L04
       lea       rbx,[rsp+30]
       mov       ebx,[rbx+rdi*4]
       cmp       esi,ebx
       jbe       short M00_L02
       jmp       short M00_L03
M00_L02:
       mov       ebx,esi
M00_L03:
       cmp       r11d,2
       jae       short M00_L04
       xor       esi,esi
       mov       [rsp+28],rsi
       lea       rsi,[rsp+28]
       mov       [rsi+rdi*4],ebx
       inc       r11d
       cmp       r11d,2
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 160
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Max_uint()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,2
       jae       short M00_L04
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       mov       esi,[rsi+rdi*4]
       mov       [rsp+30],r8
       cmp       r11d,2
       jae       short M00_L04
       lea       rbx,[rsp+30]
       mov       ebx,[rbx+rdi*4]
       cmp       esi,ebx
       jae       short M00_L02
       jmp       short M00_L03
M00_L02:
       mov       ebx,esi
M00_L03:
       cmp       r11d,2
       jae       short M00_L04
       xor       esi,esi
       mov       [rsp+28],rsi
       lea       rsi,[rsp+28]
       mov       [rsi+rdi*4],ebx
       inc       r11d
       cmp       r11d,2
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 160
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Equal_uint()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       mov       ecx,[rcx+r13*4]
       mov       [rsp+30],r14
       cmp       r12d,2
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       mov       edx,[rdx+r13*4]
       cmp       ecx,edx
       sete      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA45B68]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       eax,[7FF91AA45B94]
M00_L03:
       cmp       dword ptr [rsp+44],2
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*4],eax
       inc       r12d
       cmp       r12d,2
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 263
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_262.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_263.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_264.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_265.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_266.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Add_uint()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpaddd    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Subtract_uint()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpsubd    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Multiply_uint()
       sub       rsp,58
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vxorps    xmm2,xmm2,xmm2
       xor       r8d,r8d
M00_L01:
       vmovapd   [rsp+40],xmm0
       cmp       r8d,4
       jae       short M00_L02
       lea       r9,[rsp+40]
       movsxd    r10,r8d
       mov       r9d,[r9+r10*4]
       vmovapd   [rsp+30],xmm1
       cmp       r8d,4
       jae       short M00_L02
       lea       r11,[rsp+30]
       mov       r11d,[r11+r10*4]
       imul      r9d,r11d
       cmp       r8d,4
       jae       short M00_L02
       vmovapd   [rsp+20],xmm2
       lea       r11,[rsp+20]
       mov       [r11+r10*4],r9d
       inc       r8d
       cmp       r8d,4
       jl        short M00_L01
       vmovupd   [rdx],xmm2
       inc       eax
       cmp       eax,28
       jl        near ptr M00_L00
       add       rsp,58
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 172
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_270.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_271.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_272.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Equal_uint()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpcmpeqd  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_274.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_275.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThan_byte()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movzx     ecx,byte ptr [rcx+r13]
       mov       [rsp+30],r14
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movzx     edx,byte ptr [rdx+r13]
       movzx     ecx,cl
       cmp       ecx,edx
       setg      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAA6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,byte ptr [7FF91AA25B56]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAA6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,byte ptr [7FF91AA25B61]
M00_L03:
       cmp       dword ptr [rsp+44],8
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13],al
       inc       r12d
       cmp       r12d,8
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 270
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; BenchmarkDotNet.Autogenerated.Runnable_277.__ForDisassemblyDiagnoser__()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       dword ptr [rcx+50],0B
       jne       short M00_L00
       mov       rcx,[rbp+10]
       call      00007FF91A7B3610
M00_L00:
       nop
       lea       rsp,[rbp]
       pop       rbp
       ret
; Total bytes of code 40
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThanOrEqual_byte()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movzx     ecx,byte ptr [rcx+r13]
       mov       [rsp+30],r14
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movzx     edx,byte ptr [rdx+r13]
       movzx     ecx,cl
       cmp       ecx,edx
       setge     cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AA96DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,byte ptr [7FF91AA15B56]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AA96DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,byte ptr [7FF91AA15B61]
M00_L03:
       cmp       dword ptr [rsp+44],8
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13],al
       inc       r12d
       cmp       r12d,8
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 270
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThanOrEqual_byte()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movzx     ecx,byte ptr [rcx+r13]
       mov       [rsp+30],r14
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movzx     edx,byte ptr [rdx+r13]
       movzx     ecx,cl
       cmp       ecx,edx
       setle     cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAB6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,byte ptr [7FF91AA35B56]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAB6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,byte ptr [7FF91AA35B61]
M00_L03:
       cmp       dword ptr [rsp+44],8
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13],al
       inc       r12d
       cmp       r12d,8
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 270
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Add_byte()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,8
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movzx     esi,byte ptr [rsi+rdi]
       mov       [rsp+30],r8
       cmp       r11d,8
       jae       short M00_L02
       lea       rbx,[rsp+30]
       movzx     ebx,byte ptr [rbx+rdi]
       movzx     esi,sil
       add       esi,ebx
       movzx     esi,sil
       cmp       r11d,8
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi],sil
       inc       r11d
       cmp       r11d,8
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Subtract_byte()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,8
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movzx     esi,byte ptr [rsi+rdi]
       mov       [rsp+30],r8
       cmp       r11d,8
       jae       short M00_L02
       lea       rbx,[rsp+30]
       movzx     ebx,byte ptr [rbx+rdi]
       movzx     esi,sil
       sub       esi,ebx
       movzx     esi,sil
       cmp       r11d,8
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi],sil
       inc       r11d
       cmp       r11d,8
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Multiply_byte()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,8
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movzx     esi,byte ptr [rsi+rdi]
       mov       [rsp+30],r8
       cmp       r11d,8
       jae       short M00_L02
       lea       rbx,[rsp+30]
       movzx     ebx,byte ptr [rbx+rdi]
       movzx     esi,sil
       imul      esi,ebx
       movzx     esi,sil
       cmp       r11d,8
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi],sil
       inc       r11d
       cmp       r11d,8
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 171
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_283.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Min_byte()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,8
       jae       short M00_L04
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movzx     esi,byte ptr [rsi+rdi]
       mov       [rsp+30],r8
       cmp       r11d,8
       jae       short M00_L04
       lea       rbx,[rsp+30]
       movzx     ebx,byte ptr [rbx+rdi]
       movzx     esi,sil
       cmp       esi,ebx
       jle       short M00_L02
       jmp       short M00_L03
M00_L02:
       mov       ebx,esi
M00_L03:
       cmp       r11d,8
       jae       short M00_L04
       xor       esi,esi
       mov       [rsp+28],rsi
       lea       rsi,[rsp+28]
       mov       [rsi+rdi],bl
       inc       r11d
       cmp       r11d,8
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 171
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Max_byte()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,8
       jae       short M00_L04
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movzx     esi,byte ptr [rsi+rdi]
       mov       [rsp+30],r8
       cmp       r11d,8
       jae       short M00_L04
       lea       rbx,[rsp+30]
       movzx     ebx,byte ptr [rbx+rdi]
       movzx     esi,sil
       cmp       esi,ebx
       jge       short M00_L02
       jmp       short M00_L03
M00_L02:
       mov       ebx,esi
M00_L03:
       cmp       r11d,8
       jae       short M00_L04
       xor       esi,esi
       mov       [rsp+28],rsi
       lea       rsi,[rsp+28]
       mov       [rsi+rdi],bl
       inc       r11d
       cmp       r11d,8
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 171
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Equal_byte()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movzx     ecx,byte ptr [rcx+r13]
       mov       [rsp+30],r14
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movzx     edx,byte ptr [rdx+r13]
       movzx     ecx,cl
       cmp       ecx,edx
       sete      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAA6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,byte ptr [7FF91AA25B56]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAA6DD8
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,byte ptr [7FF91AA25B61]
M00_L03:
       cmp       dword ptr [rsp+44],8
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13],al
       inc       r12d
       cmp       r12d,8
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 270
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_287.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_288.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_289.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_290.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_291.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Add_byte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpaddb    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Subtract_byte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpsubb    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Multiply_byte()
       sub       rsp,58
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vxorps    xmm2,xmm2,xmm2
       xor       r8d,r8d
M00_L01:
       vmovapd   [rsp+40],xmm0
       cmp       r8d,10
       jae       short M00_L02
       lea       r9,[rsp+40]
       movsxd    r10,r8d
       movzx     r9d,byte ptr [r9+r10]
       vmovapd   [rsp+30],xmm1
       cmp       r8d,10
       jae       short M00_L02
       lea       r11,[rsp+30]
       movzx     r11d,byte ptr [r11+r10]
       movzx     r9d,r9b
       imul      r9d,r11d
       movzx     r9d,r9b
       cmp       r8d,10
       jae       short M00_L02
       vmovapd   [rsp+20],xmm2
       lea       r11,[rsp+20]
       mov       [r11+r10],r9b
       inc       r8d
       cmp       r8d,10
       jl        short M00_L01
       vmovupd   [rdx],xmm2
       inc       eax
       cmp       eax,28
       jl        near ptr M00_L00
       add       rsp,58
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 182
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_295.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_296.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_297.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Equal_byte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpcmpeqb  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_299.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_300.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_301.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_302.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_303.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Add_byte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpaddb    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Subtract_byte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpsubb    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Multiply_byte()
       sub       rsp,98
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vxorps    ymm2,ymm2,ymm2
       xor       r8d,r8d
M00_L01:
       vmovupd   [rsp+60],ymm0
       cmp       r8d,20
       jae       short M00_L02
       lea       r9,[rsp+60]
       movsxd    r10,r8d
       movzx     r9d,byte ptr [r9+r10]
       vmovupd   [rsp+40],ymm1
       cmp       r8d,20
       jae       short M00_L02
       lea       r11,[rsp+40]
       movzx     r11d,byte ptr [r11+r10]
       movzx     r9d,r9b
       imul      r9d,r11d
       movzx     r9d,r9b
       cmp       r8d,20
       jae       short M00_L02
       vmovupd   [rsp+20],ymm2
       lea       r11,[rsp+20]
       mov       [r11+r10],r9b
       inc       r8d
       cmp       r8d,20
       jl        short M00_L01
       vmovupd   [rdx],ymm2
       inc       eax
       cmp       eax,14
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,98
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 195
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_307.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_308.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_309.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Equal_byte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpcmpeqb  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_311.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThan_sbyte()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movsx     rcx,byte ptr [rcx+r13]
       mov       [rsp+30],r14
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movsx     rdx,byte ptr [rdx+r13]
       movsx     rcx,cl
       cmp       ecx,edx
       setg      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,byte ptr [7FF91AA55B56]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,byte ptr [7FF91AA55B61]
M00_L03:
       cmp       dword ptr [rsp+44],8
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13],al
       inc       r12d
       cmp       r12d,8
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 273
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThan_sbyte()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movsx     rcx,byte ptr [rcx+r13]
       mov       [rsp+30],r14
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movsx     rdx,byte ptr [rdx+r13]
       movsx     rcx,cl
       cmp       ecx,edx
       setl      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,byte ptr [7FF91AA55B56]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,byte ptr [7FF91AA55B61]
M00_L03:
       cmp       dword ptr [rsp+44],8
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13],al
       inc       r12d
       cmp       r12d,8
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 273
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThanOrEqual_sbyte()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movsx     rcx,byte ptr [rcx+r13]
       mov       [rsp+30],r14
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movsx     rdx,byte ptr [rdx+r13]
       movsx     rcx,cl
       cmp       ecx,edx
       setge     cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,byte ptr [7FF91AA25B56]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,byte ptr [7FF91AA25B61]
M00_L03:
       cmp       dword ptr [rsp+44],8
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13],al
       inc       r12d
       cmp       r12d,8
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 273
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThanOrEqual_sbyte()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movsx     rcx,byte ptr [rcx+r13]
       mov       [rsp+30],r14
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movsx     rdx,byte ptr [rdx+r13]
       movsx     rcx,cl
       cmp       ecx,edx
       setle     cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,byte ptr [7FF91AA45B56]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,byte ptr [7FF91AA45B61]
M00_L03:
       cmp       dword ptr [rsp+44],8
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13],al
       inc       r12d
       cmp       r12d,8
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 273
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Add_sbyte()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,8
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movsx     rsi,byte ptr [rsi+rdi]
       mov       [rsp+30],r8
       cmp       r11d,8
       jae       short M00_L02
       lea       rbx,[rsp+30]
       movsx     rbx,byte ptr [rbx+rdi]
       movsx     rsi,sil
       add       esi,ebx
       movsx     rsi,sil
       cmp       r11d,8
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi],sil
       inc       r11d
       cmp       r11d,8
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 171
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Subtract_sbyte()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,8
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movsx     rsi,byte ptr [rsi+rdi]
       mov       [rsp+30],r8
       cmp       r11d,8
       jae       short M00_L02
       lea       rbx,[rsp+30]
       movsx     rbx,byte ptr [rbx+rdi]
       movsx     rsi,sil
       sub       esi,ebx
       movsx     rsi,sil
       cmp       r11d,8
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi],sil
       inc       r11d
       cmp       r11d,8
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 171
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Multiply_sbyte()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,8
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movsx     rsi,byte ptr [rsi+rdi]
       mov       [rsp+30],r8
       cmp       r11d,8
       jae       short M00_L02
       lea       rbx,[rsp+30]
       movsx     rbx,byte ptr [rbx+rdi]
       movsx     rsi,sil
       imul      esi,ebx
       movsx     rsi,sil
       cmp       r11d,8
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi],sil
       inc       r11d
       cmp       r11d,8
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 172
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_319.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Min_sbyte()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,8
       jae       short M00_L04
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movsx     rsi,byte ptr [rsi+rdi]
       mov       [rsp+30],r8
       cmp       r11d,8
       jae       short M00_L04
       lea       rbx,[rsp+30]
       movsx     rbx,byte ptr [rbx+rdi]
       movsx     rsi,sil
       cmp       esi,ebx
       jle       short M00_L02
       jmp       short M00_L03
M00_L02:
       mov       ebx,esi
M00_L03:
       cmp       r11d,8
       jae       short M00_L04
       xor       esi,esi
       mov       [rsp+28],rsi
       lea       rsi,[rsp+28]
       mov       [rsi+rdi],bl
       inc       r11d
       cmp       r11d,8
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 172
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Max_sbyte()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,8
       jae       short M00_L04
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movsx     rsi,byte ptr [rsi+rdi]
       mov       [rsp+30],r8
       cmp       r11d,8
       jae       short M00_L04
       lea       rbx,[rsp+30]
       movsx     rbx,byte ptr [rbx+rdi]
       movsx     rsi,sil
       cmp       esi,ebx
       jge       short M00_L02
       jmp       short M00_L03
M00_L02:
       mov       ebx,esi
M00_L03:
       cmp       r11d,8
       jae       short M00_L04
       xor       esi,esi
       mov       [rsp+28],rsi
       lea       rsi,[rsp+28]
       mov       [rsi+rdi],bl
       inc       r11d
       cmp       r11d,8
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 172
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Equal_sbyte()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movsx     rcx,byte ptr [rcx+r13]
       mov       [rsp+30],r14
       cmp       r12d,8
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movsx     rdx,byte ptr [rdx+r13]
       movsx     rcx,cl
       cmp       ecx,edx
       sete      cl
       movzx     ecx,cl
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,byte ptr [7FF91AA55B56]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAD7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movsx     rax,byte ptr [7FF91AA55B61]
M00_L03:
       cmp       dword ptr [rsp+44],8
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13],al
       inc       r12d
       cmp       r12d,8
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      00007FF91A7DD438
       int       3
; Total bytes of code 273
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_323.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128GreaterThan_sbyte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpcmpgtb  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128LessThan_sbyte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpcmpgtb  xmm0,xmm1,xmm0
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_326.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_327.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Add_sbyte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpaddb    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Subtract_sbyte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpsubb    xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Multiply_sbyte()
       sub       rsp,58
       vzeroupper
       xor       eax,eax
       mov       [rsp+20],rax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vxorps    xmm2,xmm2,xmm2
       xor       r8d,r8d
M00_L01:
       vmovapd   [rsp+40],xmm0
       cmp       r8d,10
       jae       short M00_L02
       lea       r9,[rsp+40]
       movsxd    r10,r8d
       movsx     r9,byte ptr [r9+r10]
       vmovapd   [rsp+30],xmm1
       cmp       r8d,10
       jae       short M00_L02
       lea       r11,[rsp+30]
       movsx     r11,byte ptr [r11+r10]
       movsx     r9,r9b
       imul      r9d,r11d
       movsx     r9,r9b
       cmp       r8d,10
       jae       short M00_L02
       vmovapd   [rsp+20],xmm2
       lea       r11,[rsp+20]
       mov       [r11+r10],r9b
       inc       r8d
       cmp       r8d,10
       jl        short M00_L01
       vmovupd   [rdx],xmm2
       inc       eax
       cmp       eax,28
       jl        near ptr M00_L00
       add       rsp,58
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 182
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_331.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Min_sbyte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpminsb   xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Max_sbyte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpmaxsb   xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 56
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd128Equal_sbyte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,4
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   xmm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   xmm1,[r9+r8]
       vpcmpeqb  xmm0,xmm0,xmm1
       vmovupd   [rdx],xmm0
       inc       eax
       cmp       eax,28
       jl        short M00_L00
       ret
; Total bytes of code 55
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_335.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256GreaterThan_sbyte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpcmpgtb  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_337.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_338.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_339.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Add_sbyte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpaddb    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Subtract_sbyte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpsubb    ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Multiply_sbyte()
       sub       rsp,98
       vzeroupper
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vxorps    ymm2,ymm2,ymm2
       xor       r8d,r8d
M00_L01:
       vmovupd   [rsp+60],ymm0
       cmp       r8d,20
       jae       short M00_L02
       lea       r9,[rsp+60]
       movsxd    r10,r8d
       movsx     r9,byte ptr [r9+r10]
       vmovupd   [rsp+40],ymm1
       cmp       r8d,20
       jae       short M00_L02
       lea       r11,[rsp+40]
       movsx     r11,byte ptr [r11+r10]
       movsx     r9,r9b
       imul      r9d,r11d
       movsx     r9,r9b
       cmp       r8d,20
       jae       short M00_L02
       vmovupd   [rsp+20],ymm2
       lea       r11,[rsp+20]
       mov       [r11+r10],r9b
       inc       r8d
       cmp       r8d,20
       jl        short M00_L01
       vmovupd   [rdx],ymm2
       inc       eax
       cmp       eax,14
       jl        near ptr M00_L00
       vzeroupper
       add       rsp,98
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 195
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_343.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Min_sbyte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpminsb   ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Max_sbyte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpmaxsb   ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 59
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd256Equal_sbyte()
       vzeroupper
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       shl       r8,5
       add       rdx,r8
       mov       r9,[rcx+8]
       vmovupd   ymm0,[r9+r8]
       mov       r9,[rcx+10]
       vmovupd   ymm1,[r9+r8]
       vpcmpeqb  ymm0,ymm0,ymm1
       vmovupd   [rdx],ymm0
       inc       eax
       cmp       eax,14
       jl        short M00_L00
       vzeroupper
       ret
; Total bytes of code 58
```

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_347.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThan_ushort()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movzx     ecx,word ptr [rcx+r13*2]
       mov       [rsp+30],r14
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movzx     edx,word ptr [rdx+r13*2]
       movzx     ecx,cx
       call      Silk.NET.Maths.Scalar.<GreaterThan>g__UShort|18_10[[System.UInt16, System.Private.CoreLib]](UInt16, UInt16)
       movzx     ecx,al
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,word ptr [7FF91AA45B5C]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAC7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,word ptr [7FF91AA45B72]
M00_L03:
       cmp       dword ptr [rsp+44],4
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*2],ax
       inc       r12d
       cmp       r12d,4
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 271
```
```assembly
; Silk.NET.Maths.Scalar.<GreaterThan>g__UShort|18_10[[System.UInt16, System.Private.CoreLib]](UInt16, UInt16)
       movzx     eax,cx
       movzx     edx,dx
       cmp       eax,edx
       setg      al
       movzx     eax,al
       ret
; Total bytes of code 15
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThan_ushort()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movzx     ecx,word ptr [rcx+r13*2]
       mov       [rsp+30],r14
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movzx     edx,word ptr [rdx+r13*2]
       movzx     ecx,cx
       call      Silk.NET.Maths.Scalar.<LessThan>g__UShort|20_10[[System.UInt16, System.Private.CoreLib]](UInt16, UInt16)
       movzx     ecx,al
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,word ptr [7FF91AA25B5C]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAA7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,word ptr [7FF91AA25B72]
M00_L03:
       cmp       dword ptr [rsp+44],4
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*2],ax
       inc       r12d
       cmp       r12d,4
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 271
```
```assembly
; Silk.NET.Maths.Scalar.<LessThan>g__UShort|20_10[[System.UInt16, System.Private.CoreLib]](UInt16, UInt16)
       movzx     eax,cx
       movzx     edx,dx
       cmp       eax,edx
       setl      al
       movzx     eax,al
       ret
; Total bytes of code 15
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64GreaterThanOrEqual_ushort()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movzx     ecx,word ptr [rcx+r13*2]
       mov       [rsp+30],r14
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movzx     edx,word ptr [rdx+r13*2]
       movzx     ecx,cx
       call      Silk.NET.Maths.Scalar.<GreaterThanOrEqual>g__UShort|19_10[[System.UInt16, System.Private.CoreLib]](UInt16, UInt16)
       movzx     ecx,al
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,word ptr [7FF91AA35B5C]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,word ptr [7FF91AA35B72]
M00_L03:
       cmp       dword ptr [rsp+44],4
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*2],ax
       inc       r12d
       cmp       r12d,4
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 271
```
```assembly
; Silk.NET.Maths.Scalar.<GreaterThanOrEqual>g__UShort|19_10[[System.UInt16, System.Private.CoreLib]](UInt16, UInt16)
       movzx     eax,cx
       movzx     edx,dx
       cmp       eax,edx
       setge     al
       movzx     eax,al
       ret
; Total bytes of code 15
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64LessThanOrEqual_ushort()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movzx     ecx,word ptr [rcx+r13*2]
       mov       [rsp+30],r14
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movzx     edx,word ptr [rdx+r13*2]
       movzx     ecx,cx
       call      Silk.NET.Maths.Scalar.<LessThanOrEqual>g__UShort|21_10[[System.UInt16, System.Private.CoreLib]](UInt16, UInt16)
       movzx     ecx,al
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,word ptr [7FF91AA35B5C]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AAB7080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,word ptr [7FF91AA35B72]
M00_L03:
       cmp       dword ptr [rsp+44],4
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*2],ax
       inc       r12d
       cmp       r12d,4
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 271
```
```assembly
; Silk.NET.Maths.Scalar.<LessThanOrEqual>g__UShort|21_10[[System.UInt16, System.Private.CoreLib]](UInt16, UInt16)
       movzx     eax,cx
       movzx     edx,dx
       cmp       eax,edx
       setle     al
       movzx     eax,al
       ret
; Total bytes of code 15
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Add_ushort()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,4
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movzx     esi,word ptr [rsi+rdi*2]
       mov       [rsp+30],r8
       cmp       r11d,4
       jae       short M00_L02
       lea       rbx,[rsp+30]
       movzx     ebx,word ptr [rbx+rdi*2]
       movzx     esi,si
       add       esi,ebx
       movzx     esi,si
       cmp       r11d,4
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi*2],si
       inc       r11d
       cmp       r11d,4
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 163
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Subtract_ushort()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,4
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movzx     esi,word ptr [rsi+rdi*2]
       mov       [rsp+30],r8
       cmp       r11d,4
       jae       short M00_L02
       lea       rbx,[rsp+30]
       movzx     ebx,word ptr [rbx+rdi*2]
       movzx     esi,si
       sub       esi,ebx
       movzx     esi,si
       cmp       r11d,4
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi*2],si
       inc       r11d
       cmp       r11d,4
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        short M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 163
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Multiply_ushort()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,4
       jae       short M00_L02
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movzx     esi,word ptr [rsi+rdi*2]
       mov       [rsp+30],r8
       cmp       r11d,4
       jae       short M00_L02
       lea       rbx,[rsp+30]
       movzx     ebx,word ptr [rbx+rdi*2]
       movzx     esi,si
       imul      esi,ebx
       movzx     esi,si
       cmp       r11d,4
       jae       short M00_L02
       xor       ebx,ebx
       mov       [rsp+28],rbx
       lea       rbx,[rsp+28]
       mov       [rbx+rdi*2],si
       inc       r11d
       cmp       r11d,4
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L02:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 168
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_355.__ForDisassemblyDiagnoser__()

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Min_ushort()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,4
       jae       short M00_L04
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movzx     esi,word ptr [rsi+rdi*2]
       mov       [rsp+30],r8
       cmp       r11d,4
       jae       short M00_L04
       lea       rbx,[rsp+30]
       movzx     ebx,word ptr [rbx+rdi*2]
       movzx     esi,si
       cmp       esi,ebx
       jle       short M00_L02
       jmp       short M00_L03
M00_L02:
       mov       ebx,esi
M00_L03:
       cmp       r11d,4
       jae       short M00_L04
       xor       esi,esi
       mov       [rsp+28],rsi
       lea       rsi,[rsp+28]
       mov       [rsi+rdi*2],bx
       inc       r11d
       cmp       r11d,4
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Max_ushort()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+28],rax
       xor       eax,eax
M00_L00:
       mov       rdx,[rcx+18]
       movsxd    r8,eax
       lea       rdx,[rdx+r8*8]
       mov       r9,[rcx+8]
       mov       r9,[r9+r8*8]
       mov       r10,[rcx+10]
       mov       r8,[r10+r8*8]
       xor       r10d,r10d
       xor       r11d,r11d
M00_L01:
       mov       [rsp+38],r9
       cmp       r11d,4
       jae       short M00_L04
       lea       rsi,[rsp+38]
       movsxd    rdi,r11d
       movzx     esi,word ptr [rsi+rdi*2]
       mov       [rsp+30],r8
       cmp       r11d,4
       jae       short M00_L04
       lea       rbx,[rsp+30]
       movzx     ebx,word ptr [rbx+rdi*2]
       movzx     esi,si
       cmp       esi,ebx
       jge       short M00_L02
       jmp       short M00_L03
M00_L02:
       mov       ebx,esi
M00_L03:
       cmp       r11d,4
       jae       short M00_L04
       xor       esi,esi
       mov       [rsp+28],rsi
       lea       rsi,[rsp+28]
       mov       [rsi+rdi*2],bx
       inc       r11d
       cmp       r11d,4
       jl        short M00_L01
       xor       r8d,r8d
       mov       [rdx],r8
       inc       eax
       cmp       eax,50
       jl        near ptr M00_L00
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 170
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
```assembly
; Silk.NET.Maths.Benchmark.SIMDDisasm.Simd64Equal_ushort()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       xor       edi,edi
M00_L00:
       mov       rcx,[rsi+18]
       movsxd    rdx,edi
       lea       rbx,[rcx+rdx*8]
       mov       rcx,[rsi+8]
       mov       rbp,[rcx+rdx*8]
       mov       rcx,[rsi+10]
       mov       r14,[rcx+rdx*8]
       xor       r15d,r15d
       xor       r12d,r12d
M00_L01:
       mov       [rsp+38],rbp
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rcx,[rsp+38]
       movsxd    r13,r12d
       movzx     ecx,word ptr [rcx+r13*2]
       mov       [rsp+30],r14
       cmp       r12d,4
       jae       near ptr M00_L04
       lea       rdx,[rsp+30]
       movzx     edx,word ptr [rdx+r13*2]
       movzx     ecx,cx
       call      Silk.NET.Maths.Scalar.<Equal>g__UShort|16_10[[System.UInt16, System.Private.CoreLib]](UInt16, UInt16)
       movzx     ecx,al
       mov       eax,r12d
       test      ecx,ecx
       jne       short M00_L02
       mov       [rsp+44],eax
       mov       rcx,7FF91AA97080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,word ptr [7FF91AA15B5C]
       jmp       short M00_L03
M00_L02:
       mov       [rsp+44],eax
       mov       rcx,7FF91AA97080
       xor       edx,edx
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       movzx     eax,word ptr [7FF91AA15B72]
M00_L03:
       cmp       dword ptr [rsp+44],4
       jae       short M00_L04
       xor       ecx,ecx
       mov       [rsp+28],rcx
       lea       rcx,[rsp+28]
       mov       [rcx+r13*2],ax
       inc       r12d
       cmp       r12d,4
       jl        near ptr M00_L01
       xor       ecx,ecx
       mov       [rbx],rcx
       inc       edi
       cmp       edi,50
       jl        near ptr M00_L00
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       mov       ecx,15
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)
       int       3
; Total bytes of code 271
```
```assembly
; Silk.NET.Maths.Scalar.<Equal>g__UShort|16_10[[System.UInt16, System.Private.CoreLib]](UInt16, UInt16)
       movzx     eax,cx
       movzx     edx,dx
       cmp       eax,edx
       sete      al
       movzx     eax,al
       ret
; Total bytes of code 15
```
**Method was not JITted yet.**
System.ThrowHelper.ThrowArgumentOutOfRangeException(System.ExceptionArgument)

## .NET 5.0.8 (5.0.821.31504), X64 RyuJIT
**Method was not JITted yet.**
BenchmarkDotNet.Autogenerated.Runnable_359.__ForDisassemblyDiagnoser__()

