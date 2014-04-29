﻿/*
   This is a port of the Swiss Ephemeris Free Edition, Version 2.00.00
   of Astrodienst AG, Switzerland from the original C Code to .Net. For
   copyright see the original copyright notices below and additional
   copyright notes in the file named LICENSE, or - if this file is not
   available - the copyright notes at http://www.astro.ch/swisseph/ and
   following.
   
   For any questions or comments regarding this port, you should
   ONLY contact me and not Astrodienst, as the Astrodienst AG is not involved
   in this port in any way.

   Yanos : ygrenier@ygrenier.com
*/

/************************************************************
  $Header: /home/dieter/sweph/RCS/swephexp.h,v 1.75 2009/04/08 07:19:08 dieter Exp $
  SWISSEPH: exported definitions and constants 

  This file represents the standard application interface (API)
  to the Swiss Ephemeris.

  A C programmer needs only to include this file, and link his code
  with the SwissEph library.

  The function calls are documented in the Programmer's documentation,
  which is online in HTML format.

  Structure of this file:
    Public API definitions
    Internal developer's definitions
    Public API functions.

  Authors: Dieter Koch and Alois Treindl, Astrodienst Zurich

************************************************************/
/* Copyright (C) 1997 - 2008 Astrodienst AG, Switzerland.  All rights reserved.

  License conditions
  ------------------

  This file is part of Swiss Ephemeris.

  Swiss Ephemeris is distributed with NO WARRANTY OF ANY KIND.  No author
  or distributor accepts any responsibility for the consequences of using it,
  or for whether it serves any particular purpose or works at all, unless he
  or she says so in writing.  

  Swiss Ephemeris is made available by its authors under a dual licensing
  system. The software developer, who uses any part of Swiss Ephemeris
  in his or her software, must choose between one of the two license models,
  which are
  a) GNU public license version 2 or later
  b) Swiss Ephemeris Professional License

  The choice must be made before the software developer distributes software
  containing parts of Swiss Ephemeris to others, and before any public
  service using the developed software is activated.

  If the developer choses the GNU GPL software license, he or she must fulfill
  the conditions of that license, which includes the obligation to place his
  or her whole software project under the GNU GPL or a compatible license.
  See http://www.gnu.org/licenses/old-licenses/gpl-2.0.html

  If the developer choses the Swiss Ephemeris Professional license,
  he must follow the instructions as found in http://www.astro.com/swisseph/ 
  and purchase the Swiss Ephemeris Professional Edition from Astrodienst
  and sign the corresponding license contract.

  The License grants you the right to use, copy, modify and redistribute
  Swiss Ephemeris, but only under certain conditions described in the License.
  Among other things, the License requires that the copyright notices and
  this notice be preserved on all copies.

  Authors of the Swiss Ephemeris: Dieter Koch and Alois Treindl

  The authors of Swiss Ephemeris have no control or influence over any of
  the derived works, i.e. over software or services created by other
  programmers which use Swiss Ephemeris functions.

  The names of the authors or of the copyright holder (Astrodienst) must not
  be used for promoting any software, product or service which uses or contains
  the Swiss Ephemeris. This copyright notice is the ONLY place where the
  names of the authors can legally appear, except in cases where they have
  given special permission in writing.

  The trademarks 'Swiss Ephemeris' and 'Swiss Ephemeris inside' may be used
  for promoting such software, products or services.
*/
namespace SweNet
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    partial class SwissEph
    {


//#ifdef __cplusplus
//extern "C" {
//#endif

//#ifndef _SWEPHEXP_INCLUDED      /* allow multiple #includes of swephexp.h */
//#define _SWEPHEXP_INCLUDED

//#include "sweodef.h"

        /***********************************************************
         * definitions for use also by non-C programmers
         ***********************************************************/

        /* values for gregflag in swe_julday() and swe_revjul() */
        public const int SE_JUL_CAL = 0;
        public const int SE_GREG_CAL = 1;

        /*
         * planet numbers for the ipl parameter in swe_calc()
         */
        public const int SE_ECL_NUT = -1;

        public const int SE_SUN = 0;
        public const int SE_MOON = 1;
        public const int SE_MERCURY = 2;
        public const int SE_VENUS = 3;
        public const int SE_MARS = 4;
        public const int SE_JUPITER = 5;
        public const int SE_SATURN = 6;
        public const int SE_URANUS = 7;
        public const int SE_NEPTUNE = 8;
        public const int SE_PLUTO = 9;
        public const int SE_MEAN_NODE = 10;
        public const int SE_TRUE_NODE = 11;
        public const int SE_MEAN_APOG = 12;
        public const int SE_OSCU_APOG = 13;
        public const int SE_EARTH = 14;
        public const int SE_CHIRON = 15;
        public const int SE_PHOLUS = 16;
        public const int SE_CERES = 17;
        public const int SE_PALLAS = 18;
        public const int SE_JUNO = 19;
        public const int SE_VESTA = 20;
        public const int SE_INTP_APOG = 21;
        public const int SE_INTP_PERG = 22;

        public const int SE_NPLANETS = 23;

        public const int SE_AST_OFFSET = 10000;
        public const int SE_VARUNA = (SE_AST_OFFSET + 20000);

        public const int SE_FICT_OFFSET = 40;
        public const int SE_FICT_OFFSET_1 = 39;
        public const int SE_FICT_MAX = 999;
        public const int SE_NFICT_ELEM = 15;

        public const int SE_COMET_OFFSET = 1000;

        public const int SE_NALL_NAT_POINTS = (SE_NPLANETS + SE_NFICT_ELEM);

        /* Hamburger or Uranian "planets" */
        public const int SE_CUPIDO = 40;
        public const int SE_HADES = 41;
        public const int SE_ZEUS = 42;
        public const int SE_KRONOS = 43;
        public const int SE_APOLLON = 44;
        public const int SE_ADMETOS = 45;
        public const int SE_VULKANUS = 46;
        public const int SE_POSEIDON = 47;
        /* other fictitious bodies */
        public const int SE_ISIS = 48;
        public const int SE_NIBIRU = 49;
        public const int SE_HARRINGTON = 50;
        public const int SE_NEPTUNE_LEVERRIER = 51;
        public const int SE_NEPTUNE_ADAMS = 52;
        public const int SE_PLUTO_LOWELL = 53;
        public const int SE_PLUTO_PICKERING = 54;
        public const int SE_VULCAN = 55;
        public const int SE_WHITE_MOON = 56;
        public const int SE_PROSERPINA = 57;
        public const int SE_WALDEMATH = 58;

        public const int SE_FIXSTAR = -10;

        public const int SE_ASC = 0;
        public const int SE_MC = 1;
        public const int SE_ARMC = 2;
        public const int SE_VERTEX = 3;
        public const int SE_EQUASC = 4;	/* "equatorial ascendant" */
        public const int SE_COASC1 = 5;	/* "co-ascendant" (W. Koch) */
        public const int SE_COASC2 = 6;	/* "co-ascendant" (M. Munkasey) */
        public const int SE_POLASC = 7;	/* "polar ascendant" (M. Munkasey) */
        public const int SE_NASCMC = 8;

///*
// * flag bits for parameter iflag in function swe_calc()
// * The flag bits are defined in such a way that iflag = 0 delivers what one
// * usually wants:
// *    - the default ephemeris (SWISS EPHEMERIS) is used,
// *    - apparent geocentric positions referring to the true equinox of date
// *      are returned.
// * If not only coordinates, but also speed values are required, use 
// * flag = SEFLG_SPEED.
// *
// * The 'L' behind the number indicates that 32-bit integers (Long) are used.
// */
        public const int SEFLG_JPLEPH = 1;       /* use JPL ephemeris */
        public const int SEFLG_SWIEPH = 2;       /* use SWISSEPH ephemeris */
        public const int SEFLG_MOSEPH = 4;       /* use Moshier ephemeris */

        public const int SEFLG_HELCTR = 8;      /* return heliocentric position */
        public const int SEFLG_TRUEPOS = 16;     /* return true positions, not apparent */
        public const int SEFLG_J2000 = 32;     /* no precession, i.e. give J2000 equinox */
        public const int SEFLG_NONUT = 64;     /* no nutation, i.e. mean equinox of date */
        public const int SEFLG_SPEED3 = 128;     /* speed from 3 positions (do not use it,
                                                    SEFLG_SPEED is faster and more precise.) */
        public const int SEFLG_SPEED = 256;     /* high precision speed  */
        public const int SEFLG_NOGDEFL = 512;     /* turn off gravitational deflection */
        public const int SEFLG_NOABERR = 1024;    /* turn off 'annual' aberration of light */
        public const int SEFLG_EQUATORIAL = (2 * 1024);    /* equatorial positions are wanted */
        public const int SEFLG_XYZ = (4 * 1024);    /* cartesian, not polar, coordinates */
        public const int SEFLG_RADIANS = (8 * 1024);    /* coordinates in radians, not degrees */
        public const int SEFLG_BARYCTR = (16 * 1024);   /* barycentric positions */
        public const int SEFLG_TOPOCTR = (32 * 1024);   /* topocentric positions */
        public const int SEFLG_SIDEREAL = (64 * 1024);   /* sidereal positions */
        public const int SEFLG_ICRS = (128 * 1024);   /* ICRS (DE406 reference frame) */
        public const int SEFLG_DPSIDEPS_1980 = (256 * 1024); /* reproduce JPL Horizons 
                                                                1962 - today to 0.002 arcsec. */
        public const int SEFLG_JPLHOR = SEFLG_DPSIDEPS_1980;
        public const int SEFLG_JPLHOR_APPROX = (512 * 1024);   /* approximate JPL Horizons 1962 - today */

        public const int SE_SIDBITS = 256;
        /* for projection onto ecliptic of t0 */
        public const int SE_SIDBIT_ECL_T0 = 256;
        /* for projection onto solar system plane */
        public const int SE_SIDBIT_SSY_PLANE = 512;

        /* sidereal modes (ayanamsas) */
        public const int SE_SIDM_FAGAN_BRADLEY = 0;
        public const int SE_SIDM_LAHIRI = 1;
        public const int SE_SIDM_DELUCE = 2;
        public const int SE_SIDM_RAMAN = 3;
        public const int SE_SIDM_USHASHASHI = 4;
        public const int SE_SIDM_KRISHNAMURTI = 5;
        public const int SE_SIDM_DJWHAL_KHUL = 6;
        public const int SE_SIDM_YUKTESHWAR = 7;
        public const int SE_SIDM_JN_BHASIN = 8;
        public const int SE_SIDM_BABYL_KUGLER1 = 9;
        public const int SE_SIDM_BABYL_KUGLER2 = 10;
        public const int SE_SIDM_BABYL_KUGLER3 = 11;
        public const int SE_SIDM_BABYL_HUBER = 12;
        public const int SE_SIDM_BABYL_ETPSC = 13;
        public const int SE_SIDM_ALDEBARAN_15TAU = 14;
        public const int SE_SIDM_HIPPARCHOS = 15;
        public const int SE_SIDM_SASSANIAN = 16;
        public const int SE_SIDM_GALCENT_0SAG = 17;
        public const int SE_SIDM_J2000 = 18;
        public const int SE_SIDM_J1900 = 19;
        public const int SE_SIDM_B1950 = 20;
        public const int SE_SIDM_SURYASIDDHANTA = 21;
        public const int SE_SIDM_SURYASIDDHANTA_MSUN = 22;
        public const int SE_SIDM_ARYABHATA = 23;
        public const int SE_SIDM_ARYABHATA_MSUN = 24;
        public const int SE_SIDM_SS_REVATI = 25;
        public const int SE_SIDM_SS_CITRA = 26;
        public const int SE_SIDM_TRUE_CITRA = 27;
        public const int SE_SIDM_TRUE_REVATI = 28;
        public const int SE_SIDM_USER = 255;

        public const int SE_NSIDM_PREDEF = 29;

        /* used for swe_nod_aps(): */
        public const int SE_NODBIT_MEAN = 1;   /* mean nodes/apsides */
        public const int SE_NODBIT_OSCU = 2;   /* osculating nodes/apsides */
        public const int SE_NODBIT_OSCU_BAR = 4;   /* same, but motion about solar system barycenter is considered */
        public const int SE_NODBIT_FOPOINT = 256;   /* focal point of orbit instead of aphelion */

        /* default ephemeris used when no ephemeris flagbit is set */
        public const int SEFLG_DEFAULTEPH = SEFLG_SWIEPH;

        public const int SE_MAX_STNAME = 256;	/* maximum size of fixstar name;
                                                 * the parameter star in swe_fixstar
                                                 * must allow twice this space for
                                                 * the returned star name.
                                                 */

        /* defines for eclipse computations */

        public const int SE_ECL_CENTRAL = 1;
        public const int SE_ECL_NONCENTRAL = 2;
        public const int SE_ECL_TOTAL = 4;
        public const int SE_ECL_ANNULAR = 8;
        public const int SE_ECL_PARTIAL = 16;
        public const int SE_ECL_ANNULAR_TOTAL = 32;
        public const int SE_ECL_PENUMBRAL = 64;
        public const int SE_ECL_ALLTYPES_SOLAR = (SE_ECL_CENTRAL | SE_ECL_NONCENTRAL | SE_ECL_TOTAL | SE_ECL_ANNULAR | SE_ECL_PARTIAL | SE_ECL_ANNULAR_TOTAL);
        public const int SE_ECL_ALLTYPES_LUNAR = (SE_ECL_TOTAL | SE_ECL_PARTIAL | SE_ECL_PENUMBRAL);
        public const int SE_ECL_VISIBLE = 128;
        public const int SE_ECL_MAX_VISIBLE = 256;
        public const int SE_ECL_1ST_VISIBLE = 512;	/* begin of partial eclipse */
        public const int SE_ECL_PARTBEG_VISIBLE = 512;	/* begin of partial eclipse */
        public const int SE_ECL_2ND_VISIBLE = 1024;	/* begin of total eclipse */
        public const int SE_ECL_TOTBEG_VISIBLE = 1024;	/* begin of total eclipse */
        public const int SE_ECL_3RD_VISIBLE = 2048;    /* end of total eclipse */
        public const int SE_ECL_TOTEND_VISIBLE = 2048;    /* end of total eclipse */
        public const int SE_ECL_4TH_VISIBLE = 4096;    /* end of partial eclipse */
        public const int SE_ECL_PARTEND_VISIBLE = 4096;    /* end of partial eclipse */
        public const int SE_ECL_PENUMBBEG_VISIBLE = 8192;    /* begin of penumbral eclipse */
        public const int SE_ECL_PENUMBEND_VISIBLE = 16384;   /* end of penumbral eclipse */
        public const int SE_ECL_OCC_BEG_DAYLIGHT = 8192;    /* occultation begins during the day */
        public const int SE_ECL_OCC_END_DAYLIGHT = 16384;   /* occultation ends during the day */
        public const int SE_ECL_ONE_TRY = (32 * 1024); 
                                                        /* check if the next conjunction of the moon with
                                                         * a planet is an occultation; don't search further */

        /* for swe_rise_transit() */
        public const int SE_CALC_RISE = 1;
        public const int SE_CALC_SET = 2;
        public const int SE_CALC_MTRANSIT = 4;
        public const int SE_CALC_ITRANSIT = 8;
        public const int SE_BIT_DISC_CENTER = 256; /* to be or'ed to SE_CALC_RISE/SET,
                                                    * if rise or set of disc center is 
                                                    * required */
        public const int SE_BIT_DISC_BOTTOM = 8192; /* to be or'ed to SE_CALC_RISE/SET,
                                                     * if rise or set of lower limb of 
                                                     * disc is requried */
        public const int SE_BIT_NO_REFRACTION = 512; /* to be or'ed to SE_CALC_RISE/SET, 
                                                      * if refraction is to be ignored */
        public const int SE_BIT_CIVIL_TWILIGHT = 1024; /* to be or'ed to SE_CALC_RISE/SET */
        public const int SE_BIT_NAUTIC_TWILIGHT = 2048; /* to be or'ed to SE_CALC_RISE/SET */
        public const int SE_BIT_ASTRO_TWILIGHT = 4096; /* to be or'ed to SE_CALC_RISE/SET */
        public const int SE_BIT_FIXED_DISC_SIZE = (16 * 1024); /* or'ed to SE_CALC_RISE/SET:
                                                                * neglect the effect of distance on
                                                                * disc size */


        /* for swe_azalt() and swe_azalt_rev() */
        public const int SE_ECL2HOR = 0;
        public const int SE_EQU2HOR = 1;
        public const int SE_HOR2ECL = 0;
        public const int SE_HOR2EQU = 1;

        /* for swe_refrac() */
        public const int SE_TRUE_TO_APP = 0;
        public const int SE_APP_TO_TRUE = 1;

        /*
         * only used for experimenting with various JPL ephemeris files
         * which are available at Astrodienst's internal network
         */
        public const int SE_DE_NUMBER = 431;
        public const string SE_FNAME_DE200 = "de200.eph";
        public const string SE_FNAME_DE403 = "de403.eph";
        public const string SE_FNAME_DE404 = "de404.eph";
        public const string SE_FNAME_DE405 = "de405.eph";
        public const string SE_FNAME_DE406 = "de406.eph";
        public const string SE_FNAME_DE431 = "de431.eph";
        public const string SE_FNAME_DFT = SE_FNAME_DE431;
        public const string SE_FNAME_DFT2 = SE_FNAME_DE406;
        public const string SE_STARFILE_OLD = "fixstars.cat";
        public const string SE_STARFILE = "sefstars.txt";
        public const string SE_ASTNAMFILE = "seasnam.txt";
        public const string SE_FICTFILE = "seorbel.txt";

       /*
        * ephemeris path
        * this defines where ephemeris files are expected if the function
        * swe_set_ephe_path() is not called by the application.
        * Normally, every application should make this call to define its
        * own place for the ephemeris files.
        */

//#ifndef SE_EPHE_PATH
//#if MSDOS
//#ifdef PAIR_SWEPH
//#  define SE_EPHE_PATH    "\\pair\\ephe\\"
//#else
//#  define SE_EPHE_PATH    "\\sweph\\ephe\\"
//#endif
//#else
//# ifdef MACOS
//#  define SE_EPHE_PATH	":ephe:"
//# else
//#  define SE_EPHE_PATH    ".:/users/ephe2/:/users/ephe/"
//            /* At Astrodienst, we maintain two ephemeris areas for
//               the thousands of asteroid files: 
//               the short files in /users/ephe/ast*,
//               the long file in /users/ephe2/ast*. */
//# endif
//#endif
//#endif  /* SE_EPHE_PATH */

        /* defines for function swe_split_deg() (in swephlib.c) */
        public const int SE_SPLIT_DEG_ROUND_SEC = 1;
        public const int SE_SPLIT_DEG_ROUND_MIN = 2;
        public const int SE_SPLIT_DEG_ROUND_DEG = 4;
        public const int SE_SPLIT_DEG_ZODIACAL = 8;
        public const int SE_SPLIT_DEG_KEEP_SIGN = 16;	/* don't round to next sign, 
                                                         * e.g. 29.9999999 will be rounded
                                                         * to 29d59'59" (or 29d59' or 29d) */
        public const int SE_SPLIT_DEG_KEEP_DEG = 32;	/* don't round to next degree
                                                         * e.g. 13.9999999 will be rounded
                                                         * to 13d59'59" (or 13d59' or 13d) */

        /* for heliacal functions */
        public const int SE_HELIACAL_RISING = 1;
        public const int SE_HELIACAL_SETTING = 2;
        public const int SE_MORNING_FIRST = SE_HELIACAL_RISING;
        public const int SE_EVENING_LAST = SE_HELIACAL_SETTING;
        public const int SE_EVENING_FIRST = 3;
        public const int SE_MORNING_LAST = 4;
        public const int SE_ACRONYCHAL_RISING = 5;  /* still not implemented */
        public const int SE_ACRONYCHAL_SETTING = 6;  /* still not implemented */
        public const int SE_COSMICAL_SETTING = SE_ACRONYCHAL_SETTING;

        public const int SE_HELFLAG_LONG_SEARCH = 128;
        public const int SE_HELFLAG_HIGH_PRECISION = 256;
        public const int SE_HELFLAG_OPTICAL_PARAMS = 512;
        public const int SE_HELFLAG_NO_DETAILS = 1024;
        public const int SE_HELFLAG_SEARCH_1_PERIOD = (1 << 11);  /*  2048 */
        public const int SE_HELFLAG_VISLIM_DARK = (1 << 12);  /*  4096 */
        public const int SE_HELFLAG_VISLIM_NOMOON = (1 << 13);  /*  8192 */
        public const int SE_HELFLAG_VISLIM_PHOTOPIC = (1 << 14);  /* 16384 */
        public const int SE_HELFLAG_AV = (1 << 15);  /* 32768 */
        public const int SE_HELFLAG_AVKIND_VR = (1 << 15);  /* 32768 */
        public const int SE_HELFLAG_AVKIND_PTO = (1 << 16);
        public const int SE_HELFLAG_AVKIND_MIN7 = (1 << 17);
        public const int SE_HELFLAG_AVKIND_MIN9 = (1 << 18);
        public const int SE_HELFLAG_AVKIND = (SE_HELFLAG_AVKIND_VR | SE_HELFLAG_AVKIND_PTO | SE_HELFLAG_AVKIND_MIN7 | SE_HELFLAG_AVKIND_MIN9);
        public const double TJD_INVALID = 99999999.0;
        public const bool SIMULATE_VICTORVB = true;

        public const int SE_HELIACAL_LONG_SEARCH = 128;
        public const int SE_HELIACAL_HIGH_PRECISION = 256;
        public const int SE_HELIACAL_OPTICAL_PARAMS = 512;
        public const int SE_HELIACAL_NO_DETAILS = 1024;
        public const int SE_HELIACAL_SEARCH_1_PERIOD = (1 << 11);  /*  2048 */
        public const int SE_HELIACAL_VISLIM_DARK = (1 << 12);  /*  4096 */
        public const int SE_HELIACAL_VISLIM_NOMOON = (1 << 13);  /*  8192 */
        public const int SE_HELIACAL_VISLIM_PHOTOPIC = (1 << 14);  /* 16384 */
        public const int SE_HELIACAL_AVKIND_VR = (1 << 15);  /* 32768 */
        public const int SE_HELIACAL_AVKIND_PTO = (1 << 16);
        public const int SE_HELIACAL_AVKIND_MIN7 = (1 << 17);
        public const int SE_HELIACAL_AVKIND_MIN9 = (1 << 18);
        public const int SE_HELIACAL_AVKIND = (SE_HELFLAG_AVKIND_VR | SE_HELFLAG_AVKIND_PTO | SE_HELFLAG_AVKIND_MIN7 | SE_HELFLAG_AVKIND_MIN9);

        public const int SE_PHOTOPIC_FLAG = 0;
        public const int SE_SCOTOPIC_FLAG = 1;
        public const int SE_MIXEDOPIC_FLAG = 2;

///*
// * by compiling with -DPAIR_SWEPH in the compiler options it
// * is possible to create a more compact version of SwissEph which
// * contains no code for the JPL ephemeris file and for the builtin
// * Moshier ephemeris.
// * This is quite useful for MSDOS real mode applications which need to
// * run within 640 kb.
// * The option is called PAIR_SWEPH because it was introduced for
// * Astrodienst's partner software PAIR.
// */
//#ifdef PAIR_SWEPH	
//# define NO_JPL
//#endif

///**************************************************************
// * here follow some ugly definitions which are only required
// * if SwissEphemeris is compiled on Windows, either to use a DLL
// * or to create a DLL.
// * Unix users can savely ignore his section
// * and skip to the export function decarations below.
// ************************************************************/
//#if defined(MAKE_DLL) || defined(USE_DLL) || defined(_WINDOWS)
//#  include <windows.h>
//#endif

//#ifdef USE_DLL
//#  include "swedll.h"
//#endif

//#if defined(DOS32) || !MSDOS || defined(WIN32)
//            /* use compiler switch to define DOS32 */
//#  ifndef FAR 
//#    define FAR
//#  endif
//#  define MALLOC malloc  
//#  define CALLOC calloc  
//#  define FREE free  
//#else
//#  ifndef FAR
//#    define FAR far
//#  endif
//#  ifdef __BORLANDC__
//#    include <alloc.h>
//#    define MALLOC farmalloc  
//#    define CALLOC farcalloc  
//#    define FREE farfree  
//#  else
//#    define MALLOC _fmalloc
//#    define CALLOC _fcalloc
//#    define FREE _ffree
//#  endif
//#endif

///* DLL defines */
//#ifdef MAKE_DLL
//  #if defined (PASCAL)
//    #define PASCAL_CONV PASCAL 
//  #else
//    #define PASCAL_CONV 
//  #endif
//  #ifdef MAKE_DLL16 /* 16bit DLL */
//    /* We compiled the 16bit DLL for Windows 3.x using Borland C/C++ Ver:3.x
//       and the -WD or -WDE compiler switch. */
//    #define EXP16 __export 
//    #define EXP32 
//  #else /* 32bit DLL */
//    /* To export symbols in the new DLL model of Win32, Microsoft 
//       recommends the following approach */ 
//    #define EXP16 
//    #define EXP32  __declspec( dllexport )
//  #endif
//#else 
//  #define PASCAL_CONV 
//  #define EXP16 
//  #define EXP32 
//#endif  

//#ifndef _SWEDLL_H

///***********************************************************
// * exported functions
// ***********************************************************/

//#define ext_def(x)	extern EXP32 x FAR PASCAL_CONV EXP16
//            /* ext_def(x) evaluates to x on Unix */

//ext_def(int32) swe_heliacal_ut(double tjdstart_ut, double *geopos, double *datm, double *dobs, char *ObjectName, int32 TypeEvent, int32 iflag, double *dret, char *serr);
//ext_def(int32) swe_heliacal_pheno_ut(double tjd_ut, double *geopos, double *datm, double *dobs, char *ObjectName, int32 TypeEvent, int32 helflag, double *darr, char *serr);
//ext_def(int32) swe_vis_limit_mag(double tjdut, double *geopos, double *datm, double *dobs, char *ObjectName, int32 helflag, double *dret, char *serr);
///* the following are secret, for Victor Reijs' */
//ext_def(int32) swe_heliacal_angle(double tjdut, double *dgeo, double *datm, double *dobs, int32 helflag, double mag, double azi_obj, double azi_sun, double azi_moon, double alt_moon, double *dret, char *serr);
//ext_def(int32) swe_topo_arcus_visionis(double tjdut, double *dgeo, double *datm, double *dobs, int32 helflag, double mag, double azi_obj, double alt_obj, double azi_sun, double azi_moon, double alt_moon, double *dret, char *serr);

///**************************** 
// * exports from sweph.c 
// ****************************/

//ext_def(char *) swe_version(char *);

///* planets, moon, nodes etc. */
//ext_def( int32 ) swe_calc(
//        double tjd, int ipl, int32 iflag, 
//        double *xx,
//        char *serr);

//ext_def(int32) swe_calc_ut(double tjd_ut, int32 ipl, int32 iflag, 
//    double *xx, char *serr);

///* fixed stars */
//ext_def( int32 ) swe_fixstar(
//        char *star, double tjd, int32 iflag, 
//        double *xx,
//        char *serr);

//ext_def(int32) swe_fixstar_ut(char *star, double tjd_ut, int32 iflag, 
//    double *xx, char *serr);

//ext_def(int32) swe_fixstar_mag(char *star, double *mag, char *serr);

///* close Swiss Ephemeris */
//ext_def( void ) swe_close(void);

///* set directory path of ephemeris files */
//ext_def( void ) swe_set_ephe_path(char *path);

///* set file name of JPL file */
//ext_def( void ) swe_set_jpl_file(char *fname);

///* get planet name */
//ext_def( char *) swe_get_planet_name(int ipl, char *spname);

///* set geographic position of observer */
//ext_def (void) swe_set_topo(double geolon, double geolat, double geoalt);

///* set sidereal mode */
//ext_def(void) swe_set_sid_mode(int32 sid_mode, double t0, double ayan_t0);

///* get ayanamsa */
//ext_def(double) swe_get_ayanamsa(double tjd_et);

//ext_def(double) swe_get_ayanamsa_ut(double tjd_ut);

//ext_def( char *) swe_get_ayanamsa_name(int32 isidmode);

///**************************** 
// * exports from swedate.c 
// ****************************/

//ext_def( int ) swe_date_conversion(
//        int y , int m , int d ,         /* year, month, day */
//        double utime,   /* universal time in hours (decimal) */
//        char c,         /* calendar g[regorian]|j[ulian] */
//        double *tjd);

//ext_def( double ) swe_julday(
//        int year, int month, int day, double hour, 
//        int gregflag);

//ext_def( void ) swe_revjul (
//        double jd, 
//        int gregflag,
//        int *jyear, int *jmon, int *jday, double *jut);

//ext_def(int32) swe_utc_to_jd(
//        int32 iyear, int32 imonth, int32 iday, 
//    int32 ihour, int32 imin, double dsec, 
//    int32 gregflag, double *dret, char *serr);

//ext_def(void) swe_jdet_to_utc(
//        double tjd_et, int32 gregflag, 
//    int32 *iyear, int32 *imonth, int32 *iday, 
//    int32 *ihour, int32 *imin, double *dsec);

//ext_def(void) swe_jdut1_to_utc(
//        double tjd_ut, int32 gregflag, 
//    int32 *iyear, int32 *imonth, int32 *iday, 
//    int32 *ihour, int32 *imin, double *dsec);

//ext_def(void) swe_utc_time_zone(
//        int32 iyear, int32 imonth, int32 iday,
//    int32 ihour, int32 imin, double dsec,
//    double d_timezone,
//    int32 *iyear_out, int32 *imonth_out, int32 *iday_out,
//    int32 *ihour_out, int32 *imin_out, double *dsec_out);

///**************************** 
// * exports from swehouse.c 
// ****************************/

//ext_def( int ) swe_houses(
//        double tjd_ut, double geolat, double geolon, int hsys, 
//    double *cusps, double *ascmc);

//ext_def( int ) swe_houses_ex(
//        double tjd_ut, int32 iflag, double geolat, double geolon, int hsys, 
//    double *cusps, double *ascmc);

//ext_def( int ) swe_houses_armc(
//        double armc, double geolat, double eps, int hsys, 
//    double *cusps, double *ascmc);

//ext_def(double) swe_house_pos(
//    double armc, double geolat, double eps, int hsys, double *xpin, char *serr);

//ext_def(char *) swe_house_name(int hsys);



///**************************** 
// * exports from swecl.c 
// ****************************/

//ext_def(int32) swe_gauquelin_sector(double t_ut, int32 ipl, char *starname, int32 iflag, int32 imeth, double *geopos, double atpress, double attemp, double *dgsect, char *serr);

///* computes geographic location and attributes of solar 
// * eclipse at a given tjd */
//ext_def (int32) swe_sol_eclipse_where(double tjd, int32 ifl, double *geopos, double *attr, char *serr);

//ext_def (int32) swe_lun_occult_where(double tjd, int32 ipl, char *starname, int32 ifl, double *geopos, double *attr, char *serr);

///* computes attributes of a solar eclipse for given tjd, geolon, geolat */
//ext_def (int32) swe_sol_eclipse_how(double tjd, int32 ifl, double *geopos, double *attr, char *serr);

///* finds time of next local eclipse */
//ext_def (int32) swe_sol_eclipse_when_loc(double tjd_start, int32 ifl, double *geopos, double *tret, double *attr, int32 backward, char *serr);

//ext_def (int32) swe_lun_occult_when_loc(double tjd_start, int32 ipl, char *starname, int32 ifl,
//     double *geopos, double *tret, double *attr, int32 backward, char *serr);

///* finds time of next eclipse globally */
//ext_def (int32) swe_sol_eclipse_when_glob(double tjd_start, int32 ifl, int32 ifltype,
//     double *tret, int32 backward, char *serr);

///* finds time of next occultation globally */
//ext_def (int32) swe_lun_occult_when_glob(double tjd_start, int32 ipl, char *starname, int32 ifl, int32 ifltype,
//     double *tret, int32 backward, char *serr);

///* computes attributes of a lunar eclipse for given tjd */
//ext_def (int32) swe_lun_eclipse_how(
//          double tjd_ut, 
//          int32 ifl,
//          double *geopos, 
//          double *attr, 
//          char *serr);

//ext_def (int32) swe_lun_eclipse_when(double tjd_start, int32 ifl, int32 ifltype,
//     double *tret, int32 backward, char *serr);

//ext_def (int32) swe_lun_eclipse_when_loc(double tjd_start, int32 ifl, 
//     double *geopos, double *tret, double *attr, int32 backward, char *serr);

///* planetary phenomena */
//ext_def (int32) swe_pheno(double tjd, int32 ipl, int32 iflag, double *attr, char *serr);
 
//ext_def(int32) swe_pheno_ut(double tjd_ut, int32 ipl, int32 iflag, double *attr, char *serr);

//ext_def (double) swe_refrac(double inalt, double atpress, double attemp, int32 calc_flag);

//ext_def (double) swe_refrac_extended(double inalt, double geoalt, double atpress, double attemp, double lapse_rate, int32 calc_flag, double *dret);

//ext_def (void) swe_set_lapse_rate(double lapse_rate);

//ext_def (void) swe_azalt(
//      double tjd_ut,
//      int32 calc_flag,
//      double *geopos,
//      double atpress,
//      double attemp,
//      double *xin, 
//      double *xaz); 

//ext_def (void) swe_azalt_rev(
//      double tjd_ut,
//      int32 calc_flag,
//      double *geopos,
//      double *xin, 
//      double *xout); 

//ext_def (int32) swe_rise_trans_true_hor(
//               double tjd_ut, int32 ipl, char *starname, 
//           int32 epheflag, int32 rsmi,
//               double *geopos, 
//           double atpress, double attemp,
//           double horhgt,
//               double *tret,
//               char *serr);

//ext_def (int32) swe_rise_trans(
//               double tjd_ut, int32 ipl, char *starname, 
//           int32 epheflag, int32 rsmi,
//               double *geopos, 
//           double atpress, double attemp,
//               double *tret,
//               char *serr);

//ext_def (int32) swe_nod_aps(double tjd_et, int32 ipl, int32 iflag, 
//                      int32  method,
//                      double *xnasc, double *xndsc, 
//                      double *xperi, double *xaphe, 
//                      char *serr);

//ext_def (int32) swe_nod_aps_ut(double tjd_ut, int32 ipl, int32 iflag, 
//                      int32  method,
//                      double *xnasc, double *xndsc, 
//                      double *xperi, double *xaphe, 
//                      char *serr);


///**************************** 
// * exports from swephlib.c 
// ****************************/

///* delta t */
//ext_def( double ) swe_deltat(double tjd);

///* equation of time */
//ext_def(int32) swe_time_equ(double tjd, double *te, char *serr);
//ext_def(int32) swe_lmt_to_lat(double tjd_lmt, double geolon, double *tjd_lat, char *serr);
//ext_def(int32) swe_lat_to_lmt(double tjd_lat, double geolon, double *tjd_lmt, char *serr);

///* sidereal time */
//ext_def( double ) swe_sidtime0(double tjd_ut, double eps, double nut);
//ext_def( double ) swe_sidtime(double tjd_ut);

///* coordinate transformation polar -> polar */
//ext_def( void ) swe_cotrans(double *xpo, double *xpn, double eps);
//ext_def( void ) swe_cotrans_sp(double *xpo, double *xpn, double eps);

///* tidal acceleration to be used in swe_deltat() */
//ext_def( double ) swe_get_tid_acc(void);
//ext_def( void ) swe_set_tid_acc(double t_acc);

//ext_def( double ) swe_degnorm(double x);
//ext_def( double ) swe_radnorm(double x);
//ext_def( double ) swe_rad_midp(double x1, double x0);
//ext_def( double ) swe_deg_midp(double x1, double x0);

//ext_def( void ) swe_split_deg(double ddeg, int32 roundflag, int32 *ideg, int32 *imin, int32 *isec, double *dsecfr, int32 *isgn);

///******************************************************* 
// * other functions from swephlib.c;
// * they are not needed for Swiss Ephemeris,
// * but may be useful to former Placalc users.
// ********************************************************/

///* normalize argument into interval [0..DEG360] */
//ext_def( centisec ) swe_csnorm(centisec p);

///* distance in centisecs p1 - p2 normalized to [0..360[ */
//ext_def( centisec ) swe_difcsn (centisec p1, centisec p2);

//ext_def( double ) swe_difdegn (double p1, double p2);

///* distance in centisecs p1 - p2 normalized to [-180..180[ */
//ext_def( centisec ) swe_difcs2n(centisec p1, centisec p2);

//ext_def( double ) swe_difdeg2n(double p1, double p2);
//ext_def( double ) swe_difrad2n(double p1, double p2);

///* round second, but at 29.5959 always down */
//ext_def( centisec ) swe_csroundsec(centisec x);

///* double to int32 with rounding, no overflow check */
//ext_def( int32 ) swe_d2l(double x);

///* monday = 0, ... sunday = 6 */
//ext_def( int ) swe_day_of_week(double jd);

//ext_def( char *) swe_cs2timestr(CSEC t, int sep, AS_BOOL suppressZero, char *a);

//ext_def( char *) swe_cs2lonlatstr(CSEC t, char pchar, char mchar, char *s);

//ext_def( char *) swe_cs2degstr(CSEC t, char *a);

//#endif  /* #ifndef _SWEDLL_H */

//#endif  /* #ifndef _SWEPHEXP_INCLUDED */

//#ifdef __cplusplus
//} /* extern C */
//#endif

    }

}
