module Program

open Fable.Remoting.Json
open Fable.Remoting.FastJson
open Newtonsoft.Json
open System.Diagnostics

type LargeUnion =
    | Case1
    | Case2
    | Case3
    | Case4
    | Case5
    | Case6
    | Case7
    | Case8
    | Case9
    | Case10
    | Case11
    | Case12
    | Case13
    | Case14
    | Case15
    | Case16
    | Case17
    | Case18
    | Case19
    | Case20
    | Case21
    | Case22
    | Case23
    | Case24
    | Case25
    | Case26
    | Case27
    | Case28
    | Case29
    | Case30
    | Case31
    | Case32
    | Case33
    | Case34
    | Case35
    | Case36
    | Case37
    | Case38
    | Case39
    | Case40
    | Case41
    | Case42
    | Case43
    | Case44
    | Case45
    | Case46
    | Case47
    | Case48
    | Case49
    | Case50
    | Case51
    | Case52
    | Case53
    | Case54
    | Case55
    | Case56
    | Case57
    | Case58
    | Case59
    | Case60
    | Case61
    | Case62
    | Case63
    | Case64
    | Case65
    | Case66
    | Case67
    | Case68
    | Case69
    | Case70
    | Case71
    | Case72
    | Case73
    | Case74
    | Case75
    | Case76
    | Case77
    | Case78
    | Case79
    | Case80
    | Case81
    | Case82
    | Case83
    | Case84
    | Case85
    | Case86
    | Case87
    | Case88
    | Case89
    | Case90
    | Case91
    | Case92
    | Case93
    | Case94
    | Case95
    | Case96
    | Case97
    | Case98
    | Case99
    | Case100
    | Case101
    | Case102
    | Case103
    | Case104
    | Case105
    | Case106
    | Case107
    | Case108
    | Case109
    | Case110
    | Case111
    | Case112
    | Case113
    | Case114
    | Case115
    | Case116
    | Case117
    | Case118
    | Case119
    | Case120
    | Case121
    | Case122
    | Case123
    | Case124
    | Case125
    | Case126
    | Case127
    | Case128
    | Case129
    | Case130
    | Case131
    | Case132
    | Case133
    | Case134
    | Case135
    | Case136
    | Case137
    | Case138
    | Case139
    | Case140
    | Case141
    | Case142
    | Case143
    | Case144
    | Case145
    | Case146
    | Case147
    | Case148
    | Case149
    | Case150
    | Case151
    | Case152
    | Case153
    | Case154
    | Case155
    | Case156
    | Case157
    | Case158
    | Case159
    | Case160
    | Case161
    | Case162
    | Case163
    | Case164
    | Case165
    | Case166
    | Case167
    | Case168
    | Case169
    | Case170
    | Case171
    | Case172
    | Case173
    | Case174
    | Case175
    | Case176
    | Case177
    | Case178
    | Case179
    | Case180
    | Case181
    | Case182
    | Case183
    | Case184
    | Case185
    | Case186
    | Case187
    | Case188
    | Case189
    | Case190
    | Case191
    | Case192
    | Case193
    | Case194
    | Case195
    | Case196
    | Case197
    | Case198
    | Case199
    | Case200
    | Case201
    | Case202
    | Case203
    | Case204
    | Case205
    | Case206
    | Case207
    | Case208
    | Case209
    | Case210
    | Case211
    | Case212
    | Case213
    | Case214
    | Case215
    | Case216
    | Case217
    | Case218
    | Case219
    | Case220
    | Case221
    | Case222
    | Case223
    | Case224
    | Case225
    | Case226
    | Case227
    | Case228
    | Case229
    | Case230
    | Case231
    | Case232
    | Case233
    | Case234
    | Case235
    | Case236
    | Case237
    | Case238
    | Case239
    | Case240
    | Case241
    | Case242
    | Case243
    | Case244
    | Case245
    | Case246
    | Case247
    | Case248
    | Case249
    | Case250
    | Case251
    | Case252
    | Case253
    | Case254
    | Case255
    | Case256
    | Case257
    | Case258
    | Case259
    | Case260
    | Case261
    | Case262
    | Case263
    | Case264
    | Case265
    | Case266
    | Case267
    | Case268
    | Case269
    | Case270
    | Case271
    | Case272
    | Case273
    | Case274
    | Case275
    | Case276
    | Case277
    | Case278
    | Case279
    | Case280
    | Case281
    | Case282
    | Case283
    | Case284
    | Case285
    | Case286
    | Case287
    | Case288
    | Case289
    | Case290
    | Case291
    | Case292
    | Case293
    | Case294
    | Case295
    | Case296
    | Case297
    | Case298
    | Case299
    | Case300
    | Case301
    | Case302
    | Case303
    | Case304
    | Case305
    | Case306
    | Case307
    | Case308
    | Case309
    | Case310
    | Case311
    | Case312
    | Case313
    | Case314
    | Case315
    | Case316
    | Case317
    | Case318
    | Case319
    | Case320
    | Case321
    | Case322
    | Case323
    | Case324
    | Case325
    | Case326
    | Case327
    | Case328
    | Case329
    | Case330
    | Case331
    | Case332
    | Case333
    | Case334
    | Case335
    | Case336
    | Case337
    | Case338
    | Case339
    | Case340
    | Case341
    | Case342
    | Case343
    | Case344
    | Case345
    | Case346
    | Case347
    | Case348
    | Case349
    | Case350
    | Case351
    | Case352
    | Case353
    | Case354
    | Case355
    | Case356
    | Case357
    | Case358
    | Case359
    | Case360
    | Case361
    | Case362
    | Case363
    | Case364
    | Case365
    | Case366
    | Case367
    | Case368
    | Case369
    | Case370
    | Case371
    | Case372
    | Case373
    | Case374
    | Case375
    | Case376
    | Case377
    | Case378
    | Case379
    | Case380
    | Case381
    | Case382
    | Case383
    | Case384
    | Case385
    | Case386
    | Case387
    | Case388
    | Case389
    | Case390
    | Case391
    | Case392
    | Case393
    | Case394
    | Case395
    | Case396
    | Case397
    | Case398
    | Case399
    | Case400
    | Case401
    | Case402
    | Case403
    | Case404
    | Case405
    | Case406
    | Case407
    | Case408
    | Case409
    | Case410
    | Case411
    | Case412
    | Case413
    | Case414
    | Case415
    | Case416
    | Case417
    | Case418
    | Case419
    | Case420
    | Case421
    | Case422
    | Case423
    | Case424
    | Case425
    | Case426
    | Case427
    | Case428
    | Case429
    | Case430
    | Case431
    | Case432
    | Case433
    | Case434
    | Case435
    | Case436
    | Case437
    | Case438
    | Case439
    | Case440
    | Case441
    | Case442
    | Case443
    | Case444
    | Case445
    | Case446
    | Case447
    | Case448
    | Case449
    | Case450
    | Case451
    | Case452
    | Case453
    | Case454
    | Case455
    | Case456
    | Case457
    | Case458
    | Case459
    | Case460
    | Case461
    | Case462
    | Case463
    | Case464
    | Case465
    | Case466
    | Case467
    | Case468
    | Case469
    | Case470
    | Case471
    | Case472
    | Case473
    | Case474
    | Case475
    | Case476
    | Case477
    | Case478
    | Case479
    | Case480
    | Case481
    | Case482
    | Case483
    | Case484
    | Case485
    | Case486
    | Case487
    | Case488
    | Case489
    | Case490
    | Case491
    | Case492
    | Case493
    | Case494
    | Case495
    | Case496
    | Case497
    | Case498
    | Case499
    | Case500

