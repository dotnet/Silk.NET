// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.DXGI
{
    [NativeName("Name", "DXGI_GAMMA_CONTROL")]
    public unsafe partial struct GammaControl
    {
        public GammaControl
        (
            Rgb scale = default,
            Rgb offset = default
        )
        {
            Scale = scale;
            Offset = offset;
           GammaCurve_0 = default;
           GammaCurve_1 = default;
           GammaCurve_2 = default;
           GammaCurve_3 = default;
           GammaCurve_4 = default;
           GammaCurve_5 = default;
           GammaCurve_6 = default;
           GammaCurve_7 = default;
           GammaCurve_8 = default;
           GammaCurve_9 = default;
           GammaCurve_10 = default;
           GammaCurve_11 = default;
           GammaCurve_12 = default;
           GammaCurve_13 = default;
           GammaCurve_14 = default;
           GammaCurve_15 = default;
           GammaCurve_16 = default;
           GammaCurve_17 = default;
           GammaCurve_18 = default;
           GammaCurve_19 = default;
           GammaCurve_20 = default;
           GammaCurve_21 = default;
           GammaCurve_22 = default;
           GammaCurve_23 = default;
           GammaCurve_24 = default;
           GammaCurve_25 = default;
           GammaCurve_26 = default;
           GammaCurve_27 = default;
           GammaCurve_28 = default;
           GammaCurve_29 = default;
           GammaCurve_30 = default;
           GammaCurve_31 = default;
           GammaCurve_32 = default;
           GammaCurve_33 = default;
           GammaCurve_34 = default;
           GammaCurve_35 = default;
           GammaCurve_36 = default;
           GammaCurve_37 = default;
           GammaCurve_38 = default;
           GammaCurve_39 = default;
           GammaCurve_40 = default;
           GammaCurve_41 = default;
           GammaCurve_42 = default;
           GammaCurve_43 = default;
           GammaCurve_44 = default;
           GammaCurve_45 = default;
           GammaCurve_46 = default;
           GammaCurve_47 = default;
           GammaCurve_48 = default;
           GammaCurve_49 = default;
           GammaCurve_50 = default;
           GammaCurve_51 = default;
           GammaCurve_52 = default;
           GammaCurve_53 = default;
           GammaCurve_54 = default;
           GammaCurve_55 = default;
           GammaCurve_56 = default;
           GammaCurve_57 = default;
           GammaCurve_58 = default;
           GammaCurve_59 = default;
           GammaCurve_60 = default;
           GammaCurve_61 = default;
           GammaCurve_62 = default;
           GammaCurve_63 = default;
           GammaCurve_64 = default;
           GammaCurve_65 = default;
           GammaCurve_66 = default;
           GammaCurve_67 = default;
           GammaCurve_68 = default;
           GammaCurve_69 = default;
           GammaCurve_70 = default;
           GammaCurve_71 = default;
           GammaCurve_72 = default;
           GammaCurve_73 = default;
           GammaCurve_74 = default;
           GammaCurve_75 = default;
           GammaCurve_76 = default;
           GammaCurve_77 = default;
           GammaCurve_78 = default;
           GammaCurve_79 = default;
           GammaCurve_80 = default;
           GammaCurve_81 = default;
           GammaCurve_82 = default;
           GammaCurve_83 = default;
           GammaCurve_84 = default;
           GammaCurve_85 = default;
           GammaCurve_86 = default;
           GammaCurve_87 = default;
           GammaCurve_88 = default;
           GammaCurve_89 = default;
           GammaCurve_90 = default;
           GammaCurve_91 = default;
           GammaCurve_92 = default;
           GammaCurve_93 = default;
           GammaCurve_94 = default;
           GammaCurve_95 = default;
           GammaCurve_96 = default;
           GammaCurve_97 = default;
           GammaCurve_98 = default;
           GammaCurve_99 = default;
           GammaCurve_100 = default;
           GammaCurve_101 = default;
           GammaCurve_102 = default;
           GammaCurve_103 = default;
           GammaCurve_104 = default;
           GammaCurve_105 = default;
           GammaCurve_106 = default;
           GammaCurve_107 = default;
           GammaCurve_108 = default;
           GammaCurve_109 = default;
           GammaCurve_110 = default;
           GammaCurve_111 = default;
           GammaCurve_112 = default;
           GammaCurve_113 = default;
           GammaCurve_114 = default;
           GammaCurve_115 = default;
           GammaCurve_116 = default;
           GammaCurve_117 = default;
           GammaCurve_118 = default;
           GammaCurve_119 = default;
           GammaCurve_120 = default;
           GammaCurve_121 = default;
           GammaCurve_122 = default;
           GammaCurve_123 = default;
           GammaCurve_124 = default;
           GammaCurve_125 = default;
           GammaCurve_126 = default;
           GammaCurve_127 = default;
           GammaCurve_128 = default;
           GammaCurve_129 = default;
           GammaCurve_130 = default;
           GammaCurve_131 = default;
           GammaCurve_132 = default;
           GammaCurve_133 = default;
           GammaCurve_134 = default;
           GammaCurve_135 = default;
           GammaCurve_136 = default;
           GammaCurve_137 = default;
           GammaCurve_138 = default;
           GammaCurve_139 = default;
           GammaCurve_140 = default;
           GammaCurve_141 = default;
           GammaCurve_142 = default;
           GammaCurve_143 = default;
           GammaCurve_144 = default;
           GammaCurve_145 = default;
           GammaCurve_146 = default;
           GammaCurve_147 = default;
           GammaCurve_148 = default;
           GammaCurve_149 = default;
           GammaCurve_150 = default;
           GammaCurve_151 = default;
           GammaCurve_152 = default;
           GammaCurve_153 = default;
           GammaCurve_154 = default;
           GammaCurve_155 = default;
           GammaCurve_156 = default;
           GammaCurve_157 = default;
           GammaCurve_158 = default;
           GammaCurve_159 = default;
           GammaCurve_160 = default;
           GammaCurve_161 = default;
           GammaCurve_162 = default;
           GammaCurve_163 = default;
           GammaCurve_164 = default;
           GammaCurve_165 = default;
           GammaCurve_166 = default;
           GammaCurve_167 = default;
           GammaCurve_168 = default;
           GammaCurve_169 = default;
           GammaCurve_170 = default;
           GammaCurve_171 = default;
           GammaCurve_172 = default;
           GammaCurve_173 = default;
           GammaCurve_174 = default;
           GammaCurve_175 = default;
           GammaCurve_176 = default;
           GammaCurve_177 = default;
           GammaCurve_178 = default;
           GammaCurve_179 = default;
           GammaCurve_180 = default;
           GammaCurve_181 = default;
           GammaCurve_182 = default;
           GammaCurve_183 = default;
           GammaCurve_184 = default;
           GammaCurve_185 = default;
           GammaCurve_186 = default;
           GammaCurve_187 = default;
           GammaCurve_188 = default;
           GammaCurve_189 = default;
           GammaCurve_190 = default;
           GammaCurve_191 = default;
           GammaCurve_192 = default;
           GammaCurve_193 = default;
           GammaCurve_194 = default;
           GammaCurve_195 = default;
           GammaCurve_196 = default;
           GammaCurve_197 = default;
           GammaCurve_198 = default;
           GammaCurve_199 = default;
           GammaCurve_200 = default;
           GammaCurve_201 = default;
           GammaCurve_202 = default;
           GammaCurve_203 = default;
           GammaCurve_204 = default;
           GammaCurve_205 = default;
           GammaCurve_206 = default;
           GammaCurve_207 = default;
           GammaCurve_208 = default;
           GammaCurve_209 = default;
           GammaCurve_210 = default;
           GammaCurve_211 = default;
           GammaCurve_212 = default;
           GammaCurve_213 = default;
           GammaCurve_214 = default;
           GammaCurve_215 = default;
           GammaCurve_216 = default;
           GammaCurve_217 = default;
           GammaCurve_218 = default;
           GammaCurve_219 = default;
           GammaCurve_220 = default;
           GammaCurve_221 = default;
           GammaCurve_222 = default;
           GammaCurve_223 = default;
           GammaCurve_224 = default;
           GammaCurve_225 = default;
           GammaCurve_226 = default;
           GammaCurve_227 = default;
           GammaCurve_228 = default;
           GammaCurve_229 = default;
           GammaCurve_230 = default;
           GammaCurve_231 = default;
           GammaCurve_232 = default;
           GammaCurve_233 = default;
           GammaCurve_234 = default;
           GammaCurve_235 = default;
           GammaCurve_236 = default;
           GammaCurve_237 = default;
           GammaCurve_238 = default;
           GammaCurve_239 = default;
           GammaCurve_240 = default;
           GammaCurve_241 = default;
           GammaCurve_242 = default;
           GammaCurve_243 = default;
           GammaCurve_244 = default;
           GammaCurve_245 = default;
           GammaCurve_246 = default;
           GammaCurve_247 = default;
           GammaCurve_248 = default;
           GammaCurve_249 = default;
           GammaCurve_250 = default;
           GammaCurve_251 = default;
           GammaCurve_252 = default;
           GammaCurve_253 = default;
           GammaCurve_254 = default;
           GammaCurve_255 = default;
           GammaCurve_256 = default;
           GammaCurve_257 = default;
           GammaCurve_258 = default;
           GammaCurve_259 = default;
           GammaCurve_260 = default;
           GammaCurve_261 = default;
           GammaCurve_262 = default;
           GammaCurve_263 = default;
           GammaCurve_264 = default;
           GammaCurve_265 = default;
           GammaCurve_266 = default;
           GammaCurve_267 = default;
           GammaCurve_268 = default;
           GammaCurve_269 = default;
           GammaCurve_270 = default;
           GammaCurve_271 = default;
           GammaCurve_272 = default;
           GammaCurve_273 = default;
           GammaCurve_274 = default;
           GammaCurve_275 = default;
           GammaCurve_276 = default;
           GammaCurve_277 = default;
           GammaCurve_278 = default;
           GammaCurve_279 = default;
           GammaCurve_280 = default;
           GammaCurve_281 = default;
           GammaCurve_282 = default;
           GammaCurve_283 = default;
           GammaCurve_284 = default;
           GammaCurve_285 = default;
           GammaCurve_286 = default;
           GammaCurve_287 = default;
           GammaCurve_288 = default;
           GammaCurve_289 = default;
           GammaCurve_290 = default;
           GammaCurve_291 = default;
           GammaCurve_292 = default;
           GammaCurve_293 = default;
           GammaCurve_294 = default;
           GammaCurve_295 = default;
           GammaCurve_296 = default;
           GammaCurve_297 = default;
           GammaCurve_298 = default;
           GammaCurve_299 = default;
           GammaCurve_300 = default;
           GammaCurve_301 = default;
           GammaCurve_302 = default;
           GammaCurve_303 = default;
           GammaCurve_304 = default;
           GammaCurve_305 = default;
           GammaCurve_306 = default;
           GammaCurve_307 = default;
           GammaCurve_308 = default;
           GammaCurve_309 = default;
           GammaCurve_310 = default;
           GammaCurve_311 = default;
           GammaCurve_312 = default;
           GammaCurve_313 = default;
           GammaCurve_314 = default;
           GammaCurve_315 = default;
           GammaCurve_316 = default;
           GammaCurve_317 = default;
           GammaCurve_318 = default;
           GammaCurve_319 = default;
           GammaCurve_320 = default;
           GammaCurve_321 = default;
           GammaCurve_322 = default;
           GammaCurve_323 = default;
           GammaCurve_324 = default;
           GammaCurve_325 = default;
           GammaCurve_326 = default;
           GammaCurve_327 = default;
           GammaCurve_328 = default;
           GammaCurve_329 = default;
           GammaCurve_330 = default;
           GammaCurve_331 = default;
           GammaCurve_332 = default;
           GammaCurve_333 = default;
           GammaCurve_334 = default;
           GammaCurve_335 = default;
           GammaCurve_336 = default;
           GammaCurve_337 = default;
           GammaCurve_338 = default;
           GammaCurve_339 = default;
           GammaCurve_340 = default;
           GammaCurve_341 = default;
           GammaCurve_342 = default;
           GammaCurve_343 = default;
           GammaCurve_344 = default;
           GammaCurve_345 = default;
           GammaCurve_346 = default;
           GammaCurve_347 = default;
           GammaCurve_348 = default;
           GammaCurve_349 = default;
           GammaCurve_350 = default;
           GammaCurve_351 = default;
           GammaCurve_352 = default;
           GammaCurve_353 = default;
           GammaCurve_354 = default;
           GammaCurve_355 = default;
           GammaCurve_356 = default;
           GammaCurve_357 = default;
           GammaCurve_358 = default;
           GammaCurve_359 = default;
           GammaCurve_360 = default;
           GammaCurve_361 = default;
           GammaCurve_362 = default;
           GammaCurve_363 = default;
           GammaCurve_364 = default;
           GammaCurve_365 = default;
           GammaCurve_366 = default;
           GammaCurve_367 = default;
           GammaCurve_368 = default;
           GammaCurve_369 = default;
           GammaCurve_370 = default;
           GammaCurve_371 = default;
           GammaCurve_372 = default;
           GammaCurve_373 = default;
           GammaCurve_374 = default;
           GammaCurve_375 = default;
           GammaCurve_376 = default;
           GammaCurve_377 = default;
           GammaCurve_378 = default;
           GammaCurve_379 = default;
           GammaCurve_380 = default;
           GammaCurve_381 = default;
           GammaCurve_382 = default;
           GammaCurve_383 = default;
           GammaCurve_384 = default;
           GammaCurve_385 = default;
           GammaCurve_386 = default;
           GammaCurve_387 = default;
           GammaCurve_388 = default;
           GammaCurve_389 = default;
           GammaCurve_390 = default;
           GammaCurve_391 = default;
           GammaCurve_392 = default;
           GammaCurve_393 = default;
           GammaCurve_394 = default;
           GammaCurve_395 = default;
           GammaCurve_396 = default;
           GammaCurve_397 = default;
           GammaCurve_398 = default;
           GammaCurve_399 = default;
           GammaCurve_400 = default;
           GammaCurve_401 = default;
           GammaCurve_402 = default;
           GammaCurve_403 = default;
           GammaCurve_404 = default;
           GammaCurve_405 = default;
           GammaCurve_406 = default;
           GammaCurve_407 = default;
           GammaCurve_408 = default;
           GammaCurve_409 = default;
           GammaCurve_410 = default;
           GammaCurve_411 = default;
           GammaCurve_412 = default;
           GammaCurve_413 = default;
           GammaCurve_414 = default;
           GammaCurve_415 = default;
           GammaCurve_416 = default;
           GammaCurve_417 = default;
           GammaCurve_418 = default;
           GammaCurve_419 = default;
           GammaCurve_420 = default;
           GammaCurve_421 = default;
           GammaCurve_422 = default;
           GammaCurve_423 = default;
           GammaCurve_424 = default;
           GammaCurve_425 = default;
           GammaCurve_426 = default;
           GammaCurve_427 = default;
           GammaCurve_428 = default;
           GammaCurve_429 = default;
           GammaCurve_430 = default;
           GammaCurve_431 = default;
           GammaCurve_432 = default;
           GammaCurve_433 = default;
           GammaCurve_434 = default;
           GammaCurve_435 = default;
           GammaCurve_436 = default;
           GammaCurve_437 = default;
           GammaCurve_438 = default;
           GammaCurve_439 = default;
           GammaCurve_440 = default;
           GammaCurve_441 = default;
           GammaCurve_442 = default;
           GammaCurve_443 = default;
           GammaCurve_444 = default;
           GammaCurve_445 = default;
           GammaCurve_446 = default;
           GammaCurve_447 = default;
           GammaCurve_448 = default;
           GammaCurve_449 = default;
           GammaCurve_450 = default;
           GammaCurve_451 = default;
           GammaCurve_452 = default;
           GammaCurve_453 = default;
           GammaCurve_454 = default;
           GammaCurve_455 = default;
           GammaCurve_456 = default;
           GammaCurve_457 = default;
           GammaCurve_458 = default;
           GammaCurve_459 = default;
           GammaCurve_460 = default;
           GammaCurve_461 = default;
           GammaCurve_462 = default;
           GammaCurve_463 = default;
           GammaCurve_464 = default;
           GammaCurve_465 = default;
           GammaCurve_466 = default;
           GammaCurve_467 = default;
           GammaCurve_468 = default;
           GammaCurve_469 = default;
           GammaCurve_470 = default;
           GammaCurve_471 = default;
           GammaCurve_472 = default;
           GammaCurve_473 = default;
           GammaCurve_474 = default;
           GammaCurve_475 = default;
           GammaCurve_476 = default;
           GammaCurve_477 = default;
           GammaCurve_478 = default;
           GammaCurve_479 = default;
           GammaCurve_480 = default;
           GammaCurve_481 = default;
           GammaCurve_482 = default;
           GammaCurve_483 = default;
           GammaCurve_484 = default;
           GammaCurve_485 = default;
           GammaCurve_486 = default;
           GammaCurve_487 = default;
           GammaCurve_488 = default;
           GammaCurve_489 = default;
           GammaCurve_490 = default;
           GammaCurve_491 = default;
           GammaCurve_492 = default;
           GammaCurve_493 = default;
           GammaCurve_494 = default;
           GammaCurve_495 = default;
           GammaCurve_496 = default;
           GammaCurve_497 = default;
           GammaCurve_498 = default;
           GammaCurve_499 = default;
           GammaCurve_500 = default;
           GammaCurve_501 = default;
           GammaCurve_502 = default;
           GammaCurve_503 = default;
           GammaCurve_504 = default;
           GammaCurve_505 = default;
           GammaCurve_506 = default;
           GammaCurve_507 = default;
           GammaCurve_508 = default;
           GammaCurve_509 = default;
           GammaCurve_510 = default;
           GammaCurve_511 = default;
           GammaCurve_512 = default;
           GammaCurve_513 = default;
           GammaCurve_514 = default;
           GammaCurve_515 = default;
           GammaCurve_516 = default;
           GammaCurve_517 = default;
           GammaCurve_518 = default;
           GammaCurve_519 = default;
           GammaCurve_520 = default;
           GammaCurve_521 = default;
           GammaCurve_522 = default;
           GammaCurve_523 = default;
           GammaCurve_524 = default;
           GammaCurve_525 = default;
           GammaCurve_526 = default;
           GammaCurve_527 = default;
           GammaCurve_528 = default;
           GammaCurve_529 = default;
           GammaCurve_530 = default;
           GammaCurve_531 = default;
           GammaCurve_532 = default;
           GammaCurve_533 = default;
           GammaCurve_534 = default;
           GammaCurve_535 = default;
           GammaCurve_536 = default;
           GammaCurve_537 = default;
           GammaCurve_538 = default;
           GammaCurve_539 = default;
           GammaCurve_540 = default;
           GammaCurve_541 = default;
           GammaCurve_542 = default;
           GammaCurve_543 = default;
           GammaCurve_544 = default;
           GammaCurve_545 = default;
           GammaCurve_546 = default;
           GammaCurve_547 = default;
           GammaCurve_548 = default;
           GammaCurve_549 = default;
           GammaCurve_550 = default;
           GammaCurve_551 = default;
           GammaCurve_552 = default;
           GammaCurve_553 = default;
           GammaCurve_554 = default;
           GammaCurve_555 = default;
           GammaCurve_556 = default;
           GammaCurve_557 = default;
           GammaCurve_558 = default;
           GammaCurve_559 = default;
           GammaCurve_560 = default;
           GammaCurve_561 = default;
           GammaCurve_562 = default;
           GammaCurve_563 = default;
           GammaCurve_564 = default;
           GammaCurve_565 = default;
           GammaCurve_566 = default;
           GammaCurve_567 = default;
           GammaCurve_568 = default;
           GammaCurve_569 = default;
           GammaCurve_570 = default;
           GammaCurve_571 = default;
           GammaCurve_572 = default;
           GammaCurve_573 = default;
           GammaCurve_574 = default;
           GammaCurve_575 = default;
           GammaCurve_576 = default;
           GammaCurve_577 = default;
           GammaCurve_578 = default;
           GammaCurve_579 = default;
           GammaCurve_580 = default;
           GammaCurve_581 = default;
           GammaCurve_582 = default;
           GammaCurve_583 = default;
           GammaCurve_584 = default;
           GammaCurve_585 = default;
           GammaCurve_586 = default;
           GammaCurve_587 = default;
           GammaCurve_588 = default;
           GammaCurve_589 = default;
           GammaCurve_590 = default;
           GammaCurve_591 = default;
           GammaCurve_592 = default;
           GammaCurve_593 = default;
           GammaCurve_594 = default;
           GammaCurve_595 = default;
           GammaCurve_596 = default;
           GammaCurve_597 = default;
           GammaCurve_598 = default;
           GammaCurve_599 = default;
           GammaCurve_600 = default;
           GammaCurve_601 = default;
           GammaCurve_602 = default;
           GammaCurve_603 = default;
           GammaCurve_604 = default;
           GammaCurve_605 = default;
           GammaCurve_606 = default;
           GammaCurve_607 = default;
           GammaCurve_608 = default;
           GammaCurve_609 = default;
           GammaCurve_610 = default;
           GammaCurve_611 = default;
           GammaCurve_612 = default;
           GammaCurve_613 = default;
           GammaCurve_614 = default;
           GammaCurve_615 = default;
           GammaCurve_616 = default;
           GammaCurve_617 = default;
           GammaCurve_618 = default;
           GammaCurve_619 = default;
           GammaCurve_620 = default;
           GammaCurve_621 = default;
           GammaCurve_622 = default;
           GammaCurve_623 = default;
           GammaCurve_624 = default;
           GammaCurve_625 = default;
           GammaCurve_626 = default;
           GammaCurve_627 = default;
           GammaCurve_628 = default;
           GammaCurve_629 = default;
           GammaCurve_630 = default;
           GammaCurve_631 = default;
           GammaCurve_632 = default;
           GammaCurve_633 = default;
           GammaCurve_634 = default;
           GammaCurve_635 = default;
           GammaCurve_636 = default;
           GammaCurve_637 = default;
           GammaCurve_638 = default;
           GammaCurve_639 = default;
           GammaCurve_640 = default;
           GammaCurve_641 = default;
           GammaCurve_642 = default;
           GammaCurve_643 = default;
           GammaCurve_644 = default;
           GammaCurve_645 = default;
           GammaCurve_646 = default;
           GammaCurve_647 = default;
           GammaCurve_648 = default;
           GammaCurve_649 = default;
           GammaCurve_650 = default;
           GammaCurve_651 = default;
           GammaCurve_652 = default;
           GammaCurve_653 = default;
           GammaCurve_654 = default;
           GammaCurve_655 = default;
           GammaCurve_656 = default;
           GammaCurve_657 = default;
           GammaCurve_658 = default;
           GammaCurve_659 = default;
           GammaCurve_660 = default;
           GammaCurve_661 = default;
           GammaCurve_662 = default;
           GammaCurve_663 = default;
           GammaCurve_664 = default;
           GammaCurve_665 = default;
           GammaCurve_666 = default;
           GammaCurve_667 = default;
           GammaCurve_668 = default;
           GammaCurve_669 = default;
           GammaCurve_670 = default;
           GammaCurve_671 = default;
           GammaCurve_672 = default;
           GammaCurve_673 = default;
           GammaCurve_674 = default;
           GammaCurve_675 = default;
           GammaCurve_676 = default;
           GammaCurve_677 = default;
           GammaCurve_678 = default;
           GammaCurve_679 = default;
           GammaCurve_680 = default;
           GammaCurve_681 = default;
           GammaCurve_682 = default;
           GammaCurve_683 = default;
           GammaCurve_684 = default;
           GammaCurve_685 = default;
           GammaCurve_686 = default;
           GammaCurve_687 = default;
           GammaCurve_688 = default;
           GammaCurve_689 = default;
           GammaCurve_690 = default;
           GammaCurve_691 = default;
           GammaCurve_692 = default;
           GammaCurve_693 = default;
           GammaCurve_694 = default;
           GammaCurve_695 = default;
           GammaCurve_696 = default;
           GammaCurve_697 = default;
           GammaCurve_698 = default;
           GammaCurve_699 = default;
           GammaCurve_700 = default;
           GammaCurve_701 = default;
           GammaCurve_702 = default;
           GammaCurve_703 = default;
           GammaCurve_704 = default;
           GammaCurve_705 = default;
           GammaCurve_706 = default;
           GammaCurve_707 = default;
           GammaCurve_708 = default;
           GammaCurve_709 = default;
           GammaCurve_710 = default;
           GammaCurve_711 = default;
           GammaCurve_712 = default;
           GammaCurve_713 = default;
           GammaCurve_714 = default;
           GammaCurve_715 = default;
           GammaCurve_716 = default;
           GammaCurve_717 = default;
           GammaCurve_718 = default;
           GammaCurve_719 = default;
           GammaCurve_720 = default;
           GammaCurve_721 = default;
           GammaCurve_722 = default;
           GammaCurve_723 = default;
           GammaCurve_724 = default;
           GammaCurve_725 = default;
           GammaCurve_726 = default;
           GammaCurve_727 = default;
           GammaCurve_728 = default;
           GammaCurve_729 = default;
           GammaCurve_730 = default;
           GammaCurve_731 = default;
           GammaCurve_732 = default;
           GammaCurve_733 = default;
           GammaCurve_734 = default;
           GammaCurve_735 = default;
           GammaCurve_736 = default;
           GammaCurve_737 = default;
           GammaCurve_738 = default;
           GammaCurve_739 = default;
           GammaCurve_740 = default;
           GammaCurve_741 = default;
           GammaCurve_742 = default;
           GammaCurve_743 = default;
           GammaCurve_744 = default;
           GammaCurve_745 = default;
           GammaCurve_746 = default;
           GammaCurve_747 = default;
           GammaCurve_748 = default;
           GammaCurve_749 = default;
           GammaCurve_750 = default;
           GammaCurve_751 = default;
           GammaCurve_752 = default;
           GammaCurve_753 = default;
           GammaCurve_754 = default;
           GammaCurve_755 = default;
           GammaCurve_756 = default;
           GammaCurve_757 = default;
           GammaCurve_758 = default;
           GammaCurve_759 = default;
           GammaCurve_760 = default;
           GammaCurve_761 = default;
           GammaCurve_762 = default;
           GammaCurve_763 = default;
           GammaCurve_764 = default;
           GammaCurve_765 = default;
           GammaCurve_766 = default;
           GammaCurve_767 = default;
           GammaCurve_768 = default;
           GammaCurve_769 = default;
           GammaCurve_770 = default;
           GammaCurve_771 = default;
           GammaCurve_772 = default;
           GammaCurve_773 = default;
           GammaCurve_774 = default;
           GammaCurve_775 = default;
           GammaCurve_776 = default;
           GammaCurve_777 = default;
           GammaCurve_778 = default;
           GammaCurve_779 = default;
           GammaCurve_780 = default;
           GammaCurve_781 = default;
           GammaCurve_782 = default;
           GammaCurve_783 = default;
           GammaCurve_784 = default;
           GammaCurve_785 = default;
           GammaCurve_786 = default;
           GammaCurve_787 = default;
           GammaCurve_788 = default;
           GammaCurve_789 = default;
           GammaCurve_790 = default;
           GammaCurve_791 = default;
           GammaCurve_792 = default;
           GammaCurve_793 = default;
           GammaCurve_794 = default;
           GammaCurve_795 = default;
           GammaCurve_796 = default;
           GammaCurve_797 = default;
           GammaCurve_798 = default;
           GammaCurve_799 = default;
           GammaCurve_800 = default;
           GammaCurve_801 = default;
           GammaCurve_802 = default;
           GammaCurve_803 = default;
           GammaCurve_804 = default;
           GammaCurve_805 = default;
           GammaCurve_806 = default;
           GammaCurve_807 = default;
           GammaCurve_808 = default;
           GammaCurve_809 = default;
           GammaCurve_810 = default;
           GammaCurve_811 = default;
           GammaCurve_812 = default;
           GammaCurve_813 = default;
           GammaCurve_814 = default;
           GammaCurve_815 = default;
           GammaCurve_816 = default;
           GammaCurve_817 = default;
           GammaCurve_818 = default;
           GammaCurve_819 = default;
           GammaCurve_820 = default;
           GammaCurve_821 = default;
           GammaCurve_822 = default;
           GammaCurve_823 = default;
           GammaCurve_824 = default;
           GammaCurve_825 = default;
           GammaCurve_826 = default;
           GammaCurve_827 = default;
           GammaCurve_828 = default;
           GammaCurve_829 = default;
           GammaCurve_830 = default;
           GammaCurve_831 = default;
           GammaCurve_832 = default;
           GammaCurve_833 = default;
           GammaCurve_834 = default;
           GammaCurve_835 = default;
           GammaCurve_836 = default;
           GammaCurve_837 = default;
           GammaCurve_838 = default;
           GammaCurve_839 = default;
           GammaCurve_840 = default;
           GammaCurve_841 = default;
           GammaCurve_842 = default;
           GammaCurve_843 = default;
           GammaCurve_844 = default;
           GammaCurve_845 = default;
           GammaCurve_846 = default;
           GammaCurve_847 = default;
           GammaCurve_848 = default;
           GammaCurve_849 = default;
           GammaCurve_850 = default;
           GammaCurve_851 = default;
           GammaCurve_852 = default;
           GammaCurve_853 = default;
           GammaCurve_854 = default;
           GammaCurve_855 = default;
           GammaCurve_856 = default;
           GammaCurve_857 = default;
           GammaCurve_858 = default;
           GammaCurve_859 = default;
           GammaCurve_860 = default;
           GammaCurve_861 = default;
           GammaCurve_862 = default;
           GammaCurve_863 = default;
           GammaCurve_864 = default;
           GammaCurve_865 = default;
           GammaCurve_866 = default;
           GammaCurve_867 = default;
           GammaCurve_868 = default;
           GammaCurve_869 = default;
           GammaCurve_870 = default;
           GammaCurve_871 = default;
           GammaCurve_872 = default;
           GammaCurve_873 = default;
           GammaCurve_874 = default;
           GammaCurve_875 = default;
           GammaCurve_876 = default;
           GammaCurve_877 = default;
           GammaCurve_878 = default;
           GammaCurve_879 = default;
           GammaCurve_880 = default;
           GammaCurve_881 = default;
           GammaCurve_882 = default;
           GammaCurve_883 = default;
           GammaCurve_884 = default;
           GammaCurve_885 = default;
           GammaCurve_886 = default;
           GammaCurve_887 = default;
           GammaCurve_888 = default;
           GammaCurve_889 = default;
           GammaCurve_890 = default;
           GammaCurve_891 = default;
           GammaCurve_892 = default;
           GammaCurve_893 = default;
           GammaCurve_894 = default;
           GammaCurve_895 = default;
           GammaCurve_896 = default;
           GammaCurve_897 = default;
           GammaCurve_898 = default;
           GammaCurve_899 = default;
           GammaCurve_900 = default;
           GammaCurve_901 = default;
           GammaCurve_902 = default;
           GammaCurve_903 = default;
           GammaCurve_904 = default;
           GammaCurve_905 = default;
           GammaCurve_906 = default;
           GammaCurve_907 = default;
           GammaCurve_908 = default;
           GammaCurve_909 = default;
           GammaCurve_910 = default;
           GammaCurve_911 = default;
           GammaCurve_912 = default;
           GammaCurve_913 = default;
           GammaCurve_914 = default;
           GammaCurve_915 = default;
           GammaCurve_916 = default;
           GammaCurve_917 = default;
           GammaCurve_918 = default;
           GammaCurve_919 = default;
           GammaCurve_920 = default;
           GammaCurve_921 = default;
           GammaCurve_922 = default;
           GammaCurve_923 = default;
           GammaCurve_924 = default;
           GammaCurve_925 = default;
           GammaCurve_926 = default;
           GammaCurve_927 = default;
           GammaCurve_928 = default;
           GammaCurve_929 = default;
           GammaCurve_930 = default;
           GammaCurve_931 = default;
           GammaCurve_932 = default;
           GammaCurve_933 = default;
           GammaCurve_934 = default;
           GammaCurve_935 = default;
           GammaCurve_936 = default;
           GammaCurve_937 = default;
           GammaCurve_938 = default;
           GammaCurve_939 = default;
           GammaCurve_940 = default;
           GammaCurve_941 = default;
           GammaCurve_942 = default;
           GammaCurve_943 = default;
           GammaCurve_944 = default;
           GammaCurve_945 = default;
           GammaCurve_946 = default;
           GammaCurve_947 = default;
           GammaCurve_948 = default;
           GammaCurve_949 = default;
           GammaCurve_950 = default;
           GammaCurve_951 = default;
           GammaCurve_952 = default;
           GammaCurve_953 = default;
           GammaCurve_954 = default;
           GammaCurve_955 = default;
           GammaCurve_956 = default;
           GammaCurve_957 = default;
           GammaCurve_958 = default;
           GammaCurve_959 = default;
           GammaCurve_960 = default;
           GammaCurve_961 = default;
           GammaCurve_962 = default;
           GammaCurve_963 = default;
           GammaCurve_964 = default;
           GammaCurve_965 = default;
           GammaCurve_966 = default;
           GammaCurve_967 = default;
           GammaCurve_968 = default;
           GammaCurve_969 = default;
           GammaCurve_970 = default;
           GammaCurve_971 = default;
           GammaCurve_972 = default;
           GammaCurve_973 = default;
           GammaCurve_974 = default;
           GammaCurve_975 = default;
           GammaCurve_976 = default;
           GammaCurve_977 = default;
           GammaCurve_978 = default;
           GammaCurve_979 = default;
           GammaCurve_980 = default;
           GammaCurve_981 = default;
           GammaCurve_982 = default;
           GammaCurve_983 = default;
           GammaCurve_984 = default;
           GammaCurve_985 = default;
           GammaCurve_986 = default;
           GammaCurve_987 = default;
           GammaCurve_988 = default;
           GammaCurve_989 = default;
           GammaCurve_990 = default;
           GammaCurve_991 = default;
           GammaCurve_992 = default;
           GammaCurve_993 = default;
           GammaCurve_994 = default;
           GammaCurve_995 = default;
           GammaCurve_996 = default;
           GammaCurve_997 = default;
           GammaCurve_998 = default;
           GammaCurve_999 = default;
           GammaCurve_1000 = default;
           GammaCurve_1001 = default;
           GammaCurve_1002 = default;
           GammaCurve_1003 = default;
           GammaCurve_1004 = default;
           GammaCurve_1005 = default;
           GammaCurve_1006 = default;
           GammaCurve_1007 = default;
           GammaCurve_1008 = default;
           GammaCurve_1009 = default;
           GammaCurve_1010 = default;
           GammaCurve_1011 = default;
           GammaCurve_1012 = default;
           GammaCurve_1013 = default;
           GammaCurve_1014 = default;
           GammaCurve_1015 = default;
           GammaCurve_1016 = default;
           GammaCurve_1017 = default;
           GammaCurve_1018 = default;
           GammaCurve_1019 = default;
           GammaCurve_1020 = default;
           GammaCurve_1021 = default;
           GammaCurve_1022 = default;
           GammaCurve_1023 = default;
           GammaCurve_1024 = default;
        }


        [NativeName("Type", "DXGI_RGB")]
        [NativeName("Type.Name", "DXGI_RGB")]
        [NativeName("Name", "Scale")]
        public Rgb Scale;

        [NativeName("Type", "DXGI_RGB")]
        [NativeName("Type.Name", "DXGI_RGB")]
        [NativeName("Name", "Offset")]
        public Rgb Offset;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_0;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_2;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_3;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_4;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_5;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_6;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_7;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_8;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_9;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_10;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_11;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_12;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_13;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_14;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_15;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_16;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_17;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_18;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_19;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_20;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_21;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_22;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_23;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_24;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_25;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_26;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_27;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_28;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_29;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_30;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_31;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_32;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_33;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_34;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_35;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_36;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_37;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_38;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_39;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_40;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_41;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_42;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_43;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_44;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_45;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_46;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_47;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_48;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_49;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_50;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_51;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_52;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_53;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_54;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_55;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_56;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_57;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_58;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_59;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_60;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_61;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_62;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_63;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_64;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_65;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_66;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_67;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_68;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_69;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_70;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_71;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_72;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_73;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_74;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_75;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_76;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_77;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_78;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_79;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_80;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_81;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_82;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_83;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_84;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_85;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_86;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_87;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_88;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_89;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_90;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_91;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_92;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_93;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_94;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_95;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_96;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_97;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_98;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_99;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_100;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_101;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_102;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_103;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_104;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_105;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_106;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_107;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_108;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_109;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_110;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_111;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_112;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_113;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_114;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_115;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_116;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_117;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_118;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_119;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_120;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_121;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_122;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_123;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_124;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_125;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_126;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_127;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_128;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_129;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_130;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_131;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_132;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_133;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_134;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_135;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_136;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_137;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_138;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_139;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_140;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_141;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_142;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_143;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_144;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_145;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_146;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_147;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_148;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_149;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_150;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_151;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_152;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_153;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_154;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_155;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_156;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_157;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_158;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_159;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_160;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_161;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_162;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_163;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_164;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_165;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_166;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_167;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_168;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_169;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_170;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_171;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_172;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_173;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_174;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_175;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_176;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_177;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_178;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_179;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_180;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_181;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_182;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_183;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_184;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_185;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_186;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_187;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_188;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_189;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_190;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_191;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_192;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_193;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_194;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_195;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_196;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_197;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_198;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_199;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_200;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_201;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_202;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_203;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_204;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_205;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_206;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_207;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_208;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_209;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_210;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_211;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_212;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_213;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_214;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_215;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_216;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_217;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_218;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_219;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_220;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_221;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_222;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_223;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_224;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_225;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_226;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_227;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_228;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_229;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_230;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_231;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_232;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_233;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_234;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_235;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_236;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_237;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_238;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_239;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_240;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_241;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_242;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_243;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_244;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_245;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_246;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_247;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_248;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_249;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_250;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_251;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_252;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_253;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_254;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_255;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_256;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_257;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_258;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_259;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_260;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_261;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_262;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_263;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_264;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_265;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_266;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_267;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_268;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_269;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_270;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_271;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_272;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_273;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_274;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_275;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_276;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_277;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_278;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_279;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_280;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_281;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_282;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_283;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_284;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_285;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_286;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_287;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_288;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_289;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_290;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_291;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_292;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_293;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_294;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_295;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_296;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_297;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_298;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_299;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_300;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_301;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_302;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_303;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_304;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_305;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_306;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_307;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_308;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_309;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_310;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_311;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_312;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_313;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_314;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_315;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_316;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_317;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_318;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_319;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_320;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_321;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_322;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_323;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_324;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_325;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_326;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_327;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_328;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_329;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_330;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_331;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_332;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_333;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_334;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_335;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_336;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_337;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_338;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_339;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_340;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_341;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_342;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_343;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_344;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_345;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_346;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_347;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_348;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_349;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_350;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_351;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_352;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_353;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_354;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_355;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_356;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_357;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_358;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_359;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_360;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_361;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_362;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_363;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_364;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_365;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_366;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_367;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_368;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_369;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_370;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_371;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_372;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_373;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_374;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_375;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_376;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_377;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_378;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_379;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_380;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_381;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_382;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_383;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_384;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_385;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_386;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_387;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_388;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_389;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_390;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_391;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_392;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_393;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_394;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_395;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_396;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_397;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_398;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_399;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_400;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_401;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_402;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_403;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_404;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_405;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_406;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_407;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_408;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_409;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_410;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_411;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_412;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_413;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_414;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_415;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_416;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_417;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_418;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_419;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_420;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_421;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_422;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_423;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_424;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_425;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_426;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_427;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_428;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_429;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_430;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_431;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_432;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_433;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_434;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_435;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_436;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_437;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_438;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_439;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_440;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_441;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_442;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_443;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_444;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_445;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_446;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_447;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_448;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_449;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_450;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_451;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_452;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_453;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_454;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_455;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_456;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_457;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_458;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_459;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_460;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_461;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_462;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_463;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_464;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_465;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_466;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_467;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_468;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_469;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_470;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_471;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_472;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_473;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_474;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_475;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_476;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_477;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_478;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_479;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_480;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_481;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_482;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_483;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_484;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_485;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_486;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_487;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_488;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_489;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_490;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_491;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_492;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_493;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_494;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_495;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_496;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_497;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_498;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_499;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_500;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_501;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_502;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_503;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_504;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_505;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_506;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_507;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_508;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_509;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_510;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_511;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_512;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_513;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_514;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_515;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_516;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_517;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_518;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_519;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_520;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_521;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_522;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_523;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_524;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_525;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_526;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_527;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_528;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_529;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_530;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_531;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_532;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_533;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_534;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_535;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_536;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_537;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_538;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_539;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_540;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_541;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_542;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_543;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_544;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_545;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_546;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_547;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_548;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_549;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_550;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_551;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_552;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_553;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_554;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_555;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_556;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_557;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_558;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_559;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_560;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_561;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_562;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_563;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_564;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_565;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_566;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_567;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_568;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_569;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_570;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_571;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_572;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_573;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_574;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_575;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_576;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_577;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_578;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_579;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_580;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_581;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_582;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_583;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_584;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_585;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_586;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_587;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_588;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_589;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_590;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_591;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_592;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_593;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_594;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_595;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_596;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_597;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_598;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_599;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_600;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_601;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_602;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_603;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_604;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_605;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_606;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_607;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_608;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_609;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_610;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_611;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_612;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_613;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_614;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_615;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_616;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_617;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_618;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_619;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_620;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_621;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_622;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_623;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_624;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_625;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_626;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_627;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_628;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_629;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_630;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_631;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_632;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_633;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_634;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_635;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_636;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_637;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_638;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_639;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_640;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_641;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_642;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_643;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_644;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_645;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_646;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_647;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_648;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_649;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_650;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_651;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_652;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_653;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_654;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_655;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_656;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_657;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_658;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_659;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_660;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_661;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_662;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_663;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_664;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_665;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_666;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_667;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_668;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_669;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_670;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_671;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_672;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_673;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_674;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_675;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_676;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_677;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_678;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_679;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_680;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_681;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_682;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_683;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_684;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_685;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_686;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_687;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_688;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_689;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_690;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_691;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_692;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_693;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_694;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_695;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_696;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_697;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_698;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_699;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_700;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_701;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_702;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_703;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_704;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_705;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_706;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_707;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_708;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_709;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_710;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_711;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_712;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_713;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_714;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_715;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_716;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_717;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_718;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_719;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_720;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_721;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_722;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_723;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_724;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_725;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_726;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_727;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_728;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_729;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_730;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_731;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_732;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_733;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_734;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_735;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_736;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_737;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_738;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_739;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_740;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_741;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_742;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_743;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_744;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_745;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_746;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_747;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_748;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_749;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_750;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_751;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_752;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_753;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_754;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_755;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_756;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_757;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_758;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_759;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_760;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_761;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_762;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_763;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_764;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_765;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_766;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_767;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_768;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_769;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_770;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_771;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_772;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_773;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_774;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_775;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_776;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_777;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_778;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_779;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_780;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_781;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_782;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_783;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_784;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_785;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_786;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_787;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_788;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_789;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_790;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_791;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_792;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_793;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_794;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_795;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_796;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_797;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_798;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_799;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_800;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_801;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_802;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_803;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_804;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_805;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_806;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_807;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_808;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_809;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_810;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_811;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_812;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_813;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_814;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_815;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_816;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_817;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_818;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_819;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_820;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_821;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_822;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_823;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_824;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_825;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_826;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_827;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_828;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_829;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_830;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_831;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_832;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_833;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_834;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_835;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_836;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_837;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_838;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_839;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_840;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_841;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_842;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_843;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_844;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_845;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_846;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_847;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_848;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_849;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_850;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_851;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_852;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_853;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_854;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_855;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_856;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_857;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_858;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_859;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_860;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_861;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_862;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_863;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_864;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_865;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_866;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_867;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_868;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_869;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_870;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_871;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_872;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_873;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_874;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_875;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_876;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_877;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_878;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_879;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_880;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_881;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_882;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_883;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_884;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_885;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_886;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_887;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_888;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_889;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_890;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_891;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_892;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_893;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_894;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_895;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_896;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_897;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_898;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_899;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_900;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_901;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_902;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_903;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_904;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_905;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_906;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_907;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_908;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_909;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_910;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_911;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_912;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_913;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_914;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_915;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_916;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_917;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_918;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_919;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_920;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_921;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_922;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_923;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_924;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_925;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_926;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_927;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_928;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_929;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_930;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_931;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_932;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_933;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_934;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_935;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_936;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_937;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_938;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_939;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_940;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_941;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_942;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_943;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_944;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_945;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_946;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_947;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_948;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_949;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_950;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_951;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_952;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_953;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_954;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_955;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_956;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_957;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_958;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_959;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_960;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_961;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_962;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_963;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_964;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_965;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_966;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_967;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_968;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_969;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_970;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_971;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_972;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_973;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_974;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_975;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_976;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_977;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_978;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_979;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_980;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_981;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_982;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_983;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_984;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_985;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_986;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_987;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_988;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_989;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_990;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_991;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_992;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_993;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_994;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_995;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_996;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_997;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_998;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_999;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1000;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1001;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1002;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1003;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1004;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1005;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1006;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1007;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1008;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1009;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1010;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1011;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1012;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1013;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1014;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1015;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1016;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1017;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1018;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1019;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1020;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1021;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1022;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1023;
        
        [NativeName("Type", "DXGI_RGB [1025]")]
        [NativeName("Type.Name", "DXGI_RGB [1025]")]
        [NativeName("Name", "GammaCurve")]
        public Rgb GammaCurve_1024;
    }
}
