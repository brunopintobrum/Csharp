using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionCalculatorRefEOut {
    class Calculator {
        //=============================================================================
        //                            IMPLEMENTANDO REF
        //=============================================================================
        public static void TripleRef(ref int x) { // ref é o modificador de parametro.
            x = x * 3;
        }
        //=============================================================================
        //                            IMPLEMENTANDO OUT
        //=============================================================================
        public static void TripleOut(int origin, out int result) {
            result = origin * 3;
        }
    }
}