type LargeRecord = {
    Map1: Map<LargeUnion, string>
    Map2: Map<LargeUnion, string>
    Map3: Map<LargeUnion, string>
    Map4: Map<LargeUnion, string>
    Map5: Map<LargeUnion, string>
    Map6: Map<LargeUnion, string>
    Map7: Map<LargeUnion, string>
    Map8: Map<LargeUnion, string>
    Map9: Map<LargeUnion, string>
    Map10: Map<LargeUnion, string>
    Map11: Map<LargeUnion, string>
    Map12: Map<LargeUnion, string>
    Map13: Map<LargeUnion, string>
    Map14: Map<LargeUnion, string>
    Map15: Map<LargeUnion, string>
    Map16: Map<LargeUnion, string>
    Map17: Map<LargeUnion, string>
    Map18: Map<LargeUnion, string>
    Map19: Map<LargeUnion, string>
    Map20: Map<LargeUnion, string>
    Map21: Map<LargeUnion, string>
    Map22: Map<LargeUnion, string>
    Map23: Map<LargeUnion, string>
    Map24: Map<LargeUnion, string>
    Map25: Map<LargeUnion, string>
    Map26: Map<LargeUnion, string>
    Map27: Map<LargeUnion, string>
    Map28: Map<LargeUnion, string>
    Map29: Map<LargeUnion, string>
    Map30: Map<LargeUnion, string>
    Map31: Map<LargeUnion, string>
    Map32: Map<LargeUnion, string>
    Map33: Map<LargeUnion, string>
    Map34: Map<LargeUnion, string>
    Map35: Map<LargeUnion, string>
    Map36: Map<LargeUnion, string>
    Map37: Map<LargeUnion, string>
    Map38: Map<LargeUnion, string>
    Map39: Map<LargeUnion, string>
    Map40: Map<LargeUnion, string>
    Map41: Map<LargeUnion, string>
    Map42: Map<LargeUnion, string>
    Map43: Map<LargeUnion, string>
    Map44: Map<LargeUnion, string>
    Map45: Map<LargeUnion, string>
    Map46: Map<LargeUnion, string>
    Map47: Map<LargeUnion, string>
    Map48: Map<LargeUnion, string>
    Map49: Map<LargeUnion, string>
    Map50: Map<LargeUnion, string>
    Map51: Map<LargeUnion, string>
    Map52: Map<LargeUnion, string>
    Map53: Map<LargeUnion, string>
    Map54: Map<LargeUnion, string>
    Map55: Map<LargeUnion, string>
    Map56: Map<LargeUnion, string>
    Map57: Map<LargeUnion, string>
    Map58: Map<LargeUnion, string>
    Map59: Map<LargeUnion, string>
    Map60: Map<LargeUnion, string>
    Map61: Map<LargeUnion, string>
    Map62: Map<LargeUnion, string>
    Map63: Map<LargeUnion, string>
    Map64: Map<LargeUnion, string>
    Map65: Map<LargeUnion, string>
    Map66: Map<LargeUnion, string>
    Map67: Map<LargeUnion, string>
    Map68: Map<LargeUnion, string>
    Map69: Map<LargeUnion, string>
    Map70: Map<LargeUnion, string>
    Map71: Map<LargeUnion, string>
    Map72: Map<LargeUnion, string>
    Map73: Map<LargeUnion, string>
    Map74: Map<LargeUnion, string>
    Map75: Map<LargeUnion, string>
    Map76: Map<LargeUnion, string>
    Map77: Map<LargeUnion, string>
    Map78: Map<LargeUnion, string>
    Map79: Map<LargeUnion, string>
    Map80: Map<LargeUnion, string>
    Map81: Map<LargeUnion, string>
    Map82: Map<LargeUnion, string>
    Map83: Map<LargeUnion, string>
    Map84: Map<LargeUnion, string>
    Map85: Map<LargeUnion, string>
    Map86: Map<LargeUnion, string>
    Map87: Map<LargeUnion, string>
    Map88: Map<LargeUnion, string>
    Map89: Map<LargeUnion, string>
    Map90: Map<LargeUnion, string>
    Map91: Map<LargeUnion, string>
    Map92: Map<LargeUnion, string>
    Map93: Map<LargeUnion, string>
    Map94: Map<LargeUnion, string>
    Map95: Map<LargeUnion, string>
    Map96: Map<LargeUnion, string>
    Map97: Map<LargeUnion, string>
    Map98: Map<LargeUnion, string>
    Map99: Map<LargeUnion, string>
    Map100: Map<LargeUnion, string>
    Map101: Map<LargeUnion, string>
    Map102: Map<LargeUnion, string>
    Map103: Map<LargeUnion, string>
    Map104: Map<LargeUnion, string>
    Map105: Map<LargeUnion, string>
    Map106: Map<LargeUnion, string>
    Map107: Map<LargeUnion, string>
    Map108: Map<LargeUnion, string>
    Map109: Map<LargeUnion, string>
    Map110: Map<LargeUnion, string>
    Map111: Map<LargeUnion, string>
    Map112: Map<LargeUnion, string>
    Map113: Map<LargeUnion, string>
    Map114: Map<LargeUnion, string>
    Map115: Map<LargeUnion, string>
    Map116: Map<LargeUnion, string>
    Map117: Map<LargeUnion, string>
    Map118: Map<LargeUnion, string>
    Map119: Map<LargeUnion, string>
    Map120: Map<LargeUnion, string>
    Map121: Map<LargeUnion, string>
    Map122: Map<LargeUnion, string>
    Map123: Map<LargeUnion, string>
    Map124: Map<LargeUnion, string>
    Map125: Map<LargeUnion, string>
    Map126: Map<LargeUnion, string>
    Map127: Map<LargeUnion, string>
    Map128: Map<LargeUnion, string>
    Map129: Map<LargeUnion, string>
    Map130: Map<LargeUnion, string>
    Map131: Map<LargeUnion, string>
    Map132: Map<LargeUnion, string>
    Map133: Map<LargeUnion, string>
    Map134: Map<LargeUnion, string>
    Map135: Map<LargeUnion, string>
    Map136: Map<LargeUnion, string>
    Map137: Map<LargeUnion, string>
    Map138: Map<LargeUnion, string>
    Map139: Map<LargeUnion, string>
    Map140: Map<LargeUnion, string>
    Map141: Map<LargeUnion, string>
    Map142: Map<LargeUnion, string>
    Map143: Map<LargeUnion, string>
    Map144: Map<LargeUnion, string>
    Map145: Map<LargeUnion, string>
    Map146: Map<LargeUnion, string>
    Map147: Map<LargeUnion, string>
    Map148: Map<LargeUnion, string>
    Map149: Map<LargeUnion, string>
    Map150: Map<LargeUnion, string>
    Map151: Map<LargeUnion, string>
    Map152: Map<LargeUnion, string>
    Map153: Map<LargeUnion, string>
    Map154: Map<LargeUnion, string>
    Map155: Map<LargeUnion, string>
    Map156: Map<LargeUnion, string>
    Map157: Map<LargeUnion, string>
    Map158: Map<LargeUnion, string>
    Map159: Map<LargeUnion, string>
    Map160: Map<LargeUnion, string>
    Map161: Map<LargeUnion, string>
    Map162: Map<LargeUnion, string>
    Map163: Map<LargeUnion, string>
    Map164: Map<LargeUnion, string>
    Map165: Map<LargeUnion, string>
    Map166: Map<LargeUnion, string>
    Map167: Map<LargeUnion, string>
    Map168: Map<LargeUnion, string>
    Map169: Map<LargeUnion, string>
    Map170: Map<LargeUnion, string>
    Map171: Map<LargeUnion, string>
    Map172: Map<LargeUnion, string>
    Map173: Map<LargeUnion, string>
    Map174: Map<LargeUnion, string>
    Map175: Map<LargeUnion, string>
    Map176: Map<LargeUnion, string>
    Map177: Map<LargeUnion, string>
    Map178: Map<LargeUnion, string>
    Map179: Map<LargeUnion, string>
    Map180: Map<LargeUnion, string>
    Map181: Map<LargeUnion, string>
    Map182: Map<LargeUnion, string>
    Map183: Map<LargeUnion, string>
    Map184: Map<LargeUnion, string>
    Map185: Map<LargeUnion, string>
    Map186: Map<LargeUnion, string>
    Map187: Map<LargeUnion, string>
    Map188: Map<LargeUnion, string>
    Map189: Map<LargeUnion, string>
    Map190: Map<LargeUnion, string>
    Map191: Map<LargeUnion, string>
    Map192: Map<LargeUnion, string>
    Map193: Map<LargeUnion, string>
    Map194: Map<LargeUnion, string>
    Map195: Map<LargeUnion, string>
    Map196: Map<LargeUnion, string>
    Map197: Map<LargeUnion, string>
    Map198: Map<LargeUnion, string>
    Map199: Map<LargeUnion, string>
    Map200: Map<LargeUnion, string>
}

