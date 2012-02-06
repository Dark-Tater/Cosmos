﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cosmos.IL2CPU.Profiler {
  public class Assembler : Cosmos.IL2CPU.X86.AppAssembler {

    public Assembler() : base(0) {
    }
    
    protected override void InitILOps() {
      var xILOp = new ILOp(this.Assembler);
      // Don't change the type in the foreach to a var, its necessary as it is now
      // to typecast it, so we can then recast to an int.
      foreach (ILOpCode.Code xCode in Enum.GetValues(typeof(ILOpCode.Code))) {
        int xCodeValue = (int)xCode;
        if (xCodeValue <= 0xFF) {
          mILOpsLo[xCodeValue] = xILOp;
        } else {
          mILOpsHi[xCodeValue & 0xFF] = xILOp;
        }
      }
    }

  }
}