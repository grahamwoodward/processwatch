# CS_ARCH_HPPA, CS_MODE_HPPA_20+CS_MODE_BIG_ENDIAN, None
0xeb,0xff,0xb8,0x9d = b,l	0xfffffffffffffc54,r31
0xeb,0xff,0xb8,0x97 = b,l,n	0xfffffffffffffc50,r31
0xeb,0x9f,0x38,0x8d = b,gate	0xfffffffffffffc4c,ret0
0xeb,0x9f,0x38,0x87 = b,gate,n	0xfffffffffffffc48,ret0
0xeb,0xff,0x98,0x7d = b,l,push	0xfffffffffffffc44,r31
0xeb,0xff,0x98,0x77 = b,l,push,n	0xfffffffffffffc40,r31
0xe8,0x41,0x40,0x00 = blr	r1,rp
0xe8,0x41,0x40,0x02 = blr,n	r1,rp
0xe8,0x41,0xc0,0x00 = bv	r1(rp)
0xe8,0x41,0xc0,0x02 = bv,n	r1(rp)
0xe0,0x20,0x40,0x00 = be	0(sr1,r1)
0xe0,0x20,0x40,0x02 = be,n	0(sr1,r1)
0xe4,0x20,0x40,0x00 = be,l	0(sr1,r1),sr0,r31
0xe4,0x20,0x40,0x02 = be,l,n	0(sr1,r1),sr0,r31
0xe8,0x40,0xd0,0x00 = bve	(rp)
0xe8,0x40,0xd0,0x02 = bve,n	(rp)
0xe8,0x40,0xd0,0x01 = bve,pop	(rp)
0xe8,0x40,0xd0,0x03 = bve,pop,n	(rp)
0xe8,0x20,0xf0,0x00 = bve,l	(r1),rp
0xe8,0x20,0xf0,0x02 = bve,l,n	(r1),rp
0xe8,0x20,0xf0,0x01 = bve,l,push	(r1),rp
0xe8,0x20,0xf0,0x03 = bve,l,push,n	(r1),rp
0xa0,0x41,0x17,0xed = addb	r1,rp,0xfffffffffffffbfc
0xa0,0x41,0x37,0xe5 = addb,=	r1,rp,0xfffffffffffffbf8
0xa0,0x41,0x37,0xdf = addb,=,n	r1,rp,0xfffffffffffffbf4
0xa4,0x5e,0x17,0xd5 = addib	0xf,rp,0xfffffffffffffbf0
0xa4,0x5e,0x37,0xcd = addib,=	0xf,rp,0xfffffffffffffbec
0xa4,0x5e,0x37,0xc7 = addib,=,n	0xf,rp,0xfffffffffffffbe8
0xc5,0xe1,0xd7,0xbd = bb,>=	r1,0xf,0xfffffffffffffbe4
0xc5,0xe1,0xd7,0xb7 = bb,>=,n	r1,0xf,0xfffffffffffffbe0
0x80,0x41,0x17,0xad = cmpb	r1,rp,0xfffffffffffffbdc
0x80,0x41,0x37,0xa5 = cmpb,=	r1,rp,0xfffffffffffffbd8
0x80,0x41,0x37,0x9f = cmpb,=,n	r1,rp,0xfffffffffffffbd4
0x84,0x5e,0x17,0x95 = cmpib	0xf,rp,0xfffffffffffffbd0
0x84,0x5e,0x37,0x8d = cmpib,=	0xf,rp,0xfffffffffffffbcc
0x84,0x5e,0x37,0x87 = cmpib,=,n	0xf,rp,0xfffffffffffffbc8
0xc8,0x41,0x17,0x7d = movb	r1,rp,0xfffffffffffffbc4
0xc8,0x41,0x37,0x75 = movb,=	r1,rp,0xfffffffffffffbc0
0xc8,0x41,0x37,0x6f = movb,=,n	r1,rp,0xfffffffffffffbbc
0xcc,0x5e,0x17,0x65 = movib	0xf,rp,0xfffffffffffffbb8
0xcc,0x5e,0x37,0x5d = movib,=	0xf,rp,0xfffffffffffffbb4
0xcc,0x5e,0x37,0x57 = movib,=,n	0xf,rp,0xfffffffffffffbb0