let data : LargeRecord = {
    Map1 = Map.ofList [ Case1, "some string here"; Case2, "another string here" ]
    Map2 = Map.ofList [ Case2, "some string here"; Case3, "another string here" ]
    Map3 = Map.ofList [ Case3, "some string here"; Case4, "another string here" ]
    Map4 = Map.ofList [ Case4, "some string here"; Case5, "another string here" ]
    Map5 = Map.ofList [ Case5, "some string here"; Case6, "another string here" ]
    Map6 = Map.ofList [ Case6, "some string here"; Case7, "another string here" ]
    Map7 = Map.ofList [ Case7, "some string here"; Case8, "another string here" ]
    Map8 = Map.ofList [ Case8, "some string here"; Case9, "another string here" ]
    Map9 = Map.ofList [ Case9, "some string here"; Case10, "another string here" ]
    Map10 = Map.ofList [ Case10, "some string here"; Case11, "another string here" ]
    Map11 = Map.ofList [ Case11, "some string here"; Case12, "another string here" ]
    Map12 = Map.ofList [ Case12, "some string here"; Case13, "another string here" ]
    Map13 = Map.ofList [ Case13, "some string here"; Case14, "another string here" ]
    Map14 = Map.ofList [ Case14, "some string here"; Case15, "another string here" ]
    Map15 = Map.ofList [ Case15, "some string here"; Case16, "another string here" ]
    Map16 = Map.ofList [ Case16, "some string here"; Case17, "another string here" ]
    Map17 = Map.ofList [ Case17, "some string here"; Case18, "another string here" ]
    Map18 = Map.ofList [ Case18, "some string here"; Case19, "another string here" ]
    Map19 = Map.ofList [ Case19, "some string here"; Case20, "another string here" ]
    Map20 = Map.ofList [ Case20, "some string here"; Case21, "another string here" ]
    Map21 = Map.ofList [ Case21, "some string here"; Case22, "another string here" ]
    Map22 = Map.ofList [ Case22, "some string here"; Case23, "another string here" ]
    Map23 = Map.ofList [ Case23, "some string here"; Case24, "another string here" ]
    Map24 = Map.ofList [ Case24, "some string here"; Case25, "another string here" ]
    Map25 = Map.ofList [ Case25, "some string here"; Case26, "another string here" ]
    Map26 = Map.ofList [ Case26, "some string here"; Case27, "another string here" ]
    Map27 = Map.ofList [ Case27, "some string here"; Case28, "another string here" ]
    Map28 = Map.ofList [ Case28, "some string here"; Case29, "another string here" ]
    Map29 = Map.ofList [ Case29, "some string here"; Case30, "another string here" ]
    Map30 = Map.ofList [ Case30, "some string here"; Case31, "another string here" ]
    Map31 = Map.ofList [ Case31, "some string here"; Case32, "another string here" ]
    Map32 = Map.ofList [ Case32, "some string here"; Case33, "another string here" ]
    Map33 = Map.ofList [ Case33, "some string here"; Case34, "another string here" ]
    Map34 = Map.ofList [ Case34, "some string here"; Case35, "another string here" ]
    Map35 = Map.ofList [ Case35, "some string here"; Case36, "another string here" ]
    Map36 = Map.ofList [ Case36, "some string here"; Case37, "another string here" ]
    Map37 = Map.ofList [ Case37, "some string here"; Case38, "another string here" ]
    Map38 = Map.ofList [ Case38, "some string here"; Case39, "another string here" ]
    Map39 = Map.ofList [ Case39, "some string here"; Case40, "another string here" ]
    Map40 = Map.ofList [ Case40, "some string here"; Case41, "another string here" ]
    Map41 = Map.ofList [ Case41, "some string here"; Case42, "another string here" ]
    Map42 = Map.ofList [ Case42, "some string here"; Case43, "another string here" ]
    Map43 = Map.ofList [ Case43, "some string here"; Case44, "another string here" ]
    Map44 = Map.ofList [ Case44, "some string here"; Case45, "another string here" ]
    Map45 = Map.ofList [ Case45, "some string here"; Case46, "another string here" ]
    Map46 = Map.ofList [ Case46, "some string here"; Case47, "another string here" ]
    Map47 = Map.ofList [ Case47, "some string here"; Case48, "another string here" ]
    Map48 = Map.ofList [ Case48, "some string here"; Case49, "another string here" ]
    Map49 = Map.ofList [ Case49, "some string here"; Case50, "another string here" ]
    Map50 = Map.ofList [ Case50, "some string here"; Case51, "another string here" ]
    Map51 = Map.ofList [ Case51, "some string here"; Case52, "another string here" ]
    Map52 = Map.ofList [ Case52, "some string here"; Case53, "another string here" ]
    Map53 = Map.ofList [ Case53, "some string here"; Case54, "another string here" ]
    Map54 = Map.ofList [ Case54, "some string here"; Case55, "another string here" ]
    Map55 = Map.ofList [ Case55, "some string here"; Case56, "another string here" ]
    Map56 = Map.ofList [ Case56, "some string here"; Case57, "another string here" ]
    Map57 = Map.ofList [ Case57, "some string here"; Case58, "another string here" ]
    Map58 = Map.ofList [ Case58, "some string here"; Case59, "another string here" ]
    Map59 = Map.ofList [ Case59, "some string here"; Case60, "another string here" ]
    Map60 = Map.ofList [ Case60, "some string here"; Case61, "another string here" ]
    Map61 = Map.ofList [ Case61, "some string here"; Case62, "another string here" ]
    Map62 = Map.ofList [ Case62, "some string here"; Case63, "another string here" ]
    Map63 = Map.ofList [ Case63, "some string here"; Case64, "another string here" ]
    Map64 = Map.ofList [ Case64, "some string here"; Case65, "another string here" ]
    Map65 = Map.ofList [ Case65, "some string here"; Case66, "another string here" ]
    Map66 = Map.ofList [ Case66, "some string here"; Case67, "another string here" ]
    Map67 = Map.ofList [ Case67, "some string here"; Case68, "another string here" ]
    Map68 = Map.ofList [ Case68, "some string here"; Case69, "another string here" ]
    Map69 = Map.ofList [ Case69, "some string here"; Case70, "another string here" ]
    Map70 = Map.ofList [ Case70, "some string here"; Case71, "another string here" ]
    Map71 = Map.ofList [ Case71, "some string here"; Case72, "another string here" ]
    Map72 = Map.ofList [ Case72, "some string here"; Case73, "another string here" ]
    Map73 = Map.ofList [ Case73, "some string here"; Case74, "another string here" ]
    Map74 = Map.ofList [ Case74, "some string here"; Case75, "another string here" ]
    Map75 = Map.ofList [ Case75, "some string here"; Case76, "another string here" ]
    Map76 = Map.ofList [ Case76, "some string here"; Case77, "another string here" ]
    Map77 = Map.ofList [ Case77, "some string here"; Case78, "another string here" ]
    Map78 = Map.ofList [ Case78, "some string here"; Case79, "another string here" ]
    Map79 = Map.ofList [ Case79, "some string here"; Case80, "another string here" ]
    Map80 = Map.ofList [ Case80, "some string here"; Case81, "another string here" ]
    Map81 = Map.ofList [ Case81, "some string here"; Case82, "another string here" ]
    Map82 = Map.ofList [ Case82, "some string here"; Case83, "another string here" ]
    Map83 = Map.ofList [ Case83, "some string here"; Case84, "another string here" ]
    Map84 = Map.ofList [ Case84, "some string here"; Case85, "another string here" ]
    Map85 = Map.ofList [ Case85, "some string here"; Case86, "another string here" ]
    Map86 = Map.ofList [ Case86, "some string here"; Case87, "another string here" ]
    Map87 = Map.ofList [ Case87, "some string here"; Case88, "another string here" ]
    Map88 = Map.ofList [ Case88, "some string here"; Case89, "another string here" ]
    Map89 = Map.ofList [ Case89, "some string here"; Case90, "another string here" ]
    Map90 = Map.ofList [ Case90, "some string here"; Case91, "another string here" ]
    Map91 = Map.ofList [ Case91, "some string here"; Case92, "another string here" ]
    Map92 = Map.ofList [ Case92, "some string here"; Case93, "another string here" ]
    Map93 = Map.ofList [ Case93, "some string here"; Case94, "another string here" ]
    Map94 = Map.ofList [ Case94, "some string here"; Case95, "another string here" ]
    Map95 = Map.ofList [ Case95, "some string here"; Case96, "another string here" ]
    Map96 = Map.ofList [ Case96, "some string here"; Case97, "another string here" ]
    Map97 = Map.ofList [ Case97, "some string here"; Case98, "another string here" ]
    Map98 = Map.ofList [ Case98, "some string here"; Case99, "another string here" ]
    Map99 = Map.ofList [ Case99, "some string here"; Case100, "another string here" ]
    Map100 = Map.ofList [ Case100, "some string here"; Case101, "another string here" ]
    Map101 = Map.ofList [ Case101, "some string here"; Case102, "another string here" ]
    Map102 = Map.ofList [ Case102, "some string here"; Case103, "another string here" ]
    Map103 = Map.ofList [ Case103, "some string here"; Case104, "another string here" ]
    Map104 = Map.ofList [ Case104, "some string here"; Case105, "another string here" ]
    Map105 = Map.ofList [ Case105, "some string here"; Case106, "another string here" ]
    Map106 = Map.ofList [ Case106, "some string here"; Case107, "another string here" ]
    Map107 = Map.ofList [ Case107, "some string here"; Case108, "another string here" ]
    Map108 = Map.ofList [ Case108, "some string here"; Case109, "another string here" ]
    Map109 = Map.ofList [ Case109, "some string here"; Case110, "another string here" ]
    Map110 = Map.ofList [ Case110, "some string here"; Case111, "another string here" ]
    Map111 = Map.ofList [ Case111, "some string here"; Case112, "another string here" ]
    Map112 = Map.ofList [ Case112, "some string here"; Case113, "another string here" ]
    Map113 = Map.ofList [ Case113, "some string here"; Case114, "another string here" ]
    Map114 = Map.ofList [ Case114, "some string here"; Case115, "another string here" ]
    Map115 = Map.ofList [ Case115, "some string here"; Case116, "another string here" ]
    Map116 = Map.ofList [ Case116, "some string here"; Case117, "another string here" ]
    Map117 = Map.ofList [ Case117, "some string here"; Case118, "another string here" ]
    Map118 = Map.ofList [ Case118, "some string here"; Case119, "another string here" ]
    Map119 = Map.ofList [ Case119, "some string here"; Case120, "another string here" ]
    Map120 = Map.ofList [ Case120, "some string here"; Case121, "another string here" ]
    Map121 = Map.ofList [ Case121, "some string here"; Case122, "another string here" ]
    Map122 = Map.ofList [ Case122, "some string here"; Case123, "another string here" ]
    Map123 = Map.ofList [ Case123, "some string here"; Case124, "another string here" ]
    Map124 = Map.ofList [ Case124, "some string here"; Case125, "another string here" ]
    Map125 = Map.ofList [ Case125, "some string here"; Case126, "another string here" ]
    Map126 = Map.ofList [ Case126, "some string here"; Case127, "another string here" ]
    Map127 = Map.ofList [ Case127, "some string here"; Case128, "another string here" ]
    Map128 = Map.ofList [ Case128, "some string here"; Case129, "another string here" ]
    Map129 = Map.ofList [ Case129, "some string here"; Case130, "another string here" ]
    Map130 = Map.ofList [ Case130, "some string here"; Case131, "another string here" ]
    Map131 = Map.ofList [ Case131, "some string here"; Case132, "another string here" ]
    Map132 = Map.ofList [ Case132, "some string here"; Case133, "another string here" ]
    Map133 = Map.ofList [ Case133, "some string here"; Case134, "another string here" ]
    Map134 = Map.ofList [ Case134, "some string here"; Case135, "another string here" ]
    Map135 = Map.ofList [ Case135, "some string here"; Case136, "another string here" ]
    Map136 = Map.ofList [ Case136, "some string here"; Case137, "another string here" ]
    Map137 = Map.ofList [ Case137, "some string here"; Case138, "another string here" ]
    Map138 = Map.ofList [ Case138, "some string here"; Case139, "another string here" ]
    Map139 = Map.ofList [ Case139, "some string here"; Case140, "another string here" ]
    Map140 = Map.ofList [ Case140, "some string here"; Case141, "another string here" ]
    Map141 = Map.ofList [ Case141, "some string here"; Case142, "another string here" ]
    Map142 = Map.ofList [ Case142, "some string here"; Case143, "another string here" ]
    Map143 = Map.ofList [ Case143, "some string here"; Case144, "another string here" ]
    Map144 = Map.ofList [ Case144, "some string here"; Case145, "another string here" ]
    Map145 = Map.ofList [ Case145, "some string here"; Case146, "another string here" ]
    Map146 = Map.ofList [ Case146, "some string here"; Case147, "another string here" ]
    Map147 = Map.ofList [ Case147, "some string here"; Case148, "another string here" ]
    Map148 = Map.ofList [ Case148, "some string here"; Case149, "another string here" ]
    Map149 = Map.ofList [ Case149, "some string here"; Case150, "another string here" ]
    Map150 = Map.ofList [ Case150, "some string here"; Case151, "another string here" ]
    Map151 = Map.ofList [ Case151, "some string here"; Case152, "another string here" ]
    Map152 = Map.ofList [ Case152, "some string here"; Case153, "another string here" ]
    Map153 = Map.ofList [ Case153, "some string here"; Case154, "another string here" ]
    Map154 = Map.ofList [ Case154, "some string here"; Case155, "another string here" ]
    Map155 = Map.ofList [ Case155, "some string here"; Case156, "another string here" ]
    Map156 = Map.ofList [ Case156, "some string here"; Case157, "another string here" ]
    Map157 = Map.ofList [ Case157, "some string here"; Case158, "another string here" ]
    Map158 = Map.ofList [ Case158, "some string here"; Case159, "another string here" ]
    Map159 = Map.ofList [ Case159, "some string here"; Case160, "another string here" ]
    Map160 = Map.ofList [ Case160, "some string here"; Case161, "another string here" ]
    Map161 = Map.ofList [ Case161, "some string here"; Case162, "another string here" ]
    Map162 = Map.ofList [ Case162, "some string here"; Case163, "another string here" ]
    Map163 = Map.ofList [ Case163, "some string here"; Case164, "another string here" ]
    Map164 = Map.ofList [ Case164, "some string here"; Case165, "another string here" ]
    Map165 = Map.ofList [ Case165, "some string here"; Case166, "another string here" ]
    Map166 = Map.ofList [ Case166, "some string here"; Case167, "another string here" ]
    Map167 = Map.ofList [ Case167, "some string here"; Case168, "another string here" ]
    Map168 = Map.ofList [ Case168, "some string here"; Case169, "another string here" ]
    Map169 = Map.ofList [ Case169, "some string here"; Case170, "another string here" ]
    Map170 = Map.ofList [ Case170, "some string here"; Case171, "another string here" ]
    Map171 = Map.ofList [ Case171, "some string here"; Case172, "another string here" ]
    Map172 = Map.ofList [ Case172, "some string here"; Case173, "another string here" ]
    Map173 = Map.ofList [ Case173, "some string here"; Case174, "another string here" ]
    Map174 = Map.ofList [ Case174, "some string here"; Case175, "another string here" ]
    Map175 = Map.ofList [ Case175, "some string here"; Case176, "another string here" ]
    Map176 = Map.ofList [ Case176, "some string here"; Case177, "another string here" ]
    Map177 = Map.ofList [ Case177, "some string here"; Case178, "another string here" ]
    Map178 = Map.ofList [ Case178, "some string here"; Case179, "another string here" ]
    Map179 = Map.ofList [ Case179, "some string here"; Case180, "another string here" ]
    Map180 = Map.ofList [ Case180, "some string here"; Case181, "another string here" ]
    Map181 = Map.ofList [ Case181, "some string here"; Case182, "another string here" ]
    Map182 = Map.ofList [ Case182, "some string here"; Case183, "another string here" ]
    Map183 = Map.ofList [ Case183, "some string here"; Case184, "another string here" ]
    Map184 = Map.ofList [ Case184, "some string here"; Case185, "another string here" ]
    Map185 = Map.ofList [ Case185, "some string here"; Case186, "another string here" ]
    Map186 = Map.ofList [ Case186, "some string here"; Case187, "another string here" ]
    Map187 = Map.ofList [ Case187, "some string here"; Case188, "another string here" ]
    Map188 = Map.ofList [ Case188, "some string here"; Case189, "another string here" ]
    Map189 = Map.ofList [ Case189, "some string here"; Case190, "another string here" ]
    Map190 = Map.ofList [ Case190, "some string here"; Case191, "another string here" ]
    Map191 = Map.ofList [ Case191, "some string here"; Case192, "another string here" ]
    Map192 = Map.ofList [ Case192, "some string here"; Case193, "another string here" ]
    Map193 = Map.ofList [ Case193, "some string here"; Case194, "another string here" ]
    Map194 = Map.ofList [ Case194, "some string here"; Case195, "another string here" ]
    Map195 = Map.ofList [ Case195, "some string here"; Case196, "another string here" ]
    Map196 = Map.ofList [ Case196, "some string here"; Case197, "another string here" ]
    Map197 = Map.ofList [ Case197, "some string here"; Case198, "another string here" ]
    Map198 = Map.ofList [ Case198, "some string here"; Case199, "another string here" ]
    Map199 = Map.ofList [ Case199, "some string here"; Case200, "another string here" ]
    Map200 = Map.ofList [ Case200, "some string here"; Case201, "another string here" ]
}

