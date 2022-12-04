using System;
using System.Collections.Generic;
using System.Text;

namespace PN
{
    class GV
    {
        public static int nv, nr, nc, nl, k, nf, lp, lm, kp, km;
        public static int M = 100, MR = 50, MC = 20, ML = 20, MF = 1000;

        public static int[,] in_r = new int[MR + 1, 2];
        public static int[,] in_c = new int[MC + 1, 2];
        public static int[,] in_l = new int[ML + 1, 2];

        public static float[] z_r = new float[MR + 1];
        public static float[] c = new float[MC + 1];
        public static float[] l = new float[ML + 1];
        public static float[] f = new float[MF + 1];

        public static String filename;
        public static bool flag = false;
    }
}