let tryConvert(converter) =
    let serialized = JsonConvert.SerializeObject(data, [| converter |])
    let deserialized = JsonConvert.DeserializeObject<LargeRecord>(serialized, [| converter |])
    ()

let time n f =
    let stopwatch = Stopwatch.StartNew()
    for i in 1 .. n do f()
    stopwatch.ElapsedMilliseconds / int64 n

let oldConverter = FableJsonConverter() :> JsonConverter
let newConverter = FastJsonConverter() :> JsonConverter
let serielizedData = JsonConvert.SerializeObject(data, [| oldConverter |])

let benchmark n =
    printfn "Running operations %d time(s)" n

    printfn "Old (Serialization): %A ms on average" (time n (fun () ->
        JsonConvert.SerializeObject(data, [| oldConverter |])
        |> ignore
    ))

    printfn "New (Serialization): %A ms on average" (time n (fun () ->
        JsonConvert.SerializeObject(data, [| newConverter |])
        |> ignore
    ))

    printfn "Old (Deserialization): %A ms on average" (time n (fun () ->
        JsonConvert.DeserializeObject<LargeRecord>(serielizedData, [| oldConverter |])
        |> ignore
    ))

    printfn "New (Deserialization): %A ms on average" (time n (fun () ->
        JsonConvert.DeserializeObject<LargeRecord>(serielizedData, [| newConverter |])
        |> ignore
    ))

    printfn "Old (Full convertion): %A ms on average" (time n (fun () -> tryConvert oldConverter))
    printfn "New (Full convertion): %A ms on average" (time n (fun () -> tryConvert newConverter))

benchmark 10